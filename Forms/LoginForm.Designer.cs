namespace SmartMedPharmacy.Forms
{
    partial class LoginForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(LoginForm));
            this.LoginFormTitle2 = new System.Windows.Forms.Label();
            this.LoginFormTitle1 = new System.Windows.Forms.Label();
            this.labelMobileNumber = new System.Windows.Forms.Label();
            this.txtMobileNumber = new System.Windows.Forms.TextBox();
            this.txtPassword = new System.Windows.Forms.TextBox();
            this.labelPassword = new System.Windows.Forms.Label();
            this.checkBoxRole = new System.Windows.Forms.CheckBox();
            this.btnLogin = new System.Windows.Forms.Button();
            this.labelRegister = new System.Windows.Forms.Label();
            this.lnkRegister = new System.Windows.Forms.LinkLabel();
            this.SuspendLayout();
            // 
            // LoginFormTitle2
            // 
            this.LoginFormTitle2.BackColor = System.Drawing.Color.Transparent;
            this.LoginFormTitle2.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.LoginFormTitle2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LoginFormTitle2.Location = new System.Drawing.Point(50, 85);
            this.LoginFormTitle2.Name = "LoginFormTitle2";
            this.LoginFormTitle2.Size = new System.Drawing.Size(171, 23);
            this.LoginFormTitle2.TabIndex = 0;
            this.LoginFormTitle2.Text = "to SmartMed ";
            this.LoginFormTitle2.Click += new System.EventHandler(this.label1_Click);
            // 
            // LoginFormTitle1
            // 
            this.LoginFormTitle1.AutoSize = true;
            this.LoginFormTitle1.BackColor = System.Drawing.Color.Transparent;
            this.LoginFormTitle1.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LoginFormTitle1.Location = new System.Drawing.Point(46, 58);
            this.LoginFormTitle1.Name = "LoginFormTitle1";
            this.LoginFormTitle1.Size = new System.Drawing.Size(171, 26);
            this.LoginFormTitle1.TabIndex = 1;
            this.LoginFormTitle1.Text = "Welcome Back";
            // 
            // labelMobileNumber
            // 
            this.labelMobileNumber.AutoSize = true;
            this.labelMobileNumber.BackColor = System.Drawing.Color.Transparent;
            this.labelMobileNumber.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelMobileNumber.Location = new System.Drawing.Point(50, 136);
            this.labelMobileNumber.Name = "labelMobileNumber";
            this.labelMobileNumber.Size = new System.Drawing.Size(116, 17);
            this.labelMobileNumber.TabIndex = 3;
            this.labelMobileNumber.Text = "Mobile Number";
            this.labelMobileNumber.Click += new System.EventHandler(this.label4_Click);
            // 
            // txtMobileNumber
            // 
            this.txtMobileNumber.BackColor = System.Drawing.SystemColors.Info;
            this.txtMobileNumber.Location = new System.Drawing.Point(52, 157);
            this.txtMobileNumber.Name = "txtMobileNumber";
            this.txtMobileNumber.Size = new System.Drawing.Size(235, 20);
            this.txtMobileNumber.TabIndex = 4;
            this.txtMobileNumber.TextChanged += new System.EventHandler(this.txtMobileNumber_TextChanged);
            // 
            // txtPassword
            // 
            this.txtPassword.BackColor = System.Drawing.SystemColors.Info;
            this.txtPassword.Location = new System.Drawing.Point(51, 215);
            this.txtPassword.Name = "txtPassword";
            this.txtPassword.Size = new System.Drawing.Size(235, 20);
            this.txtPassword.TabIndex = 6;
            this.txtPassword.TextChanged += new System.EventHandler(this.txtPassword_TextChanged);
            // 
            // labelPassword
            // 
            this.labelPassword.AutoSize = true;
            this.labelPassword.BackColor = System.Drawing.Color.Transparent;
            this.labelPassword.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelPassword.Location = new System.Drawing.Point(49, 194);
            this.labelPassword.Name = "labelPassword";
            this.labelPassword.Size = new System.Drawing.Size(77, 17);
            this.labelPassword.TabIndex = 5;
            this.labelPassword.Text = "Password";
            // 
            // checkBoxRole
            // 
            this.checkBoxRole.AutoSize = true;
            this.checkBoxRole.BackColor = System.Drawing.Color.Transparent;
            this.checkBoxRole.Font = new System.Drawing.Font("Microsoft Sans Serif", 7F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.checkBoxRole.Location = new System.Drawing.Point(53, 252);
            this.checkBoxRole.Name = "checkBoxRole";
            this.checkBoxRole.Size = new System.Drawing.Size(126, 17);
            this.checkBoxRole.TabIndex = 9;
            this.checkBoxRole.Text = "Logging As an Admin";
            this.checkBoxRole.UseVisualStyleBackColor = false;
            this.checkBoxRole.CheckedChanged += new System.EventHandler(this.checkBoxRole_CheckedChanged);
            // 
            // btnLogin
            // 
            this.btnLogin.BackColor = System.Drawing.Color.DodgerBlue;
            this.btnLogin.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnLogin.ForeColor = System.Drawing.Color.Snow;
            this.btnLogin.Location = new System.Drawing.Point(53, 286);
            this.btnLogin.Name = "btnLogin";
            this.btnLogin.Size = new System.Drawing.Size(233, 36);
            this.btnLogin.TabIndex = 10;
            this.btnLogin.Text = "LOGIN";
            this.btnLogin.UseVisualStyleBackColor = false;
            this.btnLogin.Click += new System.EventHandler(this.btnLogin_Click);
            // 
            // labelRegister
            // 
            this.labelRegister.BackColor = System.Drawing.Color.Transparent;
            this.labelRegister.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.labelRegister.Font = new System.Drawing.Font("Microsoft Sans Serif", 7F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelRegister.Location = new System.Drawing.Point(61, 333);
            this.labelRegister.Name = "labelRegister";
            this.labelRegister.Size = new System.Drawing.Size(171, 23);
            this.labelRegister.TabIndex = 11;
            this.labelRegister.Text = "You Don\'t have an Account ?";
            this.labelRegister.Click += new System.EventHandler(this.label5_Click_1);
            // 
            // lnkRegister
            // 
            this.lnkRegister.AutoSize = true;
            this.lnkRegister.BackColor = System.Drawing.Color.Transparent;
            this.lnkRegister.Location = new System.Drawing.Point(205, 333);
            this.lnkRegister.Name = "lnkRegister";
            this.lnkRegister.Size = new System.Drawing.Size(71, 13);
            this.lnkRegister.TabIndex = 12;
            this.lnkRegister.TabStop = true;
            this.lnkRegister.Text = "Register Now";
            this.lnkRegister.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.lnkRegister_LinkClicked);
            // 
            // LoginForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.MenuHighlight;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(806, 441);
            this.Controls.Add(this.lnkRegister);
            this.Controls.Add(this.labelRegister);
            this.Controls.Add(this.btnLogin);
            this.Controls.Add(this.checkBoxRole);
            this.Controls.Add(this.txtPassword);
            this.Controls.Add(this.labelPassword);
            this.Controls.Add(this.txtMobileNumber);
            this.Controls.Add(this.labelMobileNumber);
            this.Controls.Add(this.LoginFormTitle1);
            this.Controls.Add(this.LoginFormTitle2);
            this.Name = "LoginForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "LoginForm";
            this.Load += new System.EventHandler(this.LoginForm_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label LoginFormTitle2;
        private System.Windows.Forms.Label LoginFormTitle1;
        private System.Windows.Forms.Label labelMobileNumber;
        private System.Windows.Forms.TextBox txtMobileNumber;
        private System.Windows.Forms.TextBox txtPassword;
        private System.Windows.Forms.Label labelPassword;
        private System.Windows.Forms.CheckBox checkBoxRole;
        private System.Windows.Forms.Button btnLogin;
        private System.Windows.Forms.Label labelRegister;
        private System.Windows.Forms.LinkLabel lnkRegister;
    }
}