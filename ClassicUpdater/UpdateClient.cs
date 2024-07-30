using System;
using System.Drawing;
using System.Net.Http;
using System.Windows.Forms;
using WindowsFormsAero;
using System.IO;
using Newtonsoft.Json.Linq;
using System.Diagnostics;

namespace ClassicUpdater
{
    public partial class UpdateClient : WindowsFormsAero.AeroForm
    {
        private NotifyIcon notifyIcon;
        private string updateVersion = "";

        public UpdateClient()
        {
            InitializeComponent();
            _ = new DarkModeCS(this);
            GlassMargins = new Padding(0, 223, 0, 0);
            PInvoke.Methods.SetWindowAttribute(Handle, PInvoke.ParameterTypes.DWMWINDOWATTRIBUTE.DWMWA_SYSTEMBACKDROP_TYPE, 2);
            PInvoke.Methods.SetWindowAttribute(Handle, PInvoke.ParameterTypes.DWMWINDOWATTRIBUTE.DWMWA_USE_IMMERSIVE_DARK_MODE, 1);

            notifyIcon = new NotifyIcon
            {
                Icon = SystemIcons.Information,
                Visible = true
            };

            changelogsBox.Multiline = true;
            changelogsBox.ScrollBars = ScrollBars.Vertical;
            changelogsBox.WordWrap = false;

            AutoScroll = true;
        }

        private void checkUpdates_Click(object sender, EventArgs e)
        {
            string changelogUrl = "http://127.0.0.1:5000/getchangelog";
            string versionUrl = "http://127.0.0.1:5000/getversion";

            try
            {
                using (HttpClient client = new HttpClient())
                {
                    Debug.WriteLine($"Accessing version URL: {versionUrl}");

                    var versionResponse = client.GetStringAsync(versionUrl).GetAwaiter().GetResult();
                    var versionData = JObject.Parse(versionResponse);
                    updateVersion = (string)versionData["version"];

                    Debug.WriteLine($"Fetched version: '{updateVersion}'");

                    Debug.WriteLine($"Accessing changelog URL: {changelogUrl}");
                    string changelogResponse = client.GetStringAsync(changelogUrl).GetAwaiter().GetResult();
                    var changelogData = JObject.Parse(changelogResponse);

                    string changelogContent = (string)changelogData["changelog"];
                    changelogsBox.Text = FormatChangelog(changelogContent, updateVersion);

                    string updateUrl = $"http://127.0.0.1:5000/updates/{Uri.EscapeDataString(updateVersion)}/update.upd";
                    Debug.WriteLine($"Accessing update URL: {updateUrl}");

                    InstallUpdate(client, updateUrl);
                }
            }
            catch (Exception ex)
            {
                LogException(ex);
                MessageBox.Show($"An error occurred: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void InstallUpdate(HttpClient client, string updateUrl)
        {
            try
            {
                string updateContent = client.GetStringAsync(updateUrl).GetAwaiter().GetResult();

                JObject updateData = JObject.Parse(updateContent);

                foreach (var fileEntry in updateData["files"])
                {
                    string sourceFileName = (string)fileEntry["source"];
                    string destinationPath = (string)fileEntry["destination"];

                    string fileUrl = $"http://127.0.0.1:5000/updates/{Uri.EscapeDataString(updateVersion)}/files/{Uri.EscapeDataString(sourceFileName)}";
                    Debug.WriteLine($"Accessing File URL: {fileUrl}");

                    byte[] fileBytes = client.GetByteArrayAsync(fileUrl).GetAwaiter().GetResult();
                    string directoryPath = Path.GetDirectoryName(destinationPath);

                    if (!Directory.Exists(directoryPath))
                    {
                        Directory.CreateDirectory(directoryPath);
                    }

                    File.WriteAllBytes(destinationPath, fileBytes);
                }

                MessageBox.Show("Update installed successfully.", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                checkUpdates.Text = "Check for Updates";
            }
            catch (Exception ex)
            {
                LogException(ex);
                MessageBox.Show($"An error occurred during update installation: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private string FormatChangelog(string changelog, string version)
        {
            changelog = changelog.Replace("\r\n", "\n").Replace("\r", "\n");
            string formattedChangelog = changelog.Replace("\n", "\r\n");
            formattedChangelog += $"\r\nVersion: {version}";
            return formattedChangelog;
        }

        private void LogException(Exception ex)
        {
            Debug.WriteLine($"Exception: {ex.GetType().Name}");
            Debug.WriteLine($"Message: {ex.Message}");
            Debug.WriteLine($"Stack Trace: {ex.StackTrace}");
        }
    }
}
