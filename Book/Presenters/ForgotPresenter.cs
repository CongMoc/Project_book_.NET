using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Book.Models;
using Book.Reponsitories;
using Book.Views;

namespace Book.Presenters
{
    public class ForgotPresenter
    {
        private ILoginView login;
        private ILoginReponsitory reponsitory;
        private string sqlConnectionString;
        public ForgotPresenter(ILoginView login,string sqlConnectionString)
        {
            this.login = login;
            this.reponsitory = new LoginReponsitory(sqlConnectionString);
            this.sqlConnectionString = sqlConnectionString;
            this.login.ForgotPass += ForgotPassword;
            this.login.ShowChangePass += ShowChangeView;
            this.login.ShowLogin += ShowLoginView;
            this.login.Show();
        }

        private void ShowLoginView(object sender, EventArgs e)
        {
            ILoginView view = new LoginView();
            new LoginPresenter(view, reponsitory, sqlConnectionString);
        }

        private void ShowChangeView(object sender, EventArgs e)
        {
            ILoginView view = new ChangePassView();
            new ChangePassPresenter(view, reponsitory, sqlConnectionString, login.email,true);
        }

        private void ForgotPassword(object sender, EventArgs e)
        {
            if (login.email != "")
            {
                login.IsSuccessful = false;
                int checkemail = reponsitory.CheckEmailBeforeRegister(login.email);
                if(checkemail== 0)
                {
                    login.IsSuccessful = true;
                }
                else if(checkemail ==1)
                {
                    login.Message = "Email is invaid!!!";
                }
                else
                {
                    login.Message = "Email is not existsed!!!";
                }
            }
        }
    }
}
