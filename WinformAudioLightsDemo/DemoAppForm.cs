using System;
using System.Collections.Specialized;
using System.Linq;
using System.Net;
using System.Windows.Forms;
using NAudio.CoreAudioApi;
using System.Configuration;

namespace WinformAudioLightsDemo
{

    public partial class DemoAppForm : Form
    {
        private int _messagesSent;
        private readonly string _demoUrl;

        public DemoAppForm()
        {
            InitializeComponent();

            AvailableSoundSources.Items.AddRange(new MMDeviceEnumerator().EnumerateAudioEndPoints(DataFlow.All, DeviceState.Active).ToArray());
            StopButton.Enabled = false;
            PlayButton.Enabled = false;

            VolumeMeter.Maximum = 100;
            VolumeMeter.Minimum = 0;
           
            ConsoleColorList.DataSource = ((ConsoleColor[])(Enum.GetValues(typeof(ConsoleColor)))).Select(c => c.ToString()).OrderBy(c => c).ToArray();
            ConsoleColorList.SelectedIndexChanged += ConsoleColorListSelectedIndexChanged;
            ConsoleColorList.SelectedIndex = 0;

            _demoUrl = ConfigurationManager.AppSettings.Get("DemoUrlFormat");
        }

        private void ConsoleColorListSelectedIndexChanged(object sender, EventArgs e)
        {
            ColorLabel.Text = string.Empty;
            ColorLabel.Text = (string)(((ComboBox)sender).SelectedItem);
        }

        private void AvailableSoundSourcesSelectedIndexChanged(object sender, EventArgs e)
        {
            if (AvailableSoundSources.SelectedItem == null)
            {
                StopButton.Enabled = false;
                PlayButton.Enabled = false;
                return;
            }

            StopButton.Enabled = false;
            PlayButton.Enabled = true;
        }

        private void SlowRunningTimerTick(object sender, EventArgs e)
        {
            if (AvailableSoundSources.SelectedItem == null) return;
            if (!StopButton.Enabled) return;

            SendMultiPub(VolumeMeter.Value);
        }

        private void SendMultiPub(int audioLevel)
        {
            var topicToPost = string.Empty;
            string color = null;

            if (audioLevel < 25)
            {
                topicToPost = "multi-topic-1";
                color = "DarkGreen";
            }

            if (audioLevel > 25 && audioLevel < 50)
            {
                topicToPost = "multi-topic-2";
                color = "Green";
            }

            if (audioLevel > 50 && audioLevel < 75)
            {
                topicToPost = "multi-topic-3";
                color = "Yellow";
            }
            if (audioLevel > 75)
            {
                topicToPost = "multi-topic-4";
                color = "Red";
            }

            StateLabel.Text = topicToPost;
            SendMessage(topicToPost, audioLevel, color);
        }

        private void SendMessage(string topic, int audioLevel, string color = null)
        {
            var myUrl = string.Format(_demoUrl, topic);
            SendMessageCore(myUrl, audioLevel, color);
        }

        private void StopButtonClick(object sender, EventArgs e)
        {
            PlayButton.Enabled = true;
            StopButton.Enabled = false;
            _messagesSent = 0;
        }

        private void PlayButtonClick(object sender, EventArgs e)
        {
            StopButton.Enabled = true;
            PlayButton.Enabled = false;
        }

        private void ContinuousTimerTick(object sender, EventArgs e)
        {
            if (AvailableSoundSources.SelectedItem == null) return;

            var device = (MMDevice)AvailableSoundSources.SelectedItem;
            var currentAudioLevel = (int)(Math.Round(device.AudioMeterInformation.MasterPeakValue * 100));
            VolumeMeter.Value = currentAudioLevel;

            if (!StopButton.Enabled || MultiTimer.Enabled) return;
            SendMessage("demo-topic", currentAudioLevel);
        }
        
        private void SendMessageCore(string target,int level, string color = null)
        {
            try
            {
                using (var client = new WebClient())
                {
                    var response =
                        client.UploadValues(
                            target, "PUT",
                            new NameValueCollection
                            {
                                {"color", color??ColorLabel.Text},
                                {"intensity", level.ToString()},
                                {"id", (_messagesSent+1).ToString()}
                            });
                    _messagesSent++;
                }
            }
            catch
            {
            }
            
            MessagesSentLabel.Text = string.Format("Messages sent: {0}", _messagesSent);
        }

        private void OnButtonCheckedChanged(object sender, EventArgs e)
        {
            ContinuousTimer.Enabled = true;
            MultiTimer.Enabled = true;
            _messagesSent = 0;
        }

        private void OffButtonCheckedChanged(object sender, EventArgs e)
        {
            ContinuousTimer.Enabled = true;
            MultiTimer.Enabled = false;
            _messagesSent = 0;
        }
    }
}
