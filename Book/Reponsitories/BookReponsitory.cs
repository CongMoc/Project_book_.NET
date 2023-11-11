using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Data;
using Book.Models;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.ListView;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.ProgressBar;
using System.Windows.Forms;

namespace Book.Reponsitories
{
    public class BookReponsitory : BaseReponsitory, IBookReponsitory
    {
        public BookReponsitory(string connectionString) 
        {
            this.connectionString = connectionString;
        }
        public void AddCart(CartModel bookModel, int idUser)
        {
            using (var connection = new SqlConnection(connectionString))
            using (var command = new SqlCommand())
            {
                connection.Open();
                command.Connection = connection;
                command.CommandText = @"exec InsertBookForCart @idBook,@idcustomer,@borrow,@pay,@quantity,@money";
                command.Parameters.Add("@idBook", SqlDbType.Int).Value = bookModel.IDBook;
                command.Parameters.Add("@idcustomer", SqlDbType.Int).Value = idUser;
                command.Parameters.Add("@borrow", SqlDbType.Date).Value = bookModel.Borrow;
                command.Parameters.Add("@pay", SqlDbType.Date).Value = bookModel.Pay;
                command.Parameters.Add("@quantity", SqlDbType.Int).Value = bookModel.Quantity;
                command.Parameters.Add("@money", SqlDbType.Float).Value = bookModel.Money;
                command.ExecuteNonQuery();
            }
        }
        public void Edit(CartModel bookModel, int idUser)
        {
            using (var connection = new SqlConnection(connectionString))
            using (var command = new SqlCommand())
            {
                connection.Open();
                command.Connection = connection;
                command.CommandText = @"exec UpdateCart @idorder,@idbook,@quantity,@borrow,@pay";
                command.Parameters.Add("@idorder", SqlDbType.Int).Value = bookModel.IDOrder;
                command.Parameters.Add("@borrow", SqlDbType.Date).Value = bookModel.Borrow;
                command.Parameters.Add("@quantity", SqlDbType.Int).Value = bookModel.Quantity;
                command.Parameters.Add("@pay", SqlDbType.Date).Value = bookModel.Pay;
                command.ExecuteNonQuery();
            }
        }
        public IEnumerable<BookModel> GetAllBook()
        {
            var bookList = new List<BookModel>();
            using (var connection = new SqlConnection(connectionString))
            using (var command = new SqlCommand())
            {
                connection.Open();  
                command.Connection = connection;
                command.CommandText = @"Select * from BookView order by IDBook desc";
                using (var reader = command.ExecuteReader())
                {
                    while (reader.Read())
                    {
                        var bookModel = new BookModel();
                        bookModel.IDBook = Convert.ToInt32(reader[0]);
                        bookModel.Title = reader[1].ToString();
                        bookModel.Category = reader[2].ToString();
                        bookModel.Author = reader[3].ToString();
                        bookModel.Age = reader[4].ToString();
                        bookModel.Status = reader[5].ToString();
                        bookModel.Quantity = Convert.ToInt32(reader[6]);
                        bookModel.PercenGift = reader[7].ToString();
                        bookModel.Money = float.Parse(reader[8].ToString());
                        bookList.Add(bookModel);
                    }
                }
            }    
            return bookList;
        }

