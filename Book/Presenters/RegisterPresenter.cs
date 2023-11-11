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
    public class RegisterPresenter
    {
        private ILoginView loginView;
        private ILoginReponsitory reponsitory;
        private readonly string sqlConnectionString;
        public RegisterPresenter(ILoginView loginView,string sqlConnectionString)
        {
            this.loginView = loginView;
            this.reponsitory = new LoginReponsitory(sqlConnectionString);
            this.sqlConnectionString = sqlConnectionString;
            this.loginView.RegisterEvent += RegisterUser;
            this.loginView.ShowLogin += ShowLogin;
            this.loginView.Show();
        }

        private void ShowLogin(object sender, EventArgs e)
        {
            ILoginView view = new LoginView();
            new LoginPresenter(view, reponsitory, sqlConnectionString);
        }

        private void RegisterUser(object sender, EventArgs e)
        {
            var model = new LoginModel();
            model.Email = loginView.email;
            model.Password = loginView.password;
            model.Name = loginView.name;
            model.LastName = loginView.lastname;
            int check = reponsitory.CheckEmailBeforeRegister(model.Email);
            try
            {
                loginView.IsSuccessful = true;
                if (check == 1)
                {
                    loginView.Message = "Email is invaid";
                    loginView.IsSuccessful =false;
                }
                else if(check ==0)
                {
                    loginView.Message = "Email is existed!!!";
                    loginView.IsSuccessful = false;
                }
                else
                {
                    reponsitory.Add(model);
                    loginView.Message = "Registed Successfully!!!";
                }
            }
            catch (Exception ex)
            {
                loginView.IsSuccessful = false;
                loginView.Message = ex.Message;
            }
        }
    }
}
