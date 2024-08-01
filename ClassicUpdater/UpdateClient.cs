using System;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.IO;
using System.Net.Http;
using System.Threading.Tasks;
using System.Windows.Forms;
using Newtonsoft.Json.Linq;
using System.Diagnostics;

namespace ClassicUpdater
{
    public partial class UpdateClient : Form
    {
        private string updateVersion = "";
        private bool updateAvailable = false;

        public UpdateClient()
        {
            InitializeComponent();
            InitializeCustomComponents();
            AutoScroll = true;
        }

        private void InitializeCustomComponents()
        {
            updatePanel.Paint += UpdatePanel_Paint;
            updcheckbutton.Click += updcheckbutton_Click;
        }

        private void InitializeAlternateCustomComponents()
        {
            updatePanel.Paint += UpdatePanel_Paint2;
        }

        private void UpdatePanel_Paint(object sender, PaintEventArgs e)
        {
            using (var brush = new LinearGradientBrush(
                updatePanel.ClientRectangle,
                ColorTranslator.FromHtml("#841010"),
                ColorTranslator.FromHtml("#DC0201"),
                LinearGradientMode.Vertical))
            {
                e.Graphics.FillRectangle(brush, updatePanel.ClientRectangle);
            }
        }

        private void UpdatePanel_Paint2(object sender, PaintEventArgs e)
        {
            using (var brush = new LinearGradientBrush(
                updatePanel.ClientRectangle,
                ColorTranslator.FromHtml("#F3B205"),
                ColorTranslator.FromHtml("#FECB42"),
                LinearGradientMode.Vertical))
            {
                e.Graphics.FillRectangle(brush, updatePanel.ClientRectangle);
            }
        }

