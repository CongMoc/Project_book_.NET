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
    public partial class ProfileView : Form,ICustomerView
    {
        public ProfileView()
        {
            InitializeComponent();
            lbName.Text = name;
            tsbbtnEdit.Enabled = true;
            Events();
        }
        private static ProfileView instance;
        public static ProfileView GetInstace(Form parentContainer)
        {
            if (instance == null || instance.IsDisposed)
            {
                instance = new ProfileView();
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
        private void Events()
        {
            tsbbtnEdit.Click += delegate
            {
                tsbbtnSave.Enabled = true;
                tsbbtnEdit.Enabled = false;
                txtAddress.Enabled = true;
                txtCity.Enabled = true;
                txtName.Enabled = true;
                txtEmail.Enabled = true;
                txtPhone.Enabled = true;    
                cboGender.Enabled = true;
                dtpBirth.Enabled = true;
            };
            tsbbtnSave.Click += delegate
            {
                SaveEmployee?.Invoke(this, EventArgs.Empty);
                if(IsSuccessful)
                {
                    tsbbtnSave.Enabled = false;
                    tsbbtnEdit.Enabled = true;
                    txtAddress.Enabled = false;
                    txtCity.Enabled = false;
                    txtName.Enabled = false;
                    txtEmail.Enabled = false;
                    txtPhone.Enabled = false;
                    cboGender.Enabled = false;
                    dtpBirth.Enabled = false;
                    MessageBox.Show(Message);
                }
            };
            tsbbtnChangePass.Click += delegate
            {
                ShowChangePass?.Invoke(this, EventArgs.Empty);
            };
        }

        private string Id;
        public string id
        {
            get { return Id; }
            set { Id = value; }
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
        public DateTime start { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }
        public DateTime end { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }
        public string gender
        {
            get { return cboGender.Text; }
            set { cboGender.Text = value; }
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
        private string message;
        public string Message
        {
            get { return message; }
            set { message = value; }
        }
        string ICustomerView.Top { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }

        public event EventHandler CustomerEvent;
        public event EventHandler EmployeeEvent;
        public event EventHandler AddEmployee;
        public event EventHandler RemoveEmployee;
        public event EventHandler UpdateEmployee;
        public event EventHandler SaveEmployee;
        public event EventHandler SearchStatital;
        public event EventHandler TopCustomer;
        public event EventHandler Cancel;
        public event EventHandler ShowChangePass;

        public void SetDataEmployee(BindingSource EmployeeList)
        {
            throw new NotImplementedException();
        }

        public void SetDataStatial(BindingSource StatialList)
        {
            throw new NotImplementedException();
        }

        public void SetDataTopCustomer(BindingSource TopCustomer)
        {
            throw new NotImplementedException();
        }

        private void dateTimePicker1_ValueChanged(object sender, EventArgs e)
        {

        }

        private void ProfileView_Load(object sender, EventArgs e)
        {
            EmployeeEvent?.Invoke(this, EventArgs.Empty);
            tsbbtnSave.Enabled = false;
        }
    }
}
