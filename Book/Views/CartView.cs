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
    public partial class CartView : Form,IBookView
    {
        private string message;
        private bool isSuccessful;
        private bool isEdit;
        public float Sum = 0;
        public CartView()
        {
            InitializeComponent();
            AssociateAndRaiseViewEvents();
            tabControl1.TabPages.Remove(tabPageCartDetail);
        }

        private void AssociateAndRaiseViewEvents()
        {
            tsbRepair.Click += delegate
            {
                EditEvent?.Invoke(this, EventArgs.Empty);
                if (IsEdit)
                {
                    tabControl1.TabPages.Remove(tabPageCartList);
                    tabControl1.TabPages.Add(tabPageCartDetail);
                    tsbRepair.Enabled = false;
                }
                else
                {
                    MessageBox.Show(Message);
                }
            };
            tsbDelete.Click += delegate
            {
                var result = MessageBox.Show("Are you sure you want to delete this book in cart?", "Warning", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
                if (result == DialogResult.Yes)
                {
                    DeleteEvent?.Invoke(this, EventArgs.Empty);
                    MessageBox.Show(Message);
                }
            };
            btnSave.Click += delegate
            {
                if (txtQuantity.Text != "")
                {
                    SaveEvent?.Invoke(this, EventArgs.Empty);
                    if (IsSuccessful)
                    {
                        SaveEvent?.Invoke(this, EventArgs.Empty);
                        tabControl1.TabPages.Remove(tabPageCartDetail);
                        tabControl1.TabPages.Add(tabPageCartList);
                        tsbRepair.Enabled = true;
                    }
                    MessageBox.Show(Message);
                }
                else
                {
                    MessageBox.Show("Quantity can not square zero or null!!!");
                }
            };
            btnCancel.Click += delegate
            {
                tabControl1.TabPages.Remove(tabPageCartDetail);
                tabControl1.TabPages.Add(tabPageCartList);
                tsbRepair.Enabled = true;
            };
            tsbSalary.Click += delegate
            {
                if (IsEdit)
                {
                    var result = MessageBox.Show("Are you sure want to pay for this book first?", "Warning", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
                    if (result == DialogResult.Yes)
                    {
                        PaywithIDBook?.Invoke(this, EventArgs.Empty);
                        if (IsSuccessful)
                        {
                            MessageBox.Show(Message);
                            tabControl1.TabPages.Remove(tabPageCartDetail);
                            tabControl1.TabPages.Add(tabPageCartList);
                            tsbRepair.Enabled = true;
                        }
                    }
                }
                else
                {
                    var result = MessageBox.Show("Are you sure want to pay all cart?", "Warning", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
                    if (result == DialogResult.Yes)
                    {
                        if (IsSuccessful)
                        {
                            PaywithIDBook?.Invoke(this, EventArgs.Empty);
                        }
                        MessageBox.Show(Message);
                    }
                }
            };
        }

        //Singleton pattern 
        private static CartView instance;
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
        public string age
        {
            get { return txtAuthor.Text; }
            set { txtAuthor.Text = value; }
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
            get { return txtSumMoney.Text; }
            set { txtSumMoney.Text = value; }
        }

        public DataGridView data
        {
            get { return dgvListCart; }
            set { dgvListCart = value; }
        }

        public static CartView GetInstace(Form parentContainer)
        {
            if (instance == null || instance.IsDisposed)
            {
                instance = new CartView();
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
            dgvListCart.DataSource = bookList;
        }

        private void tsbRepair_Click(object sender, EventArgs e)
        {

        }

        private void CartView_Load(object sender, EventArgs e)
        {
            
        }
    }
}
