using System;
using System.Drawing;
using System.Net.Http;
using System.Windows.Forms;
using WindowsFormsAero;

namespace ClassicUpdater
{
    public partial class UpdateClient : WindowsFormsAero.AeroForm
    {
        private NotifyIcon notifyIcon;

        public UpdateClient()
        {
            InitializeComponent();
            _ = new DarkModeCS(this);
            GlassMargins = new Padding(600, 600, 600, 600);
            PInvoke.Methods.SetWindowAttribute(Handle, PInvoke.ParameterTypes.DWMWINDOWATTRIBUTE.DWMWA_SYSTEMBACKDROP_TYPE, 2);
            PInvoke.Methods.SetWindowAttribute(Handle, PInvoke.ParameterTypes.DWMWINDOWATTRIBUTE.DWMWA_USE_IMMERSIVE_DARK_MODE, 1);

            notifyIcon = new NotifyIcon
            {
                Icon = SystemIcons.Information,
                Visible = true
            };

            changelogsBox.Multiline = true;
            changelogsBox.ScrollBars = ScrollBars.None;
            changelogsBox.WordWrap = false;

            AutoScroll = true;
        }

        private async void checkUpdates_Click(object sender, EventArgs e)
        {
            string url = "http://127.0.0.1:5000/getchangelog";
            try
            {
                using (HttpClient client = new HttpClient())
                {
                    string changelogContent = await client.GetStringAsync(url);

                    changelogContent = NormalizeLineBreaks(changelogContent);

                    string version = ExtractVersion(changelogContent);

                    string cleanedContent = RemoveVersionLine(changelogContent);

                    changelogsBox.Text = cleanedContent;

                    ShowUpdateNotification(version);
                }
            }
            catch (HttpRequestException httpEx)
            {
                MessageBox.Show($"Request error: {httpEx.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            catch (Exception ex)
            {
                MessageBox.Show($"An error occurred: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private string NormalizeLineBreaks(string text)
        {
            text = text.Replace("\r\n", "\n").Replace("\r", "\n");
            return text.Replace("\n", "\r\n");
        }

        private string ExtractVersion(string changelogContent)
        {
            string versionPrefix = "@version: ";
            int versionStartIndex = changelogContent.IndexOf(versionPrefix);
            if (versionStartIndex != -1)
            {
                int versionEndIndex = changelogContent.IndexOf('\n', versionStartIndex);
                if (versionEndIndex == -1)
                    versionEndIndex = changelogContent.Length;

                string versionLine = changelogContent.Substring(versionStartIndex, versionEndIndex - versionStartIndex);
                return versionLine.Replace(versionPrefix, "").Trim();
            }
            return "Unknown version";
        }

        private string RemoveVersionLine(string changelogContent)
        {
            string versionPrefix = "@version: ";
            int versionStartIndex = changelogContent.IndexOf(versionPrefix);
            if (versionStartIndex != -1)
            {
                int versionEndIndex = changelogContent.IndexOf('\n', versionStartIndex);
                if (versionEndIndex == -1)
                    versionEndIndex = changelogContent.Length;

                string versionLine = changelogContent.Substring(versionStartIndex, versionEndIndex - versionStartIndex);
                string cleanedContent = changelogContent.Replace(versionLine, "").Trim();

                return NormalizeLineBreaks(cleanedContent);
            }
            return NormalizeLineBreaks(changelogContent);
        }

        private void ShowUpdateNotification(string version)
        {
            notifyIcon.BalloonTipTitle = $"New update found: {version}";
            notifyIcon.BalloonTipText = "The changelog has been updated.";
            notifyIcon.BalloonTipIcon = ToolTipIcon.Info;
            notifyIcon.ShowBalloonTip(3000);
        }
    }
}
