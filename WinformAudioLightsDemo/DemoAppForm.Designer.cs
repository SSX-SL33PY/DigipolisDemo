namespace WinformAudioLightsDemo
{
    partial class DemoAppForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
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
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.VolumeMeter = new System.Windows.Forms.ProgressBar();
            this.AvailableSoundSources = new System.Windows.Forms.ComboBox();
            this.MultiTimer = new System.Windows.Forms.Timer(this.components);
            this.StateLabel = new System.Windows.Forms.Label();
            this.StopButton = new System.Windows.Forms.Button();
            this.PlayButton = new System.Windows.Forms.Button();
            this.ContinuousTimer = new System.Windows.Forms.Timer(this.components);
            this.ColorLabel = new System.Windows.Forms.Label();
            this.ConsoleColorList = new System.Windows.Forms.ComboBox();
            this.MessagesSentLabel = new System.Windows.Forms.Label();
            this.MultiPubGroup = new System.Windows.Forms.GroupBox();
            this.OffButton = new System.Windows.Forms.RadioButton();
            this.OnButton = new System.Windows.Forms.RadioButton();
            this.MultiPubGroup.SuspendLayout();
            this.SuspendLayout();
            // 
            // VolumeMeter
            // 
            this.VolumeMeter.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.VolumeMeter.Location = new System.Drawing.Point(0, 197);
            this.VolumeMeter.Margin = new System.Windows.Forms.Padding(4);
            this.VolumeMeter.Name = "VolumeMeter";
            this.VolumeMeter.Size = new System.Drawing.Size(629, 34);
            this.VolumeMeter.TabIndex = 0;
            // 
            // AvailableSoundSources
            // 
            this.AvailableSoundSources.FormattingEnabled = true;
            this.AvailableSoundSources.Location = new System.Drawing.Point(17, 16);
            this.AvailableSoundSources.Margin = new System.Windows.Forms.Padding(4);
            this.AvailableSoundSources.Name = "AvailableSoundSources";
            this.AvailableSoundSources.Size = new System.Drawing.Size(595, 24);
            this.AvailableSoundSources.TabIndex = 1;
            this.AvailableSoundSources.SelectedIndexChanged += new System.EventHandler(this.AvailableSoundSourcesSelectedIndexChanged);
            // 
            // MultiTimer
            // 
            this.MultiTimer.Enabled = true;
            this.MultiTimer.Tick += new System.EventHandler(this.SlowRunningTimerTick);
            // 
            // StateLabel
            // 
            this.StateLabel.AutoSize = true;
            this.StateLabel.Location = new System.Drawing.Point(17, 50);
            this.StateLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.StateLabel.Name = "StateLabel";
            this.StateLabel.Size = new System.Drawing.Size(0, 17);
            this.StateLabel.TabIndex = 2;
            // 
            // StopButton
            // 
            this.StopButton.Location = new System.Drawing.Point(5, 145);
            this.StopButton.Name = "StopButton";
            this.StopButton.Size = new System.Drawing.Size(75, 42);
            this.StopButton.TabIndex = 3;
            this.StopButton.Text = "Stop";
            this.StopButton.UseVisualStyleBackColor = true;
            this.StopButton.Click += new System.EventHandler(this.StopButtonClick);
            // 
            // PlayButton
            // 
            this.PlayButton.Location = new System.Drawing.Point(86, 145);
            this.PlayButton.Name = "PlayButton";
            this.PlayButton.Size = new System.Drawing.Size(75, 42);
            this.PlayButton.TabIndex = 3;
            this.PlayButton.Text = "Play";
            this.PlayButton.UseVisualStyleBackColor = true;
            this.PlayButton.Click += new System.EventHandler(this.PlayButtonClick);
            // 
            // ContinuousTimer
            // 
            this.ContinuousTimer.Enabled = true;
            this.ContinuousTimer.Tick += new System.EventHandler(this.ContinuousTimerTick);
            // 
            // ColorLabel
            // 
            this.ColorLabel.AutoSize = true;
            this.ColorLabel.Location = new System.Drawing.Point(401, 103);
            this.ColorLabel.Name = "ColorLabel";
            this.ColorLabel.Size = new System.Drawing.Size(0, 17);
            this.ColorLabel.TabIndex = 4;
            // 
            // ConsoleColorList
            // 
            this.ConsoleColorList.FormattingEnabled = true;
            this.ConsoleColorList.Location = new System.Drawing.Point(496, 100);
            this.ConsoleColorList.Name = "ConsoleColorList";
            this.ConsoleColorList.Size = new System.Drawing.Size(121, 24);
            this.ConsoleColorList.TabIndex = 5;
            // 
            // MessagesSentLabel
            // 
            this.MessagesSentLabel.AutoSize = true;
            this.MessagesSentLabel.Location = new System.Drawing.Point(183, 158);
            this.MessagesSentLabel.Name = "MessagesSentLabel";
            this.MessagesSentLabel.Size = new System.Drawing.Size(0, 17);
            this.MessagesSentLabel.TabIndex = 6;
            // 
            // MultiPubGroup
            // 
            this.MultiPubGroup.Controls.Add(this.OffButton);
            this.MultiPubGroup.Controls.Add(this.OnButton);
            this.MultiPubGroup.Location = new System.Drawing.Point(17, 82);
            this.MultiPubGroup.Name = "MultiPubGroup";
            this.MultiPubGroup.Size = new System.Drawing.Size(183, 57);
            this.MultiPubGroup.TabIndex = 7;
            this.MultiPubGroup.TabStop = false;
            this.MultiPubGroup.Text = "Multiple publish mode";
            // 
            // OffButton
            // 
            this.OffButton.AutoSize = true;
            this.OffButton.Location = new System.Drawing.Point(69, 21);
            this.OffButton.Name = "OffButton";
            this.OffButton.Size = new System.Drawing.Size(48, 21);
            this.OffButton.TabIndex = 0;
            this.OffButton.TabStop = true;
            this.OffButton.Text = "Off";
            this.OffButton.UseVisualStyleBackColor = true;
            this.OffButton.CheckedChanged += new System.EventHandler(this.OffButtonCheckedChanged);
            // 
            // OnButton
            // 
            this.OnButton.AutoSize = true;
            this.OnButton.Location = new System.Drawing.Point(15, 21);
            this.OnButton.Name = "OnButton";
            this.OnButton.Size = new System.Drawing.Size(48, 21);
            this.OnButton.TabIndex = 0;
            this.OnButton.TabStop = true;
            this.OnButton.Text = "On";
            this.OnButton.UseVisualStyleBackColor = true;
            this.OnButton.CheckedChanged += new System.EventHandler(this.OnButtonCheckedChanged);
            // 
            // DemoAppForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(629, 231);
            this.Controls.Add(this.MultiPubGroup);
            this.Controls.Add(this.MessagesSentLabel);
            this.Controls.Add(this.ConsoleColorList);
            this.Controls.Add(this.ColorLabel);
            this.Controls.Add(this.PlayButton);
            this.Controls.Add(this.StopButton);
            this.Controls.Add(this.StateLabel);
            this.Controls.Add(this.AvailableSoundSources);
            this.Controls.Add(this.VolumeMeter);
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "DemoAppForm";
            this.Text = "Digipolis Demo";
            this.MultiPubGroup.ResumeLayout(false);
            this.MultiPubGroup.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ProgressBar VolumeMeter;
        private System.Windows.Forms.ComboBox AvailableSoundSources;
        private System.Windows.Forms.Timer MultiTimer;
        private System.Windows.Forms.Label StateLabel;
        private System.Windows.Forms.Button StopButton;
        private System.Windows.Forms.Button PlayButton;
        private System.Windows.Forms.Timer ContinuousTimer;
        private System.Windows.Forms.Label ColorLabel;
        private System.Windows.Forms.ComboBox ConsoleColorList;
        private System.Windows.Forms.Label MessagesSentLabel;
        private System.Windows.Forms.GroupBox MultiPubGroup;
        private System.Windows.Forms.RadioButton OffButton;
        private System.Windows.Forms.RadioButton OnButton;
    }
}

