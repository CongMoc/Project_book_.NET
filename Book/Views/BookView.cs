using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Book.Views
{
    public partial class BookView : Form,IBookView
    {
        private string message;
        private bool isSuccessful;
        private bool isEdit;
        public string num;
        public BookView()
        {
            InitializeComponent();
            AssociateAndRaiseViewEvents();
            tabControl1.TabPages.Remove(tabPageInfor);
        }

        private void AssociateAndRaiseViewEvents()
        {
            //Search
            btnSearch.Click += delegate { SearchEvent?.Invoke(this, EventArgs.Empty); };
            txtSearch.KeyDown += (s, e) =>
            {
                if (e.KeyData == Keys.Enter)
                {
                    SearchEvent?.Invoke(this, EventArgs.Empty);
                }
            };
            //Add new
            //btnAdd.Click += delegate 
            //{ 
            //    AddNewEvent?.Invoke(this, EventArgs.Empty);
            //    tabControl1.TabPages.Remove(tabPageBookList);
            //    tabControl1.TabPages.Add(tabPageInfor);
            //    tabPageInfor.Text = "Add new book";
            //};
            //Edit
              btnAdd.Click += delegate
              {
                  EditEvent?.Invoke(this,EventArgs.Empty);
                  tabControl1.TabPages.Remove(tabPageBookList);
                  tabControl1.TabPages.Add(tabPageInfor);
              };
            /**
             * Delete
             * btnDelete.Click += delegate
             * {
             *   var result = MessageBox.Show("Are you sure you want to delete the selected book?", "Warning", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
             *   if(result == DialogResult.Yes)
             *   {
             *      DeleteEvent?.Invoke(this,EventArgs.Empty);
             *      Message.Show(Message);
             *   }
             * };
            **/
            //Save
            btnSave.Click += delegate 
            {
                if (txtQuantity.Text != "")
                {
                    if (dtpBorrow.Value < dtpPay.Value)
                    {
                        SaveEvent?.Invoke(this, EventArgs.Empty);
                        if (IsSuccessful)
                        {
                            tabControl1.TabPages.Remove(tabPageInfor);
                            tabControl1.TabPages.Add(tabPageBookList);
                        }
                    }
                    else
                    {
                        Message = "Date borrow is less than date pay!!!";
                    }
                    MessageBox.Show(Message);
                }
                else
                {
                    MessageBox.Show("Quantity is not null!!!");
                }
            };
            //Cancel
            btnCancel.Click += delegate 
            { 
                CancelEvent?.Invoke(this, EventArgs.Empty);
                tabControl1.TabPages.Remove(tabPageInfor);
                tabControl1.TabPages.Add(tabPageBookList);
            };
        }

        //Properties

        public string idBook 
        {
            get { return txtIDBook.Text; }
            set { txtIDBook.Text = value; }
        }
        public string title 
        {
            get { return txtTitle.Text; }
            set { txtTitle.Text = value; }
        }
        public string category 
        {
            get { return txtCategory.Text; }
            set { txtCategory.Text = value; }
        }
        public string author 
        {
            get { return txtAuthor.Text; }
            set { txtAuthor.Text = value; }
        }
        public string age 
        {
            get { return txtAge.Text; }
            set { txtAge.Text = value; }
        }
        public string status 
        {
            get { return txtStatus.Text; }
            set { txtStatus.Text = value; }
        }
        public string SearchValue 
        {
            get { return txtSearch.Text; }
            set { txtSearch.Text = value; }
        }
        public bool IsEdit 
        {
            get { return isEdit; }
            set { isEdit = value; }
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

        public string percentgift 
        { 
            get { return txtPercentGift.Text; }
            set { txtPercentGift.Text = value; }
        }

        public string money 
        {
            get { return txtMoney.Text; }
            set { txtMoney.Text = value; }
        }
        public string quantity
        {
            get { return txtQuantity.Text; }
            set { txtQuantity.Text = value; }
        }
        public DateTime borrow 
        {
            get { return dtpBorrow.Value; } 
            set { dtpBorrow.Value = value; }
        }
        public DateTime pay
        {
            get { return dtpPay.Value; }
            set { dtpPay.Value = value; }
        }

        public string idcus    
        { 
            get ; 
            set ; 
        }
        public string summoney { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }
        public string idOrder { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }
        public DataGridView data
        {
            get { return dgvListBook; }
            set { dgvListBook = value; }
        }


        //Events
        public event EventHandler SearchEvent;
        public event EventHandler AddNewEvent;
        public event EventHandler EditEvent;
        public event EventHandler DeleteEvent;
        public event EventHandler SaveEvent;
        public event EventHandler CancelEvent;
        public event EventHandler Pay;
        public event EventHandler Printer;
        public event EventHandler PaywithIDBook;
        public event EventHandler PayAllCart;
        public event EventHandler ShowExcel;

        //Methods
        public void SetBookListBindingSource(BindingSource bookList)
        {
            dgvListBook.DataSource = bookList;
        }

        private void frm_MainBook_Load(object sender, EventArgs e)
        {
                
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {

        }

        private void tsbbtnExit_Click(object sender, EventArgs e)
        {

        }
        static int Count = 0;
        private void tsbbtnMaximize_Click(object sender, EventArgs e)
        {
            if(Count == 0)
            {
                WindowState = FormWindowState.Maximized;
                Count++;
            }   
            else
            {
                WindowState = FormWindowState.Normal;
                Count--;
            }
        }

        private void tsbbtnMinimize_Click(object sender, EventArgs e)
        {
            WindowState = FormWindowState.Minimized;
        }

        //Singleton pattern 
        private static BookView instance;
        public static BookView GetInstace(Form parentContainer)
        {
            if(instance == null || instance.IsDisposed)
            {
                instance = new BookView();
                instance.MdiParent = parentContainer;
                instance.Dock = DockStyle.Fill;
            }
            else
            {
                if(instance.WindowState==FormWindowState.Minimized)
                {
                    instance.WindowState = FormWindowState.Normal;
                }
                instance.BringToFront();
            }
            return instance;
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}
