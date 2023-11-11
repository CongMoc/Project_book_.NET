using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Book.Models;
using Book.Reponsitories;
using Book.Views;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.ProgressBar;

namespace Book.Presenters
{
    public class MainPresenter
    {
        private IMainView mainView;
        private string sqlConnectionString;
        public int id;
        private bool checkuser;
        public MainPresenter(IMainView mainView, string sqlConnectionString,bool check, int idcus, bool checkuser)
        {
            this.mainView = mainView;
            this.sqlConnectionString = sqlConnectionString;
            this.mainView.ShowBook += ShowBooks;
            this.mainView.ShowCart += ShowCarts;
            this.mainView.ShowPublisher += ShowPublishers;
            this.mainView.ShowStory += StoryMons;
            this.mainView.ShowHistory += HistoriesView;
            this.mainView.ShowManager += ManagementView;
            this.mainView.ShowProfile += ShowProfileViews;
            this.mainView.check = check;
            id = idcus;
            this.mainView.idcus = idcus.ToString();
            this.mainView.Show();
            this.checkuser = checkuser;
        }

        private void ShowProfileViews(object sender, EventArgs e)
        {
            ICustomerView view = ProfileView.GetInstace((Form)mainView);
            new ProfilePresenter(view, sqlConnectionString, id, checkuser);
        }

        private void ManagementView(object sender, EventArgs e)
        {
            ICustomerView view = ManagerView.GetInstace((Form)mainView);
            new ManagerPresenter(view, sqlConnectionString);
        }

        private void HistoriesView(object sender, EventArgs e)
        {
            IBookView view = HistoryView.GetInstace((Form)mainView);
            new HistoryPresenter(view, sqlConnectionString, id);
        }

        private void StoryMons(object sender, EventArgs e)
        {
            IStoryView view = StoryView.GetInstace((Form)mainView);
            new StoryPresenter(view);
        }

        private void ShowPublishers(object sender, EventArgs e)
        {
            ILoginView view = new LoginView();
            ILoginReponsitory reponsitory = new LoginReponsitory(sqlConnectionString);
            new LoginPresenter(view, reponsitory, sqlConnectionString);
        }

        private void ShowCarts(object sender, EventArgs e)
        {
            IBookView cartView = CartView.GetInstace((Form)mainView);
            new CartPresenter(cartView,sqlConnectionString,id);
        }

        private void ShowBooks(object sender, EventArgs e)
        {
            IBookView view = BookView.GetInstace((Form)mainView);
            new BookPresenter(view, sqlConnectionString,id);
        }

    }
}
