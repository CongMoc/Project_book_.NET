using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Book.Views
{
    public interface IMainView
    {
        //Properties
        bool check { get; set; }
        string idcus { get; set; }   
        //Events
        event EventHandler ShowBook;
        event EventHandler ShowProfile;
        event EventHandler ShowCart;
        event EventHandler ShowHistory;
        event EventHandler ShowManager;
        event EventHandler ShowPublisher;
        event EventHandler ShowStory;
        void Show();
    }
}
