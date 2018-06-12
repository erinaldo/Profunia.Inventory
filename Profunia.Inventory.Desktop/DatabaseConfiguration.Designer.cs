using System.ComponentModel;
using System.Drawing;
using System.Windows.Forms;

namespace Profunia.Inventory.Desktop
{
    partial class DatabaseConfiguration
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
        /// 	
        private void InitializeComponent()
		{
		//	ComponentResourceManager resources = new ComponentResourceManager(typeof(frmMsSqlInstallerforOpenmiracle));
        label1 = new Label();
        panel1 = new Panel();
        lblMessage = new TextBox();
        rbtnMultyUser = new RadioButton();
        rbtnSingleUser = new RadioButton();
        btnBack = new Button();
        btnInstall = new Button();
        gbFeature = new GroupBox();
        pnlCredencial = new Panel();
        label5 = new Label();
        label4 = new Label();
        label3 = new Label();
        txtconfpassword = new TextBox();
        txtPassword = new TextBox();
        cbxSap = new CheckBox();
        cbxMssqlServer = new CheckBox();
        pbxProcess = new ProgressBar();
        lblEvent = new Label();
        pbxEvent = new ProgressBar();
        lblProcess = new Label();
        panel2 = new Panel();
        groupBox1 = new GroupBox();
        radioButton3 = new RadioButton();
        radioButton4 = new RadioButton();
        textBox1 = new TextBox();
        label10 = new Label();
        label11 = new Label();
        textBox2 = new TextBox();
        rbtnNetworkServers = new RadioButton();
        rbtnLocalServer = new RadioButton();
        button2 = new Button();
        cmbPath = new ComboBox();
        linkLabel4 = new LinkLabel();
        label13 = new Label();
        cmbServers1 = new ComboBox();
        label9 = new Label();
        cmbInstance1 = new ComboBox();
        button1 = new Button();
        btnOkServer = new Button();
        label12 = new Label();
        label2 = new Label();
        panel3 = new Panel();
        pictureBox5 = new PictureBox();
        pictureBox4 = new PictureBox();
        panel5 = new Panel();
        pictureBox3 = new PictureBox();
        pictureBox2 = new PictureBox();
        label7 = new Label();
        linkLabel2 = new LinkLabel();
        label6 = new Label();
        linkLabel1 = new LinkLabel();
        folderBrowserDialog1 = new FolderBrowserDialog();
        progressBar1 = new ProgressBar();
        panel1.SuspendLayout();
			gbFeature.SuspendLayout();
			pnlCredencial.SuspendLayout();
			panel2.SuspendLayout();
			groupBox1.SuspendLayout();
			panel3.SuspendLayout();
			((ISupportInitialize) pictureBox5).BeginInit();
        ((ISupportInitialize) pictureBox4).BeginInit();
        ((ISupportInitialize) pictureBox3).BeginInit();
        ((ISupportInitialize) pictureBox2).BeginInit();
			base.SuspendLayout();
        label1.AutoSize = true;
			label1.Font = new Font("Consolas", 14.25f, FontStyle.Bold, GraphicsUnit.Point, 0);
        label1.Location = new Point(6, 14);
        label1.Name = "label1";
			label1.Size = new Size(360, 22);
        label1.TabIndex = 4;
			label1.Text = "Openmiracle Database Configuration.";
			panel1.Controls.Add(lblMessage);
			panel1.Controls.Add(rbtnMultyUser);
			panel1.Controls.Add(rbtnSingleUser);
			panel1.Controls.Add(btnBack);
			panel1.Controls.Add(btnInstall);
			panel1.Controls.Add(gbFeature);
			panel1.Controls.Add(pbxProcess);
			panel1.Controls.Add(lblEvent);
			panel1.Controls.Add(pbxEvent);
			panel1.Controls.Add(lblProcess);
			panel1.Location = new Point(3, 41);
        panel1.Name = "panel1";
			panel1.Size = new Size(363, 441);
        panel1.TabIndex = 6;
			panel1.Visible = false;
			lblMessage.BackColor = Color.FromArgb(224, 224, 224);
			lblMessage.BorderStyle = BorderStyle.None;
			lblMessage.Font = new Font("Microsoft Sans Serif", 9f, FontStyle.Bold, GraphicsUnit.Point, 0);
        lblMessage.ForeColor = Color.FromArgb(192, 0, 0);
			lblMessage.Location = new Point(17, 363);
        lblMessage.Multiline = true;
			lblMessage.Name = "lblMessage";
			lblMessage.ReadOnly = true;
			lblMessage.Size = new Size(330, 27);
        lblMessage.TabIndex = 14;
			lblMessage.TextAlign = HorizontalAlignment.Center;
			rbtnMultyUser.AutoSize = true;
			rbtnMultyUser.Location = new Point(277, 13);
        rbtnMultyUser.Name = "rbtnMultyUser";
			rbtnMultyUser.Size = new Size(72, 17);
        rbtnMultyUser.TabIndex = 13;
			rbtnMultyUser.Text = "Multi User";
			rbtnMultyUser.UseVisualStyleBackColor = true;
			rbtnSingleUser.AutoSize = true;
			rbtnSingleUser.Checked = true;
			rbtnSingleUser.Location = new Point(195, 13);
        rbtnSingleUser.Name = "rbtnSingleUser";
			rbtnSingleUser.Size = new Size(79, 17);
        rbtnSingleUser.TabIndex = 12;
			rbtnSingleUser.TabStop = true;
			rbtnSingleUser.Text = "Single User";
			rbtnSingleUser.UseVisualStyleBackColor = true;
			btnBack.Location = new Point(170, 400);
        btnBack.Name = "btnBack";
			btnBack.Size = new Size(85, 30);
        btnBack.TabIndex = 10;
			btnBack.Text = "Back";
			btnBack.UseVisualStyleBackColor = true;
			btnBack.Click += btnBack_Click;
			btnInstall.Location = new Point(262, 399);
        btnInstall.Name = "btnInstall";
			btnInstall.Size = new Size(85, 30);
        btnInstall.TabIndex = 9;
			btnInstall.Text = "Install";
			btnInstall.UseVisualStyleBackColor = true;
			btnInstall.Click += btnInstall_Click;
			gbFeature.BackColor = Color.Transparent;
			gbFeature.Controls.Add(pnlCredencial);
			gbFeature.Controls.Add(cbxSap);
			gbFeature.Controls.Add(cbxMssqlServer);
			gbFeature.Font = new Font("Maiandra GD", 9.75f, FontStyle.Bold, GraphicsUnit.Point, 0);
        gbFeature.ForeColor = Color.Crimson;
			gbFeature.Location = new Point(9, 12);
        gbFeature.Name = "gbFeature";
			gbFeature.Size = new Size(345, 258);
        gbFeature.TabIndex = 8;
			gbFeature.TabStop = false;
			gbFeature.Text = "Select features to install.";
			pnlCredencial.Controls.Add(label5);
			pnlCredencial.Controls.Add(label4);
			pnlCredencial.Controls.Add(label3);
			pnlCredencial.Controls.Add(txtconfpassword);
			pnlCredencial.Controls.Add(txtPassword);
			pnlCredencial.Location = new Point(-6, 96);
        pnlCredencial.Name = "pnlCredencial";
			pnlCredencial.Size = new Size(357, 153);
        pnlCredencial.TabIndex = 4;
			label5.AutoSize = true;
			label5.Font = new Font("Microsoft Sans Serif", 9f, FontStyle.Regular, GraphicsUnit.Point, 0);
        label5.ForeColor = Color.Black;
			label5.Location = new Point(28, 49);
        label5.Name = "label5";
			label5.Size = new Size(99, 15);
        label5.TabIndex = 13;
			label5.Text = "Enter Password :";
			label4.AutoSize = true;
			label4.Font = new Font("Microsoft Sans Serif", 9f, FontStyle.Regular, GraphicsUnit.Point, 0);
        label4.ForeColor = Color.Black;
			label4.Location = new Point(28, 93);
        label4.Name = "label4";
			label4.Size = new Size(113, 15);
        label4.TabIndex = 12;
			label4.Text = "Confirm Password :";
			label3.AutoSize = true;
			label3.Font = new Font("Maiandra GD", 9.75f, FontStyle.Bold, GraphicsUnit.Point, 0);
        label3.ForeColor = Color.DimGray;
			label3.Location = new Point(16, 15);
        label3.Name = "label3";
			label3.Size = new Size(327, 16);
        label3.TabIndex = 11;
			label3.Text = "Built-in SQL Server system administrator account";
			txtconfpassword.Location = new Point(28, 111);
        txtconfpassword.Name = "txtconfpassword";
			txtconfpassword.PasswordChar = '*';
			txtconfpassword.Size = new Size(301, 23);
        txtconfpassword.TabIndex = 10;
			txtPassword.Location = new Point(28, 68);
        txtPassword.Name = "txtPassword";
			txtPassword.PasswordChar = '*';
			txtPassword.Size = new Size(301, 23);
        txtPassword.TabIndex = 9;
			cbxSap.AutoSize = true;
			cbxSap.Checked = true;
			cbxSap.CheckState = CheckState.Checked;
			cbxSap.Font = new Font("Microsoft Sans Serif", 8.25f, FontStyle.Regular, GraphicsUnit.Point, 0);
        cbxSap.ForeColor = Color.Black;
			cbxSap.Location = new Point(188, 48);
        cbxSap.Name = "cbxSap";
			cbxSap.Size = new Size(116, 17);
        cbxSap.TabIndex = 3;
			cbxSap.Text = "SAP Cristal Report.";
			cbxSap.UseVisualStyleBackColor = true;
			cbxMssqlServer.AutoSize = true;
			cbxMssqlServer.Checked = true;
			cbxMssqlServer.CheckState = CheckState.Checked;
			cbxMssqlServer.Font = new Font("Microsoft Sans Serif", 8.25f, FontStyle.Regular, GraphicsUnit.Point, 0);
        cbxMssqlServer.ForeColor = Color.Black;
			cbxMssqlServer.Location = new Point(36, 48);
        cbxMssqlServer.Name = "cbxMssqlServer";
			cbxMssqlServer.Size = new Size(122, 17);
        cbxMssqlServer.TabIndex = 0;
			cbxMssqlServer.Text = "MsSQL Server 2008";
			cbxMssqlServer.UseVisualStyleBackColor = true;
			cbxMssqlServer.CheckedChanged += cbxMssqlServer_CheckedChanged;
			pbxProcess.Location = new Point(16, 337);
        pbxProcess.MarqueeAnimationSpeed = 60;
			pbxProcess.Name = "pbxProcess";
			pbxProcess.Size = new Size(332, 10);
        pbxProcess.TabIndex = 7;
			lblEvent.AutoSize = true;
			lblEvent.Location = new Point(14, 276);
        lblEvent.Name = "lblEvent";
			lblEvent.Size = new Size(46, 13);
        lblEvent.TabIndex = 6;
			lblEvent.Text = "Program";
			pbxEvent.Location = new Point(16, 293);
        pbxEvent.Name = "pbxEvent";
			pbxEvent.Size = new Size(331, 10);
        pbxEvent.TabIndex = 5;
			lblProcess.AutoSize = true;
			lblProcess.Location = new Point(14, 322);
        lblProcess.Name = "lblProcess";
			lblProcess.Size = new Size(45, 13);
        lblProcess.TabIndex = 4;
			lblProcess.Text = "Process";
			panel2.BackColor = Color.Gainsboro;
			panel2.Controls.Add(groupBox1);
			panel2.Controls.Add(rbtnNetworkServers);
			panel2.Controls.Add(rbtnLocalServer);
			panel2.Controls.Add(button2);
			panel2.Controls.Add(cmbPath);
			panel2.Controls.Add(linkLabel4);
			panel2.Controls.Add(label13);
			panel2.Controls.Add(cmbServers1);
			panel2.Controls.Add(label9);
			panel2.Controls.Add(cmbInstance1);
			panel2.Controls.Add(button1);
			panel2.Controls.Add(btnOkServer);
			panel2.Controls.Add(label12);
			panel2.Controls.Add(label2);
			panel2.Location = new Point(3, 40);
        panel2.Name = "panel2";
			panel2.Size = new Size(363, 442);
        panel2.TabIndex = 7;
			panel2.Visible = false;
			groupBox1.BackColor = Color.Transparent;
			groupBox1.Controls.Add(radioButton3);
			groupBox1.Controls.Add(radioButton4);
			groupBox1.Controls.Add(textBox1);
			groupBox1.Controls.Add(label10);
			groupBox1.Controls.Add(label11);
			groupBox1.Controls.Add(textBox2);
			groupBox1.Location = new Point(9, 156);
        groupBox1.Name = "groupBox1";
			groupBox1.Size = new Size(345, 162);
        groupBox1.TabIndex = 0;
			groupBox1.TabStop = false;
			radioButton3.AutoSize = true;
			radioButton3.Font = new Font("Arial", 9f, FontStyle.Regular, GraphicsUnit.Point, 0);
        radioButton3.Location = new Point(21, 37);
        radioButton3.Name = "radioButton3";
			radioButton3.Size = new Size(195, 19);
        radioButton3.TabIndex = 56;
			radioButton3.Text = "Use SQL Server Authentication.";
			radioButton3.UseVisualStyleBackColor = true;
			radioButton3.CheckedChanged += radioButton3_CheckedChanged;
			radioButton4.AutoSize = true;
			radioButton4.Checked = true;
			radioButton4.Font = new Font("Arial", 9f, FontStyle.Regular, GraphicsUnit.Point, 0);
        radioButton4.Location = new Point(21, 16);
        radioButton4.Name = "radioButton4";
			radioButton4.Size = new Size(184, 19);
        radioButton4.TabIndex = 55;
			radioButton4.TabStop = true;
			radioButton4.Text = "Use Windows Authentication.";
			radioButton4.UseVisualStyleBackColor = true;
			textBox1.Enabled = false;
			textBox1.Font = new Font("Microsoft Sans Serif", 9f, FontStyle.Regular, GraphicsUnit.Point, 0);
        textBox1.Location = new Point(19, 78);
        textBox1.Name = "textBox1";
			textBox1.Size = new Size(307, 21);
        textBox1.TabIndex = 53;
			label10.AutoSize = true;
			label10.Enabled = false;
			label10.Font = new Font("Arial", 9f, FontStyle.Regular, GraphicsUnit.Point, 0);
        label10.Location = new Point(18, 63);
        label10.Name = "label10";
			label10.Size = new Size(53, 15);
        label10.TabIndex = 51;
			label10.Text = "User Id :";
			label11.AutoSize = true;
			label11.Enabled = false;
			label11.Font = new Font("Arial", 9f, FontStyle.Regular, GraphicsUnit.Point, 0);
        label11.Location = new Point(17, 106);
        label11.Name = "label11";
			label11.Size = new Size(69, 15);
        label11.TabIndex = 52;
			label11.Text = "Password :";
			textBox2.Enabled = false;
			textBox2.Font = new Font("Microsoft Sans Serif", 9f, FontStyle.Regular, GraphicsUnit.Point, 0);
        textBox2.Location = new Point(19, 121);
        textBox2.Name = "textBox2";
			textBox2.PasswordChar = '*';
			textBox2.Size = new Size(308, 21);
        textBox2.TabIndex = 54;
			rbtnNetworkServers.AutoSize = true;
			rbtnNetworkServers.Location = new Point(238, 39);
        rbtnNetworkServers.Name = "rbtnNetworkServers";
			rbtnNetworkServers.Size = new Size(104, 17);
        rbtnNetworkServers.TabIndex = 65;
			rbtnNetworkServers.Text = "Network Servers";
			rbtnNetworkServers.UseVisualStyleBackColor = true;
			rbtnLocalServer.AutoSize = true;
			rbtnLocalServer.Checked = true;
			rbtnLocalServer.Location = new Point(146, 39);
        rbtnLocalServer.Name = "rbtnLocalServer";
			rbtnLocalServer.Size = new Size(90, 17);
        rbtnLocalServer.TabIndex = 64;
			rbtnLocalServer.TabStop = true;
			rbtnLocalServer.Text = "Local Servers";
			rbtnLocalServer.UseVisualStyleBackColor = true;
			rbtnLocalServer.CheckedChanged += rbtnLocalServer_CheckedChanged;
			button2.Font = new Font("Microsoft Sans Serif", 8.25f, FontStyle.Regular, GraphicsUnit.Point, 0);
        button2.Location = new Point(268, 392);
        button2.Name = "button2";
			button2.Size = new Size(68, 30);
        button2.TabIndex = 63;
			button2.Text = "Ok";
			button2.UseVisualStyleBackColor = true;
			button2.Click += button2_Click;
			cmbPath.Font = new Font("Microsoft Sans Serif", 9f, FontStyle.Regular, GraphicsUnit.Point, 0);
        cmbPath.FormattingEnabled = true;
			cmbPath.Location = new Point(28, 358);
        cmbPath.Name = "cmbPath";
			cmbPath.Size = new Size(308, 23);
        cmbPath.TabIndex = 62;
			linkLabel4.AutoSize = true;
			linkLabel4.LinkColor = Color.Maroon;
			linkLabel4.Location = new Point(294, 64);
        linkLabel4.Name = "linkLabel4";
			linkLabel4.Size = new Size(44, 13);
        linkLabel4.TabIndex = 60;
			linkLabel4.TabStop = true;
			linkLabel4.Text = "Refresh";
			linkLabel4.LinkClicked += linkLabel4_LinkClicked;
			label13.AutoSize = true;
			label13.Font = new Font("Arial", 9f, FontStyle.Regular, GraphicsUnit.Point, 0);
        label13.Location = new Point(27, 339);
        label13.Name = "label13";
			label13.Size = new Size(112, 15);
        label13.TabIndex = 56;
			label13.Text = "Openmiracle Path :";
			cmbServers1.Font = new Font("Microsoft Sans Serif", 9f, FontStyle.Regular, GraphicsUnit.Point, 0);
        cmbServers1.FormattingEnabled = true;
			cmbServers1.Location = new Point(28, 84);
        cmbServers1.Name = "cmbServers1";
			cmbServers1.Size = new Size(308, 23);
        cmbServers1.TabIndex = 53;
			cmbServers1.SelectedValueChanged += cmbServers1_SelectedValueChanged;
			cmbServers1.BindingContextChanged += cmbServers1_BindingContextChanged;
			label9.AutoSize = true;
			label9.Font = new Font("Arial", 9f, FontStyle.Regular, GraphicsUnit.Point, 0);
        label9.Location = new Point(27, 64);
        label9.Name = "label9";
			label9.Size = new Size(85, 15);
        label9.TabIndex = 52;
			label9.Text = "System Name";
			cmbInstance1.Font = new Font("Microsoft Sans Serif", 9f, FontStyle.Regular, GraphicsUnit.Point, 0);
        cmbInstance1.FormattingEnabled = true;
			cmbInstance1.Location = new Point(28, 127);
        cmbInstance1.Name = "cmbInstance1";
			cmbInstance1.Size = new Size(308, 23);
        cmbInstance1.TabIndex = 51;
			cmbInstance1.SelectedValueChanged += cmbInstance1_SelectedValueChanged;
			button1.Font = new Font("Microsoft Sans Serif", 8.25f, FontStyle.Regular, GraphicsUnit.Point, 0);
        button1.Location = new Point(177, 392);
        button1.Name = "button1";
			button1.Size = new Size(85, 30);
        button1.TabIndex = 48;
			button1.Text = "Back";
			button1.UseVisualStyleBackColor = true;
			button1.Click += btnBack_Click;
			btnOkServer.Font = new Font("Microsoft Sans Serif", 8.25f, FontStyle.Regular, GraphicsUnit.Point, 0);
        btnOkServer.ForeColor = Color.Maroon;
			btnOkServer.Location = new Point(268, 320);
        btnOkServer.Name = "btnOkServer";
			btnOkServer.Size = new Size(67, 30);
        btnOkServer.TabIndex = 47;
			btnOkServer.Text = "Connect";
			btnOkServer.UseVisualStyleBackColor = true;
			btnOkServer.Click += btnOkServer_Click;
			label12.AutoSize = true;
			label12.Font = new Font("Arial", 9f, FontStyle.Regular, GraphicsUnit.Point, 0);
        label12.Location = new Point(26, 109);
        label12.Name = "label12";
			label12.Size = new Size(98, 15);
        label12.TabIndex = 42;
			label12.Text = "Server Instance :";
			label2.AutoSize = true;
			label2.Font = new Font("Arial", 9f, FontStyle.Bold, GraphicsUnit.Point, 0);
        label2.ForeColor = Color.Maroon;
			label2.Location = new Point(110, 13);
        label2.Name = "label2";
			label2.Size = new Size(232, 15);
        label2.TabIndex = 0;
			label2.Text = "MsSQL Installed Instance configuration.";
			panel3.Controls.Add(pictureBox5);
			panel3.Controls.Add(pictureBox4);
			panel3.Controls.Add(panel5);
			panel3.Controls.Add(pictureBox3);
			panel3.Controls.Add(pictureBox2);
			panel3.Controls.Add(label7);
			panel3.Controls.Add(linkLabel2);
			panel3.Controls.Add(label6);
			panel3.Controls.Add(linkLabel1);
			panel3.Location = new Point(3, 39);
        panel3.Name = "panel3";
			panel3.Size = new Size(363, 439);
        panel3.TabIndex = 8;
			//pictureBox5.Image = Resources.OpenMiracale_aboutus;
			pictureBox5.Location = new Point(27, 380);
        pictureBox5.Name = "pictureBox5";
			pictureBox5.Size = new Size(144, 57);
        pictureBox5.SizeMode = PictureBoxSizeMode.Zoom;
			pictureBox5.TabIndex = 14;
			pictureBox5.TabStop = false;
			//pictureBox4.Image = Resources.Cybrosys_Logo_full;
			pictureBox4.Location = new Point(233, 382);
        pictureBox4.Name = "pictureBox4";
			pictureBox4.Size = new Size(105, 51);
        pictureBox4.SizeMode = PictureBoxSizeMode.Zoom;
			pictureBox4.TabIndex = 13;
			pictureBox4.TabStop = false;
			panel5.BackColor = Color.Black;
			panel5.Location = new Point(29, 373);
        panel5.Name = "panel5";
			panel5.Size = new Size(307, 1);
        panel5.TabIndex = 11;
			//pictureBox3.Image = Resources.mssql;
			pictureBox3.Location = new Point(264, 259);
        pictureBox3.Name = "pictureBox3";
			pictureBox3.Size = new Size(86, 78);
        pictureBox3.SizeMode = PictureBoxSizeMode.Zoom;
			pictureBox3.TabIndex = 5;
			pictureBox3.TabStop = false;
			//pictureBox2.Image = Resources.MicrosoftSQL_Server;
			pictureBox2.Location = new Point(20, 79);
        pictureBox2.Name = "pictureBox2";
			pictureBox2.Size = new Size(92, 97);
        pictureBox2.SizeMode = PictureBoxSizeMode.Zoom;
			pictureBox2.TabIndex = 4;
			pictureBox2.TabStop = false;
			label7.ForeColor = Color.Black;
			label7.Location = new Point(19, 255);
        label7.Name = "label7";
			label7.Size = new Size(243, 100);
        label7.TabIndex = 3;
			//label7.Text = resources.GetString("label7.Text");
			label7.TextAlign = ContentAlignment.MiddleCenter;
			linkLabel2.AutoSize = true;
			linkLabel2.Font = new Font("Microsoft Sans Serif", 9.75f, FontStyle.Bold, GraphicsUnit.Point, 0);
        linkLabel2.LinkColor = Color.Crimson;
			linkLabel2.Location = new Point(24, 215);
        linkLabel2.Name = "linkLabel2";
			linkLabel2.Size = new Size(311, 16);
        linkLabel2.TabIndex = 2;
			linkLabel2.TabStop = true;
			linkLabel2.Text = "To Install and Configure MsSQL Server 2008";
			linkLabel2.Click += linkLabel2_Click;
			label6.ForeColor = Color.Black;
			label6.Location = new Point(116, 103);
        label6.Name = "label6";
			label6.Size = new Size(232, 62);
        label6.TabIndex = 1;
			label6.Text = "The MsSQL Server Instance Configuration Wizard helps automate the process of configuring your Openmiracle. It creates a custom MsSQL configuration.";
			label6.TextAlign = ContentAlignment.MiddleCenter;
			linkLabel1.AutoSize = true;
			linkLabel1.Font = new Font("Microsoft Sans Serif", 9.75f, FontStyle.Bold, GraphicsUnit.Point, 0);
        linkLabel1.LinkColor = Color.Crimson;
			linkLabel1.Location = new Point(10, 60);
        linkLabel1.Name = "linkLabel1";
			linkLabel1.Size = new Size(338, 16);
        linkLabel1.TabIndex = 0;
			linkLabel1.TabStop = true;
			linkLabel1.Text = "MsSQL Database Instance Configuration Wizard";
			linkLabel1.Click += linkLabel1_Click;
			progressBar1.Location = new Point(2, 482);
        progressBar1.MarqueeAnimationSpeed = 30;
			progressBar1.Name = "progressBar1";
			progressBar1.Size = new Size(365, 8);
        progressBar1.Style = ProgressBarStyle.Marquee;
			progressBar1.TabIndex = 9;
			base.AutoScaleDimensions = new SizeF(6f, 13f);
			base.AutoScaleMode = AutoScaleMode.Font;
			BackColor = Color.Gainsboro;
			base.ClientSize = new Size(369, 491);
			base.Controls.Add(progressBar1);
			base.Controls.Add(panel2);
			base.Controls.Add(panel1);
			base.Controls.Add(panel3);
			base.Controls.Add(label1);
			base.FormBorderStyle = FormBorderStyle.FixedDialog;
			//base.Icon = (Icon) resources.GetObject("$this.Icon");
			base.MaximizeBox = false;
			base.MinimizeBox = false;
			base.Name = "frmMsSqlInstallerforOpenmiracle";
			base.StartPosition = FormStartPosition.CenterScreen;
			Text = "Database configuration";
			base.Load += frmMySqlInstallerforOpenmiracle_Load;
			panel1.ResumeLayout(false);
			panel1.PerformLayout();
			gbFeature.ResumeLayout(false);
			gbFeature.PerformLayout();
			pnlCredencial.ResumeLayout(false);
			pnlCredencial.PerformLayout();
			panel2.ResumeLayout(false);
			panel2.PerformLayout();
			groupBox1.ResumeLayout(false);
			groupBox1.PerformLayout();
			panel3.ResumeLayout(false);
			panel3.PerformLayout();
			((ISupportInitialize) pictureBox5).EndInit();
        ((ISupportInitialize) pictureBox4).EndInit();
        ((ISupportInitialize) pictureBox3).EndInit();
        ((ISupportInitialize) pictureBox2).EndInit();
			base.ResumeLayout(false);
			base.PerformLayout();
    }

