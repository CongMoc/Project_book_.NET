    using Book.Models;
using Book.Views;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Book.Presenters
{
    public class ChangePassPresenter
    {
        private ILoginView loginView;
        private ILoginReponsitory reponsitory;
        private readonly string sqlConnectionString;
        public ChangePassPresenter(ILoginView loginView, ILoginReponsitory reponsitory, string sqlConnectionString,string email,bool edit)
        {
            this.loginView = loginView;
            this.reponsitory = reponsitory;
            this.sqlConnectionString = sqlConnectionString;
            this.loginView.ChangePass += ChangePass;
            this.loginView.email = email;
            this.loginView.IsSuccessful = edit;
            this.loginView.ShowLogin += ShowLoginView;
            loginView.Show();
        }

        private void ShowLoginView(object sender, EventArgs e)
        {
            ILoginView view = new LoginView();
            new LoginPresenter(view, reponsitory, sqlConnectionString);
        }

        private void ChangePass(object sender, EventArgs e)
        {
            try
            {
                var model = new LoginModel();
                model.Email = loginView.email;
                model.Password = loginView.password;
                reponsitory.Edit(model);
                loginView.Message = "Changed password is successfully!!!";
            }
            catch(Exception ex)
            {
                loginView.Message = ex.Message;
            }
        }
    }
}
