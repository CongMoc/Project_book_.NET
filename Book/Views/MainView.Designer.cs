namespace Book.Views
{
    partial class MainView
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainView));
            this.tsbUser = new System.Windows.Forms.ToolStrip();
            this.tsbbtnMonbook = new System.Windows.Forms.ToolStripButton();
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.tsbbtnCart = new System.Windows.Forms.ToolStripButton();
            this.tsbbtnHistoryOrder = new System.Windows.Forms.ToolStripButton();
            this.tsbbtnLogOut = new System.Windows.Forms.ToolStripButton();
            this.toolStripSeparator3 = new System.Windows.Forms.ToolStripSeparator();
            this.tsbbtnIDUser = new System.Windows.Forms.ToolStripLabel();
            this.tsbbtnMyProfile = new System.Windows.Forms.ToolStripButton();
            this.tsbbtnManager = new System.Windows.Forms.ToolStripButton();
            this.toolStripSeparator2 = new System.Windows.Forms.ToolStripSeparator();
            this.tsbbtnExit = new System.Windows.Forms.ToolStripButton();
            this.tsbbtnMaximize = new System.Windows.Forms.ToolStripButton();
            this.tsbbtnMinimize = new System.Windows.Forms.ToolStripButton();
            this.tsbbtnPublisher = new System.Windows.Forms.ToolStripButton();
            this.tsbbtnStoryMon = new System.Windows.Forms.ToolStripButton();
            this.toolStrip1 = new System.Windows.Forms.ToolStrip();
            this.elipseControl1 = new iLearnVocabProv1._0.ElipseControl();
            this.tsbUser.SuspendLayout();
            this.toolStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // tsbUser
            // 
            this.tsbUser.BackColor = System.Drawing.SystemColors.Control;
            this.tsbUser.Dock = System.Windows.Forms.DockStyle.Left;
            this.tsbUser.GripStyle = System.Windows.Forms.ToolStripGripStyle.Hidden;
            this.tsbUser.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tsbbtnMonbook,
            this.toolStripSeparator1,
            this.tsbbtnCart,
            this.tsbbtnHistoryOrder,
            this.tsbbtnLogOut,
            this.toolStripSeparator3,
            this.tsbbtnIDUser,
            this.tsbbtnMyProfile,
            this.tsbbtnManager,
            this.toolStripSeparator2});
            this.tsbUser.Location = new System.Drawing.Point(0, 0);
            this.tsbUser.Name = "tsbUser";
            this.tsbUser.Size = new System.Drawing.Size(191, 480);
            this.tsbUser.TabIndex = 1;
            // 
            // tsbbtnMonbook
            // 
            this.tsbbtnMonbook.AutoSize = false;
            this.tsbbtnMonbook.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(189)))), ((int)(((byte)(89)))));
            this.tsbbtnMonbook.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tsbbtnMonbook.Image = global::Book.Properties.Resources.rsz_author;
            this.tsbbtnMonbook.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.tsbbtnMonbook.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tsbbtnMonbook.Name = "tsbbtnMonbook";
            this.tsbbtnMonbook.Size = new System.Drawing.Size(190, 68);
            this.tsbbtnMonbook.Text = "MON BOOKS";
            // 
            // toolStripSeparator1
            // 
            this.toolStripSeparator1.Name = "toolStripSeparator1";
            this.toolStripSeparator1.Size = new System.Drawing.Size(188, 6);
            // 
            // tsbbtnCart
            // 
            this.tsbbtnCart.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tsbbtnCart.Image = global::Book.Properties.Resources.cak1;
            this.tsbbtnCart.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.tsbbtnCart.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.tsbbtnCart.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tsbbtnCart.Name = "tsbbtnCart";
            this.tsbbtnCart.Size = new System.Drawing.Size(188, 52);
            this.tsbbtnCart.Text = "Cart";
            this.tsbbtnCart.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // tsbbtnHistoryOrder
            // 
            this.tsbbtnHistoryOrder.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tsbbtnHistoryOrder.Image = global::Book.Properties.Resources.bill1;
            this.tsbbtnHistoryOrder.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.tsbbtnHistoryOrder.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.tsbbtnHistoryOrder.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tsbbtnHistoryOrder.Name = "tsbbtnHistoryOrder";
            this.tsbbtnHistoryOrder.Size = new System.Drawing.Size(188, 52);
            this.tsbbtnHistoryOrder.Text = "History ";
            // 
            // tsbbtnLogOut
            // 
            this.tsbbtnLogOut.Alignment = System.Windows.Forms.ToolStripItemAlignment.Right;
            this.tsbbtnLogOut.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tsbbtnLogOut.Image = global::Book.Properties.Resources._4831032_door_entrance_exit_leave_logout_icon2;
            this.tsbbtnLogOut.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.tsbbtnLogOut.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tsbbtnLogOut.Name = "tsbbtnLogOut";
            this.tsbbtnLogOut.Size = new System.Drawing.Size(188, 36);
            this.tsbbtnLogOut.Text = "Log Out";
            this.tsbbtnLogOut.Click += new System.EventHandler(this.tsbbtnLogOut_Click);
            // 
            // toolStripSeparator3
            // 
            this.toolStripSeparator3.Alignment = System.Windows.Forms.ToolStripItemAlignment.Right;
            this.toolStripSeparator3.Name = "toolStripSeparator3";
            this.toolStripSeparator3.Size = new System.Drawing.Size(188, 6);
            // 
            // tsbbtnIDUser
            // 
            this.tsbbtnIDUser.Alignment = System.Windows.Forms.ToolStripItemAlignment.Right;
            this.tsbbtnIDUser.Font = new System.Drawing.Font("Times New Roman", 9F, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tsbbtnIDUser.Name = "tsbbtnIDUser";
            this.tsbbtnIDUser.Size = new System.Drawing.Size(188, 15);
            this.tsbbtnIDUser.Text = "ID Cus";
            // 
            // tsbbtnMyProfile
            // 
            this.tsbbtnMyProfile.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tsbbtnMyProfile.Image = global::Book.Properties.Resources.pro;
            this.tsbbtnMyProfile.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.tsbbtnMyProfile.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.tsbbtnMyProfile.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tsbbtnMyProfile.Name = "tsbbtnMyProfile";
            this.tsbbtnMyProfile.Size = new System.Drawing.Size(188, 52);
            this.tsbbtnMyProfile.Text = "My Profile";
            this.tsbbtnMyProfile.Click += new System.EventHandler(this.tsbbtnMyProfile_Click);
            // 
            // tsbbtnManager
            // 
            this.tsbbtnManager.AutoSize = false;
            this.tsbbtnManager.Enabled = false;
            this.tsbbtnManager.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tsbbtnManager.Image = global::Book.Properties.Resources.Task;
            this.tsbbtnManager.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.tsbbtnManager.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.tsbbtnManager.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tsbbtnManager.Name = "tsbbtnManager";
            this.tsbbtnManager.Size = new System.Drawing.Size(188, 52);
            this.tsbbtnManager.Text = "Manager";
            // 
            // toolStripSeparator2
            // 
            this.toolStripSeparator2.Alignment = System.Windows.Forms.ToolStripItemAlignment.Right;
            this.toolStripSeparator2.Name = "toolStripSeparator2";
            this.toolStripSeparator2.Size = new System.Drawing.Size(188, 6);
            // 
            // tsbbtnExit
            // 
            this.tsbbtnExit.Alignment = System.Windows.Forms.ToolStripItemAlignment.Right;
            this.tsbbtnExit.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.tsbbtnExit.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tsbbtnExit.Image = global::Book.Properties.Resources.exit;
            this.tsbbtnExit.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.tsbbtnExit.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tsbbtnExit.Name = "tsbbtnExit";
            this.tsbbtnExit.Size = new System.Drawing.Size(28, 71);
            this.tsbbtnExit.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.tsbbtnExit.Click += new System.EventHandler(this.tsbbtnExit_Click);
            // 
            // tsbbtnMaximize
            // 
            this.tsbbtnMaximize.Alignment = System.Windows.Forms.ToolStripItemAlignment.Right;
            this.tsbbtnMaximize.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.tsbbtnMaximize.Image = global::Book.Properties.Resources.maxi;
            this.tsbbtnMaximize.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.tsbbtnMaximize.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.tsbbtnMaximize.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tsbbtnMaximize.Name = "tsbbtnMaximize";
            this.tsbbtnMaximize.Size = new System.Drawing.Size(28, 71);
            this.tsbbtnMaximize.Text = "Maximize";
            this.tsbbtnMaximize.Click += new System.EventHandler(this.tsbbtnMaximize_Click);
            // 
            // tsbbtnMinimize
            // 
            this.tsbbtnMinimize.Alignment = System.Windows.Forms.ToolStripItemAlignment.Right;
            this.tsbbtnMinimize.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.tsbbtnMinimize.Image = global::Book.Properties.Resources.under;
            this.tsbbtnMinimize.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tsbbtnMinimize.Name = "tsbbtnMinimize";
            this.tsbbtnMinimize.Size = new System.Drawing.Size(23, 71);
            this.tsbbtnMinimize.Text = "Minimize";
            this.tsbbtnMinimize.Click += new System.EventHandler(this.tsbbtnMinimize_Click);
            // 
            // tsbbtnPublisher
            // 
            this.tsbbtnPublisher.AutoSize = false;
            this.tsbbtnPublisher.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.tsbbtnPublisher.Font = new System.Drawing.Font("Times New Roman", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tsbbtnPublisher.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tsbbtnPublisher.Name = "tsbbtnPublisher";
            this.tsbbtnPublisher.Size = new System.Drawing.Size(100, 74);
            this.tsbbtnPublisher.Text = "Publisher";
            // 
            // tsbbtnStoryMon
            // 
            this.tsbbtnStoryMon.AutoSize = false;
            this.tsbbtnStoryMon.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.tsbbtnStoryMon.Font = new System.Drawing.Font("Times New Roman", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tsbbtnStoryMon.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tsbbtnStoryMon.Name = "tsbbtnStoryMon";
            this.tsbbtnStoryMon.Size = new System.Drawing.Size(139, 74);
            this.tsbbtnStoryMon.Text = "Mon Book\'s Story";
            // 
            // toolStrip1
            // 
            this.toolStrip1.AutoSize = false;
            this.toolStrip1.GripStyle = System.Windows.Forms.ToolStripGripStyle.Hidden;
            this.toolStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tsbbtnExit,
            this.tsbbtnMaximize,
            this.tsbbtnMinimize,
            this.tsbbtnPublisher,
            this.tsbbtnStoryMon});
            this.toolStrip1.Location = new System.Drawing.Point(191, 0);
            this.toolStrip1.Name = "toolStrip1";
            this.toolStrip1.Size = new System.Drawing.Size(609, 74);
            this.toolStrip1.TabIndex = 2;
            this.toolStrip1.Text = "toolStrip1";
            this.toolStrip1.ItemClicked += new System.Windows.Forms.ToolStripItemClickedEventHandler(this.toolStrip1_ItemClicked);
            // 
            // elipseControl1
            // 
            this.elipseControl1.CornerRadius = 30;
            this.elipseControl1.TargetControl = this;
            // 
            // MainView
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 480);
            this.Controls.Add(this.toolStrip1);
            this.Controls.Add(this.tsbUser);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.IsMdiContainer = true;
            this.Name = "MainView";
            this.Text = "MainView";
            this.Load += new System.EventHandler(this.MainView_Load);
            this.tsbUser.ResumeLayout(false);
            this.tsbUser.PerformLayout();
            this.toolStrip1.ResumeLayout(false);
            this.toolStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ToolStrip tsbUser;
        private System.Windows.Forms.ToolStripButton tsbbtnMonbook;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
        private System.Windows.Forms.ToolStripButton tsbbtnCart;
        private System.Windows.Forms.ToolStripButton tsbbtnHistoryOrder;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator2;
        private System.Windows.Forms.ToolStripButton tsbbtnMyProfile;
        private System.Windows.Forms.ToolStripButton tsbbtnManager;
        private iLearnVocabProv1._0.ElipseControl elipseControl1;
        private System.Windows.Forms.ToolStripLabel tsbbtnIDUser;
        private System.Windows.Forms.ToolStripButton tsbbtnLogOut;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator3;
        private System.Windows.Forms.ToolStrip toolStrip1;
        private System.Windows.Forms.ToolStripButton tsbbtnExit;
        private System.Windows.Forms.ToolStripButton tsbbtnMaximize;
        private System.Windows.Forms.ToolStripButton tsbbtnMinimize;
        private System.Windows.Forms.ToolStripButton tsbbtnPublisher;
        private System.Windows.Forms.ToolStripButton tsbbtnStoryMon;
    }
}