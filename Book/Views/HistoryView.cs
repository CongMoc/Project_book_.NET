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
    public partial class HistoryView : Form,IBookView
    {
        public HistoryView()
        {
            InitializeComponent();
            tabControl1.TabPages.Remove(tabPageCartDetail);
            EventsHis();
        }

        private void EventsHis()
        {
            tsbbtnBookback.Click += delegate
            {
                EditEvent?.Invoke(this, EventArgs.Empty);
                if (IsEdit)
                {
                    DialogResult result = MessageBox.Show("Do you want to buy book back for cart?", "Question", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                    if(result == DialogResult.Yes)
                    {
                        AddNewEvent?.Invoke(this, EventArgs.Empty);
                    }
                }
                MessageBox.Show(Message);
            };
            tsbbtnDelete.Click += delegate
            {
                DialogResult result = MessageBox.Show("Do you want to delete this book from history?", "Question", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                if (result == DialogResult.Yes)
                {
                    DeleteEvent?.Invoke(this, EventArgs.Empty);
                }
            };
        }

        
        private static HistoryView instance;
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

        public string idOrder
        {
            get { return txtIDOrder.Text; }
            set { txtIDOrder.Text = value; }
        }
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
        public string status
        {
            get { return txtStatus.Text; }
            set { txtStatus.Text = value; }
        }
        private bool isEdit;
        private bool isSuccessful;
        private string message;
        public bool IsEdit
        {
            get { return isEdit; }
            set { isEdit = value; }
        }
        public bool IsSuccessful
        {
            get { return isSuccessful; }
            set { isSuccessful = value; }
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

        public bool NameUser { get; set; }
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
        public string summoney
        {
            get;set;
        }
        public string age { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }
        public DataGridView data
        {
            get { return dgvListHistory; }
            set { dgvListHistory = value; }
        }

        public string SearchValue { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }

        public static HistoryView GetInstace(Form parentContainer)
        {
            if (instance == null || instance.IsDisposed)
            {
                instance = new HistoryView();
                instance.MdiParent = parentContainer;
                instance.Dock = DockStyle.Fill;
            }
            else
            {
                if (instance.WindowState == FormWindowState.Minimized)
                {
                    instance.WindowState = FormWindowState.Normal;
                }
                instance.BringToFront();
            }
            return instance;
        }

        public void SetBookListBindingSource(BindingSource bookList)
        {
            dgvListHistory.DataSource = bookList;
        }
    }
}
