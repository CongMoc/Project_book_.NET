using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Runtime.Remoting.Messaging;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.ProgressBar;

namespace Book.Views
{
    public partial class RegisterView : Form,ILoginView
    {
        public RegisterView()
        {
            InitializeComponent();
            AssociateAndRaiseViewEvents();
        }

        private void AssociateAndRaiseViewEvents()
        {
            btnRegister.Click += delegate
            {
                if (txtEmail.Text == "" || txtPassword.Text == "" || txtRetype.Text == "")
                {
                    lbMessage.Text = "Email,Password and retype password is not null!!!";
                }
                else
                {
                    if (txtRetype.Text == txtPassword.Text)
                    {
                        RegisterEvent?.Invoke(this, EventArgs.Empty);
                        if (IsSuccessful)
                        {
                            this.Hide();
                            ShowLogin?.Invoke(this, EventArgs.Empty);
                            this.Close();
                            MessageBox.Show(Message);
                        }
                        else
                        {
                            lbMessage.Text = Message;
                        }
                    }
                    else
                    {
                        lbMessage.Text = "Password and re-enter password are not the same!!!";
                    }
                }
            };
            lbBack.Click += delegate
            {
                this.Hide();
                ShowLogin?.Invoke(this, EventArgs.Empty);
                this.Close();
            };
        }

        static int countpass = 0;
        static int countretype = 0;
        private bool isSuccessful;
        private string message;

        public event EventHandler LoginEvent;
        public event EventHandler ShowMainBook;
        public event EventHandler RegisterEvent;
        public event EventHandler ForgotPass;
        public event EventHandler ShowRegister;
        public event EventHandler ShowForgotPass;
        public event EventHandler ChangePass;
        public event EventHandler ShowChangePass;
        public event EventHandler ShowLogin;

        public string email 
        { 
            get { return txtEmail.Text; }
            set { txtEmail.Text = value; }
        }
        public string password 
        {
            get { return txtPassword.Text; }
            set { txtPassword.Text = value; }
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
        public string name
        {
            get { return txtName.Text; }
            set { txtName.Text = value; }
        }
        public string lastname
        {
            get { return txtLastName.Text; }
            set { txtLastName.Text = value; }
        }

        private void btnBack_Click(object sender, EventArgs e)
        {
        }

        private void pictureBoxSeeRetype_MouseClick(object sender, MouseEventArgs e)
        {
            if (countpass == 0)
            {
                txtPassword.UseSystemPasswordChar = false;
                countretype++;
            }
            else
            {
                txtPassword.UseSystemPasswordChar = true;
                countretype--;
            }
        }

        private void pictureBoxSeePass_MouseClick(object sender, MouseEventArgs e)
        {
            if (countpass == 0)
            {
                txtPassword.UseSystemPasswordChar = false;
                countpass++;
            }
            else
            {
                txtPassword.UseSystemPasswordChar = true;
                countpass--;
            }
        }

        private void txtName_MouseClick(object sender, MouseEventArgs e)
        {
            txtName.Text = "";
        }

        private void txtLastName_MouseClick(object sender, MouseEventArgs e)
        {
            txtLastName.Text = "";
        }

        private void txtEmail_MouseClick(object sender, MouseEventArgs e)
        {
            txtEmail.Text = "";
        }

        private void txtPassword_MouseClick(object sender, MouseEventArgs e)
        {
            txtPassword.Text = "";
            txtPassword.UseSystemPasswordChar = true;
        }

        private void txtRetype_MouseClick(object sender, MouseEventArgs e)
        {
            txtRetype.Text = "";
            txtRetype.UseSystemPasswordChar = true;
        }

        private void btnRegister_Click(object sender, EventArgs e)
        {

        }

        private void RegisterView_Load(object sender, EventArgs e)
        {

        }
    }
}
