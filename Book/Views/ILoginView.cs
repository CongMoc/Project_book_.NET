using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Book.Views
{
    public interface ILoginView
    {
        //Properties - Fields
        string email { get; set; }
        string  password { get; set; }
        string name { get; set; }   
        string lastname { get; set; }
        bool IsSuccessful { get; set; }
        string Message { get; set; }
        //Events
        event EventHandler LoginEvent;
        event EventHandler ShowMainBook;
        event EventHandler RegisterEvent;
        event EventHandler ShowRegister;
        event EventHandler ShowForgotPass;
        event EventHandler ForgotPass;
        event EventHandler ChangePass;
        event EventHandler ShowChangePass;
        event EventHandler ShowLogin;
        void Show();
    }
}
