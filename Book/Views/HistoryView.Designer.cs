namespace Book.Views
{
    partial class HistoryView
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
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabPageCartList = new System.Windows.Forms.TabPage();
            this.dgvListHistory = new System.Windows.Forms.DataGridView();
            this.tabPageCartDetail = new System.Windows.Forms.TabPage();
            this.label1 = new System.Windows.Forms.Label();
            this.txtMoney = new System.Windows.Forms.TextBox();
            this.bl_totalmoney = new System.Windows.Forms.Label();
            this.dtpBorrow = new System.Windows.Forms.DateTimePicker();
            this.dtpPay = new System.Windows.Forms.DateTimePicker();
            this.label12 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label13 = new System.Windows.Forms.Label();
            this.label14 = new System.Windows.Forms.Label();
            this.label15 = new System.Windows.Forms.Label();
            this.label16 = new System.Windows.Forms.Label();
            this.label17 = new System.Windows.Forms.Label();
            this.txtQuantity = new System.Windows.Forms.TextBox();
            this.txtIDBook = new System.Windows.Forms.TextBox();
            this.txtTitle = new System.Windows.Forms.TextBox();
            this.txtAuthor = new System.Windows.Forms.TextBox();
            this.txtStatus = new System.Windows.Forms.TextBox();
            this.txtPercentGift = new System.Windows.Forms.TextBox();
            this.txtCategory = new System.Windows.Forms.TextBox();
            this.txtIDOrder = new System.Windows.Forms.TextBox();
            this.toolStrip1 = new System.Windows.Forms.ToolStrip();
            this.toolStripSeparator8 = new System.Windows.Forms.ToolStripSeparator();
            this.tsbbtnBookback = new System.Windows.Forms.ToolStripButton();
            this.toolStripSeparator3 = new System.Windows.Forms.ToolStripSeparator();
            this.toolStripSeparator4 = new System.Windows.Forms.ToolStripSeparator();
            this.tsbbtnDelete = new System.Windows.Forms.ToolStripButton();
            this.toolStripSeparator5 = new System.Windows.Forms.ToolStripSeparator();
            this.tabControl1.SuspendLayout();
            this.tabPageCartList.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvListHistory)).BeginInit();
            this.tabPageCartDetail.SuspendLayout();
            this.toolStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // tabControl1
            // 
            this.tabControl1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tabControl1.Controls.Add(this.tabPageCartList);
            this.tabControl1.Controls.Add(this.tabPageCartDetail);
            this.tabControl1.Location = new System.Drawing.Point(12, 63);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(782, 415);
            this.tabControl1.TabIndex = 16;
            // 
            // tabPageCartList
            // 
            this.tabPageCartList.Controls.Add(this.dgvListHistory);
            this.tabPageCartList.Location = new System.Drawing.Point(4, 22);
            this.tabPageCartList.Name = "tabPageCartList";
            this.tabPageCartList.Padding = new System.Windows.Forms.Padding(3);
            this.tabPageCartList.Size = new System.Drawing.Size(774, 389);
            this.tabPageCartList.TabIndex = 0;
            this.tabPageCartList.Text = "HistoryList";
            this.tabPageCartList.UseVisualStyleBackColor = true;
            // 
            // dgvListHistory
            // 
            this.dgvListHistory.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dgvListHistory.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvListHistory.Location = new System.Drawing.Point(7, 15);
            this.dgvListHistory.Name = "dgvListHistory";
            this.dgvListHistory.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvListHistory.Size = new System.Drawing.Size(761, 368);
            this.dgvListHistory.TabIndex = 17;
            // 
            // tabPageCartDetail
            // 
            this.tabPageCartDetail.Controls.Add(this.label1);
            this.tabPageCartDetail.Controls.Add(this.txtMoney);
            this.tabPageCartDetail.Controls.Add(this.bl_totalmoney);
            this.tabPageCartDetail.Controls.Add(this.dtpBorrow);
            this.tabPageCartDetail.Controls.Add(this.dtpPay);
            this.tabPageCartDetail.Controls.Add(this.label12);
            this.tabPageCartDetail.Controls.Add(this.label11);
            this.tabPageCartDetail.Controls.Add(this.label8);
            this.tabPageCartDetail.Controls.Add(this.label7);
            this.tabPageCartDetail.Controls.Add(this.label6);
            this.tabPageCartDetail.Controls.Add(this.label13);
            this.tabPageCartDetail.Controls.Add(this.label14);
            this.tabPageCartDetail.Controls.Add(this.label15);
            this.tabPageCartDetail.Controls.Add(this.label16);
            this.tabPageCartDetail.Controls.Add(this.label17);
            this.tabPageCartDetail.Controls.Add(this.txtQuantity);
            this.tabPageCartDetail.Controls.Add(this.txtIDBook);
            this.tabPageCartDetail.Controls.Add(this.txtTitle);
            this.tabPageCartDetail.Controls.Add(this.txtAuthor);
            this.tabPageCartDetail.Controls.Add(this.txtStatus);
            this.tabPageCartDetail.Controls.Add(this.txtPercentGift);
            this.tabPageCartDetail.Controls.Add(this.txtCategory);
            this.tabPageCartDetail.Controls.Add(this.txtIDOrder);
            this.tabPageCartDetail.Font = new System.Drawing.Font("Times New Roman", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tabPageCartDetail.Location = new System.Drawing.Point(4, 22);
            this.tabPageCartDetail.Name = "tabPageCartDetail";
            this.tabPageCartDetail.Padding = new System.Windows.Forms.Padding(3);
            this.tabPageCartDetail.Size = new System.Drawing.Size(774, 389);
            this.tabPageCartDetail.TabIndex = 1;
            this.tabPageCartDetail.Text = "CartDetail";
            this.tabPageCartDetail.UseVisualStyleBackColor = true;
            // 
            // label1
            // 
            this.label1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)));
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Times New Roman", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(634, 298);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(17, 19);
            this.label1.TabIndex = 59;
            this.label1.Text = "$";
            // 
            // txtMoney
            // 
            this.txtMoney.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)));
            this.txtMoney.Enabled = false;
            this.txtMoney.Font = new System.Drawing.Font("Times New Roman", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtMoney.Location = new System.Drawing.Point(432, 300);
            this.txtMoney.Name = "txtMoney";
            this.txtMoney.Size = new System.Drawing.Size(200, 20);
            this.txtMoney.TabIndex = 58;
            // 
            // bl_totalmoney
            // 
            this.bl_totalmoney.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)));
            this.bl_totalmoney.AutoSize = true;
            this.bl_totalmoney.Font = new System.Drawing.Font("Times New Roman", 9.75F, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bl_totalmoney.Location = new System.Drawing.Point(365, 302);
            this.bl_totalmoney.Name = "bl_totalmoney";
            this.bl_totalmoney.Size = new System.Drawing.Size(49, 15);
            this.bl_totalmoney.TabIndex = 57;
            this.bl_totalmoney.Text = "Money:";
            // 
            // dtpBorrow
            // 
            this.dtpBorrow.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.dtpBorrow.Location = new System.Drawing.Point(115, 245);
            this.dtpBorrow.Name = "dtpBorrow";
            this.dtpBorrow.Size = new System.Drawing.Size(200, 22);
            this.dtpBorrow.TabIndex = 56;
            // 
            // dtpPay
            // 
            this.dtpPay.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.dtpPay.Location = new System.Drawing.Point(432, 245);
            this.dtpPay.Name = "dtpPay";
            this.dtpPay.Size = new System.Drawing.Size(200, 22);
            this.dtpPay.TabIndex = 55;
            // 
            // label12
            // 
            this.label12.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.label12.AutoSize = true;
            this.label12.Font = new System.Drawing.Font("Times New Roman", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label12.Location = new System.Drawing.Point(33, 251);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(76, 15);
            this.label12.TabIndex = 54;
            this.label12.Text = "Date borrow:";
            // 
            // label11
            // 
            this.label11.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("Times New Roman", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label11.Location = new System.Drawing.Point(360, 251);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(58, 15);
            this.label11.TabIndex = 53;
            this.label11.Text = "Date pay:";
            // 
            // label8
            // 
            this.label8.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Times New Roman", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(360, 192);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(57, 15);
            this.label8.TabIndex = 47;
            this.label8.Text = "Quantity:";
            // 
            // label7
            // 
            this.label7.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Times New Roman", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(360, 141);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(72, 15);
            this.label7.TabIndex = 46;
            this.label7.Text = "Percent Gift:";
            // 
            // label6
            // 
            this.label6.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Times New Roman", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(360, 94);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(44, 15);
            this.label6.TabIndex = 45;
            this.label6.Text = "Status:";
            // 
            // label13
            // 
            this.label13.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.label13.AutoSize = true;
            this.label13.Font = new System.Drawing.Font("Times New Roman", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label13.Location = new System.Drawing.Point(360, 38);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(49, 15);
            this.label13.TabIndex = 44;
            this.label13.Text = "Author:";
            // 
            // label14
            // 
            this.label14.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.label14.AutoSize = true;
            this.label14.Font = new System.Drawing.Font("Times New Roman", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label14.Location = new System.Drawing.Point(33, 196);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(59, 15);
            this.label14.TabIndex = 43;
            this.label14.Text = "Category:";
            // 
            // label15
            // 
            this.label15.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.label15.AutoSize = true;
            this.label15.Font = new System.Drawing.Font("Times New Roman", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label15.Location = new System.Drawing.Point(33, 141);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(34, 15);
            this.label15.TabIndex = 42;
            this.label15.Text = "Title:";
            // 
            // label16
            // 
            this.label16.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.label16.AutoSize = true;
            this.label16.Font = new System.Drawing.Font("Times New Roman", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label16.Location = new System.Drawing.Point(33, 90);
            this.label16.Name = "label16";
            this.label16.Size = new System.Drawing.Size(54, 15);
            this.label16.TabIndex = 41;
            this.label16.Text = "ID Book:";
            // 
            // label17
            // 
            this.label17.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.label17.AutoSize = true;
            this.label17.Font = new System.Drawing.Font("Times New Roman", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label17.Location = new System.Drawing.Point(33, 38);
            this.label17.Name = "label17";
            this.label17.Size = new System.Drawing.Size(56, 15);
            this.label17.TabIndex = 40;
            this.label17.Text = "ID Order:";
            // 
            // txtQuantity
            // 
            this.txtQuantity.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.txtQuantity.Location = new System.Drawing.Point(432, 189);
            this.txtQuantity.Name = "txtQuantity";
            this.txtQuantity.Size = new System.Drawing.Size(200, 22);
            this.txtQuantity.TabIndex = 39;
            // 
            // txtIDBook
            // 
            this.txtIDBook.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.txtIDBook.Enabled = false;
            this.txtIDBook.Location = new System.Drawing.Point(115, 87);
            this.txtIDBook.Name = "txtIDBook";
            this.txtIDBook.Size = new System.Drawing.Size(200, 22);
            this.txtIDBook.TabIndex = 38;
            // 
            // txtTitle
            // 
            this.txtTitle.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.txtTitle.Enabled = false;
            this.txtTitle.Location = new System.Drawing.Point(115, 138);
            this.txtTitle.Name = "txtTitle";
            this.txtTitle.Size = new System.Drawing.Size(200, 22);
            this.txtTitle.TabIndex = 37;
            // 
            // txtAuthor
            // 
            this.txtAuthor.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.txtAuthor.Enabled = false;
            this.txtAuthor.Location = new System.Drawing.Point(432, 35);
            this.txtAuthor.Name = "txtAuthor";
            this.txtAuthor.Size = new System.Drawing.Size(200, 22);
            this.txtAuthor.TabIndex = 36;
            // 
            // txtStatus
            // 
            this.txtStatus.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.txtStatus.Enabled = false;
            this.txtStatus.Location = new System.Drawing.Point(432, 87);
            this.txtStatus.Name = "txtStatus";
            this.txtStatus.Size = new System.Drawing.Size(200, 22);
            this.txtStatus.TabIndex = 35;
            // 
            // txtPercentGift
            // 
            this.txtPercentGift.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.txtPercentGift.Enabled = false;
            this.txtPercentGift.Location = new System.Drawing.Point(432, 138);
            this.txtPercentGift.Name = "txtPercentGift";
            this.txtPercentGift.Size = new System.Drawing.Size(200, 22);
            this.txtPercentGift.TabIndex = 34;
            // 
            // txtCategory
            // 
            this.txtCategory.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.txtCategory.Enabled = false;
            this.txtCategory.Location = new System.Drawing.Point(115, 189);
            this.txtCategory.Name = "txtCategory";
            this.txtCategory.Size = new System.Drawing.Size(200, 22);
            this.txtCategory.TabIndex = 33;
            // 
            // txtIDOrder
            // 
            this.txtIDOrder.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.txtIDOrder.Enabled = false;
            this.txtIDOrder.Location = new System.Drawing.Point(115, 35);
            this.txtIDOrder.Name = "txtIDOrder";
            this.txtIDOrder.Size = new System.Drawing.Size(200, 22);
            this.txtIDOrder.TabIndex = 32;
            // 
            // toolStrip1
            // 
            this.toolStrip1.AutoSize = false;
            this.toolStrip1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(189)))), ((int)(((byte)(89)))));
            this.toolStrip1.Font = new System.Drawing.Font("Times New Roman", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.toolStrip1.GripStyle = System.Windows.Forms.ToolStripGripStyle.Hidden;
            this.toolStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripSeparator8,
            this.tsbbtnBookback,
            this.toolStripSeparator3,
            this.toolStripSeparator4,
            this.tsbbtnDelete,
            this.toolStripSeparator5});
            this.toolStrip1.Location = new System.Drawing.Point(0, 0);
            this.toolStrip1.Name = "toolStrip1";
            this.toolStrip1.Size = new System.Drawing.Size(806, 60);
            this.toolStrip1.TabIndex = 17;
            // 
            // toolStripSeparator8
            // 
            this.toolStripSeparator8.Name = "toolStripSeparator8";
            this.toolStripSeparator8.Size = new System.Drawing.Size(6, 60);
            // 
            // tsbbtnBookback
            // 
            this.tsbbtnBookback.AutoSize = false;
            this.tsbbtnBookback.Font = new System.Drawing.Font("Times New Roman", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tsbbtnBookback.Image = global::Book.Properties.Resources.pay;
            this.tsbbtnBookback.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.tsbbtnBookback.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tsbbtnBookback.Name = "tsbbtnBookback";
            this.tsbbtnBookback.Size = new System.Drawing.Size(150, 50);
            this.tsbbtnBookback.Text = "Buy Again ";
            // 
            // toolStripSeparator3
            // 
            this.toolStripSeparator3.Alignment = System.Windows.Forms.ToolStripItemAlignment.Right;
            this.toolStripSeparator3.Name = "toolStripSeparator3";
            this.toolStripSeparator3.Size = new System.Drawing.Size(6, 60);
            // 
            // toolStripSeparator4
            // 
            this.toolStripSeparator4.Name = "toolStripSeparator4";
            this.toolStripSeparator4.Size = new System.Drawing.Size(6, 60);
            // 
            // tsbbtnDelete
            // 
            this.tsbbtnDelete.AutoSize = false;
            this.tsbbtnDelete.Font = new System.Drawing.Font("Times New Roman", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tsbbtnDelete.Image = global::Book.Properties.Resources.delete21;
            this.tsbbtnDelete.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.tsbbtnDelete.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tsbbtnDelete.Name = "tsbbtnDelete";
            this.tsbbtnDelete.Size = new System.Drawing.Size(100, 50);
            this.tsbbtnDelete.Text = "Delete";
            // 
            // toolStripSeparator5
            // 
            this.toolStripSeparator5.Name = "toolStripSeparator5";
            this.toolStripSeparator5.Size = new System.Drawing.Size(6, 60);
            // 
            // HistoryView
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(806, 490);
            this.Controls.Add(this.toolStrip1);
            this.Controls.Add(this.tabControl1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "HistoryView";
            this.Text = "HistoryView";
            this.tabControl1.ResumeLayout(false);
            this.tabPageCartList.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvListHistory)).EndInit();
            this.tabPageCartDetail.ResumeLayout(false);
            this.tabPageCartDetail.PerformLayout();
            this.toolStrip1.ResumeLayout(false);
            this.toolStrip1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabPageCartList;
        private System.Windows.Forms.DataGridView dgvListHistory;
        private System.Windows.Forms.TabPage tabPageCartDetail;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtMoney;
        private System.Windows.Forms.Label bl_totalmoney;
        private System.Windows.Forms.DateTimePicker dtpBorrow;
        private System.Windows.Forms.DateTimePicker dtpPay;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.Label label16;
        private System.Windows.Forms.Label label17;
        private System.Windows.Forms.TextBox txtQuantity;
        private System.Windows.Forms.TextBox txtIDBook;
        private System.Windows.Forms.TextBox txtTitle;
        private System.Windows.Forms.TextBox txtAuthor;
        private System.Windows.Forms.TextBox txtStatus;
        private System.Windows.Forms.TextBox txtPercentGift;
        private System.Windows.Forms.TextBox txtCategory;
        private System.Windows.Forms.TextBox txtIDOrder;
        private System.Windows.Forms.ToolStrip toolStrip1;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator8;
        private System.Windows.Forms.ToolStripButton tsbbtnBookback;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator3;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator4;
        private System.Windows.Forms.ToolStripButton tsbbtnDelete;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator5;
    }
}