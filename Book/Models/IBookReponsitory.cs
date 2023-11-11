using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Book.Models
{
    public interface IBookReponsitory
    {
        void AddCart(CartModel bookModel,int idUser);
        void Edit(CartModel bookModel,int idUser);
        void PayCartWithBook(CartModel bookModel, int idUser);
        void PayAllCart(int idUser);
        void BookbackCart(int idUser, int idorder);
        void DeleteBookCart(int id);
        float GetPrice(int id);
        int Check(int idorder,int idbook,int quantity);
        IEnumerable<BookModel> GetAllBook();
        IEnumerable<CartModel> GetAllCart(int IDCustomer,string status);
        IEnumerable<CartModel> GetByValueCart(string value);//Search in CartView
        IEnumerable<BookModel> GetByValue(string value);//Searchs in BooKview
        void PrinterExcelBook(DataGridView list);//Export get out to a file Excelw
    }
}
