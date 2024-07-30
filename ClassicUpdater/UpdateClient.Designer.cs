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
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.themeLabel1 = new WindowsFormsAero.ThemeLabel();
            this.themeLabel2 = new WindowsFormsAero.ThemeLabel();
            this.checkUpdates = new WindowsFormsAero.Button();
            this.changelogsBox = new WindowsFormsAero.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.Color.Black;
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(183, 12);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(150, 150);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // themeLabel1
            // 
            this.themeLabel1.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.themeLabel1.Location = new System.Drawing.Point(190, 168);
            this.themeLabel1.Name = "themeLabel1";
            this.themeLabel1.Size = new System.Drawing.Size(145, 27);
            this.themeLabel1.TabIndex = 1;
            this.themeLabel1.Text = "Classic Updater";
            // 
            // themeLabel2
            // 
            this.themeLabel2.Location = new System.Drawing.Point(103, 201);
            this.themeLabel2.Name = "themeLabel2";
            this.themeLabel2.Size = new System.Drawing.Size(331, 20);
            this.themeLabel2.TabIndex = 2;
            this.themeLabel2.Text = "Welcome to Classic Updater. You can update Classic 7 here.";
            // 
            // checkUpdates
            // 
            this.checkUpdates.Location = new System.Drawing.Point(206, 467);
            this.checkUpdates.Name = "checkUpdates";
            this.checkUpdates.Size = new System.Drawing.Size(125, 34);
            this.checkUpdates.TabIndex = 3;
            this.checkUpdates.Text = "Check for Updates";
            this.checkUpdates.UseVisualStyleBackColor = true;
            this.checkUpdates.Click += new System.EventHandler(this.checkUpdates_Click);
            // 
            // changelogsBox
            // 
            this.changelogsBox.Location = new System.Drawing.Point(62, 246);
            this.changelogsBox.Multiline = true;
            this.changelogsBox.Name = "changelogsBox";
            this.changelogsBox.ReadOnly = true;
            this.changelogsBox.Size = new System.Drawing.Size(414, 197);
            this.changelogsBox.TabIndex = 4;
            // 
            // UpdateClient
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(544, 513);
            this.Controls.Add(this.changelogsBox);
            this.Controls.Add(this.checkUpdates);
            this.Controls.Add(this.themeLabel2);
            this.Controls.Add(this.themeLabel1);
            this.Controls.Add(this.pictureBox1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.Name = "UpdateClient";
            this.Text = "Classic Updater";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBox1;
        private WindowsFormsAero.ThemeLabel themeLabel1;
        private WindowsFormsAero.ThemeLabel themeLabel2;
        private WindowsFormsAero.Button checkUpdates;
        private WindowsFormsAero.TextBox changelogsBox;
    }
}

