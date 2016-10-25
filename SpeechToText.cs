using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using EllisMIS.Audio.Transcription.Microsoft;

namespace MicrosoftSpeechToTextExample
{
    public partial class SpeechToText : Form
    {
        Dictation _dictation;

        public SpeechToText()
        {
            InitializeComponent();

        }

        private void btnWavFile_Click(object sender, EventArgs e)
        {           
            if (_dictation != null)
            {
                _dictation.Dispose();
            }

            _dictation = new Dictation();
            SetEvents();
            _dictation.Start("example.wav");
            
        }

        void _transcriber_SpeechHypothesizingEvent(object sender, System.Speech.Recognition.SpeechHypothesizedEventArgs e)
        {
            string finalAnswer = e.Result.Text;
            Console.WriteLine("Speech Recognizing: " + e.Result.Text);
        }

        void transcriber_SpeechRecognizedEvent(object sender, System.Speech.Recognition.SpeechRecognizedEventArgs e)
        {
            richTextBox1.Text = e.Result.Text;
            Console.WriteLine("Speech Recognized: " + e.Result.Text);
        }

        public void SetEvents()
        {
            _dictation.SpeechRecognizedEvent -= new Dictation.SpeechRecognizedEventHandler(transcriber_SpeechRecognizedEvent);
            _dictation.SpeechHypothesizingEvent -= new Dictation.SpeechHypothesizingEventHandler(_transcriber_SpeechHypothesizingEvent);
            _dictation.SpeechRecognizedEvent += new Dictation.SpeechRecognizedEventHandler(transcriber_SpeechRecognizedEvent);
            _dictation.SpeechHypothesizingEvent += new Dictation.SpeechHypothesizingEventHandler(_transcriber_SpeechHypothesizingEvent);
        }

        private void btnMic_Click(object sender, EventArgs e)
        {           
            if (_dictation != null)
            {
                _dictation.Dispose();
            }

            _dictation = new Dictation();
            SetEvents();
            _dictation.Start();
        }

    }
}