        public IEnumerable<BookModel> GetByValue(string value)
        {
            var bookList = new List<BookModel>();
            int bookId = int.TryParse(value, out _) ? Convert.ToInt32(value) : 0;
            string Title = value;
            using (var connection = new SqlConnection(connectionString))
            using (var command = new SqlCommand())
            {
                connection.Open();
                command.Connection = connection;
                command.CommandText = @"Select * from BookView
                                        where IDBook = @id or Title like '%'+ @title+'%'
                                        order by IDBook desc";
                command.Parameters.Add("@id", SqlDbType.Int).Value = bookId;
                command.Parameters.Add("@title", SqlDbType.NVarChar).Value = Title;
                using (var reader = command.ExecuteReader())
                {
                    while (reader.Read())
                    {
                        var bookModel = new BookModel();
                        bookModel.IDBook = Convert.ToInt32(reader[0]);
                        bookModel.Title = reader[1].ToString();
                        bookModel.Category = reader[2].ToString();
                        bookModel.Author = reader[3].ToString();
                        bookModel.Age = reader[4].ToString();
                        bookModel.Status = reader[5].ToString();
                        bookModel.Quantity = Convert.ToInt32(reader[6]);
                        bookModel.PercenGift = reader[7].ToString();
                        bookModel.Money =float.Parse(reader[8].ToString());
                        bookList.Add(bookModel);
                    }
                }
            }
            return bookList;
        }


        public void DeleteBookCart(int id)
        {
            using (var connection = new SqlConnection(connectionString))
            using (var command = new SqlCommand())
            {
                connection.Open();
                command.Connection = connection;
                command.CommandText = @"exec DeleteCart @id";
                command.Parameters.Add("@id", SqlDbType.Int).Value = id;
                command.ExecuteNonQuery();
            }
        }
        public IEnumerable<CartModel> GetByValueCart(string value)
        {
            var bookList = new List<CartModel>();
            int bookId = int.TryParse(value, out _) ? Convert.ToInt32(value) : 0;
            string Title = value;
            using (var connection = new SqlConnection(connectionString))
            using (var command = new SqlCommand())
            {
                connection.Open();
                command.Connection = connection;
                command.CommandText = @"Select * from CartView
                                        where IDBook = @id or Title like '%'+ @title+'%'
                                        or Author = @author or Category = @category
                                        order by IDBook desc";
                command.Parameters.Add("@id", SqlDbType.Int).Value = bookId;
                command.Parameters.Add("@title", SqlDbType.NVarChar).Value = Title;
                command.Parameters.Add("@author", SqlDbType.NVarChar).Value = Title;
                command.Parameters.Add("@category", SqlDbType.NVarChar).Value = Title;
                using (var reader = command.ExecuteReader())
                {
                    while (reader.Read())
                    {
                        var bookModel = new CartModel();
                        bookModel.IDOrder = Convert.ToInt32(reader[0]);
                        bookModel.IDBook = Convert.ToInt32(reader[1]);
                        bookModel.Title = reader[2].ToString();
                        bookModel.Author = reader[3].ToString();
                        bookModel.Category = reader[4].ToString();
                        bookModel.Borrow = DateTime.Parse(reader[5].ToString());
                        bookModel.Pay = DateTime.Parse(reader[6].ToString());
                        bookModel.PercenGift = reader[7].ToString();
                        bookModel.Status = reader[8].ToString();
                        bookModel.Quantity = Convert.ToInt32(reader[9]);
                        bookModel.Money = float.Parse(reader[10].ToString());
                        bookModel.SumMoney = bookModel.Quantity * bookModel.Money;
                        bookList.Add(bookModel);
                    }
                }
            }
            return bookList;
        }

        public void PayCartWithBook(CartModel bookModel, int idUser)
        {
            using (var connection = new SqlConnection(connectionString))
            using (var command = new SqlCommand())
            {
                connection.Open();
                command.Connection = connection;
                command.CommandText = @"exec PayCartWithBook @idOrder,@idBook";
                command.Parameters.Add("@idOrder", SqlDbType.Int).Value = bookModel.IDOrder;
                command.Parameters.Add("@idBook", SqlDbType.Int).Value = idUser;
                command.ExecuteNonQuery();
            }
        }

