using System;
using System.IO;
using System.Runtime.InteropServices;
using System.Threading;
using NAudio.CoreAudioApi;
using NAudio.Wave;
using System.Windows.Forms;

namespace JorgitoRecords
{
    public partial class Form1 : Form
    {
        private WasapiLoopbackCapture capture;
        private WaveFileWriter writer;
        private string outputFilePath = "recordedAudio.wav";

        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
        }

        private void btnStart_Click(object sender, EventArgs e)
        {
            StartRecording();
        }

        private void btnStop_Click(object sender, EventArgs e)
        {
            StopRecording();
        }

        private void StartRecording()
        {
            try
            {
                capture = new WasapiLoopbackCapture();
                capture.DataAvailable += OnDataAvailable;
                capture.RecordingStopped += OnRecordingStopped;

                writer = new WaveFileWriter(outputFilePath, capture.WaveFormat);

                capture.StartRecording();
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error starting recording: {ex.Message}");
            }
        }

        private void StopRecording()
        {
            if (capture != null)
            {
                capture.StopRecording();
            }
        }

        private void OnDataAvailable(object sender, WaveInEventArgs e)
        {
            if (writer != null)
            {
                writer.Write(e.Buffer, 0, e.BytesRecorded);
                writer.Flush();
            }
        }

        private void OnRecordingStopped(object sender, StoppedEventArgs e)
        {
            if (writer != null)
            {
                writer.Dispose();
                writer = null;
            }

            if (capture != null)
            {
                capture.Dispose();
                capture = null;
            }

            if (e.Exception != null)
            {
                MessageBox.Show($"Error stopping recording: {e.Exception.Message}");
            }
        }
    }
}
