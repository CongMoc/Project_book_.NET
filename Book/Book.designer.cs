namespace Book.Views
{
    partial class frm_MainBook
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frm_MainBook));
            this.tsbUser = new System.Windows.Forms.ToolStrip();
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.toolStrip1 = new System.Windows.Forms.ToolStrip();
            this.toolStripButton2 = new System.Windows.Forms.ToolStripButton();
            this.tsbbtnExit = new System.Windows.Forms.ToolStripButton();
            this.tsbbtnMaximize = new System.Windows.Forms.ToolStripButton();
            this.tsbbtnMinimize = new System.Windows.Forms.ToolStripButton();
            this.tsbbtnNameUser = new System.Windows.Forms.ToolStripButton();
            this.toolStripButton1 = new System.Windows.Forms.ToolStripButton();
            this.tsbbtnHistoryOrder = new System.Windows.Forms.ToolStripButton();
            this.tsbbtnPublisher = new System.Windows.Forms.ToolStripButton();
            this.tsbbtnStoryMon = new System.Windows.Forms.ToolStripButton();
            this.tsbbtnLogOut = new System.Windows.Forms.ToolStripButton();
            this.toolStripSeparator2 = new System.Windows.Forms.ToolStripSeparator();
            this.panel1 = new System.Windows.Forms.Panel();
            this.dgvListBook = new System.Windows.Forms.DataGridView();
            this.btnAdd = new System.Windows.Forms.Button();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.btnSearch = new System.Windows.Forms.Button();
            this.tsbUser.SuspendLayout();
            this.toolStrip1.SuspendLayout();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvListBook)).BeginInit();
            this.SuspendLayout();
            // 
            // tsbUser
            // 
            this.tsbUser.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(189)))), ((int)(((byte)(89)))));
            this.tsbUser.Dock = System.Windows.Forms.DockStyle.Left;
            this.tsbUser.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tsbbtnNameUser,
            this.toolStripSeparator1,
            this.toolStripButton1,
            this.tsbbtnHistoryOrder,
            this.tsbbtnLogOut,
            this.toolStripSeparator2});
            this.tsbUser.Location = new System.Drawing.Point(0, 0);
            this.tsbUser.Name = "tsbUser";
            this.tsbUser.Size = new System.Drawing.Size(171, 512);
            this.tsbUser.TabIndex = 0;
            // 
            // toolStripSeparator1
            // 
            this.toolStripSeparator1.Name = "toolStripSeparator1";
            this.toolStripSeparator1.Size = new System.Drawing.Size(168, 6);
            // 
            // toolStrip1
            // 
            this.toolStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripButton2,
            this.tsbbtnExit,
            this.tsbbtnMaximize,
            this.tsbbtnMinimize,
            this.tsbbtnPublisher,
            this.tsbbtnStoryMon});
            this.toolStrip1.Location = new System.Drawing.Point(171, 0);
            this.toolStrip1.Name = "toolStrip1";
            this.toolStrip1.Size = new System.Drawing.Size(780, 77);
            this.toolStrip1.TabIndex = 1;
            this.toolStrip1.Text = "toolStrip1";
            // 
            // toolStripButton2
            // 
            this.toolStripButton2.AutoSize = false;
            this.toolStripButton2.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.toolStripButton2.Image = global::Book.Properties.Resources.rsz_author;
            this.toolStripButton2.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.toolStripButton2.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.toolStripButton2.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripButton2.Name = "toolStripButton2";
            this.toolStripButton2.Size = new System.Drawing.Size(200, 74);
            this.toolStripButton2.Text = "Mon Books";
            this.toolStripButton2.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // tsbbtnExit
            // 
            this.tsbbtnExit.Alignment = System.Windows.Forms.ToolStripItemAlignment.Right;
            this.tsbbtnExit.AutoSize = false;
            this.tsbbtnExit.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.tsbbtnExit.Image = global::Book.Properties.Resources._4781838_cancel_close_delete_exit_logout_icon;
            this.tsbbtnExit.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tsbbtnExit.Name = "tsbbtnExit";
            this.tsbbtnExit.Size = new System.Drawing.Size(23, 30);
            this.tsbbtnExit.Text = "Exit";
            // 
            // tsbbtnMaximize
            // 
            this.tsbbtnMaximize.Alignment = System.Windows.Forms.ToolStripItemAlignment.Right;
            this.tsbbtnMaximize.AutoSize = false;
            this.tsbbtnMaximize.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.tsbbtnMaximize.Image = global::Book.Properties.Resources.rsz_square_1;
            this.tsbbtnMaximize.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.tsbbtnMaximize.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.tsbbtnMaximize.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tsbbtnMaximize.Name = "tsbbtnMaximize";
            this.tsbbtnMaximize.Size = new System.Drawing.Size(30, 28);
            this.tsbbtnMaximize.Text = "Maximize";
            // 
            // tsbbtnMinimize
            // 
            this.tsbbtnMinimize.Alignment = System.Windows.Forms.ToolStripItemAlignment.Right;
            this.tsbbtnMinimize.AutoSize = false;
            this.tsbbtnMinimize.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.tsbbtnMinimize.Image = global::Book.Properties.Resources.under;
            this.tsbbtnMinimize.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tsbbtnMinimize.Name = "tsbbtnMinimize";
            this.tsbbtnMinimize.Size = new System.Drawing.Size(23, 30);
            this.tsbbtnMinimize.Text = "Minimize";
            // 
            // tsbbtnNameUser
            // 
            this.tsbbtnNameUser.AutoSize = false;
            this.tsbbtnNameUser.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tsbbtnNameUser.Image = global::Book.Properties.Resources.usermain;
            this.tsbbtnNameUser.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.tsbbtnNameUser.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tsbbtnNameUser.Name = "tsbbtnNameUser";
            this.tsbbtnNameUser.Size = new System.Drawing.Size(170, 68);
            this.tsbbtnNameUser.Text = "Name User";
            // 
            // toolStripButton1
            // 
            this.toolStripButton1.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.toolStripButton1.Image = global::Book.Properties.Resources._211707_cart_icon;
            this.toolStripButton1.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.toolStripButton1.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripButton1.Name = "toolStripButton1";
            this.toolStripButton1.Size = new System.Drawing.Size(168, 52);
            this.toolStripButton1.Text = "toolStripButton1";
            // 
            // tsbbtnHistoryOrder
            // 
            this.tsbbtnHistoryOrder.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.tsbbtnHistoryOrder.Image = global::Book.Properties.Resources._5027891_book_learning_notebook_reading_study_icon;
            this.tsbbtnHistoryOrder.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.tsbbtnHistoryOrder.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tsbbtnHistoryOrder.Name = "tsbbtnHistoryOrder";
            this.tsbbtnHistoryOrder.Size = new System.Drawing.Size(168, 52);
            this.tsbbtnHistoryOrder.Text = "History Order Book";
            // 
            // tsbbtnPublisher
            // 
            this.tsbbtnPublisher.AutoSize = false;
            this.tsbbtnPublisher.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.tsbbtnPublisher.Font = new System.Drawing.Font("Times New Roman", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tsbbtnPublisher.Image = ((System.Drawing.Image)(resources.GetObject("tsbbtnPublisher.Image")));
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
            this.tsbbtnStoryMon.Image = ((System.Drawing.Image)(resources.GetObject("tsbbtnStoryMon.Image")));
            this.tsbbtnStoryMon.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tsbbtnStoryMon.Name = "tsbbtnStoryMon";
            this.tsbbtnStoryMon.Size = new System.Drawing.Size(139, 74);
            this.tsbbtnStoryMon.Text = "Mon Book\'s Story";
            // 
            // tsbbtnLogOut
            // 
            this.tsbbtnLogOut.Alignment = System.Windows.Forms.ToolStripItemAlignment.Right;
            this.tsbbtnLogOut.AutoSize = false;
            this.tsbbtnLogOut.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.tsbbtnLogOut.Font = new System.Drawing.Font("Times New Roman", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tsbbtnLogOut.Image = ((System.Drawing.Image)(resources.GetObject("tsbbtnLogOut.Image")));
            this.tsbbtnLogOut.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tsbbtnLogOut.Name = "tsbbtnLogOut";
            this.tsbbtnLogOut.Size = new System.Drawing.Size(168, 50);
            this.tsbbtnLogOut.Text = "Log Out";
            // 
            // toolStripSeparator2
            // 
            this.toolStripSeparator2.Alignment = System.Windows.Forms.ToolStripItemAlignment.Right;
            this.toolStripSeparator2.Name = "toolStripSeparator2";
            this.toolStripSeparator2.Size = new System.Drawing.Size(168, 6);
            // 
            // panel1
            // 
            this.panel1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panel1.Controls.Add(this.dgvListBook);
            this.panel1.Location = new System.Drawing.Point(206, 119);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(616, 376);
            this.panel1.TabIndex = 2;
            // 
            // dgvListBook
            // 
            this.dgvListBook.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dgvListBook.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvListBook.Location = new System.Drawing.Point(3, 3);
            this.dgvListBook.Name = "dgvListBook";
            this.dgvListBook.Size = new System.Drawing.Size(610, 370);
            this.dgvListBook.TabIndex = 0;
            // 
            // btnAdd
            // 
            this.btnAdd.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnAdd.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(189)))), ((int)(((byte)(89)))));
            this.btnAdd.Font = new System.Drawing.Font("Times New Roman", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAdd.ForeColor = System.Drawing.SystemColors.ControlText;
            this.btnAdd.Location = new System.Drawing.Point(854, 119);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(75, 23);
            this.btnAdd.TabIndex = 3;
            this.btnAdd.Text = "Add New";
            this.btnAdd.UseVisualStyleBackColor = false;
            // 
            // textBox1
            // 
            this.textBox1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.textBox1.Location = new System.Drawing.Point(502, 92);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(236, 20);
            this.textBox1.TabIndex = 4;
            // 
            // btnSearch
            // 
            this.btnSearch.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnSearch.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(189)))), ((int)(((byte)(89)))));
            this.btnSearch.Font = new System.Drawing.Font("Times New Roman", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSearch.ForeColor = System.Drawing.SystemColors.ControlText;
            this.btnSearch.Location = new System.Drawing.Point(744, 90);
            this.btnSearch.Name = "btnSearch";
            this.btnSearch.Size = new System.Drawing.Size(75, 23);
            this.btnSearch.TabIndex = 3;
            this.btnSearch.Text = "Search";
            this.btnSearch.UseVisualStyleBackColor = false;
            // 
            // frm_MainBook
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(951, 512);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.btnSearch);
            this.Controls.Add(this.btnAdd);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.toolStrip1);
            this.Controls.Add(this.tsbUser);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "frm_MainBook";
            this.Text = "frm_MainBook";
            this.Load += new System.EventHandler(this.frm_MainBook_Load);
            this.tsbUser.ResumeLayout(false);
            this.tsbUser.PerformLayout();
            this.toolStrip1.ResumeLayout(false);
            this.toolStrip1.PerformLayout();
            this.panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvListBook)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ToolStrip tsbUser;
        private System.Windows.Forms.ToolStripButton tsbbtnNameUser;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
        private System.Windows.Forms.ToolStripButton toolStripButton1;
        private System.Windows.Forms.ToolStrip toolStrip1;
        private System.Windows.Forms.ToolStripButton toolStripButton2;
        private System.Windows.Forms.ToolStripButton tsbbtnHistoryOrder;
        private System.Windows.Forms.ToolStripButton tsbbtnExit;
        private System.Windows.Forms.ToolStripButton tsbbtnMaximize;
        private System.Windows.Forms.ToolStripButton tsbbtnMinimize;
        private System.Windows.Forms.ToolStripButton tsbbtnLogOut;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator2;
        private System.Windows.Forms.ToolStripButton tsbbtnPublisher;
        private System.Windows.Forms.ToolStripButton tsbbtnStoryMon;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.DataGridView dgvListBook;
        private System.Windows.Forms.Button btnAdd;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Button btnSearch;
    }
}