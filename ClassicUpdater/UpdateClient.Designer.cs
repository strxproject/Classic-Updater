namespace ClassicUpdater
{
    partial class UpdateClient
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(UpdateClient));
            this.headerLabel = new System.Windows.Forms.Label();
            this.updatePanel = new System.Windows.Forms.Panel();
            this.updateText = new System.Windows.Forms.Label();
            this.updateTextBelow = new System.Windows.Forms.Label();
            this.infoPanel = new System.Windows.Forms.Panel();
            this.progressBar1 = new System.Windows.Forms.ProgressBar();
            this.updcheckbutton = new System.Windows.Forms.Button();
            this.shieldImage = new System.Windows.Forms.PictureBox();
            this.mostrecheader = new System.Windows.Forms.Label();
            this.updinstalledheader = new System.Windows.Forms.Label();
            this.yourecupdheader = new System.Windows.Forms.Label();
            this.dateCheckUpd = new System.Windows.Forms.Label();
            this.dateInstalledUpd = new System.Windows.Forms.Label();
            this.recieveUpdateLabel = new System.Windows.Forms.Label();
            this.viewupdhistorylink = new System.Windows.Forms.LinkLabel();
            this.getupdPanel = new System.Windows.Forms.Panel();
            this.getupdfindoutlink = new System.Windows.Forms.LinkLabel();
            this.getupdheader = new System.Windows.Forms.Label();
            this.versioncurrentinstallinglabel = new System.Windows.Forms.Label();
            this.curverlabel = new System.Windows.Forms.Label();
            this.newverlabel = new System.Windows.Forms.Label();
            this.updatesizelabel = new System.Windows.Forms.Label();
            this.infoPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.shieldImage)).BeginInit();
            this.getupdPanel.SuspendLayout();
            this.SuspendLayout();
            // 
            // headerLabel
            // 
            this.headerLabel.AutoSize = true;
            this.headerLabel.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.headerLabel.ForeColor = System.Drawing.Color.MidnightBlue;
            this.headerLabel.Location = new System.Drawing.Point(51, 28);
            this.headerLabel.Name = "headerLabel";
            this.headerLabel.Size = new System.Drawing.Size(117, 21);
            this.headerLabel.TabIndex = 0;
            this.headerLabel.Text = "Classic Updater";
            // 
            // updatePanel
            // 
            this.updatePanel.BackColor = System.Drawing.Color.DarkOliveGreen;
            this.updatePanel.Location = new System.Drawing.Point(0, 0);
            this.updatePanel.Name = "updatePanel";
            this.updatePanel.Size = new System.Drawing.Size(20, 119);
            this.updatePanel.TabIndex = 1;
            // 
            // updateText
            // 
            this.updateText.AutoSize = true;
            this.updateText.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.updateText.ForeColor = System.Drawing.Color.MidnightBlue;
            this.updateText.Location = new System.Drawing.Point(82, 12);
            this.updateText.Name = "updateText";
            this.updateText.Size = new System.Drawing.Size(266, 21);
            this.updateText.TabIndex = 2;
            this.updateText.Text = "Check for updates for your computer";
            // 
            // updateTextBelow
            // 
            this.updateTextBelow.AutoSize = true;
            this.updateTextBelow.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.updateTextBelow.Location = new System.Drawing.Point(83, 38);
            this.updateTextBelow.Name = "updateTextBelow";
            this.updateTextBelow.Size = new System.Drawing.Size(393, 30);
            this.updateTextBelow.TabIndex = 3;
            this.updateTextBelow.Text = "Always install the latest updates to enhance your computer\'s security and\r\nperfor" +
    "mance\r\n";
            // 
            // infoPanel
            // 
            this.infoPanel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.infoPanel.Controls.Add(this.updatesizelabel);
            this.infoPanel.Controls.Add(this.newverlabel);
            this.infoPanel.Controls.Add(this.curverlabel);
            this.infoPanel.Controls.Add(this.versioncurrentinstallinglabel);
            this.infoPanel.Controls.Add(this.progressBar1);
            this.infoPanel.Controls.Add(this.updcheckbutton);
            this.infoPanel.Controls.Add(this.updatePanel);
            this.infoPanel.Controls.Add(this.shieldImage);
            this.infoPanel.Controls.Add(this.updateText);
            this.infoPanel.Controls.Add(this.updateTextBelow);
            this.infoPanel.Location = new System.Drawing.Point(55, 76);
            this.infoPanel.Name = "infoPanel";
            this.infoPanel.Size = new System.Drawing.Size(488, 99);
            this.infoPanel.TabIndex = 5;
            // 
            // progressBar1
            // 
            this.progressBar1.Location = new System.Drawing.Point(71, 38);
            this.progressBar1.Name = "progressBar1";
            this.progressBar1.Size = new System.Drawing.Size(171, 17);
            this.progressBar1.TabIndex = 6;
            this.progressBar1.Visible = false;
            // 
            // updcheckbutton
            // 
            this.updcheckbutton.Location = new System.Drawing.Point(353, 67);
            this.updcheckbutton.Name = "updcheckbutton";
            this.updcheckbutton.Size = new System.Drawing.Size(124, 23);
            this.updcheckbutton.TabIndex = 5;
            this.updcheckbutton.Text = "Check for updates";
            this.updcheckbutton.UseVisualStyleBackColor = true;
            this.updcheckbutton.Click += new System.EventHandler(this.updcheckbutton_Click);
            // 
            // shieldImage
            // 
            this.shieldImage.BackColor = System.Drawing.Color.Transparent;
            this.shieldImage.BackgroundImage = global::ClassicUpdater.Properties.Resources.crossShield;
            this.shieldImage.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.shieldImage.Location = new System.Drawing.Point(24, 8);
            this.shieldImage.Name = "shieldImage";
            this.shieldImage.Size = new System.Drawing.Size(55, 55);
            this.shieldImage.TabIndex = 4;
            this.shieldImage.TabStop = false;
            // 
            // mostrecheader
            // 
            this.mostrecheader.AutoSize = true;
            this.mostrecheader.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.mostrecheader.Location = new System.Drawing.Point(53, 194);
            this.mostrecheader.Name = "mostrecheader";
            this.mostrecheader.Size = new System.Drawing.Size(170, 15);
            this.mostrecheader.TabIndex = 6;
            this.mostrecheader.Text = "Most recent check for updates:";
            // 
            // updinstalledheader
            // 
            this.updinstalledheader.AutoSize = true;
            this.updinstalledheader.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.updinstalledheader.Location = new System.Drawing.Point(52, 213);
            this.updinstalledheader.Name = "updinstalledheader";
            this.updinstalledheader.Size = new System.Drawing.Size(128, 15);
            this.updinstalledheader.TabIndex = 7;
            this.updinstalledheader.Text = "Updates were installed:";
            // 
            // yourecupdheader
            // 
            this.yourecupdheader.AutoSize = true;
            this.yourecupdheader.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.yourecupdheader.Location = new System.Drawing.Point(53, 232);
            this.yourecupdheader.Name = "yourecupdheader";
            this.yourecupdheader.Size = new System.Drawing.Size(115, 15);
            this.yourecupdheader.TabIndex = 8;
            this.yourecupdheader.Text = "You recieve updates:";
            // 
            // dateCheckUpd
            // 
            this.dateCheckUpd.AutoSize = true;
            this.dateCheckUpd.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dateCheckUpd.Location = new System.Drawing.Point(234, 194);
            this.dateCheckUpd.Name = "dateCheckUpd";
            this.dateCheckUpd.Size = new System.Drawing.Size(38, 15);
            this.dateCheckUpd.TabIndex = 9;
            this.dateCheckUpd.Text = "Never";
            // 
            // dateInstalledUpd
            // 
            this.dateInstalledUpd.AutoSize = true;
            this.dateInstalledUpd.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dateInstalledUpd.Location = new System.Drawing.Point(234, 213);
            this.dateInstalledUpd.Name = "dateInstalledUpd";
            this.dateInstalledUpd.Size = new System.Drawing.Size(38, 15);
            this.dateInstalledUpd.TabIndex = 10;
            this.dateInstalledUpd.Text = "Never";
            // 
            // recieveUpdateLabel
            // 
            this.recieveUpdateLabel.AutoSize = true;
            this.recieveUpdateLabel.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.recieveUpdateLabel.Location = new System.Drawing.Point(234, 232);
            this.recieveUpdateLabel.Name = "recieveUpdateLabel";
            this.recieveUpdateLabel.Size = new System.Drawing.Size(101, 15);
            this.recieveUpdateLabel.TabIndex = 11;
            this.recieveUpdateLabel.Text = "For Classic 7 only.";
            // 
            // viewupdhistorylink
            // 
            this.viewupdhistorylink.AutoSize = true;
            this.viewupdhistorylink.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.viewupdhistorylink.LinkBehavior = System.Windows.Forms.LinkBehavior.NeverUnderline;
            this.viewupdhistorylink.LinkColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(102)))), ((int)(((byte)(204)))));
            this.viewupdhistorylink.Location = new System.Drawing.Point(335, 213);
            this.viewupdhistorylink.Name = "viewupdhistorylink";
            this.viewupdhistorylink.Size = new System.Drawing.Size(111, 15);
            this.viewupdhistorylink.TabIndex = 12;
            this.viewupdhistorylink.TabStop = true;
            this.viewupdhistorylink.Text = "View update history";
            this.viewupdhistorylink.Visible = false;
            // 
            // getupdPanel
            // 
            this.getupdPanel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.getupdPanel.Controls.Add(this.getupdfindoutlink);
            this.getupdPanel.Controls.Add(this.getupdheader);
            this.getupdPanel.Location = new System.Drawing.Point(56, 267);
            this.getupdPanel.Name = "getupdPanel";
            this.getupdPanel.Size = new System.Drawing.Size(487, 45);
            this.getupdPanel.TabIndex = 13;
            // 
            // getupdfindoutlink
            // 
            this.getupdfindoutlink.AutoSize = true;
            this.getupdfindoutlink.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.getupdfindoutlink.LinkBehavior = System.Windows.Forms.LinkBehavior.NeverUnderline;
            this.getupdfindoutlink.LinkColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(102)))), ((int)(((byte)(204)))));
            this.getupdfindoutlink.Location = new System.Drawing.Point(239, 14);
            this.getupdfindoutlink.Name = "getupdfindoutlink";
            this.getupdfindoutlink.Size = new System.Drawing.Size(82, 15);
            this.getupdfindoutlink.TabIndex = 1;
            this.getupdfindoutlink.TabStop = true;
            this.getupdfindoutlink.Text = "Find out more";
            // 
            // getupdheader
            // 
            this.getupdheader.AutoSize = true;
            this.getupdheader.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.getupdheader.Location = new System.Drawing.Point(13, 14);
            this.getupdheader.Name = "getupdheader";
            this.getupdheader.Size = new System.Drawing.Size(230, 15);
            this.getupdheader.TabIndex = 0;
            this.getupdheader.Text = "Get updates for other Starix Team projects.";
            // 
            // versioncurrentinstallinglabel
            // 
            this.versioncurrentinstallinglabel.AutoSize = true;
            this.versioncurrentinstallinglabel.Font = new System.Drawing.Font("Segoe UI Semibold", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.versioncurrentinstallinglabel.Location = new System.Drawing.Point(68, 60);
            this.versioncurrentinstallinglabel.Name = "versioncurrentinstallinglabel";
            this.versioncurrentinstallinglabel.Size = new System.Drawing.Size(109, 15);
            this.versioncurrentinstallinglabel.TabIndex = 14;
            this.versioncurrentinstallinglabel.Text = "Currently installing:";
            this.versioncurrentinstallinglabel.Visible = false;
            // 
            // curverlabel
            // 
            this.curverlabel.AutoSize = true;
            this.curverlabel.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.curverlabel.Location = new System.Drawing.Point(83, 38);
            this.curverlabel.Name = "curverlabel";
            this.curverlabel.Size = new System.Drawing.Size(91, 15);
            this.curverlabel.TabIndex = 15;
            this.curverlabel.Text = "Current version:";
            this.curverlabel.Visible = false;
            // 
            // newverlabel
            // 
            this.newverlabel.AutoSize = true;
            this.newverlabel.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.newverlabel.Location = new System.Drawing.Point(83, 57);
            this.newverlabel.Name = "newverlabel";
            this.newverlabel.Size = new System.Drawing.Size(75, 15);
            this.newverlabel.TabIndex = 16;
            this.newverlabel.Text = "New version:";
            this.newverlabel.Visible = false;
            // 
            // updatesizelabel
            // 
            this.updatesizelabel.AutoSize = true;
            this.updatesizelabel.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.updatesizelabel.Location = new System.Drawing.Point(231, 38);
            this.updatesizelabel.Name = "updatesizelabel";
            this.updatesizelabel.Size = new System.Drawing.Size(124, 15);
            this.updatesizelabel.TabIndex = 17;
            this.updatesizelabel.Text = "Update size: 0.01 MB";
            this.updatesizelabel.Visible = false;
            // 
            // UpdateClient
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(749, 403);
            this.Controls.Add(this.getupdPanel);
            this.Controls.Add(this.viewupdhistorylink);
            this.Controls.Add(this.recieveUpdateLabel);
            this.Controls.Add(this.dateInstalledUpd);
            this.Controls.Add(this.dateCheckUpd);
            this.Controls.Add(this.yourecupdheader);
            this.Controls.Add(this.updinstalledheader);
            this.Controls.Add(this.mostrecheader);
            this.Controls.Add(this.infoPanel);
            this.Controls.Add(this.headerLabel);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "UpdateClient";
            this.Text = "Classic Updater";
            this.infoPanel.ResumeLayout(false);
            this.infoPanel.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.shieldImage)).EndInit();
            this.getupdPanel.ResumeLayout(false);
            this.getupdPanel.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label headerLabel;
        private System.Windows.Forms.Panel updatePanel;
        private System.Windows.Forms.Label updateText;
        private System.Windows.Forms.Label updateTextBelow;
        private System.Windows.Forms.PictureBox shieldImage;
        private System.Windows.Forms.Panel infoPanel;
        private System.Windows.Forms.Label mostrecheader;
        private System.Windows.Forms.Label updinstalledheader;
        private System.Windows.Forms.Label yourecupdheader;
        private System.Windows.Forms.Label dateCheckUpd;
        private System.Windows.Forms.Label dateInstalledUpd;
        private System.Windows.Forms.Label recieveUpdateLabel;
        private System.Windows.Forms.LinkLabel viewupdhistorylink;
        private System.Windows.Forms.Panel getupdPanel;
        private System.Windows.Forms.LinkLabel getupdfindoutlink;
        private System.Windows.Forms.Label getupdheader;
        private System.Windows.Forms.Button updcheckbutton;
        private System.Windows.Forms.ProgressBar progressBar1;
        private System.Windows.Forms.Label versioncurrentinstallinglabel;
        private System.Windows.Forms.Label curverlabel;
        private System.Windows.Forms.Label newverlabel;
        private System.Windows.Forms.Label updatesizelabel;
    }
}

