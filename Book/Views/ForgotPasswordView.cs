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
    public partial class ForgotPasswordView : Form,ILoginView
    {
        public ForgotPasswordView()
        {
            InitializeComponent();
            Events();
        }

        private void Events()
        {
            btnResetPass.Click += delegate
            {
                if (txtEmail.Text != "")
                {
                    ForgotPass?.Invoke(this, EventArgs.Empty);
                    if (IsSuccessful)
                    {
                        ShowChangePass?.Invoke(this, EventArgs.Empty);
                        this.Close();
                    }
                    else
                    {
                        lbMessage.Text = Message;
                    }
                }
                else
                {
                    lbMessage.Text = "Email is not null";
                }
            };
            lbLogin.Click += delegate
            {
                lbMessage.Text = "";
                ShowLogin?.Invoke(this, EventArgs.Empty);
                this.Close();
            };
        }

        public string email
        { 
            get { return txtEmail.Text; } 
            set { txtEmail.Text = value; } 
        }
        private bool issuccessful;
        private string message;
        public string password { get; set; }
        public string name { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }
        public string lastname { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }
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

        public event EventHandler LoginEvent;
        public event EventHandler ShowMainBook;
        public event EventHandler RegisterEvent;
        public event EventHandler ShowRegister;
        public event EventHandler ShowForgotPass;
        public event EventHandler ForgotPass;
        public event EventHandler ChangePass;
        public event EventHandler ShowChangePass;
        public event EventHandler ShowLogin;
    }
}
