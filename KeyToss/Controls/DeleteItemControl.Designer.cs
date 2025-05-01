namespace Password_Manager_WF.Controls
{
    partial class DeleteItemControl
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
            this.allItems = new System.Windows.Forms.ListView();
            this.ID = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.Website = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.Username = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.Password = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.Category = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.panel12 = new System.Windows.Forms.Panel();
            this.label29 = new System.Windows.Forms.Label();
            this.pictureBox6 = new System.Windows.Forms.PictureBox();
            this.passwordServiceBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.label28 = new System.Windows.Forms.Label();
            this.IdInput = new System.Windows.Forms.TextBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.label27 = new System.Windows.Forms.Label();
            this.DeleteButton = new System.Windows.Forms.Button();
            this.toastNotificationsManager1 = new DevExpress.XtraBars.ToastNotifications.ToastNotificationsManager(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox6)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.passwordServiceBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.toastNotificationsManager1)).BeginInit();
            this.SuspendLayout();
            // 
            // allItems
            // 
            this.allItems.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.allItems.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.ID,
            this.Website,
            this.Username,
            this.Password,
            this.Category});
            this.allItems.Font = new System.Drawing.Font("Roboto Condensed", 24F, System.Drawing.FontStyle.Bold);
            this.allItems.ForeColor = System.Drawing.SystemColors.MenuHighlight;
            this.allItems.HideSelection = false;
            this.allItems.Location = new System.Drawing.Point(43, 157);
            this.allItems.Name = "allItems";
            this.allItems.Size = new System.Drawing.Size(1149, 246);
            this.allItems.TabIndex = 37;
            this.allItems.UseCompatibleStateImageBehavior = false;
            this.allItems.View = System.Windows.Forms.View.Details;
            // 
            // ID
            // 
            this.ID.Text = "Id";
            this.ID.Width = 73;
            // 
            // Website
            // 
            this.Website.Text = "Website";
            this.Website.Width = 281;
            // 
            // Username
            // 
            this.Username.Text = "Username";
            this.Username.Width = 282;
            // 
            // Password
            // 
            this.Password.Text = "Password";
            this.Password.Width = 351;
            // 
            // Category
            // 
            this.Category.Text = "Category";
            this.Category.Width = 129;
            // 
            // panel12
            // 
            this.panel12.BackColor = System.Drawing.Color.Black;
            this.panel12.Location = new System.Drawing.Point(548, 15);
            this.panel12.Name = "panel12";
            this.panel12.Size = new System.Drawing.Size(1, 72);
            this.panel12.TabIndex = 40;
            // 
            // label29
            // 
            this.label29.AutoSize = true;
            this.label29.Font = new System.Drawing.Font("Roboto Condensed", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label29.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(123)))), ((int)(((byte)(255)))));
            this.label29.Location = new System.Drawing.Point(565, 30);
            this.label29.Name = "label29";
            this.label29.Size = new System.Drawing.Size(188, 38);
            this.label29.TabIndex = 39;
            this.label29.Text = "DELETE ITEM";
            // 
            // pictureBox6
            // 
            this.pictureBox6.Image = global::Password_Manager_WF.Properties.Resources.pngegg;
            this.pictureBox6.Location = new System.Drawing.Point(444, 15);
            this.pictureBox6.Name = "pictureBox6";
            this.pictureBox6.Size = new System.Drawing.Size(87, 71);
            this.pictureBox6.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox6.TabIndex = 38;
            this.pictureBox6.TabStop = false;
            // 
            // passwordServiceBindingSource
            // 
            this.passwordServiceBindingSource.DataSource = typeof(PasswordManager.Services.PasswordService);
            // 
            // label28
            // 
            this.label28.AutoSize = true;
            this.label28.Font = new System.Drawing.Font("Roboto Condensed", 48F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label28.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(123)))), ((int)(((byte)(255)))));
            this.label28.Location = new System.Drawing.Point(385, 459);
            this.label28.Name = "label28";
            this.label28.Size = new System.Drawing.Size(467, 77);
            this.label28.TabIndex = 58;
            this.label28.Text = "DELETE AN ITEM";
            // 
            // IdInput
            // 
            this.IdInput.AccessibleName = "txtIdInput";
            this.IdInput.BackColor = System.Drawing.Color.White;
            this.IdInput.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.IdInput.Font = new System.Drawing.Font("Roboto Condensed", 27.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.IdInput.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(123)))), ((int)(((byte)(255)))));
            this.IdInput.Location = new System.Drawing.Point(371, 635);
            this.IdInput.MaxLength = 25;
            this.IdInput.Name = "IdInput";
            this.IdInput.Size = new System.Drawing.Size(497, 45);
            this.IdInput.TabIndex = 63;
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(123)))), ((int)(((byte)(255)))));
            this.panel1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.panel1.Location = new System.Drawing.Point(371, 688);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(500, 1);
            this.panel1.TabIndex = 62;
            // 
            // label27
            // 
            this.label27.AutoSize = true;
            this.label27.Font = new System.Drawing.Font("Roboto Condensed", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label27.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(123)))), ((int)(((byte)(255)))));
            this.label27.Location = new System.Drawing.Point(599, 562);
            this.label27.Name = "label27";
            this.label27.Size = new System.Drawing.Size(42, 38);
            this.label27.TabIndex = 61;
            this.label27.Text = "Id";
            this.label27.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // DeleteButton
            // 
            this.DeleteButton.BackColor = System.Drawing.Color.Red;
            this.DeleteButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.DeleteButton.Font = new System.Drawing.Font("Roboto Condensed", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.DeleteButton.ForeColor = System.Drawing.Color.White;
            this.DeleteButton.Location = new System.Drawing.Point(567, 795);
            this.DeleteButton.Name = "DeleteButton";
            this.DeleteButton.Size = new System.Drawing.Size(101, 32);
            this.DeleteButton.TabIndex = 64;
            this.DeleteButton.Text = "DELETE";
            this.DeleteButton.UseVisualStyleBackColor = false;
            this.DeleteButton.Click += new System.EventHandler(this.deleteOnClick);
            // 
            // toastNotificationsManager1
            // 
            this.toastNotificationsManager1.ApplicationId = "80b7b249-fc71-4d26-9536-358ec80e458b";
            this.toastNotificationsManager1.Notifications.AddRange(new DevExpress.XtraBars.ToastNotifications.IToastNotificationProperties[] {
            new DevExpress.XtraBars.ToastNotifications.ToastNotification("df6a9ad8-7ad2-41f1-b8aa-1610c00c13ae", global::Password_Manager_WF.Properties.Resources.success_svgrepo_com, "Successfull deleted Item!", "The entry won\'t be in the list anymore.", "", DevExpress.XtraBars.ToastNotifications.ToastNotificationTemplate.ImageAndText02),
            new DevExpress.XtraBars.ToastNotifications.ToastNotification("78696c86-325f-42cc-83e2-1db09312d82c", global::Password_Manager_WF.Properties.Resources.warning_svgrepo_com, "Empty fields are not allowed!", "Please fill out all fields.", "", DevExpress.XtraBars.ToastNotifications.ToastNotificationTemplate.ImageAndText02),
            new DevExpress.XtraBars.ToastNotifications.ToastNotification("4c22e3fd-4146-4a1f-84f7-189275a7fbd3", global::Password_Manager_WF.Properties.Resources.error_svgrepo_com, "Id not found!", "Please check your input again.", "", DevExpress.XtraBars.ToastNotifications.ToastNotificationTemplate.ImageAndText02)});
            // 
            // DeleteItemControl
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.Controls.Add(this.DeleteButton);
            this.Controls.Add(this.IdInput);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.label27);
            this.Controls.Add(this.label28);
            this.Controls.Add(this.allItems);
            this.Controls.Add(this.panel12);
            this.Controls.Add(this.label29);
            this.Controls.Add(this.pictureBox6);
            this.Name = "DeleteItemControl";
            this.Size = new System.Drawing.Size(1235, 836);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox6)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.passwordServiceBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.toastNotificationsManager1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListView allItems;
        private System.Windows.Forms.ColumnHeader Website;
        private System.Windows.Forms.ColumnHeader Username;
        private System.Windows.Forms.ColumnHeader Password;
        private System.Windows.Forms.ColumnHeader Category;
        private System.Windows.Forms.Panel panel12;
        private System.Windows.Forms.Label label29;
        private System.Windows.Forms.PictureBox pictureBox6;
        private System.Windows.Forms.BindingSource passwordServiceBindingSource;
        private System.Windows.Forms.Label label28;
        private System.Windows.Forms.ColumnHeader ID;
        private System.Windows.Forms.TextBox IdInput;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label27;
        private System.Windows.Forms.Button DeleteButton;
        private DevExpress.XtraBars.ToastNotifications.ToastNotificationsManager toastNotificationsManager1;
    }
}
