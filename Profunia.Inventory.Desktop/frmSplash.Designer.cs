using System.ComponentModel;
using System.Drawing;
using System.Windows.Forms;

namespace Profunia.Inventory.Desktop
{
    partial class frmSplash
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
            components = new Container();
           // ComponentResourceManager resources = new ComponentResourceManager(typeof(frmSplash));
            ntfyVersionUpdate = new NotifyIcon(components);
            timer1 = new Timer(components);
            lblVersion = new Label();
            base.SuspendLayout();
            ntfyVersionUpdate.Text = "notifyIcon1";
            ntfyVersionUpdate.Click += ntfyVersionUpdate_Click;
            timer1.Tick += timer1_Tick;
            lblVersion.AutoSize = true;
            lblVersion.BackColor = Color.Transparent;
            lblVersion.Font = new Font("Arial", 9f, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblVersion.ForeColor = Color.White;
            lblVersion.Location = new Point(257, 76);
            lblVersion.Name = "lblVersion";
            lblVersion.Size = new Size(34, 15);
            lblVersion.TabIndex = 1;
            lblVersion.Text = "1.0.0";
            base.AutoScaleDimensions = new SizeF(6f, 13f);
            base.AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.Black;
           // BackgroundImage = Resources._2;
            base.ClientSize = new Size(497, 242);
            base.Controls.Add(lblVersion);
            ForeColor = Color.Black;
            base.FormBorderStyle = FormBorderStyle.None;
           // base.Icon = (Icon)resources.GetObject("$this.Icon");
            base.Name = "frmSplash";
            base.ShowInTaskbar = false;
            base.StartPosition = FormStartPosition.CenterScreen;
            Text = "frmSplash";
            base.TransparencyKey = Color.Black;
            base.Load += frmSplash_Load;
            base.ResumeLayout(false);
            base.PerformLayout();
        }

        #endregion

        private System.Windows.Forms.Label lblVersion;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.NotifyIcon ntfyVersionUpdate;
    }
}