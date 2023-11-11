using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Book.Views
{
    public interface IBookView
    {
        //Properties - Fields
        string idOrder { get; set; }
        string idBook { get; set; }       
        string title { get; set; }
        string category { get; set; }
        string author { get; set; }
        string age { get; set; }
        string status { get; set; }
        string percentgift { get; set; }
        string quantity { get; set; }
        string money { get; set; }  
        string SearchValue { get; set; }
        bool IsEdit { get; set; }
        bool IsSuccessful { get; set; } 
        string Message { get; set; }
        DateTime borrow { get; set; }   
        DateTime pay{ get; set; }
        string summoney { get; set; }
        //Events
        event EventHandler SearchEvent;
        event EventHandler AddNewEvent;
        event EventHandler EditEvent;
        event EventHandler DeleteEvent;
        event EventHandler SaveEvent;
        event EventHandler CancelEvent;
        event EventHandler PaywithIDBook;
        event EventHandler ShowExcel;
        //Methods
        DataGridView data { get; set; }
        void SetBookListBindingSource(BindingSource bookList);
        void Show();//Optional
    }
}
