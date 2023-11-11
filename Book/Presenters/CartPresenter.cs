using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Book.Models;
using Book.Reponsitories;
using Book.Views;
using System.Windows.Forms;

namespace Book.Presenters
{
    public class CartPresenter
    {
        private IBookView view;
        private IBookReponsitory reponsitory;
        private BindingSource booksBindingSource;
        private IEnumerable<CartModel> bookList;
        public int id;
        public CartPresenter(IBookView view, string sqlConnectionString,int idcus)
        {
            this.view = view;
            this.reponsitory = new BookReponsitory(sqlConnectionString);
            this.booksBindingSource = new BindingSource();
            //Subscribe events handler methods to view events
            this.view.SearchEvent += SearchBookInCart;
            this.view.EditEvent += LoadSelectedBookToEditCart;
            this.view.DeleteEvent += DeleteSelectedBook;
            this.view.SaveEvent += SaveBook;
            this.view.CancelEvent += CancelAction;
            this.view.PaywithIDBook += PayMoney;
            id = idcus;
            //Set books binding source
            this.view.SetBookListBindingSource(booksBindingSource);
            //Load books list view 
            LoadAllBookList();
            //Show view
            this.view.Show();
        }

        private void PayMoney(object sender, EventArgs e)
        {
            if(view.IsEdit)
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
                reponsitory.PayCartWithBook(model, id);
                view.Message = $"Thank you for always accompanying and trusting our brand! " +
                    $"Your book has been paid for and the lease is due {view.borrow} to {view.borrow} " +
                    $"The total amount you have to pay is {view.money}$";
                view.IsSuccessful = true;
                LoadAllBookList();
            } 
            else
            {
                reponsitory.PayAllCart(id);
                view.Message = "Thank you for always accompanying and trusting our brand!" +
                    " The book in your cart has been paid for." +
                    $" The total amount you have to pay is {view.summoney}$";
                view.IsSuccessful = true;
                LoadAllBookList();
            }
        }

        private void LoadSelectedBookToEditCart(object sender, EventArgs e)
        {
            var book = (CartModel)booksBindingSource.Current;
            if (book is null)
            {
                view.IsEdit = false;
                view.Message = "Cart is null... PLease take some book for cart before edit!!!";                          
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

        private void LoadAllBookList()
        {
            bookList = reponsitory.GetAllCart(id,"Unpaid");
            booksBindingSource.DataSource = bookList;//Set data source
            view.summoney = reponsitory.GetPrice(id).ToString();
            view.IsEdit = false;
        }

        private void CancelAction(object sender, EventArgs e)
        {
            ClearviewFields();
        }

        private void SaveBook(object sender, EventArgs e)
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
                int check = reponsitory.Check(model.IDOrder, model.IDBook, model.Quantity);
                try
                {
                    if (check == 1)
                    {
                        new Common.ModelDataValidation().Validate(model);
                        reponsitory.Edit(model, id);
                        view.Message = "Book edited successfully from cart";
                        view.IsSuccessful = true;
                        LoadAllBookList();
                        ClearviewFields();
                    }
                    else
                    {
                        view.IsSuccessful = false;
                        view.Message = $"Quantity is less than {check}!!!";
                    }
                }
                catch (Exception ex)
                {
                    view.IsSuccessful = false;
                    view.Message = ex.Message;
                }
            }
        }
        private void ClearviewFields()
        {
            view.idOrder = "0";
            view.idBook = "0";
            view.title = "";
            view.author = "";
            view.category = "";
            view.status = "";
            view.percentgift = "";
            view.quantity = "0";
            view.money = "0";
        }


        private void DeleteSelectedBook(object sender, EventArgs e)
        {
            try
            {
                var book = (CartModel)booksBindingSource.Current;
                if (book != null)
                {
                    reponsitory.DeleteBookCart(book.IDOrder);
                    view.IsSuccessful = true;
                    view.Message = "Book deleted successfully from cart";
                    LoadAllBookList();
                }
                else
                {
                    view.Message = "Cart is null...Can not delete!!!";            
                }
            }
            catch (Exception)
            {
                view.IsSuccessful = false;
                view.Message = "An error ocurred, could not delete book";
            }
        }

        private void SearchBookInCart(object sender, EventArgs e)
        {
            bool emptyValue = string.IsNullOrWhiteSpace(this.view.SearchValue);
            if (emptyValue == false)
            {
                bookList = reponsitory.GetByValueCart(this.view.SearchValue);
            }
            else
            {
                bookList = reponsitory.GetAllCart(id, "Unpaid");
            }
            booksBindingSource.DataSource = bookList;
        }
    }
}
