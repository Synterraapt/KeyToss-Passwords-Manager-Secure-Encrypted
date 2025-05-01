namespace Password_Manager_WF.Controls
{
    partial class MasterpasswordControl
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
            this.button1 = new System.Windows.Forms.Button();
            this.oldMasterPw = new System.Windows.Forms.TextBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.label27 = new System.Windows.Forms.Label();
            this.label28 = new System.Windows.Forms.Label();
            this.panel12 = new System.Windows.Forms.Panel();
            this.label29 = new System.Windows.Forms.Label();
            this.pictureBox6 = new System.Windows.Forms.PictureBox();
            this.newMasterPw = new System.Windows.Forms.TextBox();
            this.panel2 = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.newMasterPwConfirm = new System.Windows.Forms.TextBox();
            this.panel3 = new System.Windows.Forms.Panel();
            this.label2 = new System.Windows.Forms.Label();
            this.toastNotificationsManager1 = new DevExpress.XtraBars.ToastNotifications.ToastNotificationsManager(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox6)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.toastNotificationsManager1)).BeginInit();
            this.SuspendLayout();
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(123)))), ((int)(((byte)(255)))));
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button1.Font = new System.Drawing.Font("Roboto Condensed", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.ForeColor = System.Drawing.Color.White;
            this.button1.Location = new System.Drawing.Point(614, 806);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(101, 32);
            this.button1.TabIndex = 48;
            this.button1.Text = "SAVE";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.MpChangedOnClick);
            // 
            // oldMasterPw
            // 
            this.oldMasterPw.AccessibleName = "txtMasterPassword";
            this.oldMasterPw.BackColor = System.Drawing.Color.White;
            this.oldMasterPw.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.oldMasterPw.Font = new System.Drawing.Font("Roboto Condensed", 27.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.oldMasterPw.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(123)))), ((int)(((byte)(255)))));
            this.oldMasterPw.Location = new System.Drawing.Point(403, 346);
            this.oldMasterPw.MaxLength = 25;
            this.oldMasterPw.Name = "oldMasterPw";
            this.oldMasterPw.Size = new System.Drawing.Size(497, 45);
            this.oldMasterPw.TabIndex = 47;
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(123)))), ((int)(((byte)(255)))));
            this.panel1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.panel1.Location = new System.Drawing.Point(403, 399);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(500, 1);
            this.panel1.TabIndex = 46;
            // 
            // label27
            // 
            this.label27.AutoSize = true;
            this.label27.Font = new System.Drawing.Font("Roboto Condensed", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label27.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(123)))), ((int)(((byte)(255)))));
            this.label27.Location = new System.Drawing.Point(498, 273);
            this.label27.Name = "label27";
            this.label27.Size = new System.Drawing.Size(297, 38);
            this.label27.TabIndex = 45;
            this.label27.Text = "Old master password:";
            this.label27.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // label28
            // 
            this.label28.AutoSize = true;
            this.label28.Font = new System.Drawing.Font("Roboto Condensed", 48F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label28.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(123)))), ((int)(((byte)(255)))));
            this.label28.Location = new System.Drawing.Point(158, 164);
            this.label28.Name = "label28";
            this.label28.Size = new System.Drawing.Size(965, 77);
            this.label28.TabIndex = 44;
            this.label28.Text = "CHANGE YOUR MASTER PASSWORD";
            // 
            // panel12
            // 
            this.panel12.BackColor = System.Drawing.Color.Black;
            this.panel12.Location = new System.Drawing.Point(546, 32);
            this.panel12.Name = "panel12";
            this.panel12.Size = new System.Drawing.Size(1, 72);
            this.panel12.TabIndex = 43;
            // 
            // label29
            // 
            this.label29.AutoSize = true;
            this.label29.Font = new System.Drawing.Font("Roboto Condensed", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label29.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(123)))), ((int)(((byte)(255)))));
            this.label29.Location = new System.Drawing.Point(563, 47);
            this.label29.Name = "label29";
            this.label29.Size = new System.Drawing.Size(282, 38);
            this.label29.TabIndex = 42;
            this.label29.Text = "MASTER PASSWORD";
            // 
            // pictureBox6
            // 
            this.pictureBox6.Image = global::Password_Manager_WF.Properties.Resources.pngegg;
            this.pictureBox6.Location = new System.Drawing.Point(442, 32);
            this.pictureBox6.Name = "pictureBox6";
            this.pictureBox6.Size = new System.Drawing.Size(87, 71);
            this.pictureBox6.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox6.TabIndex = 41;
            this.pictureBox6.TabStop = false;
            // 
            // newMasterPw
            // 
            this.newMasterPw.AccessibleName = "txtMasterPassword";
            this.newMasterPw.BackColor = System.Drawing.Color.White;
            this.newMasterPw.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.newMasterPw.Font = new System.Drawing.Font("Roboto Condensed", 27.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.newMasterPw.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(123)))), ((int)(((byte)(255)))));
            this.newMasterPw.Location = new System.Drawing.Point(403, 526);
            this.newMasterPw.MaxLength = 25;
            this.newMasterPw.Name = "newMasterPw";
            this.newMasterPw.Size = new System.Drawing.Size(497, 45);
            this.newMasterPw.TabIndex = 50;
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(123)))), ((int)(((byte)(255)))));
            this.panel2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.panel2.Location = new System.Drawing.Point(403, 579);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(500, 1);
            this.panel2.TabIndex = 49;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Roboto Condensed", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(123)))), ((int)(((byte)(255)))));
            this.label1.Location = new System.Drawing.Point(498, 453);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(309, 38);
            this.label1.TabIndex = 48;
            this.label1.Text = "New master password:";
            this.label1.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // newMasterPwConfirm
            // 
            this.newMasterPwConfirm.AccessibleName = "txtMasterPassword";
            this.newMasterPwConfirm.BackColor = System.Drawing.Color.White;
            this.newMasterPwConfirm.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.newMasterPwConfirm.Font = new System.Drawing.Font("Roboto Condensed", 27.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.newMasterPwConfirm.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(123)))), ((int)(((byte)(255)))));
            this.newMasterPwConfirm.Location = new System.Drawing.Point(406, 707);
            this.newMasterPwConfirm.MaxLength = 25;
            this.newMasterPwConfirm.Name = "newMasterPwConfirm";
            this.newMasterPwConfirm.Size = new System.Drawing.Size(497, 45);
            this.newMasterPwConfirm.TabIndex = 53;
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(123)))), ((int)(((byte)(255)))));
            this.panel3.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.panel3.Location = new System.Drawing.Point(406, 760);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(500, 1);
            this.panel3.TabIndex = 52;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Roboto Condensed", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(123)))), ((int)(((byte)(255)))));
            this.label2.Location = new System.Drawing.Point(459, 634);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(401, 38);
            this.label2.TabIndex = 51;
            this.label2.Text = "Repeat new master password:";
            this.label2.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // toastNotificationsManager1
            // 
            this.toastNotificationsManager1.ApplicationId = "Password Manager";
            this.toastNotificationsManager1.Notifications.AddRange(new DevExpress.XtraBars.ToastNotifications.IToastNotificationProperties[] {
            new DevExpress.XtraBars.ToastNotifications.ToastNotification("345efb63-9e01-443c-b0cf-755278c4832d", global::Password_Manager_WF.Properties.Resources.warning_svgrepo_com, "Fields can\'t be empty!", "Please fill in all fields.", "", DevExpress.XtraBars.ToastNotifications.ToastNotificationTemplate.ImageAndText02),
            new DevExpress.XtraBars.ToastNotifications.ToastNotification("4a211faf-9d32-4cce-bcaf-4c8ade2cd07c", global::Password_Manager_WF.Properties.Resources.success_svgrepo_com, "Successfully changed master password!", "Please login again.", "", DevExpress.XtraBars.ToastNotifications.ToastNotificationTemplate.ImageAndText02),
            new DevExpress.XtraBars.ToastNotifications.ToastNotification("f419951b-a23d-4e9b-a3ca-cc0f32486652", global::Password_Manager_WF.Properties.Resources.error_svgrepo_com, "Incorrect current master password!", "Please try again.", "", DevExpress.XtraBars.ToastNotifications.ToastNotificationTemplate.ImageAndText02),
            new DevExpress.XtraBars.ToastNotifications.ToastNotification("7f6a8153-3d9e-4d74-be66-2f13b6d196f0", global::Password_Manager_WF.Properties.Resources.error_svgrepo_com, "Passwords do not match!", "Please try again.", "", DevExpress.XtraBars.ToastNotifications.ToastNotificationTemplate.ImageAndText02)});
            // 
            // MasterpasswordControl
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.Controls.Add(this.newMasterPwConfirm);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.newMasterPw);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.oldMasterPw);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.label27);
            this.Controls.Add(this.label28);
            this.Controls.Add(this.panel12);
            this.Controls.Add(this.label29);
            this.Controls.Add(this.pictureBox6);
            this.Name = "MasterpasswordControl";
            this.Size = new System.Drawing.Size(1131, 922);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox6)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.toastNotificationsManager1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.TextBox oldMasterPw;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label27;
        private System.Windows.Forms.Label label28;
        private System.Windows.Forms.Panel panel12;
        private System.Windows.Forms.Label label29;
        private System.Windows.Forms.PictureBox pictureBox6;
        private System.Windows.Forms.TextBox newMasterPw;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox newMasterPwConfirm;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Label label2;
        private DevExpress.XtraBars.ToastNotifications.ToastNotificationsManager toastNotificationsManager1;
    }
}
