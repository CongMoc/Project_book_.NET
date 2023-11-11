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
    public partial class frm_MainBook : Form,IBookView
    {
        private string message;
        private bool isSuccessful;

        public frm_MainBook()
        {
            InitializeComponent();
        }
        //Properties

        public int idBook 
        {
            get => throw new NotImplementedException(); 
            set => throw new NotImplementedException();
        }
        public string title 
        {
            get => throw new NotImplementedException(); 
            set => throw new NotImplementedException();
        }
        public string category 
        { 
            get => throw new NotImplementedException(); 
            set => throw new NotImplementedException();
        }
        public string author 
        { 
            get => throw new NotImplementedException(); 
            set => throw new NotImplementedException(); 
        }
        public string age 
        {
            get => throw new NotImplementedException(); 
            set => throw new NotImplementedException();
        }
        public string status 
        { 
            get => throw new NotImplementedException(); 
            set => throw new NotImplementedException(); 
        }
        public string pubDate
        { 
            get => throw new NotImplementedException(); 
            set => throw new NotImplementedException();
        }
        public int quantity 
        { 
            get => throw new NotImplementedException(); 
            set => throw new NotImplementedException();
        }
        public string SearchValue 
        {
            get => throw new NotImplementedException(); 
            set => throw new NotImplementedException(); 
        }
        public bool IsEdit 
        {
            get { return isEdit; }
            set { isSuccessful = value; }
        }
        public bool IsSuccessful 
        {
            get {return isSuccessful; }
            set { isSuccessful = value;}
        }
        public string Message 
        { 
            get { return message; }
            set { message = value; }
        }

        //Events
        public event EventHandler SearchEvent;
        public event EventHandler AddNewEvent;
        public event EventHandler EditEvent;
        public event EventHandler DeleteEvent;
        public event EventHandler SaveEvent;
        public event EventHandler CancelEvent;

        //Methods
        public void SetBookListBindingSource(BindingSource bookList)
        {
            dgvListBook.DataSource = bookList;
        }

        private void frm_MainBook_Load(object sender, EventArgs e)
        {

        }
    }
}
