using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Book.Models;
using Book.Views;
using Book.Reponsitories;
using System.Windows.Forms;

namespace Book.Presenters
{
    public class HistoryPresenter
    {
        private IBookView view;
        private BindingSource source;
        private IBookReponsitory reponsitory;
        private IEnumerable<CartModel> bookList;
        private int idcus;

        public HistoryPresenter(IBookView view, string sqlconnectionString,int id)
        {
            this.view = view;
            this.reponsitory = new BookReponsitory(sqlconnectionString);
            this.source = new BindingSource();
            this.view.SearchEvent += SearchBook;
            this.view.AddNewEvent += AddBackCart;
            this.view.EditEvent += LoadBookForCart;
            this.view.DeleteEvent += DeleteOrder;
            this.view.ShowExcel += ExcelViews;
            idcus = id;
            this.view.SetBookListBindingSource(source);
            LoadAllBookList();
            this.view.Show();
        }

        private void ExcelViews(object sender, EventArgs e)
        {
            var book = (CartModel)source.Current;
            if (book is null)
            {
                MessageBox.Show("Cart is null...Please try again!!!","Warning",MessageBoxButtons.OK);
            }
            else
            {
                reponsitory.PrinterExcelBook(view.data);
            }
        }

        private void DeleteOrder(object sender, EventArgs e)
        {
            try
            {
                var book = (CartModel)source.Current;
                if (book is null)
                {
                    view.IsEdit = false;
                    view.Message = "You must choose some book in list history!!!";
                }
                else
                {
                    reponsitory.DeleteBookCart(book.IDOrder);
                    view.IsSuccessful = true;
                    view.Message = "Book deleted successfully from cart";
                    LoadAllBookList();
                }
            }
            catch (Exception)
            {
                view.IsSuccessful = false;
                view.Message = "An error ocurred, could not delete book";
            }
        }

        private void LoadAllBookList()
        {
            bookList = reponsitory.GetAllCart(idcus,"Bought");
            source.DataSource = bookList;//Set data source
        }
        private void LoadBookForCart(object sender, EventArgs e)
        {
            var book = (CartModel)source.Current;
            if (book is null)
            {
                view.IsEdit = false;
                view.Message = "You must choose some book in list history!!!";
            }
            else
            {
                view.idOrder = book.IDOrder.ToString();
                view.idBook = book.IDBook.ToString();
                view.title = book.Title;
                view.author = book.Author;
                view.category = book.Category;
                view.borrow = book.Borrow;
                view.pay = book.Pay;
                view.status = book.Status;
                view.percentgift = book.PercenGift;
                view.quantity = book.Quantity.ToString();
                view.money = book.Money.ToString();
                view.IsEdit = true;
            }
        }

        private void AddBackCart(object sender, EventArgs e)
        {
            if (view.IsEdit)
            {
                var model = new CartModel();
                model.IDOrder = Convert.ToInt32(view.idOrder);
                model.IDBook = Convert.ToInt32(view.idBook);
                model.Title = view.title;
                model.Author = view.author;
                model.Category = view.category;
                model.Status = view.status;
                model.PercenGift = view.percentgift;
                model.Quantity = Convert.ToInt32(view.quantity);
                model.Borrow = view.borrow;
                model.Pay = view.pay;
                model.Money = float.Parse(view.money);
                try
                {
                    reponsitory.BookbackCart(idcus, model.IDOrder);
                    view.Message = "Book backed successfull for cart";
                    view.IsSuccessful = true;
                    LoadAllBookList();
                }
                catch (Exception ex)
                {
                    view.IsSuccessful = false;
                    view.Message = ex.Message;
                }
            }
        }


        private void SearchBook(object sender, EventArgs e)
        {
            bool emptyValue = string.IsNullOrWhiteSpace(this.view.SearchValue);
            if (emptyValue == false)
            {
                bookList = reponsitory.GetByValueCart(this.view.SearchValue);
            }
            else
            {
                bookList = reponsitory.GetAllCart(idcus,"Bought");
            }
            source.DataSource = bookList;
        }
    }
}
