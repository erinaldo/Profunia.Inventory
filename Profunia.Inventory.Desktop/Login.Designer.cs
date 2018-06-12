using System.Drawing;
using System.Windows.Forms;

namespace Profunia.Inventory.Desktop
{
    partial class Login
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
           // ComponentResourceManager resources = new ComponentResourceManager(typeof(Login));
            textBox1 = new TextBox();
            textBox2 = new TextBox();
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            label4 = new Label();
            button1 = new Button();
            button2 = new Button();
            label5 = new Label();
            base.SuspendLayout();
            textBox1.Location = new Point(92, 77);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(195, 20);
            textBox1.TabIndex = 0;
            textBox2.Location = new Point(92, 107);
            textBox2.Name = "textBox2";
            textBox2.PasswordChar = '*';
            textBox2.Size = new Size(195, 20);
            textBox2.TabIndex = 1;
            label1.AutoSize = true;
            label1.Location = new Point(25, 80);
            label1.Name = "label1";
            label1.Size = new Size(66, 13);
            label1.TabIndex = 2;
            label1.Text = "User Name :";
            label2.AutoSize = true;
            label2.Location = new Point(25, 110);
            label2.Name = "label2";
            label2.Size = new Size(59, 13);
            label2.TabIndex = 3;
            label2.Text = "Password :";
            label3.AutoSize = true;
            label3.Location = new Point(31, 13);
            label3.Name = "label3";
            label3.Size = new Size(259, 13);
            label3.TabIndex = 4;
            label3.Text = "Spring Security Login Form, Database Authentication.";
            label4.AutoSize = true;
            label4.ForeColor = Color.Maroon;
            label4.Location = new Point(154, 31);
            label4.Name = "label4";
            label4.Size = new Size(135, 13);
            label4.TabIndex = 5;
            label4.Text = "This page is for admin only.";
            button1.Location = new Point(213, 132);
            button1.Name = "button1";
            button1.Size = new Size(75, 23);
            button1.TabIndex = 6;
            button1.Text = "Ok";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            button2.Location = new Point(132, 132);
            button2.Name = "button2";
            button2.Size = new Size(75, 23);
            button2.TabIndex = 7;
            button2.Text = "Cancel";
            button2.UseVisualStyleBackColor = true;
            button2.Click += button2_Click;
            label5.AutoSize = true;
            label5.ForeColor = Color.DarkSlateBlue;
            label5.Location = new Point(26, 52);
            label5.Name = "label5";
            label5.Size = new Size(192, 13);
            label5.TabIndex = 8;
            label5.Text = "Please provide SQL Server credentials.";
            base.AutoScaleDimensions = new SizeF(6f, 13f);
            base.AutoScaleMode = AutoScaleMode.Font;
            base.ClientSize = new Size(312, 163);
            base.Controls.Add(label5);
            base.Controls.Add(button2);
            base.Controls.Add(button1);
            base.Controls.Add(label4);
            base.Controls.Add(label3);
            base.Controls.Add(label2);
            base.Controls.Add(label1);
            base.Controls.Add(textBox2);
            base.Controls.Add(textBox1);
            base.FormBorderStyle = FormBorderStyle.FixedSingle;
            //base.Icon = (Icon)resources.GetObject("$this.Icon");
            base.MaximizeBox = false;
            base.MinimizeBox = false;
            base.Name = "Login";
            base.StartPosition = FormStartPosition.CenterScreen;
            Text = "Login";
            base.ResumeLayout(false);
            base.PerformLayout();
        }

        #endregion

        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.TextBox textBox1;
    }
}