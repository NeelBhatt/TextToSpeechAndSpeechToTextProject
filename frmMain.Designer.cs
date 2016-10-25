namespace MicrosoftSpeechToTextExample
{
    partial class TextToSpeech
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
            this.Save = new System.Windows.Forms.Button();
            this.txtContent = new System.Windows.Forms.RichTextBox();
            this.Resume = new System.Windows.Forms.Button();
            this.Pause = new System.Windows.Forms.Button();
            this.Speak = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // Save
            // 
            this.Save.Location = new System.Drawing.Point(433, 330);
            this.Save.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.Save.Name = "Save";
            this.Save.Size = new System.Drawing.Size(66, 24);
            this.Save.TabIndex = 0;
            this.Save.Text = "Save";
            this.Save.UseVisualStyleBackColor = true;
            this.Save.Click += new System.EventHandler(this.Save_Click);
            // 
            // txtContent
            // 
            this.txtContent.Location = new System.Drawing.Point(8, 63);
            this.txtContent.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.txtContent.Name = "txtContent";
            this.txtContent.Size = new System.Drawing.Size(493, 265);
            this.txtContent.TabIndex = 3;
            this.txtContent.Text = "";
            // 
            // Resume
            // 
            this.Resume.Location = new System.Drawing.Point(363, 330);
            this.Resume.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.Resume.Name = "Resume";
            this.Resume.Size = new System.Drawing.Size(66, 24);
            this.Resume.TabIndex = 4;
            this.Resume.Text = "Resume";
            this.Resume.UseVisualStyleBackColor = true;
            this.Resume.Click += new System.EventHandler(this.Resume_Click);
            // 
            // Pause
            // 
            this.Pause.Location = new System.Drawing.Point(293, 330);
            this.Pause.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.Pause.Name = "Pause";
            this.Pause.Size = new System.Drawing.Size(66, 24);
            this.Pause.TabIndex = 5;
            this.Pause.Text = "Pause";
            this.Pause.UseVisualStyleBackColor = true;
            this.Pause.Click += new System.EventHandler(this.Pause_Click);
            // 
            // Speak
            // 
            this.Speak.Location = new System.Drawing.Point(223, 330);
            this.Speak.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.Speak.Name = "Speak";
            this.Speak.Size = new System.Drawing.Size(66, 24);
            this.Speak.TabIndex = 6;
            this.Speak.Text = "Speak";
            this.Speak.UseVisualStyleBackColor = true;
            this.Speak.Click += new System.EventHandler(this.Speak_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(27, 23);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(86, 13);
            this.label1.TabIndex = 7;
            this.label1.Text = "Enter text below:";
            // 
            // frmMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(507, 367);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.Speak);
            this.Controls.Add(this.Pause);
            this.Controls.Add(this.Resume);
            this.Controls.Add(this.txtContent);
            this.Controls.Add(this.Save);
            this.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.Name = "frmMain";
            this.Text = "Text To Speech Converter";
            this.Load += new System.EventHandler(this.frmMain_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button Save;
        private System.Windows.Forms.RichTextBox txtContent;
        private System.Windows.Forms.Button Resume;
        private System.Windows.Forms.Button Pause;
        private System.Windows.Forms.Button Speak;
        private System.Windows.Forms.Label label1;
    }
}

