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
    public partial class LoginView : Form,ILoginView
    {
        static int count = 0;
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
            get;
            set;
        }
        public string lastname
        {
            get;
            set;
        }

        public LoginView()
        {
            InitializeComponent();
            AssociateAndRaiseViewEvents();
        }

        private void AssociateAndRaiseViewEvents()
        {
            //Login
            btnLogin.Click += delegate 
            {
                if (txtEmail.Text != "")
                {
                    if (txtPassword.Text != "")
                    {
                        LoginEvent?.Invoke(this, EventArgs.Empty);
                        if (IsSuccessful)
                        {
                            this.Hide();
                            ShowMainBook?.Invoke(this, EventArgs.Empty);
                            MessageBox.Show(Message);
                        }
                        else
                        {
                            lbMessage.Text = Message;
                        }
                    }
                    else
                    {
                        lbMessage.Text = "Password is not null!!!";
                    }
                }
                else if(txtPassword.Text !="")
                {
                    lbMessage.Text = "Email is not null!!!";
                }
                else
                {
                    lbMessage.Text ="Email and password is not null!!!";
                }
            };
            btnLogin.KeyDown += (s, e) =>
            {
                if (e.KeyData == Keys.Enter)
                {
                    LoginEvent?.Invoke(this, EventArgs.Empty);
                    if (IsSuccessful)
                    {
                        this.Hide();
                        ShowMainBook?.Invoke(this, EventArgs.Empty);
                        MessageBox.Show(Message);
                    }
                    else
                    {
                        MessageBox.Show(Message);
                    }
                }
            };
            //Regiter
            lbRegister.Click += delegate
            {
                this.Hide();
                ShowRegister?.Invoke(this, EventArgs.Empty);
            };
            //ForgotPassword
            lbForgot.Click += delegate
            {
                this.Hide();
                ShowForgotPass?.Invoke(this, EventArgs.Empty);
            };
        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {

        }

        private void LoginView_Load(object sender, EventArgs e)
        {
            
        }

        public void CheckLoginUser(int check)
        {
            
        }

        private void lbRegister_Click(object sender, EventArgs e)
        {

        }

        private void pictureBoxSeePass_MouseClick(object sender, MouseEventArgs e)
        {
            if(count==0)
            {
                txtPassword.UseSystemPasswordChar = false;
                count++;
            }    
            else
            {
                txtPassword.UseSystemPasswordChar = true;
                count--;
            }
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

        private void btnLogin_Click(object sender, EventArgs e)
        {

        }

        private void lbClose_Click(object sender, EventArgs e)
        {
            DialogResult dg = MessageBox.Show("Do you want to exit?", "Warning", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (dg == DialogResult.Yes)
            {
                Application.Exit();
            }
        }

        private void txtPassword_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtPassword_Click(object sender, EventArgs e)
        {
            txtPassword.Text = "";
            txtPassword.UseSystemPasswordChar = true;
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }
    }
}
