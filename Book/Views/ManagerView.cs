using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Book.Views
{
    public partial class ManagerView : Form,ICustomerView
    {
        public ManagerView()
        {
            InitializeComponent();
            Events();
            tabControl1.TabPages.Remove(tabPageExcel);
            tabControl1.TabPages.Remove(tabPageDetail);
        }

        private void Events()
        {
            tsbbtnEmployee.Click += delegate
            {
                EmployeeEvent?.Invoke(this, EventArgs.Empty);
                tabControl1.TabPages.Add(tabPageEmployee);
                tabControl1.TabPages.Remove(tabPageExcel);
                tabControl1.TabPages.Remove(tabPageDetail);
            };
            tsbbtnStatistical.Click += delegate
            {
                tabControl1.TabPages.Add(tabPageExcel); 
                tabControl1.TabPages.Remove(tabPageEmployee);
                tabControl1.TabPages.Remove(tabPageDetail);
            };
            btnSearch.Click += delegate
            {
                CustomerEvent?.Invoke(this, EventArgs.Empty);
            };
            btnCheck.Click += delegate
            {
                SearchStatital?.Invoke(this, EventArgs.Empty);
            };
            btnAdd.Click += delegate
            {
                AddEmployee?.Invoke(this, EventArgs.Empty);
                tabControl1.TabPages.Remove(tabPageExcel);
                tabControl1.TabPages.Remove(tabPageEmployee);
                tabControl1.TabPages.Add(tabPageDetail);
            };
            btnEdit.Click += delegate
            {
                UpdateEmployee?.Invoke(this, EventArgs.Empty);
                if (isEdit)
                {
                    tabControl1.TabPages.Remove(tabPageExcel);
                    tabControl1.TabPages.Remove(tabPageEmployee);
                    tabControl1.TabPages.Add(tabPageDetail);
                }
                else
                {
                    MessageBox.Show(Message);
                }
            };
            btnDeleteEm.Click += delegate
            {
                DialogResult result = MessageBox.Show("Do you want to remove this people!!!", "Warning", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                if(result == DialogResult.Yes)
                {
                    RemoveEmployee?.Invoke(this, EventArgs.Empty);
                }
            };
            btnSave.Click += delegate
            {
                SaveEmployee?.Invoke(this, EventArgs.Empty);
                if(IsSuccessful)
                { 
                    tabControl1.TabPages.Remove(tabPageExcel);
                    tabControl1.TabPages.Add(tabPageEmployee);
                    tabControl1.TabPages.Remove(tabPageDetail);
                }
                MessageBox.Show(Message);
            };
            btnCancel.Click += delegate
            {
                tabControl1.TabPages.Remove(tabPageExcel);
                tabControl1.TabPages.Add(tabPageEmployee);
                tabControl1.TabPages.Remove(tabPageDetail);
            };
        }

        public string name 
        {
            get { return txtName.Text; }
            set { txtName.Text = value; }
        }
        public DateTime birthyear
        { 
            get { return dtpBirth.Value; }
            set { dtpBirth.Value = value; }
        }
        public string gender 
        {
            get { return txtGender.Text; }
            set { txtGender.Text = value; } 
        }
        public string email 
        {
            get { return txtEmail.Text; }
            set { txtEmail.Text = value; }
        }
        public string address
        {
            get { return txtAddress.Text; }
            set { txtAddress.Text = value; } 
        }
        public string city
        {
            get { return txtCity.Text; }
            set { txtCity.Text = value; }
        }
        public string phone
        {
            get { return txtPhone.Text; } 
            set { txtPhone.Text = value; } 
        }
        private string message;
        private bool isEdit;
        private bool isSuccessful;
        public bool IsEdit
        { 
            get { return isEdit; }
            set { isEdit = value; }
        }
        public bool IsSuccessful 
        {
            get { return isSuccessful; }
            set { isSuccessful = value; }
        }
        public string Message
        { 
            get { return message; }
            set { message = value; }
        }
        public string Top
        {
            get { return cboTop.Text; }
            set { cboTop.Text = value; }
        }

        public DateTime start
        { 
            get { return dptStart.Value; }
            set { dptStart.Value = value; }
        }
        public DateTime end 
        {
            get { return dptEnd.Value; }
            set { dptEnd.Value = value; }
        }
        private string Id;
        public string id
        {
            get { return Id; }
            set { Id = value; }
        }

        public event EventHandler AddEmployee;
        public event EventHandler RemoveEmployee;
        public event EventHandler UpdateEmployee;
        public event EventHandler SaveEmployee;
        public event EventHandler EmployeeEvent;
        public event EventHandler SearchStatital;
        public event EventHandler CustomerEvent;
        public event EventHandler TopCustomer;
        public event EventHandler Cancel;
        public event EventHandler ShowChangePass;

        private static ManagerView instance;
        public static ManagerView GetInstace(Form parentContainer)
        {
            if (instance == null || instance.IsDisposed)
            {
                instance = new ManagerView();
                instance.MdiParent = parentContainer;
                instance.Dock = DockStyle.Fill;
            }
            else
            {
                if (instance.WindowState == FormWindowState.Minimized)
                {
                    instance.WindowState = FormWindowState.Normal;
                }
                instance.BringToFront();
            }
            return instance;
        }
        public void SetDataEmployee(BindingSource EmployeeList)
        {
            dgvEmployeeList.DataSource = EmployeeList;
        }

        public void SetDataStatial(BindingSource StatialList)
        {
            dgvStatistical.DataSource = StatialList;
        }

        private void tabPage3_Click(object sender, EventArgs e)
        {

        }

        private void tsbbtnBack_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void tsTop_ItemClicked(object sender, ToolStripItemClickedEventArgs e)
        {

        }

        public void SetDataTopCustomer(BindingSource TopCustomer)
        {
            dgvStatistical.DataSource = TopCustomer;
        }

        private void ManagerView_Load(object sender, EventArgs e)
        {
            EmployeeEvent?.Invoke(this,EventArgs.Empty);
        }
    }
}
