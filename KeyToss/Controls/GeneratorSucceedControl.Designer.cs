namespace Password_Manager_WF.Controls
{
    partial class GeneratorSucceedControl
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.passwordBox = new System.Windows.Forms.TextBox();
            this.label27 = new System.Windows.Forms.Label();
            this.label28 = new System.Windows.Forms.Label();
            this.panel12 = new System.Windows.Forms.Panel();
            this.label29 = new System.Windows.Forms.Label();
            this.copyToClipboard = new System.Windows.Forms.PictureBox();
            this.pictureBox6 = new System.Windows.Forms.PictureBox();
            this.toastNotificationsManager1 = new DevExpress.XtraBars.ToastNotifications.ToastNotificationsManager(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.copyToClipboard)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox6)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.toastNotificationsManager1)).BeginInit();
            this.SuspendLayout();
            // 
            // passwordBox
            // 
            this.passwordBox.AccessibleName = "txtMasterPassword";
            this.passwordBox.BackColor = System.Drawing.Color.White;
            this.passwordBox.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.passwordBox.Font = new System.Drawing.Font("Roboto Condensed", 27.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.passwordBox.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(123)))), ((int)(((byte)(255)))));
            this.passwordBox.Location = new System.Drawing.Point(450, 409);
            this.passwordBox.MaxLength = 25;
            this.passwordBox.Name = "passwordBox";
            this.passwordBox.Size = new System.Drawing.Size(305, 45);
            this.passwordBox.TabIndex = 47;
            this.passwordBox.TextChanged += new System.EventHandler(this.passwordBox_TextChanged);
            // 
            // label27
            // 
            this.label27.AutoSize = true;
            this.label27.Font = new System.Drawing.Font("Roboto Condensed", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label27.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(123)))), ((int)(((byte)(255)))));
            this.label27.Location = new System.Drawing.Point(488, 324);
            this.label27.Name = "label27";
            this.label27.Size = new System.Drawing.Size(289, 38);
            this.label27.TabIndex = 45;
            this.label27.Text = "Generated password:";
            // 
            // label28
            // 
            this.label28.AutoSize = true;
            this.label28.Font = new System.Drawing.Font("Roboto Condensed", 48F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label28.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(123)))), ((int)(((byte)(255)))));
            this.label28.Location = new System.Drawing.Point(254, 238);
            this.label28.Name = "label28";
            this.label28.Size = new System.Drawing.Size(794, 77);
            this.label28.TabIndex = 44;
            this.label28.Text = "GENERATE YOUR PASSWORD!";
            // 
            // panel12
            // 
            this.panel12.BackColor = System.Drawing.Color.Black;
            this.panel12.Location = new System.Drawing.Point(627, 32);
            this.panel12.Name = "panel12";
            this.panel12.Size = new System.Drawing.Size(1, 72);
            this.panel12.TabIndex = 43;
            // 
            // label29
            // 
            this.label29.AutoSize = true;
            this.label29.Font = new System.Drawing.Font("Roboto Condensed", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label29.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(123)))), ((int)(((byte)(255)))));
            this.label29.Location = new System.Drawing.Point(644, 47);
            this.label29.Name = "label29";
            this.label29.Size = new System.Drawing.Size(156, 38);
            this.label29.TabIndex = 42;
            this.label29.Text = "GENERATE";
            // 
            // copyToClipboard
            // 
            this.copyToClipboard.Cursor = System.Windows.Forms.Cursors.Hand;
            this.copyToClipboard.Image = global::Password_Manager_WF.Properties.Resources.copy_svgrepo_com__1_;
            this.copyToClipboard.Location = new System.Drawing.Point(771, 418);
            this.copyToClipboard.Name = "copyToClipboard";
            this.copyToClipboard.Size = new System.Drawing.Size(28, 27);
            this.copyToClipboard.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.copyToClipboard.TabIndex = 48;
            this.copyToClipboard.TabStop = false;
            this.copyToClipboard.Click += new System.EventHandler(this.CopyToClipboard);
            // 
            // pictureBox6
            // 
            this.pictureBox6.Image = global::Password_Manager_WF.Properties.Resources.pngegg;
            this.pictureBox6.Location = new System.Drawing.Point(523, 32);
            this.pictureBox6.Name = "pictureBox6";
            this.pictureBox6.Size = new System.Drawing.Size(87, 71);
            this.pictureBox6.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox6.TabIndex = 41;
            this.pictureBox6.TabStop = false;
            // 
            // toastNotificationsManager1
            // 
            this.toastNotificationsManager1.ApplicationId = "80b7b249-fc71-4d26-9536-358ec80e458b";
            this.toastNotificationsManager1.Notifications.AddRange(new DevExpress.XtraBars.ToastNotifications.IToastNotificationProperties[] {
            new DevExpress.XtraBars.ToastNotifications.ToastNotification("a5a040b7-e4d6-4682-8ed2-9b49b008c996", global::Password_Manager_WF.Properties.Resources.success_svgrepo_com, "Password copied!", "copied to your clipboard.", "", DevExpress.XtraBars.ToastNotifications.ToastNotificationTemplate.ImageAndText02)});
            // 
            // GeneratorSucceedControl
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.Controls.Add(this.copyToClipboard);
            this.Controls.Add(this.passwordBox);
            this.Controls.Add(this.label27);
            this.Controls.Add(this.label28);
            this.Controls.Add(this.panel12);
            this.Controls.Add(this.label29);
            this.Controls.Add(this.pictureBox6);
            this.Name = "GeneratorSucceedControl";
            this.Size = new System.Drawing.Size(1124, 697);
            ((System.ComponentModel.ISupportInitialize)(this.copyToClipboard)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox6)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.toastNotificationsManager1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.TextBox passwordBox;
        private System.Windows.Forms.Label label27;
        private System.Windows.Forms.Label label28;
        private System.Windows.Forms.Panel panel12;
        private System.Windows.Forms.Label label29;
        private System.Windows.Forms.PictureBox pictureBox6;
        private System.Windows.Forms.PictureBox copyToClipboard;
        private DevExpress.XtraBars.ToastNotifications.ToastNotificationsManager toastNotificationsManager1;
    }
}
