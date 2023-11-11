using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Book.Models;
using Book.Reponsitories;
using Book.Views;

namespace Book.Presenters
{
    internal class LoginPresenter
    {
        private ILoginView loginView;
        private ILoginReponsitory reponsitory;
        private string sqlConnectionString;
        private bool check;
        public LoginPresenter(ILoginView loginView,ILoginReponsitory reponsitory,string sqlConnectionString )
        {
            this.loginView = loginView;
            this.reponsitory = reponsitory;
            this.sqlConnectionString = sqlConnectionString;
            this.loginView.LoginEvent += LoginEvent;
            this.loginView.ShowMainBook += ShowMainBook;
            this.loginView.ShowRegister += ShowRegisters;
            this.loginView.ShowForgotPass += ShowForgotPass;
            loginView.Show();
        }

        private void ShowForgotPass(object sender, EventArgs e)
        {
            ILoginView view = new ForgotPasswordView();
            new ForgotPresenter(view,sqlConnectionString);
        }

        private void ShowRegisters(object sender, EventArgs e)
        {
            ILoginView view = new RegisterView();
            new RegisterPresenter(view,sqlConnectionString);
        }

        private void LoginEvent(object sender, EventArgs e)
        {

            int checkemail = reponsitory.CheckEmailBeforeRegister(loginView.email);
            int login = reponsitory.Check(loginView.email, loginView.password);
            if (login == 1 || login == 2)
            {
                loginView.Message = "Loginned Successfully!!!";
                loginView.IsSuccessful = true;
                if(login ==1)
                {
                    check = true;
                }
            }
            else
            {
                loginView.IsSuccessful = false;
                if (login == 0 || checkemail == 0)
                {
                    loginView.Message = "Password is wrong...Please try again!!!";
                }
                else if(login == 4)
                {
                    loginView.Message = "Email and password is wrong!!!";
                }
                else
                {
                    if(checkemail==1)
                    {
                        loginView.Message = "Email is invaid!!!";
                    }
                    else
                    {
                        loginView.Message = "Email is wrong...Please try again!!!";
                    }
                }
            }
        }

        private void ShowMainBook(object sender, EventArgs e)
        {
            int id = reponsitory.CheckUser(loginView.email);
            //employee == fales else => customer == true
            IMainView view = new MainView();
            if (id == 0)
            {
                new MainPresenter(view, sqlConnectionString, check, id,false);
            }
            else
            {
                new MainPresenter(view, sqlConnectionString, check, id,true);
            }
        }
    }
}
