namespace ClassicUpdater
{
    partial class Form1
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.themeLabel1 = new WindowsFormsAero.ThemeLabel();
            this.themeLabel2 = new WindowsFormsAero.ThemeLabel();
            this.button1 = new WindowsFormsAero.Button();
            this.textBox1 = new WindowsFormsAero.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.Color.Black;
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(256, 74);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(150, 150);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // themeLabel1
            // 
            this.themeLabel1.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.themeLabel1.Location = new System.Drawing.Point(261, 238);
            this.themeLabel1.Name = "themeLabel1";
            this.themeLabel1.Size = new System.Drawing.Size(145, 27);
            this.themeLabel1.TabIndex = 1;
            this.themeLabel1.Text = "Classic Updater";
            // 
            // themeLabel2
            // 
            this.themeLabel2.Location = new System.Drawing.Point(172, 271);
            this.themeLabel2.Name = "themeLabel2";
            this.themeLabel2.Size = new System.Drawing.Size(331, 20);
            this.themeLabel2.TabIndex = 2;
            this.themeLabel2.Text = "Welcome to Classic Updater. You can update Classic 7 here.";
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(270, 525);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(125, 34);
            this.button1.TabIndex = 3;
            this.button1.Text = "Check for Updates";
            this.button1.UseVisualStyleBackColor = true;
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(222, 313);
            this.textBox1.Multiline = true;
            this.textBox1.Name = "textBox1";
            this.textBox1.ReadOnly = true;
            this.textBox1.Size = new System.Drawing.Size(221, 197);
            this.textBox1.TabIndex = 4;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(681, 647);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.themeLabel2);
            this.Controls.Add(this.themeLabel1);
            this.Controls.Add(this.pictureBox1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.Name = "Form1";
            this.Text = "Classic Updater";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBox1;
        private WindowsFormsAero.ThemeLabel themeLabel1;
        private WindowsFormsAero.ThemeLabel themeLabel2;
        private WindowsFormsAero.Button button1;
        private WindowsFormsAero.TextBox textBox1;
    }
}

