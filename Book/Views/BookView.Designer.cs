namespace Book.Views
{
    partial class BookView
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(BookView));
            this.tabPageInfor = new System.Windows.Forms.TabPage();
            this.dtpBorrow = new System.Windows.Forms.DateTimePicker();
            this.dtpPay = new System.Windows.Forms.DateTimePicker();
            this.label12 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.txtMoney = new System.Windows.Forms.TextBox();
            this.btnCancel = new System.Windows.Forms.Button();
            this.btnSave = new System.Windows.Forms.Button();
            this.label8 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.txtQuantity = new System.Windows.Forms.TextBox();
            this.txtTitle = new System.Windows.Forms.TextBox();
            this.txtAuthor = new System.Windows.Forms.TextBox();
            this.txtAge = new System.Windows.Forms.TextBox();
            this.txtStatus = new System.Windows.Forms.TextBox();
            this.txtCategory = new System.Windows.Forms.TextBox();
            this.txtIDBook = new System.Windows.Forms.TextBox();
            this.tabPageBookList = new System.Windows.Forms.TabPage();
            this.btnAdd = new System.Windows.Forms.Button();
            this.btnSearch = new System.Windows.Forms.Button();
            this.dgvListBook = new System.Windows.Forms.DataGridView();
            this.txtSearch = new System.Windows.Forms.TextBox();
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.pageSetupDialog1 = new System.Windows.Forms.PageSetupDialog();
            this.txtPercentGift = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.tabPageInfor.SuspendLayout();
            this.tabPageBookList.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvListBook)).BeginInit();
            this.tabControl1.SuspendLayout();
            this.SuspendLayout();
            // 
            // tabPageInfor
            // 
            this.tabPageInfor.AccessibleRole = System.Windows.Forms.AccessibleRole.None;
            this.tabPageInfor.Controls.Add(this.dtpBorrow);
            this.tabPageInfor.Controls.Add(this.dtpPay);
            this.tabPageInfor.Controls.Add(this.label12);
            this.tabPageInfor.Controls.Add(this.label11);
            this.tabPageInfor.Controls.Add(this.label10);
            this.tabPageInfor.Controls.Add(this.label9);
            this.tabPageInfor.Controls.Add(this.txtMoney);
            this.tabPageInfor.Controls.Add(this.btnCancel);
            this.tabPageInfor.Controls.Add(this.btnSave);
            this.tabPageInfor.Controls.Add(this.label8);
            this.tabPageInfor.Controls.Add(this.label7);
            this.tabPageInfor.Controls.Add(this.label6);
            this.tabPageInfor.Controls.Add(this.label5);
            this.tabPageInfor.Controls.Add(this.label4);
            this.tabPageInfor.Controls.Add(this.label3);
            this.tabPageInfor.Controls.Add(this.label2);
            this.tabPageInfor.Controls.Add(this.label1);
            this.tabPageInfor.Controls.Add(this.txtQuantity);
            this.tabPageInfor.Controls.Add(this.txtTitle);
            this.tabPageInfor.Controls.Add(this.txtAuthor);
            this.tabPageInfor.Controls.Add(this.txtAge);
            this.tabPageInfor.Controls.Add(this.txtStatus);
            this.tabPageInfor.Controls.Add(this.txtPercentGift);
            this.tabPageInfor.Controls.Add(this.txtCategory);
            this.tabPageInfor.Controls.Add(this.txtIDBook);
            this.tabPageInfor.Location = new System.Drawing.Point(4, 22);
            this.tabPageInfor.Name = "tabPageInfor";
            this.tabPageInfor.Padding = new System.Windows.Forms.Padding(3);
            this.tabPageInfor.Size = new System.Drawing.Size(737, 435);
            this.tabPageInfor.TabIndex = 1;
            this.tabPageInfor.Text = "BookInfor";
            this.tabPageInfor.UseVisualStyleBackColor = true;
            // 
            // dtpBorrow
            // 
            this.dtpBorrow.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.dtpBorrow.Location = new System.Drawing.Point(146, 260);
            this.dtpBorrow.Name = "dtpBorrow";
            this.dtpBorrow.Size = new System.Drawing.Size(200, 20);
            this.dtpBorrow.TabIndex = 24;
            // 
            // dtpPay
            // 
            this.dtpPay.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.dtpPay.Checked = false;
            this.dtpPay.Location = new System.Drawing.Point(445, 260);
            this.dtpPay.Name = "dtpPay";
            this.dtpPay.Size = new System.Drawing.Size(200, 20);
            this.dtpPay.TabIndex = 23;
            // 
            // label12
            // 
            this.label12.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(77, 266);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(68, 13);
            this.label12.TabIndex = 22;
            this.label12.Text = "Date borrow:";
            // 
            // label11
            // 
            this.label11.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(373, 266);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(53, 13);
            this.label11.TabIndex = 21;
            this.label11.Text = "Date pay:";
            // 
            // label10
            // 
            this.label10.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Times New Roman", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.Location = new System.Drawing.Point(450, 311);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(17, 19);
            this.label10.TabIndex = 20;
            this.label10.Text = "$";
            // 
            // label9
            // 
            this.label9.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(232, 314);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(42, 13);
            this.label9.TabIndex = 19;
            this.label9.Text = "Money:";
            // 
            // txtMoney
            // 
            this.txtMoney.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.txtMoney.Enabled = false;
            this.txtMoney.Location = new System.Drawing.Point(280, 311);
            this.txtMoney.Name = "txtMoney";
            this.txtMoney.Size = new System.Drawing.Size(164, 20);
            this.txtMoney.TabIndex = 18;
            // 
            // btnCancel
            // 
            this.btnCancel.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.btnCancel.Location = new System.Drawing.Point(376, 355);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(146, 23);
            this.btnCancel.TabIndex = 17;
            this.btnCancel.Text = "Cancel";
            this.btnCancel.UseVisualStyleBackColor = true;
            // 
            // btnSave
            // 
            this.btnSave.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.btnSave.Location = new System.Drawing.Point(193, 355);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(146, 23);
            this.btnSave.TabIndex = 16;
            this.btnSave.Text = "Save";
            this.btnSave.UseVisualStyleBackColor = true;
            // 
            // label8
            // 
            this.label8.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(373, 207);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(49, 13);
            this.label8.TabIndex = 15;
            this.label8.Text = "Quantity:";
            // 
            // label6
            // 
            this.label6.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(373, 109);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(40, 13);
            this.label6.TabIndex = 13;
            this.label6.Text = "Status:";
            // 
            // label5
            // 
            this.label5.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(373, 53);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(29, 13);
            this.label5.TabIndex = 12;
            this.label5.Text = "Age:";
            // 
            // label4
            // 
            this.label4.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(77, 211);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(52, 13);
            this.label4.TabIndex = 11;
            this.label4.Text = "Category:";
            // 
            // label3
            // 
            this.label3.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(77, 156);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(41, 13);
            this.label3.TabIndex = 10;
            this.label3.Text = "Author:";
            // 
            // label2
            // 
            this.label2.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(77, 105);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(30, 13);
            this.label2.TabIndex = 9;
            this.label2.Text = "Title:";
            // 
            // label1
            // 
            this.label1.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(77, 53);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(49, 13);
            this.label1.TabIndex = 8;
            this.label1.Text = "ID Book:";
            // 
            // txtQuantity
            // 
            this.txtQuantity.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.txtQuantity.Location = new System.Drawing.Point(445, 204);
            this.txtQuantity.Name = "txtQuantity";
            this.txtQuantity.Size = new System.Drawing.Size(200, 20);
            this.txtQuantity.TabIndex = 7;
            // 
            // txtTitle
            // 
            this.txtTitle.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.txtTitle.Enabled = false;
            this.txtTitle.Location = new System.Drawing.Point(146, 102);
            this.txtTitle.Name = "txtTitle";
            this.txtTitle.Size = new System.Drawing.Size(200, 20);
            this.txtTitle.TabIndex = 6;
            // 
            // txtAuthor
            // 
            this.txtAuthor.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.txtAuthor.Enabled = false;
            this.txtAuthor.Location = new System.Drawing.Point(146, 153);
            this.txtAuthor.Name = "txtAuthor";
            this.txtAuthor.Size = new System.Drawing.Size(200, 20);
            this.txtAuthor.TabIndex = 5;
            // 
            // txtAge
            // 
            this.txtAge.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.txtAge.Enabled = false;
            this.txtAge.Location = new System.Drawing.Point(445, 50);
            this.txtAge.Name = "txtAge";
            this.txtAge.Size = new System.Drawing.Size(200, 20);
            this.txtAge.TabIndex = 4;
            // 
            // txtStatus
            // 
            this.txtStatus.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.txtStatus.Enabled = false;
            this.txtStatus.Location = new System.Drawing.Point(445, 102);
            this.txtStatus.Name = "txtStatus";
            this.txtStatus.Size = new System.Drawing.Size(200, 20);
            this.txtStatus.TabIndex = 3;
            // 
            // txtCategory
            // 
            this.txtCategory.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.txtCategory.Enabled = false;
            this.txtCategory.Location = new System.Drawing.Point(146, 204);
            this.txtCategory.Name = "txtCategory";
            this.txtCategory.Size = new System.Drawing.Size(200, 20);
            this.txtCategory.TabIndex = 1;
            // 
            // txtIDBook
            // 
            this.txtIDBook.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.txtIDBook.Enabled = false;
            this.txtIDBook.Location = new System.Drawing.Point(146, 50);
            this.txtIDBook.Name = "txtIDBook";
            this.txtIDBook.Size = new System.Drawing.Size(200, 20);
            this.txtIDBook.TabIndex = 0;
            // 
            // tabPageBookList
            // 
            this.tabPageBookList.Controls.Add(this.btnAdd);
            this.tabPageBookList.Controls.Add(this.btnSearch);
            this.tabPageBookList.Controls.Add(this.dgvListBook);
            this.tabPageBookList.Controls.Add(this.txtSearch);
            this.tabPageBookList.Location = new System.Drawing.Point(4, 22);
            this.tabPageBookList.Name = "tabPageBookList";
            this.tabPageBookList.Padding = new System.Windows.Forms.Padding(3);
            this.tabPageBookList.Size = new System.Drawing.Size(737, 435);
            this.tabPageBookList.TabIndex = 0;
            this.tabPageBookList.Text = "BookList";
            this.tabPageBookList.UseVisualStyleBackColor = true;
            // 
            // btnAdd
            // 
            this.btnAdd.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnAdd.Font = new System.Drawing.Font("Times New Roman", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAdd.Location = new System.Drawing.Point(638, 54);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(75, 23);
            this.btnAdd.TabIndex = 10;
            this.btnAdd.Text = "Add cart";
            this.btnAdd.UseVisualStyleBackColor = true;
            // 
            // btnSearch
            // 
            this.btnSearch.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnSearch.Font = new System.Drawing.Font("Times New Roman", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSearch.Location = new System.Drawing.Point(532, 10);
            this.btnSearch.Name = "btnSearch";
            this.btnSearch.Size = new System.Drawing.Size(75, 23);
            this.btnSearch.TabIndex = 9;
            this.btnSearch.Text = "Search";
            this.btnSearch.UseVisualStyleBackColor = true;
            // 
            // dgvListBook
            // 
            this.dgvListBook.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dgvListBook.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvListBook.Location = new System.Drawing.Point(6, 42);
            this.dgvListBook.Name = "dgvListBook";
            this.dgvListBook.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvListBook.Size = new System.Drawing.Size(601, 387);
            this.dgvListBook.TabIndex = 0;
            // 
            // txtSearch
            // 
            this.txtSearch.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.txtSearch.Location = new System.Drawing.Point(232, 12);
            this.txtSearch.Name = "txtSearch";
            this.txtSearch.Size = new System.Drawing.Size(294, 20);
            this.txtSearch.TabIndex = 8;
            // 
            // tabControl1
            // 
            this.tabControl1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tabControl1.Controls.Add(this.tabPageBookList);
            this.tabControl1.Controls.Add(this.tabPageInfor);
            this.tabControl1.Location = new System.Drawing.Point(12, 12);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(745, 461);
            this.tabControl1.TabIndex = 2;
            // 
            // txtPercentGift
            // 
            this.txtPercentGift.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.txtPercentGift.Enabled = false;
            this.txtPercentGift.Location = new System.Drawing.Point(445, 153);
            this.txtPercentGift.Name = "txtPercentGift";
            this.txtPercentGift.Size = new System.Drawing.Size(200, 20);
            this.txtPercentGift.TabIndex = 2;
            // 
            // label7
            // 
            this.label7.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(373, 156);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(26, 13);
            this.label7.TabIndex = 14;
            this.label7.Text = "Gift:";
            // 
            // BookView
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(769, 485);
            this.Controls.Add(this.tabControl1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "BookView";
            this.Text = "Mon Books";
            this.Load += new System.EventHandler(this.frm_MainBook_Load);
            this.tabPageInfor.ResumeLayout(false);
            this.tabPageInfor.PerformLayout();
            this.tabPageBookList.ResumeLayout(false);
            this.tabPageBookList.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvListBook)).EndInit();
            this.tabControl1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.TabPage tabPageInfor;
        private System.Windows.Forms.Button btnCancel;
        private System.Windows.Forms.Button btnSave;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtQuantity;
        private System.Windows.Forms.TextBox txtTitle;
        private System.Windows.Forms.TextBox txtAuthor;
        private System.Windows.Forms.TextBox txtAge;
        private System.Windows.Forms.TextBox txtStatus;
        private System.Windows.Forms.TextBox txtCategory;
        private System.Windows.Forms.TextBox txtIDBook;
        private System.Windows.Forms.TabPage tabPageBookList;
        private System.Windows.Forms.TextBox txtSearch;
        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.DataGridView dgvListBook;
        private System.Windows.Forms.Button btnAdd;
        private System.Windows.Forms.Button btnSearch;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.TextBox txtMoney;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.DateTimePicker dtpBorrow;
        private System.Windows.Forms.DateTimePicker dtpPay;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.PageSetupDialog pageSetupDialog1;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox txtPercentGift;
    }
}