using System.Drawing;
using System.Windows.Forms;

namespace Profunia.Inventory.Desktop
{
    partial class SQLErrorLog
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
            this.SuspendLayout();
            // 
            // SQLErrorLog
            // 
           // ComponentResourceManager resources = new ComponentResourceManager(typeof(SQLErrorLog));
            base.SuspendLayout();
            base.AutoScaleDimensions = new SizeF(6f, 13f);
            base.AutoScaleMode = AutoScaleMode.Font;
            base.ClientSize = new Size(854, 448);
            //base.Icon = (Icon)resources.GetObject("$this.Icon");
            base.Name = "SQLErrorLog";
            base.StartPosition = FormStartPosition.CenterScreen;
            Text = "Openmiracle SQL Configuration ErrorLog";
            base.TopMost = true;
            base.Load += SQLErrorLog_Load;
            base.ResumeLayout(false);

        }

        #endregion
    }
}