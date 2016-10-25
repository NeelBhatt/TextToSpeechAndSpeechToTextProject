using System;
using System.Windows.Forms;
using System.Speech.Synthesis;
using System.IO;

namespace MicrosoftSpeechToTextExample
{
    public partial class TextToSpeech : Form
    {
        SpeechSynthesizer _voice;

        public TextToSpeech()
        {
            InitializeComponent();

            
            _voice = new SpeechSynthesizer();      
                
        }

        private void Speak_Click(object sender, EventArgs e)
        {            
            if (!string.IsNullOrEmpty(txtContent.Text))
                _voice.SpeakAsync(txtContent.Text);
        }

        private void Save_Click(object sender, EventArgs e)
        {
            using (SaveFileDialog sfd = new SaveFileDialog()
            {
                Filter = "Wav Files|*.wav",
                Title = "Save File as Wav"
            })
            {
                if (sfd.ShowDialog() != DialogResult.OK)
                    return;

                try
                {
                    using (var fs = new FileStream(sfd.FileName, FileMode.Create, FileAccess.Write))
                    {
                        _voice.SetOutputToWaveStream(fs);
                        _voice.Speak(txtContent.Text);
                    }
                }
                catch (Exception ex)
                {
                    //handle here
                }
            }
        }

        private void Pause_Click(object sender, EventArgs e) {
            _voice.Pause();

        }

        private void Resume_Click(object sender, EventArgs e)
        {
            _voice.Resume();
        }

        private void frmMain_Load(object sender, EventArgs e)
        {

        }
    }
}