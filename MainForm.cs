using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Reflection;
using System.Threading.Tasks;
using System.Windows.Forms;
using Accord.Video.FFMPEG;
using AForge.Video;
using AForge.Video.DirectShow;

namespace WebCamRecorderWinForms
{
    public partial class MainForm : Form
    {
        private VideoCaptureDevice _inputDeviceFrameReader = null;
        private VideoFileWriter _outputVideoWriter;
   
        public MainForm()
        {
            InitializeComponent();
        }

        private void OnFormLoad(object sender, EventArgs e)
        {
            var applicationFolder = Path.GetDirectoryName(Assembly.GetExecutingAssembly().Location);
            var ffmpeg = Path.Combine(applicationFolder, "ffmpeg.exe");
            if (!File.Exists(ffmpeg))
                MessageBox.Show("Please put ffmpeg binaries (Windows x-64 bit / Shared Linking) to the application!", "Error");
            
        }

        private void OpenVideoWriting()
        {
            var applicationFolder = Path.GetDirectoryName(Assembly.GetExecutingAssembly().Location);
            var recordingFolder = Path.Combine(applicationFolder, "recordings");
            if (!Directory.Exists(recordingFolder))
                Directory.CreateDirectory(recordingFolder);

            var recordingFile = Path.Combine(recordingFolder, $"{DateTime.Now.ToString("yyyy-dd-M--HH-mm-ss")}.avi");
            int h = _inputDeviceFrameReader.VideoResolution.FrameSize.Height;
            int w = _inputDeviceFrameReader.VideoResolution.FrameSize.Width;
            _outputVideoWriter = new VideoFileWriter();
            _outputVideoWriter.Open(recordingFile, w, h, 25, VideoCodec.Default, 5000000);
        }

        private void OnSelectVideoInputDevice(object sender, EventArgs e)
        {
            var inputVideoDeviceSelectorDialog = new VideoCaptureDeviceForm();
            if (inputVideoDeviceSelectorDialog.ShowDialog(this) == DialogResult.OK)
            {
                // Preparing to read
                _inputDeviceFrameReader = inputVideoDeviceSelectorDialog.VideoDevice;
                _inputDeviceFrameReader.NewFrame += new NewFrameEventHandler(OnNextFrameReceived);

                OpenVideoWriting();


                _inputDeviceFrameReader.Start();
            }
        }

        void OnNextFrameReceived(object sender, NewFrameEventArgs eventArgs)
        {
            var previousBitmap = _webcamPicturePreviewBox.Image;
            _webcamPicturePreviewBox.Image = (Bitmap)eventArgs.Frame.Clone();
            previousBitmap?.Dispose();
            _outputVideoWriter.WriteVideoFrame(eventArgs.Frame);
        }

        private void OnStop(object sender, EventArgs e)
        {
            if (_inputDeviceFrameReader != null)
            {
                _inputDeviceFrameReader.Stop();
            }
            if (_outputVideoWriter != null)
            {
                _outputVideoWriter.Close();
                _outputVideoWriter = null;
            }
        }

        private void OnFormClosing(object sender, FormClosingEventArgs e)
        {
            DisposeInputDevice();

        }

        private void DisposeInputDevice()
        {
            if (_inputDeviceFrameReader != null)
            {
                _inputDeviceFrameReader.Stop();
                _inputDeviceFrameReader.NewFrame -= new NewFrameEventHandler(OnNextFrameReceived);
                _inputDeviceFrameReader = null;
            }
        }

        private async void OnStartSessionsOfRecording(object sender, EventArgs e)
        {
            int secondsInterval = (int)_intervalBetweenRecordingSessionsSecNumericUpDown.Value;
            int secondsWrite = (int)_recordingSessionTimeSecNumericUpDown.Value;
            butStop.Enabled = false;
            goButton.Enabled = false;
            _startButton.Enabled = false;

            if (_inputDeviceFrameReader == null)
            {
                OnSelectVideoInputDevice(sender, e);
            }

            while (_inputDeviceFrameReader != null)
            {
                _startButton.BackColor = Color.Red;
                await Task.Delay(secondsWrite * 1000);
                _inputDeviceFrameReader.Stop();
                _outputVideoWriter.Close();
                _outputVideoWriter.Dispose();

                _startButton.BackColor = Color.Yellow;
                await Task.Delay(secondsInterval * 1000);
                OpenVideoWriting();
                _inputDeviceFrameReader.Start();
            }
        }
    }
}
