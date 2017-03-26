namespace SelfMailer.Controls
{
    partial class MailProperties
    {
        /// <summary> 
        /// Variable nécessaire au concepteur.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary> 
        /// Nettoyage des ressources utilisées.
        /// </summary>
        /// <param name="disposing">true si les ressources managées doivent être supprimées ; sinon, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Code généré par le Concepteur de composants

        /// <summary> 
        /// Méthode requise pour la prise en charge du concepteur - ne modifiez pas 
        /// le contenu de cette méthode avec l'éditeur de code.
        /// </summary>
        private void InitializeComponent()
        {
            this.lblSendType = new System.Windows.Forms.Label();
            this.SendType = new System.Windows.Forms.ComboBox();
            this.MailContent = new System.Windows.Forms.GroupBox();
            this.lblSubject = new System.Windows.Forms.Label();
            this.Subject = new System.Windows.Forms.TextBox();
            this.lblBody = new System.Windows.Forms.Label();
            this.LoadBody = new System.Windows.Forms.Button();
            this.PreviewBody = new System.Windows.Forms.Button();
            this.MailContent.SuspendLayout();
            this.SuspendLayout();
            // 
            // lblSendType
            // 
            this.lblSendType.AutoSize = true;
            this.lblSendType.Location = new System.Drawing.Point(4, 31);
            this.lblSendType.Name = "lblSendType";
            this.lblSendType.Size = new System.Drawing.Size(74, 13);
            this.lblSendType.TabIndex = 0;
            this.lblSendType.Text = "Type d\'envoi :\r\n";
            // 
            // SendType
            // 
            this.SendType.AllowDrop = true;
            this.SendType.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.SendType.FormattingEnabled = true;
            this.SendType.Location = new System.Drawing.Point(84, 23);
            this.SendType.Name = "SendType";
            this.SendType.Size = new System.Drawing.Size(210, 21);
            this.SendType.TabIndex = 1;
            // 
            // MailContent
            // 
            this.MailContent.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.MailContent.Controls.Add(this.PreviewBody);
            this.MailContent.Controls.Add(this.LoadBody);
            this.MailContent.Controls.Add(this.lblBody);
            this.MailContent.Controls.Add(this.Subject);
            this.MailContent.Controls.Add(this.lblSubject);
            this.MailContent.Enabled = false;
            this.MailContent.Location = new System.Drawing.Point(7, 61);
            this.MailContent.Name = "MailContent";
            this.MailContent.Size = new System.Drawing.Size(291, 128);
            this.MailContent.TabIndex = 2;
            this.MailContent.TabStop = false;
            this.MailContent.Text = "Contenu";
            // 
            // lblSubject
            // 
            this.lblSubject.AutoSize = true;
            this.lblSubject.Location = new System.Drawing.Point(7, 20);
            this.lblSubject.Name = "lblSubject";
            this.lblSubject.Size = new System.Drawing.Size(40, 13);
            this.lblSubject.TabIndex = 0;
            this.lblSubject.Text = "Sujet : ";
            // 
            // Subject
            // 
            this.Subject.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.Subject.Location = new System.Drawing.Point(77, 17);
            this.Subject.Name = "Subject";
            this.Subject.Size = new System.Drawing.Size(208, 20);
            this.Subject.TabIndex = 1;
            // 
            // lblBody
            // 
            this.lblBody.AutoSize = true;
            this.lblBody.Location = new System.Drawing.Point(10, 48);
            this.lblBody.Name = "lblBody";
            this.lblBody.Size = new System.Drawing.Size(43, 13);
            this.lblBody.TabIndex = 2;
            this.lblBody.Text = "Corps : ";
            // 
            // LoadBody
            // 
            this.LoadBody.Location = new System.Drawing.Point(77, 48);
            this.LoadBody.Name = "LoadBody";
            this.LoadBody.Size = new System.Drawing.Size(75, 23);
            this.LoadBody.TabIndex = 3;
            this.LoadBody.Text = "Parcourir...";
            this.LoadBody.UseVisualStyleBackColor = true;
            // 
            // PreviewBody
            // 
            this.PreviewBody.Location = new System.Drawing.Point(212, 48);
            this.PreviewBody.Name = "PreviewBody";
            this.PreviewBody.Size = new System.Drawing.Size(75, 23);
            this.PreviewBody.TabIndex = 4;
            this.PreviewBody.Text = "Aperçu";
            this.PreviewBody.UseVisualStyleBackColor = true;
            // 
            // MailProperties
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.MailContent);
            this.Controls.Add(this.SendType);
            this.Controls.Add(this.lblSendType);
            this.Name = "MailProperties";
            this.Size = new System.Drawing.Size(357, 198);
            this.MailContent.ResumeLayout(false);
            this.MailContent.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblSendType;
        private System.Windows.Forms.ComboBox SendType;
        private System.Windows.Forms.GroupBox MailContent;
        private System.Windows.Forms.Button PreviewBody;
        private System.Windows.Forms.Button LoadBody;
        private System.Windows.Forms.Label lblBody;
        private System.Windows.Forms.TextBox Subject;
        private System.Windows.Forms.Label lblSubject;
    }
}
