using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;
using Book.Models;
using Book.Views;
using Book.Presenters;
using Book.Reponsitories;
using System.Configuration;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.ProgressBar;

namespace Book
{
    internal static class Program
    {
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            string sqlConnectionString = ConfigurationManager.ConnectionStrings["SqlConnection"].ConnectionString;
            ILoginView view = new LoginView();
            ILoginReponsitory reponsitory = new LoginReponsitory(sqlConnectionString);
            new LoginPresenter(view, reponsitory, sqlConnectionString);
            Application.Run((Form)view);
        }
    }
}
