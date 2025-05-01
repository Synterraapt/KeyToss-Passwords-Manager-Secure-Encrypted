namespace Password_Manager_WF.Controls
{
    partial class AllItemsControl
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
            this.Website = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.Username = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.Password = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.Category = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.panel12 = new System.Windows.Forms.Panel();
            this.label29 = new System.Windows.Forms.Label();
            this.searchBar = new System.Windows.Forms.TextBox();
            this.DeleteButton = new System.Windows.Forms.Button();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.pictureBox6 = new System.Windows.Forms.PictureBox();
            this.passwordServiceBindingSource = new System.Windows.Forms.BindingSource(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox6)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.passwordServiceBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // allItems
            // 
            this.allItems.AccessibleName = "textListView";
            this.allItems.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.allItems.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.Website,
            this.Username,
            this.Password,
            this.Category});
            this.allItems.Font = new System.Drawing.Font("Roboto Condensed", 24F, System.Drawing.FontStyle.Bold);
            this.allItems.ForeColor = System.Drawing.SystemColors.MenuHighlight;
            this.allItems.FullRowSelect = true;
            this.allItems.HideSelection = false;
            this.allItems.Location = new System.Drawing.Point(54, 198);
            this.allItems.Name = "allItems";
            this.allItems.Size = new System.Drawing.Size(1178, 591);
            this.allItems.TabIndex = 0;
            this.allItems.UseCompatibleStateImageBehavior = false;
            this.allItems.View = System.Windows.Forms.View.Details;
            // 
            // Website
            // 
            this.Website.Text = "Website";
            this.Website.Width = 252;
            // 
            // Username
            // 
            this.Username.Text = "Username";
            this.Username.Width = 331;
            // 
            // Password
            // 
            this.Password.Text = "Password";
            this.Password.Width = 297;
            // 
            // Category
            // 
            this.Category.Text = "Category";
            this.Category.Width = 264;
            // 
            // panel12
            // 
            this.panel12.BackColor = System.Drawing.Color.Black;
            this.panel12.Location = new System.Drawing.Point(627, 32);
            this.panel12.Name = "panel12";
            this.panel12.Size = new System.Drawing.Size(1, 72);
            this.panel12.TabIndex = 35;
            // 
            // label29
            // 
            this.label29.AutoSize = true;
            this.label29.Font = new System.Drawing.Font("Roboto Condensed", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label29.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(123)))), ((int)(((byte)(255)))));
            this.label29.Location = new System.Drawing.Point(644, 47);
            this.label29.Name = "label29";
            this.label29.Size = new System.Drawing.Size(100, 38);
            this.label29.TabIndex = 34;
            this.label29.Text = "ITEMS";
            // 
            // searchBar
            // 
            this.searchBar.AccessibleName = "searchBar";
            this.searchBar.Location = new System.Drawing.Point(457, 133);
            this.searchBar.Name = "searchBar";
            this.searchBar.Size = new System.Drawing.Size(231, 20);
            this.searchBar.TabIndex = 38;
            // 
            // DeleteButton
            // 
            this.DeleteButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(123)))), ((int)(((byte)(255)))));
            this.DeleteButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.DeleteButton.Font = new System.Drawing.Font("Roboto Condensed", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.DeleteButton.ForeColor = System.Drawing.Color.White;
            this.DeleteButton.Location = new System.Drawing.Point(703, 127);
            this.DeleteButton.Name = "DeleteButton";
            this.DeleteButton.Size = new System.Drawing.Size(101, 32);
            this.DeleteButton.TabIndex = 65;
            this.DeleteButton.Text = "SEARCH";
            this.DeleteButton.UseVisualStyleBackColor = false;
            this.DeleteButton.Click += new System.EventHandler(this.searchOnClick);
            // 
            // pictureBox2
            // 
            this.pictureBox2.Cursor = System.Windows.Forms.Cursors.Hand;
            this.pictureBox2.Image = global::Password_Manager_WF.Properties.Resources.delete_note_svgrepo_com__1_;
            this.pictureBox2.Location = new System.Drawing.Point(645, 795);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(41, 43);
            this.pictureBox2.TabIndex = 66;
            this.pictureBox2.TabStop = false;
            this.pictureBox2.Click += new System.EventHandler(this.deleteItemOnClick);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Cursor = System.Windows.Forms.Cursors.Hand;
            this.pictureBox1.Image = global::Password_Manager_WF.Properties.Resources.add_circle_svgrepo_com__1_;
            this.pictureBox1.Location = new System.Drawing.Point(598, 795);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(41, 43);
            this.pictureBox1.TabIndex = 36;
            this.pictureBox1.TabStop = false;
            this.pictureBox1.Click += new System.EventHandler(this.AddButtonOnClick);
            // 
            // pictureBox6
            // 
            this.pictureBox6.Image = global::Password_Manager_WF.Properties.Resources.pngegg;
            this.pictureBox6.Location = new System.Drawing.Point(523, 32);
            this.pictureBox6.Name = "pictureBox6";
            this.pictureBox6.Size = new System.Drawing.Size(87, 71);
            this.pictureBox6.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox6.TabIndex = 33;
            this.pictureBox6.TabStop = false;
            // 
            // passwordServiceBindingSource
            // 
            this.passwordServiceBindingSource.DataSource = typeof(PasswordManager.Services.PasswordService);
            // 
            // AllItemsControl
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.Controls.Add(this.pictureBox2);
            this.Controls.Add(this.DeleteButton);
            this.Controls.Add(this.searchBar);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.panel12);
            this.Controls.Add(this.label29);
            this.Controls.Add(this.pictureBox6);
            this.Controls.Add(this.allItems);
            this.Name = "AllItemsControl";
            this.Size = new System.Drawing.Size(1235, 836);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox6)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.passwordServiceBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListView allItems;
        private System.Windows.Forms.Panel panel12;
        private System.Windows.Forms.Label label29;
        private System.Windows.Forms.PictureBox pictureBox6;
        private System.Windows.Forms.ColumnHeader Website;
        private System.Windows.Forms.ColumnHeader Username;
        private System.Windows.Forms.ColumnHeader Password;
        private System.Windows.Forms.ColumnHeader Category;
        private System.Windows.Forms.BindingSource passwordServiceBindingSource;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.TextBox searchBar;
        private System.Windows.Forms.Button DeleteButton;
        private System.Windows.Forms.PictureBox pictureBox2;
    }
}
