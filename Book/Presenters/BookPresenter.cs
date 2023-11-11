 using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Book.Models;
using Book.Reponsitories;
using Book.Views;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.ProgressBar;

namespace Book.Presenters
{
    public class BookPresenter
    {
        //Fields
        private IBookView view;
        private IBookReponsitory reponsitory;
        private BindingSource booksBindingSource;
        private IEnumerable<BookModel> bookList;
        public int id;
        public int num;
        public BookPresenter(IBookView view, string sqlConnectionString,int idcus)
        {
            this.booksBindingSource = new BindingSource();
            this.view = view;
            this.reponsitory = new BookReponsitory(sqlConnectionString);
            //Subscribe events handler methods to view events
            this.view.SearchEvent += SearchBook;
            this.view.AddNewEvent += AddNewBook;
            this.view.EditEvent += LoadSelectedBookToEdit;
            this.view.DeleteEvent += DeleteSelectedBook;
            this.view.SaveEvent += SaveBook;
            this.view.CancelEvent += CancelAction;
            id = idcus;
            //Set books binding source
            this.view.SetBookListBindingSource(booksBindingSource);
            //Load books list view 
            LoadAllBookList();
            //Show view
            this.view.Show();
        }


        //Methods
        private void LoadAllBookList()
        {
            bookList = reponsitory.GetAllBook();
            booksBindingSource.DataSource = bookList;//Set data source
        }

        private void CancelAction(object sender, EventArgs e)
        {
            ClearviewFields();
        }
        public float MoneyBook(float moneyBook,string percent)
        {
            if(percent == "20%")
            {
                moneyBook -= moneyBook/5;
            }
            else if(percent =="40%")
            {
                moneyBook -= (moneyBook * 2) / 5;
            }
            return moneyBook;
        }
        private void SaveBook(object sender, EventArgs e)
        {
            float money = float.Parse(view.money);
            var model = new CartModel();
            model.IDBook = Convert.ToInt32(view.idBook);
            model.Title = view.title;
            model.Author = view.author;
            model.Category = view.category;
            model.Status = view.status;
            model.PercenGift = view.percentgift;
            model.Quantity = Convert.ToInt32(view.quantity);
            model.Borrow = view.borrow;
            model.Pay = view.pay;
            model.Money = MoneyBook(money, view.percentgift);
            if (model.Quantity <= num && model.Quantity != 0)
            {
                reponsitory.AddCart(model, id);
                view.Message = "Book added successfully";
                view.IsSuccessful = true;
                LoadAllBookList();
            }
            else
            {
                view.IsSuccessful = false;
                view.Message = $"Quantity must to be less than {num} and can not square zero!!!";
            }
        }

        private void ClearviewFields()
        {
            view.idBook = "0";
            view.title = "";
            view.author = "";
            view.age = "";
            view.category = "";
            view.status = "";
            view.percentgift = "";
            view.quantity ="0";
            view.money = "0";
        }

        private void DeleteSelectedBook(object sender, EventArgs e)
        {
            try
            {
                var book = (BookModel)booksBindingSource.Current;
                reponsitory.DeleteBookCart(book.IDBook);
                view.IsSuccessful = true;
                view.Message = "Book deleted successfully";
                LoadAllBookList();
            }
            catch (Exception)
            {
                view.IsSuccessful = false;
                view.Message = "An error ocurred, could not delete book";
            }
        }

        private void LoadSelectedBookToEdit(object sender, EventArgs e)
        {
            var book = (BookModel)booksBindingSource.Current;
            view.idBook = book.IDBook.ToString();
            view.title = book.Title;
            view.author = book.Author;
            view.age = book.Age;
            view.category = book.Category;
            view.status = book.Status;
            view.percentgift = book.PercenGift;
            num = book.Quantity;
            view.money = book.Money.ToString();
            view.IsEdit = true;
        }

        private void AddNewBook(object sender, EventArgs e)
        {
            view.IsEdit = false;
        }

        private void SearchBook(object sender, EventArgs e)
        {
            bool emptyValue = string.IsNullOrWhiteSpace(this.view.SearchValue);
            if (emptyValue == false)
            {
                bookList = reponsitory.GetByValue(this.view.SearchValue);
            }
            else
            {
                bookList = reponsitory.GetAllBook();
            }
            booksBindingSource.DataSource = bookList;
        }
    }
}