    //    private void InitializeComponent()
    //    {
    //        this.rbtnNetworkServers = new System.Windows.Forms.RadioButton();
    //        this.radioButton3 = new System.Windows.Forms.RadioButton();
    //        this.radioButton4 = new System.Windows.Forms.RadioButton();
    //        this.textBox1 = new System.Windows.Forms.TextBox();
    //        this.label10 = new System.Windows.Forms.Label();
    //        this.rbtnLocalServer = new System.Windows.Forms.RadioButton();
    //        this.button2 = new System.Windows.Forms.Button();
    //        this.cmbPath = new System.Windows.Forms.ComboBox();
    //        this.linkLabel4 = new System.Windows.Forms.LinkLabel();
    //        this.label13 = new System.Windows.Forms.Label();
    //        this.cmbServers1 = new System.Windows.Forms.ComboBox();
    //        this.label9 = new System.Windows.Forms.Label();
    //        this.cmbInstance1 = new System.Windows.Forms.ComboBox();
    //        this.button1 = new System.Windows.Forms.Button();
    //        this.btnOkServer = new System.Windows.Forms.Button();
    //        this.label2 = new System.Windows.Forms.Label();
    //        this.panel3 = new System.Windows.Forms.Panel();
    //        this.pictureBox5 = new System.Windows.Forms.PictureBox();
    //        this.pictureBox4 = new System.Windows.Forms.PictureBox();
    //        this.panel5 = new System.Windows.Forms.Panel();
    //        this.pictureBox3 = new System.Windows.Forms.PictureBox();
    //        this.pictureBox2 = new System.Windows.Forms.PictureBox();
    //        this.label7 = new System.Windows.Forms.Label();
    //        this.linkLabel2 = new System.Windows.Forms.LinkLabel();
    //        this.label6 = new System.Windows.Forms.Label();
    //        this.linkLabel1 = new System.Windows.Forms.LinkLabel();
    //        this.label12 = new System.Windows.Forms.Label();
    //        this.progressBar1 = new System.Windows.Forms.ProgressBar();
    //        this.label11 = new System.Windows.Forms.Label();
    //        this.panel1 = new System.Windows.Forms.Panel();
    //        this.lblMessage = new System.Windows.Forms.TextBox();
    //        this.rbtnMultyUser = new System.Windows.Forms.RadioButton();
    //        this.rbtnSingleUser = new System.Windows.Forms.RadioButton();
    //        this.btnBack = new System.Windows.Forms.Button();
    //        this.btnInstall = new System.Windows.Forms.Button();
    //        this.gbFeature = new System.Windows.Forms.GroupBox();
    //        this.pnlCredencial = new System.Windows.Forms.Panel();
    //        this.label5 = new System.Windows.Forms.Label();
    //        this.label4 = new System.Windows.Forms.Label();
    //        this.label3 = new System.Windows.Forms.Label();
    //        this.txtconfpassword = new System.Windows.Forms.TextBox();
    //        this.txtPassword = new System.Windows.Forms.TextBox();
    //        this.cbxSap = new System.Windows.Forms.CheckBox();
    //        this.cbxMssqlServer = new System.Windows.Forms.CheckBox();
    //        this.pbxProcess = new System.Windows.Forms.ProgressBar();
    //        this.lblEvent = new System.Windows.Forms.Label();
    //        this.pbxEvent = new System.Windows.Forms.ProgressBar();
    //        this.lblProcess = new System.Windows.Forms.Label();
    //        this.label1 = new System.Windows.Forms.Label();
    //        this.panel2 = new System.Windows.Forms.Panel();
    //        this.groupBox1 = new System.Windows.Forms.GroupBox();
    //        this.textBox2 = new System.Windows.Forms.TextBox();
    //        this.folderBrowserDialog1 = new System.Windows.Forms.FolderBrowserDialog();
    //        this.panel3.SuspendLayout();
    //        ((System.ComponentModel.ISupportInitialize)(this.pictureBox5)).BeginInit();
    //        ((System.ComponentModel.ISupportInitialize)(this.pictureBox4)).BeginInit();
    //        ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).BeginInit();
    //        ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
    //        this.panel1.SuspendLayout();
    //        this.gbFeature.SuspendLayout();
    //        this.pnlCredencial.SuspendLayout();
    //        this.panel2.SuspendLayout();
    //        this.groupBox1.SuspendLayout();
    //        this.SuspendLayout();
    //        // 
    //        // rbtnNetworkServers
    //        // 
    //        this.rbtnNetworkServers.AutoSize = true;
    //        this.rbtnNetworkServers.Location = new System.Drawing.Point(238, 39);
    //        this.rbtnNetworkServers.Name = "rbtnNetworkServers";
    //        this.rbtnNetworkServers.Size = new System.Drawing.Size(104, 17);
    //        this.rbtnNetworkServers.TabIndex = 65;
    //        this.rbtnNetworkServers.Text = "Network Servers";
    //        this.rbtnNetworkServers.UseVisualStyleBackColor = true;
    //        // 
    //        // radioButton3
    //        // 
    //        this.radioButton3.AutoSize = true;
    //        this.radioButton3.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
    //        this.radioButton3.Location = new System.Drawing.Point(21, 37);
    //        this.radioButton3.Name = "radioButton3";
    //        this.radioButton3.Size = new System.Drawing.Size(195, 19);
    //        this.radioButton3.TabIndex = 56;
    //        this.radioButton3.Text = "Use SQL Server Authentication.";
    //        this.radioButton3.UseVisualStyleBackColor = true;
    //        // 
    //        // radioButton4
    //        // 
    //        this.radioButton4.AutoSize = true;
    //        this.radioButton4.Checked = true;
    //        this.radioButton4.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
    //        this.radioButton4.Location = new System.Drawing.Point(21, 16);
    //        this.radioButton4.Name = "radioButton4";
    //        this.radioButton4.Size = new System.Drawing.Size(184, 19);
    //        this.radioButton4.TabIndex = 55;
    //        this.radioButton4.TabStop = true;
    //        this.radioButton4.Text = "Use Windows Authentication.";
    //        this.radioButton4.UseVisualStyleBackColor = true;
    //        // 
    //        // textBox1
    //        // 
    //        this.textBox1.Enabled = false;
    //        this.textBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
    //        this.textBox1.Location = new System.Drawing.Point(19, 78);
    //        this.textBox1.Name = "textBox1";
    //        this.textBox1.Size = new System.Drawing.Size(307, 21);
    //        this.textBox1.TabIndex = 53;
    //        // 
    //        // label10
    //        // 
    //        this.label10.AutoSize = true;
    //        this.label10.Enabled = false;
    //        this.label10.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
    //        this.label10.Location = new System.Drawing.Point(18, 63);
    //        this.label10.Name = "label10";
    //        this.label10.Size = new System.Drawing.Size(53, 15);
    //        this.label10.TabIndex = 51;
    //        this.label10.Text = "User Id :";
    //        // 
    //        // rbtnLocalServer
    //        // 
    //        this.rbtnLocalServer.AutoSize = true;
    //        this.rbtnLocalServer.Checked = true;
    //        this.rbtnLocalServer.Location = new System.Drawing.Point(146, 39);
    //        this.rbtnLocalServer.Name = "rbtnLocalServer";
    //        this.rbtnLocalServer.Size = new System.Drawing.Size(90, 17);
    //        this.rbtnLocalServer.TabIndex = 64;
    //        this.rbtnLocalServer.TabStop = true;
    //        this.rbtnLocalServer.Text = "Local Servers";
    //        this.rbtnLocalServer.UseVisualStyleBackColor = true;
    //        // 
    //        // button2
    //        // 
    //        this.button2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
    //        this.button2.Location = new System.Drawing.Point(268, 392);
    //        this.button2.Name = "button2";
    //        this.button2.Size = new System.Drawing.Size(68, 30);
    //        this.button2.TabIndex = 63;
    //        this.button2.Text = "Ok";
    //        this.button2.UseVisualStyleBackColor = true;
    //        // 
    //        // cmbPath
    //        // 
    //        this.cmbPath.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
    //        this.cmbPath.FormattingEnabled = true;
    //        this.cmbPath.Location = new System.Drawing.Point(28, 358);
    //        this.cmbPath.Name = "cmbPath";
    //        this.cmbPath.Size = new System.Drawing.Size(308, 23);
    //        this.cmbPath.TabIndex = 62;
    //        // 
    //        // linkLabel4
    //        // 
    //        this.linkLabel4.AutoSize = true;
    //        this.linkLabel4.LinkColor = System.Drawing.Color.Maroon;
    //        this.linkLabel4.Location = new System.Drawing.Point(294, 64);
    //        this.linkLabel4.Name = "linkLabel4";
    //        this.linkLabel4.Size = new System.Drawing.Size(44, 13);
    //        this.linkLabel4.TabIndex = 60;
    //        this.linkLabel4.TabStop = true;
    //        this.linkLabel4.Text = "Refresh";
    //        // 
    //        // label13
    //        // 
    //        this.label13.AutoSize = true;
    //        this.label13.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
    //        this.label13.Location = new System.Drawing.Point(27, 339);
    //        this.label13.Name = "label13";
    //        this.label13.Size = new System.Drawing.Size(112, 15);
    //        this.label13.TabIndex = 56;
    //        this.label13.Text = "Openmiracle Path :";
    //        // 
    //        // cmbServers1
    //        // 
    //        this.cmbServers1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
    //        this.cmbServers1.FormattingEnabled = true;
    //        this.cmbServers1.Location = new System.Drawing.Point(28, 84);
    //        this.cmbServers1.Name = "cmbServers1";
    //        this.cmbServers1.Size = new System.Drawing.Size(308, 23);
    //        this.cmbServers1.TabIndex = 53;
    //        // 
    //        // label9
    //        // 
    //        this.label9.AutoSize = true;
    //        this.label9.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
    //        this.label9.Location = new System.Drawing.Point(27, 64);
    //        this.label9.Name = "label9";
    //        this.label9.Size = new System.Drawing.Size(85, 15);
    //        this.label9.TabIndex = 52;
    //        this.label9.Text = "System Name";
    //        // 
    //        // cmbInstance1
    //        // 
    //        this.cmbInstance1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
    //        this.cmbInstance1.FormattingEnabled = true;
    //        this.cmbInstance1.Location = new System.Drawing.Point(28, 127);
    //        this.cmbInstance1.Name = "cmbInstance1";
    //        this.cmbInstance1.Size = new System.Drawing.Size(308, 23);
    //        this.cmbInstance1.TabIndex = 51;
    //        // 
    //        // button1
    //        // 
    //        this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
    //        this.button1.Location = new System.Drawing.Point(177, 392);
    //        this.button1.Name = "button1";
    //        this.button1.Size = new System.Drawing.Size(85, 30);
    //        this.button1.TabIndex = 48;
    //        this.button1.Text = "Back";
    //        this.button1.UseVisualStyleBackColor = true;
    //        // 
    //        // btnOkServer
    //        // 
    //        this.btnOkServer.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
    //        this.btnOkServer.ForeColor = System.Drawing.Color.Maroon;
    //        this.btnOkServer.Location = new System.Drawing.Point(268, 320);
    //        this.btnOkServer.Name = "btnOkServer";
    //        this.btnOkServer.Size = new System.Drawing.Size(67, 30);
    //        this.btnOkServer.TabIndex = 47;
    //        this.btnOkServer.Text = "Connect";
    //        this.btnOkServer.UseVisualStyleBackColor = true;
    //        // 
    //        // label2
    //        // 
    //        this.label2.AutoSize = true;
    //        this.label2.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
    //        this.label2.ForeColor = System.Drawing.Color.Maroon;
    //        this.label2.Location = new System.Drawing.Point(110, 13);
    //        this.label2.Name = "label2";
    //        this.label2.Size = new System.Drawing.Size(232, 15);
    //        this.label2.TabIndex = 0;
    //        this.label2.Text = "MsSQL Installed Instance configuration.";
    //        // 
    //        // panel3
    //        // 
    //        this.panel3.Controls.Add(this.pictureBox5);
    //        this.panel3.Controls.Add(this.pictureBox4);
    //        this.panel3.Controls.Add(this.panel5);
    //        this.panel3.Controls.Add(this.pictureBox3);
    //        this.panel3.Controls.Add(this.pictureBox2);
    //        this.panel3.Controls.Add(this.label7);
    //        this.panel3.Controls.Add(this.linkLabel2);
    //        this.panel3.Controls.Add(this.label6);
    //        this.panel3.Controls.Add(this.linkLabel1);
    //        this.panel3.Location = new System.Drawing.Point(3, 32);
    //        this.panel3.Name = "panel3";
    //        this.panel3.Size = new System.Drawing.Size(363, 439);
    //        this.panel3.TabIndex = 13;
    //        // 
    //        // pictureBox5
    //        // 
    //        this.pictureBox5.Location = new System.Drawing.Point(27, 380);
    //        this.pictureBox5.Name = "pictureBox5";
    //        this.pictureBox5.Size = new System.Drawing.Size(144, 57);
    //        this.pictureBox5.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
    //        this.pictureBox5.TabIndex = 14;
    //        this.pictureBox5.TabStop = false;
    //        // 
    //        // pictureBox4
    //        // 
    //        this.pictureBox4.Location = new System.Drawing.Point(233, 382);
    //        this.pictureBox4.Name = "pictureBox4";
    //        this.pictureBox4.Size = new System.Drawing.Size(105, 51);
    //        this.pictureBox4.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
    //        this.pictureBox4.TabIndex = 13;
    //        this.pictureBox4.TabStop = false;
    //        // 
    //        // panel5
    //        // 
    //        this.panel5.BackColor = System.Drawing.Color.Black;
    //        this.panel5.Location = new System.Drawing.Point(29, 373);
    //        this.panel5.Name = "panel5";
    //        this.panel5.Size = new System.Drawing.Size(307, 1);
    //        this.panel5.TabIndex = 11;
    //        // 
    //        // pictureBox3
    //        // 
    //        this.pictureBox3.Location = new System.Drawing.Point(264, 259);
    //        this.pictureBox3.Name = "pictureBox3";
    //        this.pictureBox3.Size = new System.Drawing.Size(86, 78);
    //        this.pictureBox3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
    //        this.pictureBox3.TabIndex = 5;
    //        this.pictureBox3.TabStop = false;
    //        // 
    //        // pictureBox2
    //        // 
    //        this.pictureBox2.Location = new System.Drawing.Point(20, 79);
    //        this.pictureBox2.Name = "pictureBox2";
    //        this.pictureBox2.Size = new System.Drawing.Size(92, 97);
    //        this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
    //        this.pictureBox2.TabIndex = 4;
    //        this.pictureBox2.TabStop = false;
    //        // 
    //        // label7
    //        // 
    //        this.label7.ForeColor = System.Drawing.Color.Black;
    //        this.label7.Location = new System.Drawing.Point(19, 255);
    //        this.label7.Name = "label7";
    //        this.label7.Size = new System.Drawing.Size(243, 100);
    //        this.label7.TabIndex = 3;
    //        this.label7.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
    //        // 
    //        // linkLabel2
    //        // 
    //        this.linkLabel2.AutoSize = true;
    //        this.linkLabel2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
    //        this.linkLabel2.LinkColor = System.Drawing.Color.Crimson;
    //        this.linkLabel2.Location = new System.Drawing.Point(24, 215);
    //        this.linkLabel2.Name = "linkLabel2";
    //        this.linkLabel2.Size = new System.Drawing.Size(311, 16);
    //        this.linkLabel2.TabIndex = 2;
    //        this.linkLabel2.TabStop = true;
    //        this.linkLabel2.Text = "To Install and Configure MsSQL Server 2008";
    //        // 
    //        // label6
    //        // 
    //        this.label6.ForeColor = System.Drawing.Color.Black;
    //        this.label6.Location = new System.Drawing.Point(116, 103);
    //        this.label6.Name = "label6";
    //        this.label6.Size = new System.Drawing.Size(232, 62);
    //        this.label6.TabIndex = 1;
    //        this.label6.Text = "The MsSQL Server Instance Configuration Wizard helps automate the process of conf" +
    //"iguring your Openmiracle. It creates a custom MsSQL configuration.";
    //        this.label6.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
    //        // 
    //        // linkLabel1
    //        // 
    //        this.linkLabel1.AutoSize = true;
    //        this.linkLabel1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
    //        this.linkLabel1.LinkColor = System.Drawing.Color.Crimson;
    //        this.linkLabel1.Location = new System.Drawing.Point(10, 60);
    //        this.linkLabel1.Name = "linkLabel1";
    //        this.linkLabel1.Size = new System.Drawing.Size(338, 16);
    //        this.linkLabel1.TabIndex = 0;
    //        this.linkLabel1.TabStop = true;
    //        this.linkLabel1.Text = "MsSQL Database Instance Configuration Wizard";
    //        this.linkLabel1.Click += new System.EventHandler(this.linkLabel1_Click);
    //        // 
    //        // label12
    //        // 
    //        this.label12.AutoSize = true;
    //        this.label12.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
    //        this.label12.Location = new System.Drawing.Point(26, 109);
    //        this.label12.Name = "label12";
    //        this.label12.Size = new System.Drawing.Size(98, 15);
    //        this.label12.TabIndex = 42;
    //        this.label12.Text = "Server Instance :";
    //        // 
    //        // progressBar1
    //        // 
    //        this.progressBar1.Location = new System.Drawing.Point(2, 475);
    //        this.progressBar1.MarqueeAnimationSpeed = 30;
    //        this.progressBar1.Name = "progressBar1";
    //        this.progressBar1.Size = new System.Drawing.Size(365, 8);
    //        this.progressBar1.Style = System.Windows.Forms.ProgressBarStyle.Marquee;
    //        this.progressBar1.TabIndex = 14;
    //        // 
    //        // label11
    //        // 
    //        this.label11.AutoSize = true;
    //        this.label11.Enabled = false;
    //        this.label11.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
    //        this.label11.Location = new System.Drawing.Point(17, 106);
    //        this.label11.Name = "label11";
    //        this.label11.Size = new System.Drawing.Size(69, 15);
    //        this.label11.TabIndex = 52;
    //        this.label11.Text = "Password :";
    //        // 
    //        // panel1
    //        // 
    //        this.panel1.Controls.Add(this.lblMessage);
    //        this.panel1.Controls.Add(this.rbtnMultyUser);
    //        this.panel1.Controls.Add(this.rbtnSingleUser);
    //        this.panel1.Controls.Add(this.btnBack);
    //        this.panel1.Controls.Add(this.btnInstall);
    //        this.panel1.Controls.Add(this.gbFeature);
    //        this.panel1.Controls.Add(this.pbxProcess);
    //        this.panel1.Controls.Add(this.lblEvent);
    //        this.panel1.Controls.Add(this.pbxEvent);
    //        this.panel1.Controls.Add(this.lblProcess);
    //        this.panel1.Location = new System.Drawing.Point(3, 34);
    //        this.panel1.Name = "panel1";
    //        this.panel1.Size = new System.Drawing.Size(363, 441);
    //        this.panel1.TabIndex = 11;
    //        this.panel1.Visible = false;
    //        // 
    //        // lblMessage
    //        // 
    //        this.lblMessage.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
    //        this.lblMessage.BorderStyle = System.Windows.Forms.BorderStyle.None;
    //        this.lblMessage.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
    //        this.lblMessage.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
    //        this.lblMessage.Location = new System.Drawing.Point(17, 363);
    //        this.lblMessage.Multiline = true;
    //        this.lblMessage.Name = "lblMessage";
    //        this.lblMessage.ReadOnly = true;
    //        this.lblMessage.Size = new System.Drawing.Size(330, 27);
    //        this.lblMessage.TabIndex = 14;
    //        this.lblMessage.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
    //        // 
    //        // rbtnMultyUser
    //        // 
    //        this.rbtnMultyUser.AutoSize = true;
    //        this.rbtnMultyUser.Location = new System.Drawing.Point(277, 13);
    //        this.rbtnMultyUser.Name = "rbtnMultyUser";
    //        this.rbtnMultyUser.Size = new System.Drawing.Size(72, 17);
    //        this.rbtnMultyUser.TabIndex = 13;
    //        this.rbtnMultyUser.Text = "Multi User";
    //        this.rbtnMultyUser.UseVisualStyleBackColor = true;
    //        // 
    //        // rbtnSingleUser
    //        // 
    //        this.rbtnSingleUser.AutoSize = true;
    //        this.rbtnSingleUser.Checked = true;
    //        this.rbtnSingleUser.Location = new System.Drawing.Point(195, 13);
    //        this.rbtnSingleUser.Name = "rbtnSingleUser";
    //        this.rbtnSingleUser.Size = new System.Drawing.Size(79, 17);
    //        this.rbtnSingleUser.TabIndex = 12;
    //        this.rbtnSingleUser.TabStop = true;
    //        this.rbtnSingleUser.Text = "Single User";
    //        this.rbtnSingleUser.UseVisualStyleBackColor = true;
    //        // 
    //        // btnBack
    //        // 
    //        this.btnBack.Location = new System.Drawing.Point(170, 400);
    //        this.btnBack.Name = "btnBack";
    //        this.btnBack.Size = new System.Drawing.Size(85, 30);
    //        this.btnBack.TabIndex = 10;
    //        this.btnBack.Text = "Back";
    //        this.btnBack.UseVisualStyleBackColor = true;
    //        // 
    //        // btnInstall
    //        // 
    //        this.btnInstall.Location = new System.Drawing.Point(262, 399);
    //        this.btnInstall.Name = "btnInstall";
    //        this.btnInstall.Size = new System.Drawing.Size(85, 30);
    //        this.btnInstall.TabIndex = 9;
    //        this.btnInstall.Text = "Install";
    //        this.btnInstall.UseVisualStyleBackColor = true;
    //        // 
    //        // gbFeature
    //        // 
    //        this.gbFeature.BackColor = System.Drawing.Color.Transparent;
    //        this.gbFeature.Controls.Add(this.pnlCredencial);
    //        this.gbFeature.Controls.Add(this.cbxSap);
    //        this.gbFeature.Controls.Add(this.cbxMssqlServer);
    //        this.gbFeature.Font = new System.Drawing.Font("Maiandra GD", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
    //        this.gbFeature.ForeColor = System.Drawing.Color.Crimson;
    //        this.gbFeature.Location = new System.Drawing.Point(9, 12);
    //        this.gbFeature.Name = "gbFeature";
    //        this.gbFeature.Size = new System.Drawing.Size(345, 258);
    //        this.gbFeature.TabIndex = 8;
    //        this.gbFeature.TabStop = false;
    //        this.gbFeature.Text = "Select features to install.";
    //        // 
    //        // pnlCredencial
    //        // 
    //        this.pnlCredencial.Controls.Add(this.label5);
    //        this.pnlCredencial.Controls.Add(this.label4);
    //        this.pnlCredencial.Controls.Add(this.label3);
    //        this.pnlCredencial.Controls.Add(this.txtconfpassword);
    //        this.pnlCredencial.Controls.Add(this.txtPassword);
    //        this.pnlCredencial.Location = new System.Drawing.Point(-6, 96);
    //        this.pnlCredencial.Name = "pnlCredencial";
    //        this.pnlCredencial.Size = new System.Drawing.Size(357, 153);
    //        this.pnlCredencial.TabIndex = 4;
    //        // 
    //        // label5
    //        // 
    //        this.label5.AutoSize = true;
    //        this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
    //        this.label5.ForeColor = System.Drawing.Color.Black;
    //        this.label5.Location = new System.Drawing.Point(28, 49);
    //        this.label5.Name = "label5";
    //        this.label5.Size = new System.Drawing.Size(99, 15);
    //        this.label5.TabIndex = 13;
    //        this.label5.Text = "Enter Password :";
    //        // 
    //        // label4
    //        // 
    //        this.label4.AutoSize = true;
    //        this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
    //        this.label4.ForeColor = System.Drawing.Color.Black;
    //        this.label4.Location = new System.Drawing.Point(28, 93);
    //        this.label4.Name = "label4";
    //        this.label4.Size = new System.Drawing.Size(113, 15);
    //        this.label4.TabIndex = 12;
    //        this.label4.Text = "Confirm Password :";
    //        // 
    //        // label3
    //        // 
    //        this.label3.AutoSize = true;
    //        this.label3.Font = new System.Drawing.Font("Maiandra GD", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
    //        this.label3.ForeColor = System.Drawing.Color.DimGray;
    //        this.label3.Location = new System.Drawing.Point(16, 15);
    //        this.label3.Name = "label3";
    //        this.label3.Size = new System.Drawing.Size(327, 16);
    //        this.label3.TabIndex = 11;
    //        this.label3.Text = "Built-in SQL Server system administrator account";
    //        // 
    //        // txtconfpassword
    //        // 
    //        this.txtconfpassword.Location = new System.Drawing.Point(28, 111);
    //        this.txtconfpassword.Name = "txtconfpassword";
    //        this.txtconfpassword.PasswordChar = '*';
    //        this.txtconfpassword.Size = new System.Drawing.Size(301, 23);
    //        this.txtconfpassword.TabIndex = 10;
    //        // 
    //        // txtPassword
    //        // 
    //        this.txtPassword.Location = new System.Drawing.Point(28, 68);
    //        this.txtPassword.Name = "txtPassword";
    //        this.txtPassword.PasswordChar = '*';
    //        this.txtPassword.Size = new System.Drawing.Size(301, 23);
    //        this.txtPassword.TabIndex = 9;
    //        // 
    //        // cbxSap
    //        // 
    //        this.cbxSap.AutoSize = true;
    //        this.cbxSap.Checked = true;
    //        this.cbxSap.CheckState = System.Windows.Forms.CheckState.Checked;
    //        this.cbxSap.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
    //        this.cbxSap.ForeColor = System.Drawing.Color.Black;
    //        this.cbxSap.Location = new System.Drawing.Point(188, 48);
    //        this.cbxSap.Name = "cbxSap";
    //        this.cbxSap.Size = new System.Drawing.Size(116, 17);
    //        this.cbxSap.TabIndex = 3;
    //        this.cbxSap.Text = "SAP Cristal Report.";
    //        this.cbxSap.UseVisualStyleBackColor = true;
    //        // 
    //        // cbxMssqlServer
    //        // 
    //        this.cbxMssqlServer.AutoSize = true;
    //        this.cbxMssqlServer.Checked = true;
    //        this.cbxMssqlServer.CheckState = System.Windows.Forms.CheckState.Checked;
    //        this.cbxMssqlServer.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
    //        this.cbxMssqlServer.ForeColor = System.Drawing.Color.Black;
    //        this.cbxMssqlServer.Location = new System.Drawing.Point(36, 48);
    //        this.cbxMssqlServer.Name = "cbxMssqlServer";
    //        this.cbxMssqlServer.Size = new System.Drawing.Size(122, 17);
    //        this.cbxMssqlServer.TabIndex = 0;
    //        this.cbxMssqlServer.Text = "MsSQL Server 2008";
    //        this.cbxMssqlServer.UseVisualStyleBackColor = true;
    //        // 
    //        // pbxProcess
    //        // 
    //        this.pbxProcess.Location = new System.Drawing.Point(16, 337);
    //        this.pbxProcess.MarqueeAnimationSpeed = 60;
    //        this.pbxProcess.Name = "pbxProcess";
    //        this.pbxProcess.Size = new System.Drawing.Size(332, 10);
    //        this.pbxProcess.TabIndex = 7;
    //        // 
    //        // lblEvent
    //        // 
    //        this.lblEvent.AutoSize = true;
    //        this.lblEvent.Location = new System.Drawing.Point(14, 276);
    //        this.lblEvent.Name = "lblEvent";
    //        this.lblEvent.Size = new System.Drawing.Size(46, 13);
    //        this.lblEvent.TabIndex = 6;
    //        this.lblEvent.Text = "Program";
    //        // 
    //        // pbxEvent
    //        // 
    //        this.pbxEvent.Location = new System.Drawing.Point(16, 293);
    //        this.pbxEvent.Name = "pbxEvent";
    //        this.pbxEvent.Size = new System.Drawing.Size(331, 10);
    //        this.pbxEvent.TabIndex = 5;
    //        // 
    //        // lblProcess
    //        // 
    //        this.lblProcess.AutoSize = true;
    //        this.lblProcess.Location = new System.Drawing.Point(14, 322);
    //        this.lblProcess.Name = "lblProcess";
    //        this.lblProcess.Size = new System.Drawing.Size(45, 13);
    //        this.lblProcess.TabIndex = 4;
    //        this.lblProcess.Text = "Process";
    //        // 
    //        // label1
    //        // 
    //        this.label1.AutoSize = true;
    //        this.label1.Font = new System.Drawing.Font("Consolas", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
    //        this.label1.Location = new System.Drawing.Point(6, 7);
    //        this.label1.Name = "label1";
    //        this.label1.Size = new System.Drawing.Size(360, 22);
    //        this.label1.TabIndex = 10;
    //        this.label1.Text = "Openmiracle Database Configuration.";
    //        // 
    //        // panel2
    //        // 
    //        this.panel2.BackColor = System.Drawing.Color.Gainsboro;
    //        this.panel2.Controls.Add(this.groupBox1);
    //        this.panel2.Controls.Add(this.rbtnNetworkServers);
    //        this.panel2.Controls.Add(this.rbtnLocalServer);
    //        this.panel2.Controls.Add(this.button2);
    //        this.panel2.Controls.Add(this.cmbPath);
    //        this.panel2.Controls.Add(this.linkLabel4);
    //        this.panel2.Controls.Add(this.label13);
    //        this.panel2.Controls.Add(this.cmbServers1);
    //        this.panel2.Controls.Add(this.label9);
    //        this.panel2.Controls.Add(this.cmbInstance1);
    //        this.panel2.Controls.Add(this.button1);
    //        this.panel2.Controls.Add(this.btnOkServer);
    //        this.panel2.Controls.Add(this.label12);
    //        this.panel2.Controls.Add(this.label2);
    //        this.panel2.Location = new System.Drawing.Point(3, 33);
    //        this.panel2.Name = "panel2";
    //        this.panel2.Size = new System.Drawing.Size(363, 442);
    //        this.panel2.TabIndex = 12;
    //        this.panel2.Visible = false;
    //        // 
    //        // groupBox1
    //        // 
    //        this.groupBox1.BackColor = System.Drawing.Color.Transparent;
    //        this.groupBox1.Controls.Add(this.radioButton3);
    //        this.groupBox1.Controls.Add(this.radioButton4);
    //        this.groupBox1.Controls.Add(this.textBox1);
    //        this.groupBox1.Controls.Add(this.label10);
    //        this.groupBox1.Controls.Add(this.label11);
    //        this.groupBox1.Controls.Add(this.textBox2);
    //        this.groupBox1.Location = new System.Drawing.Point(9, 156);
    //        this.groupBox1.Name = "groupBox1";
    //        this.groupBox1.Size = new System.Drawing.Size(345, 162);
    //        this.groupBox1.TabIndex = 0;
    //        this.groupBox1.TabStop = false;
    //        // 
    //        // textBox2
    //        // 
    //        this.textBox2.Enabled = false;
    //        this.textBox2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
    //        this.textBox2.Location = new System.Drawing.Point(19, 121);
    //        this.textBox2.Name = "textBox2";
    //        this.textBox2.PasswordChar = '*';
    //        this.textBox2.Size = new System.Drawing.Size(308, 21);
    //        this.textBox2.TabIndex = 54;
    //        // 
    //        // DatabaseConfiguration
    //        // 
    //        this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
    //        this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
    //        this.ClientSize = new System.Drawing.Size(369, 491);
    //        this.Controls.Add(this.panel3);
    //        this.Controls.Add(this.progressBar1);
    //        this.Controls.Add(this.panel1);
    //        this.Controls.Add(this.label1);
    //        this.Controls.Add(this.panel2);
    //        this.Name = "DatabaseConfiguration";
    //        this.Text = "DatabaseConfiguration";
    //        this.panel3.ResumeLayout(false);
    //        this.panel3.PerformLayout();
    //        ((System.ComponentModel.ISupportInitialize)(this.pictureBox5)).EndInit();
    //        ((System.ComponentModel.ISupportInitialize)(this.pictureBox4)).EndInit();
    //        ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).EndInit();
    //        ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
    //        this.panel1.ResumeLayout(false);
    //        this.panel1.PerformLayout();
    //        this.gbFeature.ResumeLayout(false);
    //        this.gbFeature.PerformLayout();
    //        this.pnlCredencial.ResumeLayout(false);
    //        this.pnlCredencial.PerformLayout();
    //        this.panel2.ResumeLayout(false);
    //        this.panel2.PerformLayout();
    //        this.groupBox1.ResumeLayout(false);
    //        this.groupBox1.PerformLayout();
    //        this.ResumeLayout(false);
    //        this.PerformLayout();

