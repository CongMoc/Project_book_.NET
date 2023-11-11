namespace Book.Views
{
    partial class ManagerView
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ManagerView));
            this.tsTop = new System.Windows.Forms.ToolStrip();
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.tsbbtnEmployee = new System.Windows.Forms.ToolStripButton();
            this.toolStripSeparator5 = new System.Windows.Forms.ToolStripSeparator();
            this.tsbbtnStatistical = new System.Windows.Forms.ToolStripButton();
            this.toolStripSeparator4 = new System.Windows.Forms.ToolStripSeparator();
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabPageEmployee = new System.Windows.Forms.TabPage();
            this.btnEdit = new System.Windows.Forms.Button();
            this.btnDeleteEm = new System.Windows.Forms.Button();
            this.btnAdd = new System.Windows.Forms.Button();
            this.dgvEmployeeList = new System.Windows.Forms.DataGridView();
            this.tabPageDetail = new System.Windows.Forms.TabPage();
            this.dtpBirth = new System.Windows.Forms.DateTimePicker();
            this.btnSave = new System.Windows.Forms.Button();
            this.btnCancel = new System.Windows.Forms.Button();
            this.label8 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.txtName = new System.Windows.Forms.TextBox();
            this.txtAddress = new System.Windows.Forms.TextBox();
            this.txtCity = new System.Windows.Forms.TextBox();
            this.txtPhone = new System.Windows.Forms.TextBox();
            this.txtEmail = new System.Windows.Forms.TextBox();
            this.tabPageExcel = new System.Windows.Forms.TabPage();
            this.btnCheck = new System.Windows.Forms.Button();
            this.cboTop = new System.Windows.Forms.ComboBox();
            this.label9 = new System.Windows.Forms.Label();
            this.btnSearch = new System.Windows.Forms.Button();
            this.label18 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.dptEnd = new System.Windows.Forms.DateTimePicker();
            this.dptStart = new System.Windows.Forms.DateTimePicker();
            this.dgvStatistical = new System.Windows.Forms.DataGridView();
            this.txtGender = new System.Windows.Forms.ComboBox();
            this.tsTop.SuspendLayout();
            this.tabControl1.SuspendLayout();
            this.tabPageEmployee.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvEmployeeList)).BeginInit();
            this.tabPageDetail.SuspendLayout();
            this.tabPageExcel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvStatistical)).BeginInit();
            this.SuspendLayout();
            // 
            // tsTop
            // 
            this.tsTop.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(189)))), ((int)(((byte)(89)))));
            this.tsTop.GripStyle = System.Windows.Forms.ToolStripGripStyle.Hidden;
            this.tsTop.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripSeparator1,
            this.tsbbtnEmployee,
            this.toolStripSeparator5,
            this.tsbbtnStatistical,
            this.toolStripSeparator4});
            this.tsTop.Location = new System.Drawing.Point(0, 0);
            this.tsTop.Name = "tsTop";
            this.tsTop.Size = new System.Drawing.Size(868, 55);
            this.tsTop.TabIndex = 0;
            this.tsTop.Text = "toolStrip1";
            this.tsTop.ItemClicked += new System.Windows.Forms.ToolStripItemClickedEventHandler(this.tsTop_ItemClicked);
            // 
            // toolStripSeparator1
            // 
            this.toolStripSeparator1.Name = "toolStripSeparator1";
            this.toolStripSeparator1.Size = new System.Drawing.Size(6, 55);
            // 
            // tsbbtnEmployee
            // 
            this.tsbbtnEmployee.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tsbbtnEmployee.Image = global::Book.Properties.Resources.em;
            this.tsbbtnEmployee.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.tsbbtnEmployee.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tsbbtnEmployee.Name = "tsbbtnEmployee";
            this.tsbbtnEmployee.Size = new System.Drawing.Size(127, 52);
            this.tsbbtnEmployee.Text = "Employee";
            // 
            // toolStripSeparator5
            // 
            this.toolStripSeparator5.Name = "toolStripSeparator5";
            this.toolStripSeparator5.Size = new System.Drawing.Size(6, 55);
            // 
            // tsbbtnStatistical
            // 
            this.tsbbtnStatistical.AutoSize = false;
            this.tsbbtnStatistical.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tsbbtnStatistical.Image = global::Book.Properties.Resources.pj;
            this.tsbbtnStatistical.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.tsbbtnStatistical.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tsbbtnStatistical.Name = "tsbbtnStatistical";
            this.tsbbtnStatistical.Size = new System.Drawing.Size(158, 52);
            this.tsbbtnStatistical.Text = "Statistical";
            // 
            // toolStripSeparator4
            // 
            this.toolStripSeparator4.Name = "toolStripSeparator4";
            this.toolStripSeparator4.Size = new System.Drawing.Size(6, 55);
            // 
            // tabControl1
            // 
            this.tabControl1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tabControl1.Controls.Add(this.tabPageEmployee);
            this.tabControl1.Controls.Add(this.tabPageDetail);
            this.tabControl1.Controls.Add(this.tabPageExcel);
            this.tabControl1.Location = new System.Drawing.Point(12, 58);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(844, 428);
            this.tabControl1.TabIndex = 1;
            // 
            // tabPageEmployee
            // 
            this.tabPageEmployee.Controls.Add(this.btnEdit);
            this.tabPageEmployee.Controls.Add(this.btnDeleteEm);
            this.tabPageEmployee.Controls.Add(this.btnAdd);
            this.tabPageEmployee.Controls.Add(this.dgvEmployeeList);
            this.tabPageEmployee.Location = new System.Drawing.Point(4, 22);
            this.tabPageEmployee.Name = "tabPageEmployee";
            this.tabPageEmployee.Padding = new System.Windows.Forms.Padding(3);
            this.tabPageEmployee.Size = new System.Drawing.Size(836, 402);
            this.tabPageEmployee.TabIndex = 1;
            this.tabPageEmployee.Text = "EmloyeeList";
            this.tabPageEmployee.UseVisualStyleBackColor = true;
            // 
            // btnEdit
            // 
            this.btnEdit.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnEdit.Location = new System.Drawing.Point(711, 106);
            this.btnEdit.Name = "btnEdit";
            this.btnEdit.Size = new System.Drawing.Size(97, 33);
            this.btnEdit.TabIndex = 7;
            this.btnEdit.Text = "Edit";
            this.btnEdit.UseVisualStyleBackColor = true;
            // 
            // btnDeleteEm
            // 
            this.btnDeleteEm.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnDeleteEm.Location = new System.Drawing.Point(711, 164);
            this.btnDeleteEm.Name = "btnDeleteEm";
            this.btnDeleteEm.Size = new System.Drawing.Size(97, 33);
            this.btnDeleteEm.TabIndex = 6;
            this.btnDeleteEm.Text = "Delete";
            this.btnDeleteEm.UseVisualStyleBackColor = true;
            // 
            // btnAdd
            // 
            this.btnAdd.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnAdd.Location = new System.Drawing.Point(711, 44);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(97, 33);
            this.btnAdd.TabIndex = 4;
            this.btnAdd.Text = "Add";
            this.btnAdd.UseVisualStyleBackColor = true;
            // 
            // dgvEmployeeList
            // 
            this.dgvEmployeeList.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dgvEmployeeList.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvEmployeeList.Location = new System.Drawing.Point(6, 31);
            this.dgvEmployeeList.Name = "dgvEmployeeList";
            this.dgvEmployeeList.Size = new System.Drawing.Size(676, 365);
            this.dgvEmployeeList.TabIndex = 0;
            // 
            // tabPageDetail
            // 
            this.tabPageDetail.Controls.Add(this.txtGender);
            this.tabPageDetail.Controls.Add(this.dtpBirth);
            this.tabPageDetail.Controls.Add(this.btnSave);
            this.tabPageDetail.Controls.Add(this.btnCancel);
            this.tabPageDetail.Controls.Add(this.label8);
            this.tabPageDetail.Controls.Add(this.label7);
            this.tabPageDetail.Controls.Add(this.label6);
            this.tabPageDetail.Controls.Add(this.label5);
            this.tabPageDetail.Controls.Add(this.label4);
            this.tabPageDetail.Controls.Add(this.label3);
            this.tabPageDetail.Controls.Add(this.label2);
            this.tabPageDetail.Controls.Add(this.txtName);
            this.tabPageDetail.Controls.Add(this.txtAddress);
            this.tabPageDetail.Controls.Add(this.txtCity);
            this.tabPageDetail.Controls.Add(this.txtPhone);
            this.tabPageDetail.Controls.Add(this.txtEmail);
            this.tabPageDetail.Location = new System.Drawing.Point(4, 22);
            this.tabPageDetail.Name = "tabPageDetail";
            this.tabPageDetail.Padding = new System.Windows.Forms.Padding(3);
            this.tabPageDetail.Size = new System.Drawing.Size(836, 402);
            this.tabPageDetail.TabIndex = 2;
            this.tabPageDetail.Text = "Detail";
            this.tabPageDetail.UseVisualStyleBackColor = true;
            this.tabPageDetail.Click += new System.EventHandler(this.tabPage3_Click);
            // 
            // dtpBirth
            // 
            this.dtpBirth.Location = new System.Drawing.Point(160, 127);
            this.dtpBirth.Name = "dtpBirth";
            this.dtpBirth.Size = new System.Drawing.Size(185, 20);
            this.dtpBirth.TabIndex = 34;
            // 
            // btnSave
            // 
            this.btnSave.Location = new System.Drawing.Point(288, 326);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(96, 23);
            this.btnSave.TabIndex = 33;
            this.btnSave.Text = "Save";
            this.btnSave.UseVisualStyleBackColor = true;
            // 
            // btnCancel
            // 
            this.btnCancel.Location = new System.Drawing.Point(434, 326);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(96, 23);
            this.btnCancel.TabIndex = 32;
            this.btnCancel.Text = "Cancel";
            this.btnCancel.UseVisualStyleBackColor = true;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(68, 184);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(45, 13);
            this.label8.TabIndex = 31;
            this.label8.Text = "Gender:";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(227, 241);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(41, 13);
            this.label7.TabIndex = 30;
            this.label7.Text = "Phone:";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(392, 184);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(27, 13);
            this.label6.TabIndex = 29;
            this.label6.Text = "City:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(392, 133);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(48, 13);
            this.label5.TabIndex = 28;
            this.label5.Text = "Address:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(392, 81);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(35, 13);
            this.label4.TabIndex = 27;
            this.label4.Text = "Email:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(68, 133);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(53, 13);
            this.label3.TabIndex = 26;
            this.label3.Text = "BirthYear:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(68, 82);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(38, 13);
            this.label2.TabIndex = 25;
            this.label2.Text = "Name:";
            // 
            // txtName
            // 
            this.txtName.Location = new System.Drawing.Point(160, 79);
            this.txtName.Name = "txtName";
            this.txtName.Size = new System.Drawing.Size(185, 20);
            this.txtName.TabIndex = 22;
            // 
            // txtAddress
            // 
            this.txtAddress.Location = new System.Drawing.Point(487, 130);
            this.txtAddress.Name = "txtAddress";
            this.txtAddress.Size = new System.Drawing.Size(195, 20);
            this.txtAddress.TabIndex = 20;
            // 
            // txtCity
            // 
            this.txtCity.Location = new System.Drawing.Point(487, 181);
            this.txtCity.Name = "txtCity";
            this.txtCity.Size = new System.Drawing.Size(195, 20);
            this.txtCity.TabIndex = 19;
            // 
            // txtPhone
            // 
            this.txtPhone.Location = new System.Drawing.Point(322, 238);
            this.txtPhone.Name = "txtPhone";
            this.txtPhone.Size = new System.Drawing.Size(195, 20);
            this.txtPhone.TabIndex = 18;
            // 
            // txtEmail
            // 
            this.txtEmail.Location = new System.Drawing.Point(487, 78);
            this.txtEmail.Name = "txtEmail";
            this.txtEmail.Size = new System.Drawing.Size(195, 20);
            this.txtEmail.TabIndex = 17;
            // 
            // tabPageExcel
            // 
            this.tabPageExcel.Controls.Add(this.btnCheck);
            this.tabPageExcel.Controls.Add(this.cboTop);
            this.tabPageExcel.Controls.Add(this.label9);
            this.tabPageExcel.Controls.Add(this.btnSearch);
            this.tabPageExcel.Controls.Add(this.label18);
            this.tabPageExcel.Controls.Add(this.label11);
            this.tabPageExcel.Controls.Add(this.dptEnd);
            this.tabPageExcel.Controls.Add(this.dptStart);
            this.tabPageExcel.Controls.Add(this.dgvStatistical);
            this.tabPageExcel.Location = new System.Drawing.Point(4, 22);
            this.tabPageExcel.Name = "tabPageExcel";
            this.tabPageExcel.Padding = new System.Windows.Forms.Padding(3);
            this.tabPageExcel.Size = new System.Drawing.Size(836, 402);
            this.tabPageExcel.TabIndex = 4;
            this.tabPageExcel.Text = "Excel";
            this.tabPageExcel.UseVisualStyleBackColor = true;
            // 
            // btnCheck
            // 
            this.btnCheck.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.btnCheck.Location = new System.Drawing.Point(724, 21);
            this.btnCheck.Name = "btnCheck";
            this.btnCheck.Size = new System.Drawing.Size(82, 23);
            this.btnCheck.TabIndex = 10;
            this.btnCheck.Text = "Check";
            this.btnCheck.UseVisualStyleBackColor = true;
            // 
            // cboTop
            // 
            this.cboTop.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.cboTop.FormattingEnabled = true;
            this.cboTop.Items.AddRange(new object[] {
            "10",
            "3",
            "5"});
            this.cboTop.Location = new System.Drawing.Point(655, 23);
            this.cboTop.Name = "cboTop";
            this.cboTop.Size = new System.Drawing.Size(42, 21);
            this.cboTop.Sorted = true;
            this.cboTop.TabIndex = 9;
            this.cboTop.Text = "3";
            // 
            // label9
            // 
            this.label9.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Times New Roman", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.Location = new System.Drawing.Point(562, 25);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(87, 15);
            this.label9.TabIndex = 8;
            this.label9.Text = "Top Customer:";
            // 
            // btnSearch
            // 
            this.btnSearch.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.btnSearch.Location = new System.Drawing.Point(294, 99);
            this.btnSearch.Name = "btnSearch";
            this.btnSearch.Size = new System.Drawing.Size(82, 23);
            this.btnSearch.TabIndex = 5;
            this.btnSearch.Text = "Search";
            this.btnSearch.UseVisualStyleBackColor = true;
            // 
            // label18
            // 
            this.label18.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.label18.AutoSize = true;
            this.label18.Font = new System.Drawing.Font("Times New Roman", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label18.Location = new System.Drawing.Point(42, 66);
            this.label18.Name = "label18";
            this.label18.Size = new System.Drawing.Size(74, 15);
            this.label18.TabIndex = 4;
            this.label18.Text = "Finish Date:";
            // 
            // label11
            // 
            this.label11.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("Times New Roman", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label11.Location = new System.Drawing.Point(42, 20);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(67, 15);
            this.label11.TabIndex = 3;
            this.label11.Text = "Start Date:";
            // 
            // dptEnd
            // 
            this.dptEnd.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.dptEnd.Location = new System.Drawing.Point(145, 66);
            this.dptEnd.Name = "dptEnd";
            this.dptEnd.Size = new System.Drawing.Size(231, 20);
            this.dptEnd.TabIndex = 2;
            // 
            // dptStart
            // 
            this.dptStart.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.dptStart.Location = new System.Drawing.Point(145, 20);
            this.dptStart.Name = "dptStart";
            this.dptStart.Size = new System.Drawing.Size(231, 20);
            this.dptStart.TabIndex = 1;
            // 
            // dgvStatistical
            // 
            this.dgvStatistical.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dgvStatistical.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvStatistical.Location = new System.Drawing.Point(6, 128);
            this.dgvStatistical.Name = "dgvStatistical";
            this.dgvStatistical.Size = new System.Drawing.Size(824, 268);
            this.dgvStatistical.TabIndex = 0;
            // 
            // txtGender
            // 
            this.txtGender.FormattingEnabled = true;
            this.txtGender.Items.AddRange(new object[] {
            "Boy",
            "Girl",
            "..."});
            this.txtGender.Location = new System.Drawing.Point(160, 181);
            this.txtGender.Name = "txtGender";
            this.txtGender.Size = new System.Drawing.Size(79, 21);
            this.txtGender.TabIndex = 35;
            this.txtGender.Text = "Boy";
            // 
            // ManagerView
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(868, 498);
            this.Controls.Add(this.tabControl1);
            this.Controls.Add(this.tsTop);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "ManagerView";
            this.Text = "ManagerView";
            this.Load += new System.EventHandler(this.ManagerView_Load);
            this.tsTop.ResumeLayout(false);
            this.tsTop.PerformLayout();
            this.tabControl1.ResumeLayout(false);
            this.tabPageEmployee.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvEmployeeList)).EndInit();
            this.tabPageDetail.ResumeLayout(false);
            this.tabPageDetail.PerformLayout();
            this.tabPageExcel.ResumeLayout(false);
            this.tabPageExcel.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvStatistical)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ToolStrip tsTop;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
        private System.Windows.Forms.ToolStripButton tsbbtnEmployee;
        private System.Windows.Forms.ToolStripButton tsbbtnStatistical;
        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabPageEmployee;
        private System.Windows.Forms.DataGridView dgvEmployeeList;
        private System.Windows.Forms.TabPage tabPageDetail;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtName;
        private System.Windows.Forms.TextBox txtAddress;
        private System.Windows.Forms.TextBox txtCity;
        private System.Windows.Forms.TextBox txtPhone;
        private System.Windows.Forms.TextBox txtEmail;
        private System.Windows.Forms.TabPage tabPageExcel;
        private System.Windows.Forms.Button btnDeleteEm;
        private System.Windows.Forms.Button btnAdd;
        private System.Windows.Forms.Button btnSave;
        private System.Windows.Forms.Button btnCancel;
        private System.Windows.Forms.Button btnSearch;
        private System.Windows.Forms.Label label18;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.DateTimePicker dptEnd;
        private System.Windows.Forms.DateTimePicker dptStart;
        private System.Windows.Forms.DataGridView dgvStatistical;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator5;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator4;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.DateTimePicker dtpBirth;
        private System.Windows.Forms.ComboBox cboTop;
        private System.Windows.Forms.Button btnCheck;
        private System.Windows.Forms.Button btnEdit;
        private System.Windows.Forms.ComboBox txtGender;
    }
}