        // Print list cart book
        public IEnumerable<CartModel> GetAllCart(int IDCustomer, string status)
        {
            var bookList = new List<CartModel>();
            using (var connection = new SqlConnection(connectionString))
            using (var command = new SqlCommand())
            {
                connection.Open();
                command.Connection = connection;
                command.CommandText = @"exec CartView @id,@status";
                command.Parameters.Add("@id", SqlDbType.Int).Value = IDCustomer;
                command.Parameters.Add("@status", SqlDbType.NVarChar).Value = status;
                using (var reader = command.ExecuteReader())
                {
                    while (reader.Read())
                    {
                        var bookModel = new CartModel();
                        bookModel.IDOrder = Convert.ToInt32(reader[0]);
                        bookModel.IDBook = Convert.ToInt32(reader[1]);
                        bookModel.Title = reader[2].ToString();
                        bookModel.Author = reader[3].ToString();
                        bookModel.Category = reader[4].ToString();
                        bookModel.Borrow = DateTime.Parse(reader[5].ToString());
                        bookModel.Pay = DateTime.Parse(reader[6].ToString());
                        bookModel.PercenGift = reader[7].ToString();
                        bookModel.Status = reader[8].ToString();
                        bookModel.Quantity = Convert.ToInt32(reader[9]);
                        bookModel.Money = float.Parse(reader[10].ToString());
                        bookModel.SumMoney = (float)bookModel.Quantity * bookModel.Money;
                        bookList.Add(bookModel);
                    }
                }
            }
            return bookList;
        }

        public float GetPrice(int id)
        {
            float check = 0;
            using (var connection = new SqlConnection(connectionString))
            using (var command = new SqlCommand())
            {
                connection.Open();
                command.Connection = connection;
                command.CommandText = "select dbo.SumMoney('" +id + "')";
                using (var reader = command.ExecuteReader())
                {
                    while (reader.Read())
                    {
                        check = float.Parse(reader[0].ToString());
                    }
                }
            }
            return check;
        }

        public void PrinterExcelBook(DataGridView list)
        {
            Microsoft.Office.Interop.Excel.Application XcelApp = new Microsoft.Office.Interop.Excel.Application();
            XcelApp.Application.Workbooks.Add(Type.Missing);
            for (int i = 1; i < list.Columns.Count + 1; i++)
            {
                XcelApp.Cells[1, i] = list.Columns[i - 1].HeaderText;
            }
            for (int i = 0; i < list.Rows.Count; i++)
            {
                for (int j = 0; j < list.Columns.Count; j++)
                {
                    XcelApp.Cells[i + 2, j + 1] = list.Rows[i].Cells[j].Value.ToString();
                }
            }
            XcelApp.Columns.AutoFit();
            XcelApp.Visible = true;
        }

        public int Check(int idorder, int idbook, int quantity)
        {
            int check = 0;
            using (var connection = new SqlConnection(connectionString))
            using (var command = new SqlCommand())
            {
                connection.Open();
                command.Connection = connection;
                command.CommandText = @"select dbo.CheckUpdateCart('" + idorder + "','" + idbook + "','"+quantity+"')";
                using (var reader = command.ExecuteReader())
                {
                    while (reader.Read())
                    {
                        check = Convert.ToInt32(reader[0]);
                    }
                }
            }
            return check;
        }

        public void PayAllCart(int idUser)
        {
            using (var connection = new SqlConnection(connectionString))
            using (var command = new SqlCommand())
            {
                connection.Open();
                command.Connection = connection;
                command.CommandText = @"exec PayAllCart @idcus";
                command.Parameters.Add("@idcus", SqlDbType.Int).Value = idUser;
                command.ExecuteNonQuery();
            }
        }

        public void BookbackCart(int idUser, int idorder)
        {
            using (var connection = new SqlConnection(connectionString))
            using (var command = new SqlCommand())
            {
                connection.Open();
                command.Connection = connection;
                command.CommandText = @"exec BookbackCart @id,@idcus";
                command.Parameters.Add("@id", SqlDbType.Int).Value = idorder;
                command.Parameters.Add("@idcus", SqlDbType.Int).Value = idUser;
                command.ExecuteNonQuery();
            }
        }
    }
}