    //    }

    #endregion

    private System.Windows.Forms.RadioButton rbtnNetworkServers;
        private System.Windows.Forms.RadioButton radioButton3;
        private System.Windows.Forms.RadioButton radioButton4;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.RadioButton rbtnLocalServer;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.ComboBox cmbPath;
        private System.Windows.Forms.LinkLabel linkLabel4;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.ComboBox cmbServers1;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.ComboBox cmbInstance1;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button btnOkServer;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.PictureBox pictureBox5;
        private System.Windows.Forms.PictureBox pictureBox4;
        private System.Windows.Forms.Panel panel5;
        private System.Windows.Forms.PictureBox pictureBox3;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.LinkLabel linkLabel2;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.LinkLabel linkLabel1;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.ProgressBar progressBar1;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.TextBox lblMessage;
        private System.Windows.Forms.RadioButton rbtnMultyUser;
        private System.Windows.Forms.RadioButton rbtnSingleUser;
        private System.Windows.Forms.Button btnBack;
        private System.Windows.Forms.Button btnInstall;
        private System.Windows.Forms.GroupBox gbFeature;
        private System.Windows.Forms.Panel pnlCredencial;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtconfpassword;
        private System.Windows.Forms.TextBox txtPassword;
        private System.Windows.Forms.CheckBox cbxSap;
        private System.Windows.Forms.CheckBox cbxMssqlServer;
        private System.Windows.Forms.ProgressBar pbxProcess;
        private System.Windows.Forms.Label lblEvent;
        private System.Windows.Forms.ProgressBar pbxEvent;
        private System.Windows.Forms.Label lblProcess;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.FolderBrowserDialog folderBrowserDialog1;
    }
}