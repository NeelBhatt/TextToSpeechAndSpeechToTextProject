namespace MicrosoftSpeechToTextExample
{
    partial class SpeechToText
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
            this.btnWavFile = new System.Windows.Forms.Button();
            this.btnMic = new System.Windows.Forms.Button();
            this.richTextBox1 = new System.Windows.Forms.RichTextBox();
            this.SuspendLayout();
            // 
            // btnWavFile
            // 
            this.btnWavFile.Location = new System.Drawing.Point(36, 25);
            this.btnWavFile.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btnWavFile.Name = "btnWavFile";
            this.btnWavFile.Size = new System.Drawing.Size(140, 30);
            this.btnWavFile.TabIndex = 0;
            this.btnWavFile.Text = "Transcribe a .WAV file";
            this.btnWavFile.UseVisualStyleBackColor = true;
            this.btnWavFile.Click += new System.EventHandler(this.btnWavFile_Click);
            // 
            // btnMic
            // 
            this.btnMic.Location = new System.Drawing.Point(36, 61);
            this.btnMic.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btnMic.Name = "btnMic";
            this.btnMic.Size = new System.Drawing.Size(140, 35);
            this.btnMic.TabIndex = 3;
            this.btnMic.Text = "Transcribe using your MIC";
            this.btnMic.UseVisualStyleBackColor = true;
            this.btnMic.Click += new System.EventHandler(this.btnMic_Click);
            // 
            // richTextBox1
            // 
            this.richTextBox1.Location = new System.Drawing.Point(12, 129);
            this.richTextBox1.Name = "richTextBox1";
            this.richTextBox1.Size = new System.Drawing.Size(264, 205);
            this.richTextBox1.TabIndex = 4;
            this.richTextBox1.Text = "";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(288, 346);
            this.Controls.Add(this.richTextBox1);
            this.Controls.Add(this.btnMic);
            this.Controls.Add(this.btnWavFile);
            this.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnWavFile;
        private System.Windows.Forms.Button btnMic;
        private System.Windows.Forms.RichTextBox richTextBox1;
    }
}

