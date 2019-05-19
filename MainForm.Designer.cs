namespace WebCamRecorderWinForms
{
    partial class MainForm
    {
        /// <summary>
        /// Обязательная переменная конструктора.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Освободить все используемые ресурсы.
        /// </summary>
        /// <param name="disposing">истинно, если управляемый ресурс должен быть удален; иначе ложно.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Код, автоматически созданный конструктором форм Windows

        /// <summary>
        /// Требуемый метод для поддержки конструктора — не изменяйте 
        /// содержимое этого метода с помощью редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            this.butStop = new System.Windows.Forms.Button();
            this._webcamPicturePreviewBox = new System.Windows.Forms.PictureBox();
            this.goButton = new System.Windows.Forms.Button();
            this._intervalBetweenRecordingSessionsSecNumericUpDown = new System.Windows.Forms.NumericUpDown();
            this._recordingSessionTimeSecNumericUpDown = new System.Windows.Forms.NumericUpDown();
            this._recordingSessionPanel = new System.Windows.Forms.Panel();
            this._startButton = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this._webcamPicturePreviewBox)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this._intervalBetweenRecordingSessionsSecNumericUpDown)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this._recordingSessionTimeSecNumericUpDown)).BeginInit();
            this._recordingSessionPanel.SuspendLayout();
            this.SuspendLayout();
            // 
            // butStop
            // 
            this.butStop.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.butStop.BackColor = System.Drawing.Color.DarkSalmon;
            this.butStop.Location = new System.Drawing.Point(658, 451);
            this.butStop.Name = "butStop";
            this.butStop.Size = new System.Drawing.Size(122, 76);
            this.butStop.TabIndex = 0;
            this.butStop.Text = "Stop";
            this.butStop.UseVisualStyleBackColor = false;
            this.butStop.Click += new System.EventHandler(this.OnStop);
            // 
            // _webcamPicturePreviewBox
            // 
            this._webcamPicturePreviewBox.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this._webcamPicturePreviewBox.Location = new System.Drawing.Point(12, 12);
            this._webcamPicturePreviewBox.Name = "_webcamPicturePreviewBox";
            this._webcamPicturePreviewBox.Size = new System.Drawing.Size(960, 355);
            this._webcamPicturePreviewBox.TabIndex = 1;
            this._webcamPicturePreviewBox.TabStop = false;
            // 
            // goButton
            // 
            this.goButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.goButton.BackColor = System.Drawing.Color.Chartreuse;
            this.goButton.Location = new System.Drawing.Point(786, 451);
            this.goButton.Name = "goButton";
            this.goButton.Size = new System.Drawing.Size(186, 76);
            this.goButton.TabIndex = 2;
            this.goButton.Text = "Go";
            this.goButton.UseVisualStyleBackColor = false;
            this.goButton.Click += new System.EventHandler(this.OnSelectVideoInputDevice);
            // 
            // _intervalBetweenRecordingSessionsSecNumericUpDown
            // 
            this._intervalBetweenRecordingSessionsSecNumericUpDown.Location = new System.Drawing.Point(408, 26);
            this._intervalBetweenRecordingSessionsSecNumericUpDown.Name = "_intervalBetweenRecordingSessionsSecNumericUpDown";
            this._intervalBetweenRecordingSessionsSecNumericUpDown.Size = new System.Drawing.Size(120, 22);
            this._intervalBetweenRecordingSessionsSecNumericUpDown.TabIndex = 3;
            this._intervalBetweenRecordingSessionsSecNumericUpDown.Value = new decimal(new int[] {
            20,
            0,
            0,
            0});
            // 
            // _recordingSessionTimeSecNumericUpDown
            // 
            this._recordingSessionTimeSecNumericUpDown.Location = new System.Drawing.Point(408, 78);
            this._recordingSessionTimeSecNumericUpDown.Name = "_recordingSessionTimeSecNumericUpDown";
            this._recordingSessionTimeSecNumericUpDown.Size = new System.Drawing.Size(120, 22);
            this._recordingSessionTimeSecNumericUpDown.TabIndex = 4;
            this._recordingSessionTimeSecNumericUpDown.Value = new decimal(new int[] {
            5,
            0,
            0,
            0});
            // 
            // _recordingSessionPanel
            // 
            this._recordingSessionPanel.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this._recordingSessionPanel.Controls.Add(this._startButton);
            this._recordingSessionPanel.Controls.Add(this.label2);
            this._recordingSessionPanel.Controls.Add(this.label1);
            this._recordingSessionPanel.Controls.Add(this._recordingSessionTimeSecNumericUpDown);
            this._recordingSessionPanel.Controls.Add(this._intervalBetweenRecordingSessionsSecNumericUpDown);
            this._recordingSessionPanel.Location = new System.Drawing.Point(12, 401);
            this._recordingSessionPanel.Name = "_recordingSessionPanel";
            this._recordingSessionPanel.Size = new System.Drawing.Size(640, 126);
            this._recordingSessionPanel.TabIndex = 5;
            // 
            // _startButton
            // 
            this._startButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this._startButton.BackColor = System.Drawing.Color.Chartreuse;
            this._startButton.Location = new System.Drawing.Point(547, 26);
            this._startButton.Name = "_startButton";
            this._startButton.Size = new System.Drawing.Size(80, 74);
            this._startButton.TabIndex = 6;
            this._startButton.Text = "Start";
            this._startButton.UseVisualStyleBackColor = false;
            this._startButton.Click += new System.EventHandler(this.OnStartSessionsOfRecording);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(27, 80);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(216, 17);
            this.label2.TabIndex = 6;
            this.label2.Text = "Recording session time, seconds";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(27, 28);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(302, 17);
            this.label1.TabIndex = 5;
            this.label1.Text = "Interval between recordings sessions, seconds";
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(984, 539);
            this.Controls.Add(this._recordingSessionPanel);
            this.Controls.Add(this.goButton);
            this.Controls.Add(this._webcamPicturePreviewBox);
            this.Controls.Add(this.butStop);
            this.Name = "MainForm";
            this.Text = "Web-Cam Recorder";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.OnFormClosing);
            this.Load += new System.EventHandler(this.OnFormLoad);
            ((System.ComponentModel.ISupportInitialize)(this._webcamPicturePreviewBox)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this._intervalBetweenRecordingSessionsSecNumericUpDown)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this._recordingSessionTimeSecNumericUpDown)).EndInit();
            this._recordingSessionPanel.ResumeLayout(false);
            this._recordingSessionPanel.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button butStop;
        private System.Windows.Forms.PictureBox _webcamPicturePreviewBox;
        private System.Windows.Forms.Button goButton;
        private System.Windows.Forms.NumericUpDown _intervalBetweenRecordingSessionsSecNumericUpDown;
        private System.Windows.Forms.NumericUpDown _recordingSessionTimeSecNumericUpDown;
        private System.Windows.Forms.Panel _recordingSessionPanel;
        private System.Windows.Forms.Button _startButton;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
    }
}