        private async void updcheckbutton_Click(object sender, EventArgs e)
        {
            if (updateAvailable)
            {
                string updateUrl = $"https://updates.starix.lol/updates/{Uri.EscapeDataString(updateVersion)}/update.upd";
                using (var client = new HttpClient())
                {
                    await InstallUpdateAsync(client, updateUrl);
                }
            }
            else
            {
                string versionUrl = "https://updates.starix.lol/getversion";
                UpdateUIForCheckingUpdates();

                try
                {
                    using (var client = new HttpClient())
                    {
                        Debug.WriteLine($"Accessing version URL: {versionUrl}");
                        string versionResponse = await client.GetStringAsync(versionUrl);
                        var versionData = JObject.Parse(versionResponse);
                        updateVersion = (string)versionData["version"];
                        Debug.WriteLine($"Fetched version: '{updateVersion}'");
                        this.versioncurrentinstallinglabel.Text = $"Currently installing: {updateVersion}";

                        string currentVersion = "0.2.1";
                        if (IsUpdateAvailable(currentVersion, updateVersion))
                        {
                            updateAvailable = true;
                            string updateUrl = $"https://updates.starix.lol/updates/{Uri.EscapeDataString(updateVersion)}/update.upd";
                            Debug.WriteLine($"Accessing update URL: {updateUrl}");
                            UpdateUIForUpdateAvailable();
                        }
                        else
                        {
                            MessageBox.Show("You are already using the latest version.", "No Updates", MessageBoxButtons.OK, MessageBoxIcon.Information);
                            updateAvailable = false;
                        }
                    }
                }
                catch (Exception ex)
                {
                    LogException(ex);
                    MessageBox.Show($"An error occurred: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        private bool IsUpdateAvailable(string currentVersion, string availableVersion)
        {
            var current = new Version(currentVersion);
            var available = new Version(availableVersion);
            return available.CompareTo(current) > 0;
        }

        private void UpdateUIForCheckingUpdates()
        {
            infoPanel.Size = new Size(499, 75);
            shieldImage.Location = new Point(9, 8);
            updateText.Location = new Point(67, 12);
            mostrecheader.Location = new Point(53, 167);
            dateCheckUpd.Location = new Point(234, 167);
            updinstalledheader.Location = new Point(52, 186);
            dateInstalledUpd.Location = new Point(234, 186);
            viewupdhistorylink.Location = new Point(335, 186);
            yourecupdheader.Location = new Point(53, 205);
            recieveUpdateLabel.Location = new Point(234, 205);
            getupdPanel.Location = new Point(56, 240);

            shieldImage.BackgroundImage = Properties.Resources.updateIcon;
            updateText.Text = "Checking for updates...";
            updateTextBelow.Visible = false;
            updcheckbutton.Visible = false;
            updcheckbutton.Text = "Install updates";
            updatePanel.Visible = false;
            progressBar1.Visible = true;
            dateCheckUpd.Text = DateTime.Now.ToString("MM/dd/yyyy HH:mm:ss");
        }

        private async Task InstallUpdateAsync(HttpClient client, string updateUrl)
        {
            try
            {
                UpdateUIForInstallingUpdates();
                string updateContent = await client.GetStringAsync(updateUrl);
                var updateData = JObject.Parse(updateContent);

                foreach (var fileEntry in updateData["files"])
                {
                    string sourceFileName = (string)fileEntry["source"];
                    string destinationPath = (string)fileEntry["destination"];
                    string fileUrl = $"https://updates.starix.lol/updates/{Uri.EscapeDataString(updateVersion)}/files/{Uri.EscapeDataString(sourceFileName)}";

                    Debug.WriteLine($"Accessing File URL: {fileUrl}");
                    byte[] fileBytes = await client.GetByteArrayAsync(fileUrl);
                    string directoryPath = Path.GetDirectoryName(destinationPath);

                    if (!Directory.Exists(directoryPath))
                    {
                        Directory.CreateDirectory(directoryPath);
                    }

                    File.WriteAllBytes(destinationPath, fileBytes);
                }

                MessageBox.Show("Update installed successfully.", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                UpdateUIForCheckingUpdates();
                updateAvailable = false;
            }
            catch (Exception ex)
            {
                LogException(ex);
                MessageBox.Show($"An error occurred during update installation: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void UpdateUIForInstallingUpdates()
        {
            infoPanel.Size = new Size(499, 82);
            shieldImage.Location = new Point(9, 8);
            updateText.Location = new Point(67, 12);
            mostrecheader.Location = new Point(53, 167);
            dateCheckUpd.Location = new Point(234, 167);
            updinstalledheader.Location = new Point(52, 186);
            dateInstalledUpd.Location = new Point(234, 186);
            viewupdhistorylink.Location = new Point(335, 186);
            yourecupdheader.Location = new Point(53, 205);
            recieveUpdateLabel.Location = new Point(234, 205);
            getupdPanel.Location = new Point(56, 240);

            shieldImage.BackgroundImage = Properties.Resources.updateIcon;
            updateText.Text = "Downloading and installing updates";
            updateTextBelow.Visible = false;
            updcheckbutton.Visible = false;
            updcheckbutton.Text = "Try again";
            updatePanel.Visible = false;
            progressBar1.Visible = true;
            versioncurrentinstallinglabel.Visible = true;
            dateInstalledUpd.Text = DateTime.Now.ToString("MM/dd/yyyy HH:mm:ss");
        }

        private void UpdateUIForUpdateAvailable()
        {
            InitializeAlternateCustomComponents();
            updatePanel.Visible = true;
            shieldImage.Location = new Point(24, 8);
            updateText.Location = new Point(82, 12);
            mostrecheader.Location = new Point(53, 216);
            dateCheckUpd.Location = new Point(234, 216);
            updinstalledheader.Location = new Point(52, 235);
            dateInstalledUpd.Location = new Point(234, 235);
            viewupdhistorylink.Location = new Point(335, 235);
            yourecupdheader.Location = new Point(53, 254);
            recieveUpdateLabel.Location = new Point(234, 254);
            getupdPanel.Location = new Point(56, 289);

            updatePanel.Size = new Size(20, 119);
            updcheckbutton.Size = new Size(93, 23);
            infoPanel.Size = new Size(488, 120);
            updcheckbutton.Location = new Point(384, 85);
            shieldImage.BackgroundImage = Properties.Resources.exclamationShield;
            progressBar1.Visible = false;
            updcheckbutton.Visible = true;
            updcheckbutton.Text = "Install updates";
            updateText.Text = "Download and install updates for your computer";
        }

        private void LogException(Exception ex)
        {
            Debug.WriteLine($"Exception: {ex.GetType().Name}");
            Debug.WriteLine($"Message: {ex.Message}");
            Debug.WriteLine($"Stack Trace: {ex.StackTrace}");
        }
    }
}
