namespace SelfMailer.Forms
{
    partial class MailServerSettings
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
            this.components = new System.ComponentModel.Container();
            this.lblFromName = new System.Windows.Forms.Label();
            this.lblFromEmail = new System.Windows.Forms.Label();
            this.lblHost = new System.Windows.Forms.Label();
            this.lblUsername = new System.Windows.Forms.Label();
            this.lblPassword = new System.Windows.Forms.Label();
            this.FromName = new System.Windows.Forms.TextBox();
            this.FromEmail = new System.Windows.Forms.TextBox();
            this.Host = new System.Windows.Forms.TextBox();
            this.Username = new System.Windows.Forms.TextBox();
            this.Password = new System.Windows.Forms.TextBox();
            this.Valid = new System.Windows.Forms.Button();
            this.Cancel = new System.Windows.Forms.Button();
            this.errorProvider = new System.Windows.Forms.ErrorProvider(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider)).BeginInit();
            this.SuspendLayout();
            // 
            // lblFromName
            // 
            this.lblFromName.AutoSize = true;
            this.lblFromName.Location = new System.Drawing.Point(0, 2);
            this.lblFromName.Name = "lblFromName";
            this.lblFromName.Size = new System.Drawing.Size(56, 13);
            this.lblFromName.TabIndex = 0;
            this.lblFromName.Text = "Nom Exp :";
            // 
            // lblFromEmail
            // 
            this.lblFromEmail.AutoSize = true;
            this.lblFromEmail.Location = new System.Drawing.Point(0, 28);
            this.lblFromEmail.Name = "lblFromEmail";
            this.lblFromEmail.Size = new System.Drawing.Size(53, 13);
            this.lblFromEmail.TabIndex = 1;
            this.lblFromEmail.Text = "Email Exp";
            // 
            // lblHost
            // 
            this.lblHost.AutoSize = true;
            this.lblHost.Location = new System.Drawing.Point(0, 54);
            this.lblHost.Name = "lblHost";
            this.lblHost.Size = new System.Drawing.Size(30, 13);
            this.lblHost.TabIndex = 2;
            this.lblHost.Text = "Hôte";
            // 
            // lblUsername
            // 
            this.lblUsername.AutoSize = true;
            this.lblUsername.Location = new System.Drawing.Point(0, 83);
            this.lblUsername.Name = "lblUsername";
            this.lblUsername.Size = new System.Drawing.Size(53, 13);
            this.lblUsername.TabIndex = 3;
            this.lblUsername.Text = "Utilisateur";
            // 
            // lblPassword
            // 
            this.lblPassword.AutoSize = true;
            this.lblPassword.Location = new System.Drawing.Point(0, 113);
            this.lblPassword.Name = "lblPassword";
            this.lblPassword.Size = new System.Drawing.Size(71, 13);
            this.lblPassword.TabIndex = 4;
            this.lblPassword.Text = "Mot de passe";
            // 
            // FromName
            // 
            this.FromName.Location = new System.Drawing.Point(77, 2);
            this.FromName.Name = "FromName";
            this.FromName.Size = new System.Drawing.Size(196, 20);
            this.FromName.TabIndex = 5;
            // 
            // FromEmail
            // 
            this.FromEmail.Location = new System.Drawing.Point(77, 28);
            this.FromEmail.Name = "FromEmail";
            this.FromEmail.Size = new System.Drawing.Size(196, 20);
            this.FromEmail.TabIndex = 6;
            this.FromEmail.Validating += new System.ComponentModel.CancelEventHandler(this.FromEmail_Validating);
            // 
            // Host
            // 
            this.Host.Location = new System.Drawing.Point(77, 54);
            this.Host.Name = "Host";
            this.Host.Size = new System.Drawing.Size(196, 20);
            this.Host.TabIndex = 7;
            this.Host.Click += new System.EventHandler(this.Valid_Click);
            // 
            // Username
            // 
            this.Username.Location = new System.Drawing.Point(77, 83);
            this.Username.Name = "Username";
            this.Username.Size = new System.Drawing.Size(196, 20);
            this.Username.TabIndex = 8;
            // 
            // Password
            // 
            this.Password.Location = new System.Drawing.Point(77, 110);
            this.Password.Name = "Password";
            this.Password.Size = new System.Drawing.Size(196, 20);
            this.Password.TabIndex = 9;
            this.Password.UseSystemPasswordChar = true;
            // 
            // Valid
            // 
            this.Valid.Location = new System.Drawing.Point(158, 139);
            this.Valid.Name = "Valid";
            this.Valid.Size = new System.Drawing.Size(75, 23);
            this.Valid.TabIndex = 10;
            this.Valid.Text = "Valider";
            this.Valid.UseVisualStyleBackColor = true;
            this.Valid.Click += new System.EventHandler(this.Valid_Click);
            // 
            // Cancel
            // 
            this.Cancel.Location = new System.Drawing.Point(252, 139);
            this.Cancel.Name = "Cancel";
            this.Cancel.Size = new System.Drawing.Size(75, 23);
            this.Cancel.TabIndex = 11;
            this.Cancel.Text = "Annuler";
            this.Cancel.UseVisualStyleBackColor = true;
            // 
            // errorProvider
            // 
            this.errorProvider.ContainerControl = this;
            // 
            // MailServerSettings
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(339, 166);
            this.Controls.Add(this.Cancel);
            this.Controls.Add(this.Valid);
            this.Controls.Add(this.Password);
            this.Controls.Add(this.Username);
            this.Controls.Add(this.Host);
            this.Controls.Add(this.FromEmail);
            this.Controls.Add(this.FromName);
            this.Controls.Add(this.lblPassword);
            this.Controls.Add(this.lblUsername);
            this.Controls.Add(this.lblHost);
            this.Controls.Add(this.lblFromEmail);
            this.Controls.Add(this.lblFromName);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Name = "MailServerSettings";
            this.ShowInTaskbar = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Paramètres du serveur mail";
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblFromName;
        private System.Windows.Forms.Label lblFromEmail;
        private System.Windows.Forms.Label lblHost;
        private System.Windows.Forms.Label lblUsername;
        private System.Windows.Forms.Label lblPassword;
        private System.Windows.Forms.TextBox FromName;
        private System.Windows.Forms.TextBox FromEmail;
        private System.Windows.Forms.TextBox Host;
        private System.Windows.Forms.TextBox Username;
        private System.Windows.Forms.TextBox Password;
        private System.Windows.Forms.Button Valid;
        private System.Windows.Forms.Button Cancel;
        private System.Windows.Forms.ErrorProvider errorProvider;
    }
}