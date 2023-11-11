using Book.Models;
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
    public partial class ChangePassView : Form, ILoginView
    {
        public ChangePassView()
        {
            InitializeComponent();
            Events();
        }

        private void Events()
        {
            btnChange.Click += delegate
            {
                if ( txtNewPassword.Text == "" || txtRetypePass.Text == "")
                {
                    lbMessage.Text = "Old pass, new pass and retype pass is not null!!!";
                }
                else
                {
                    if (txtNewPassword.Text == txtRetypePass.Text)
                    {
                        ChangePass?.Invoke(this, EventArgs.Empty);
                        if(IsSuccessful ==false)
                        {
                            this.Close();
                        }
                        MessageBox.Show(Message);
                    }
                    else
                    {
                        lbMessage.Text = "New password and retype password is not same!!!";
                    }
                }
            };
            if(IsSuccessful)
            {
                lbLogin.Enabled = false;
                lbLogin.Click += delegate
                {
                    this.Close();
                    ShowLogin?.Invoke(this, EventArgs.Empty);
                };
            }
            else
            {
                lbLogin.Enabled = true;
                lbClose.Click += delegate
                {
                    this.Close();
                };
            }
            lbLogin.Click += delegate
            {
                this.Close(); 
                ShowLogin?.Invoke(this, EventArgs.Empty);
            };
        }

        static int count = 0;
        static int countretype = 0;
        private string message;
        public event EventHandler LoginEvent;
        public event EventHandler ShowMainBook;
        public event EventHandler RegisterEvent;
        public event EventHandler ShowRegister;
        public event EventHandler ShowForgotPass;
        public event EventHandler ForgotPass;
        public event EventHandler ChangePass;
        public event EventHandler ShowChangePass;
        public event EventHandler ShowLogin;

        private string Email;
        public string email
        {
            get { return Email; }
            set { Email = value; }
        }
        public string password
        {
            get
            {
                return txtNewPassword.Text;
            }
            set { txtNewPassword.Text = value; }
        }
        public string name { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }
        public string lastname { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }
        private bool issuccessful;
        public bool IsSuccessful 
        {
            get { return issuccessful; }
            set { issuccessful = value; } 
        }
        public string Message
        {
            get { return message; }
            set { message = value; }
        }

        private void lbClose_Click(object sender, EventArgs e)
        {

        }

        private void pictureBoxSeePass_MouseClick(object sender, MouseEventArgs e)
        {
            if (count == 0)
            {
                txtNewPassword.UseSystemPasswordChar = false;
                count++;
            }
            else
            {
                txtNewPassword.UseSystemPasswordChar = true;
                count--;
            }

        }

        private void pictureBoxSeeRetype_MouseClick(object sender, MouseEventArgs e)
        {
            if (countretype == 0)
            {
                txtNewPassword.UseSystemPasswordChar = false;
                countretype++;
            }
            else
            {
                txtNewPassword.UseSystemPasswordChar = true;
                countretype--;
            }
        }

        private void txtOldPass_MouseClick(object sender, MouseEventArgs e)
        {
            
        }

        private void txtNewPassword_MouseClick(object sender, MouseEventArgs e)
        {
            txtNewPassword.Text = "";
            txtNewPassword.UseSystemPasswordChar = true;
        }

        private void txtRetypePass_MouseClick(object sender, MouseEventArgs e)
        {
            txtRetypePass.Text = "";
            txtRetypePass.UseSystemPasswordChar = true;
        }

        private void ChangePassword_Load(object sender, EventArgs e)
        {

        }
    }
}
