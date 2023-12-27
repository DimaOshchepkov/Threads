namespace Ex1
{
    partial class MainForm
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            buttonStart = new Button();
            buttonPauseThread1 = new Button();
            buttonPauseThread2 = new Button();
            textBoxFileContent = new TextBox();
            trackBarThread1 = new TrackBar();
            trackBarThread2 = new TrackBar();
            buttonStop = new Button();
            labelThread1 = new Label();
            labelThread2 = new Label();
            buttonResume = new Button();
            ((System.ComponentModel.ISupportInitialize)trackBarThread1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)trackBarThread2).BeginInit();
            SuspendLayout();
            // 
            // buttonStart
            // 
            buttonStart.Location = new Point(125, 20);
            buttonStart.Margin = new Padding(3, 2, 3, 2);
            buttonStart.Name = "buttonStart";
            buttonStart.Size = new Size(82, 22);
            buttonStart.TabIndex = 0;
            buttonStart.Text = "Start";
            buttonStart.UseVisualStyleBackColor = true;
            buttonStart.Click += buttonStart_Click;
            // 
            // buttonPauseThread1
            // 
            buttonPauseThread1.Location = new Point(141, 199);
            buttonPauseThread1.Margin = new Padding(3, 2, 3, 2);
            buttonPauseThread1.Name = "buttonPauseThread1";
            buttonPauseThread1.Size = new Size(82, 22);
            buttonPauseThread1.TabIndex = 1;
            buttonPauseThread1.Text = "Pause";
            buttonPauseThread1.UseVisualStyleBackColor = true;
            buttonPauseThread1.Click += buttonPauseThread1_Click;
            // 
            // buttonPauseThread2
            // 
            buttonPauseThread2.Location = new Point(141, 285);
            buttonPauseThread2.Margin = new Padding(3, 2, 3, 2);
            buttonPauseThread2.Name = "buttonPauseThread2";
            buttonPauseThread2.Size = new Size(82, 22);
            buttonPauseThread2.TabIndex = 2;
            buttonPauseThread2.Text = "Pause";
            buttonPauseThread2.UseVisualStyleBackColor = true;
            buttonPauseThread2.Click += buttonPauseThread2_Click;
            // 
            // textBoxFileContent
            // 
            textBoxFileContent.BackColor = SystemColors.ActiveBorder;
            textBoxFileContent.Location = new Point(348, 29);
            textBoxFileContent.Margin = new Padding(3, 2, 3, 2);
            textBoxFileContent.Multiline = true;
            textBoxFileContent.Name = "textBoxFileContent";
            textBoxFileContent.Size = new Size(287, 270);
            textBoxFileContent.TabIndex = 3;
            // 
            // trackBarThread1
            // 
            trackBarThread1.Location = new Point(125, 150);
            trackBarThread1.Margin = new Padding(3, 2, 3, 2);
            trackBarThread1.Maximum = 10000;
            trackBarThread1.Minimum = 100;
            trackBarThread1.Name = "trackBarThread1";
            trackBarThread1.Size = new Size(114, 45);
            trackBarThread1.TabIndex = 4;
            trackBarThread1.Value = 5000;
            // 
            // trackBarThread2
            // 
            trackBarThread2.Location = new Point(125, 236);
            trackBarThread2.Margin = new Padding(3, 2, 3, 2);
            trackBarThread2.Maximum = 10000;
            trackBarThread2.Minimum = 100;
            trackBarThread2.Name = "trackBarThread2";
            trackBarThread2.Size = new Size(114, 45);
            trackBarThread2.TabIndex = 5;
            trackBarThread2.Value = 5000;
            // 
            // buttonStop
            // 
            buttonStop.Location = new Point(64, 59);
            buttonStop.Margin = new Padding(3, 2, 3, 2);
            buttonStop.Name = "buttonStop";
            buttonStop.Size = new Size(82, 22);
            buttonStop.TabIndex = 6;
            buttonStop.Text = "Stop";
            buttonStop.UseVisualStyleBackColor = true;
            buttonStop.Click += buttonStop_Click;
            // 
            // labelThread1
            // 
            labelThread1.AutoSize = true;
            labelThread1.Location = new Point(10, 150);
            labelThread1.Name = "labelThread1";
            labelThread1.Size = new Size(100, 15);
            labelThread1.TabIndex = 7;
            labelThread1.Text = "Пишущий поток";
            // 
            // labelThread2
            // 
            labelThread2.AutoSize = true;
            labelThread2.Location = new Point(10, 236);
            labelThread2.Name = "labelThread2";
            labelThread2.Size = new Size(109, 15);
            labelThread2.TabIndex = 8;
            labelThread2.Text = "Удаляющий поток";
            // 
            // buttonResume
            // 
            buttonResume.Location = new Point(186, 59);
            buttonResume.Margin = new Padding(3, 2, 3, 2);
            buttonResume.Name = "buttonResume";
            buttonResume.Size = new Size(82, 22);
            buttonResume.TabIndex = 9;
            buttonResume.Text = "Resume";
            buttonResume.UseVisualStyleBackColor = true;
            buttonResume.Click += buttonResume_Click;
            // 
            // MainForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.ControlDark;
            ClientSize = new Size(700, 338);
            Controls.Add(buttonResume);
            Controls.Add(labelThread2);
            Controls.Add(labelThread1);
            Controls.Add(buttonStop);
            Controls.Add(trackBarThread2);
            Controls.Add(trackBarThread1);
            Controls.Add(textBoxFileContent);
            Controls.Add(buttonPauseThread2);
            Controls.Add(buttonPauseThread1);
            Controls.Add(buttonStart);
            ForeColor = SystemColors.WindowText;
            Margin = new Padding(3, 2, 3, 2);
            Name = "MainForm";
            Text = "Потоки";
            FormClosed += MainForm_FormClosed;
            Load += MainForm_Load;
            ((System.ComponentModel.ISupportInitialize)trackBarThread1).EndInit();
            ((System.ComponentModel.ISupportInitialize)trackBarThread2).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button buttonStart;
        private Button buttonPauseThread1;
        private Button buttonPauseThread2;
        private TextBox textBoxFileContent;
        private TrackBar trackBarThread1;
        private TrackBar trackBarThread2;
        private Button buttonStop;
        private Label labelThread1;
        private Label labelThread2;
        private Button buttonResume;
    }
}