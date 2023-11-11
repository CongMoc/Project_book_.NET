using Book.Models;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Microsoft.Office.Interop.Excel;

namespace Book.Reponsitories
{
    public class CustomerReponsitory : BaseReponsitory, ICustomerReponsitory
    {
        public CustomerReponsitory(string sqlConnectionString) 
        {
            this.connectionString = sqlConnectionString;
        }

        public void AddEmployee(CustomerModel Model)
        {
            using (var connection = new SqlConnection(connectionString))
            using (var command = new SqlCommand())
            {
                connection.Open();
                command.Connection = connection;
                command.CommandText = @"exec AddEm @name,@gender,@birthDay,@address,@email,@city,@phone";
                command.Parameters.Add("@name", SqlDbType.NVarChar).Value = Model.Name;
                command.Parameters.Add("@gender", SqlDbType.Char).Value = Model.Gender;
                command.Parameters.Add("@birthDay", SqlDbType.Date).Value = Model.BirthYear;
                command.Parameters.Add("@address", SqlDbType.NVarChar).Value = Model.Address;
                command.Parameters.Add("@email", SqlDbType.NVarChar).Value = Model.Email;
                command.Parameters.Add("@city", SqlDbType.NVarChar).Value = Model.City;
                command.Parameters.Add("@phone", SqlDbType.Char).Value = Model.Phone;
                command.ExecuteNonQuery();
            }
        }

        public int checkEmail(string email)
        {
            int check = 0;
            using (var connection = new SqlConnection(connectionString))
            using (var command = new SqlCommand())
            {
                connection.Open();
                command.Connection = connection;
                command.CommandText = "select dbo.CheckRegister('" + email + "')";
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

        public void DeleteEmployee(CustomerModel Model)
        {
            using (var connection = new SqlConnection(connectionString))
            using (var command = new SqlCommand())
            {
                connection.Open();
                command.Connection = connection;
                command.CommandText = @"exec deleteEm @id";
                command.Parameters.Add("@id", SqlDbType.Int).Value = Model.ID;
                command.ExecuteNonQuery();
            }
        }


        public IEnumerable<CustomerModel> GetAllEmployees()
        {
            var List = new List<CustomerModel>();
            using (var connection = new SqlConnection(connectionString))
            using (var command = new SqlCommand())
            {
                connection.Open();
                command.Connection = connection;
                command.CommandText = @"Select * from EmployeeView";
                using (var reader = command.ExecuteReader())
                {
                    while (reader.Read())
                    {
                        var model = new CustomerModel();
                        model.ID = Convert.ToInt32(reader[0]);
                        model.Name = reader[1].ToString();
                        model.Gender = reader[2].ToString();
                        model.BirthYear = DateTime.Parse(reader[3].ToString());
                        model.Address = reader[4].ToString();
                        model.Email= reader[5].ToString();
                        model.City = reader[6].ToString();
                        model.Phone= reader[7].ToString();
                        List.Add(model);
                    }
                }
            }
            return List;
        }

        public IEnumerable<CartModel> GetAllValueFollowTime(DateTime start,DateTime end)
        {
            var List = new List<CartModel>();
            using (var connection = new SqlConnection(connectionString))
            using (var command = new SqlCommand())
            {
                connection.Open();
                command.Connection = connection;
                command.CommandText = @"exec StatialFollowTime @start,@end";
                command.Parameters.Add("@start", SqlDbType.Date).Value = start;
                command.Parameters.Add("@end", SqlDbType.Date).Value = end;
                using (var reader = command.ExecuteReader())
                {
                    while (reader.Read())
                    {
                        var model = new CartModel();
                        model.IDOrder = Convert.ToInt32(reader[0]);
                        model.IDBook = Convert.ToInt32(reader[1]);
                        model.Title = reader[2].ToString();
                        model.Author = reader[3].ToString();
                        model.Category = reader[4].ToString();
                        model.Status =reader[5].ToString();
                        model.PercenGift = reader[6].ToString();
                        model.Quantity = Convert.ToInt32(reader[7]);
                        model.Money = float.Parse(reader[8].ToString());
                        model.Borrow = DateTime.Parse(reader[9].ToString());
                        model.Pay = DateTime.Parse(reader[10].ToString());
                        model.SumMoney = float.Parse(reader[11].ToString());
                        List.Add(model);
                    }
                }
            }
            return List;
        }

        public IEnumerable<StatialModel> GetAllValueWithTopCustomer(int top)
        {
            var List = new List<StatialModel>();
            using (var connection = new SqlConnection(connectionString))
            using (var command = new SqlCommand())
            {
                connection.Open();
                command.Connection = connection;
                command.CommandText = @"exec TopCus @num";
                command.Parameters.Add("@num", SqlDbType.Int).Value = top;
                using (var reader = command.ExecuteReader())
                {
                    while (reader.Read())
                    {
                        var model = new StatialModel();
                        model.Quantity = Convert.ToInt32(reader[0]);
                        model.Money = Convert.ToInt32(reader[1]);
                        model.ID = Convert.ToInt32(reader[2]);
                        model.Name = reader[3].ToString();
                        model.Phone = reader[4].ToString();
                        List.Add(model);
                    }
                }
            }
            return List;
        }

        public IEnumerable<CustomerModel> GetCus(CustomerModel model,int id)
        {
            var List = new List<CustomerModel>();
            using (var connection = new SqlConnection(connectionString))
            using (var command = new SqlCommand())
            {
                connection.Open();
                command.Connection = connection;
                command.CommandText = @"Select * from Cus(@id)";
                command.Parameters.Add("@id", SqlDbType.Int).Value = id;
                using (var reader = command.ExecuteReader())
                {
                    while (reader.Read())
                    {
                        model.ID = Convert.ToInt32(reader[0]);
                        model.Name = reader[1].ToString();
                        model.Gender = reader[7].ToString();
                        model.BirthYear = DateTime.Parse(reader[2].ToString());
                        model.Address = reader[4].ToString();
                        model.Email = reader[3].ToString();
                        model.City = reader[5].ToString();
                        model.Phone = reader[6].ToString();
                        List.Add(model);
                    }
                }
            }
            return List;
        }

        public IEnumerable<CustomerModel> GetInformation(CustomerModel model,int id)
        {
            var List = new List<CustomerModel>();
            using (var connection = new SqlConnection(connectionString))
            using (var command = new SqlCommand())
            {
                connection.Open();
                command.Connection = connection;
                command.CommandText = @"Select * from EmployeeView where ID = @id";
                command.Parameters.Add("@id", SqlDbType.Int).Value = id;
                using (var reader = command.ExecuteReader())
                {
                    while (reader.Read())
                    {
                        model.ID = Convert.ToInt32(reader[0]);
                        model.Name = reader[1].ToString();
                        model.Gender = reader[2].ToString();
                        model.BirthYear = DateTime.Parse(reader[3].ToString());
                        model.Address = reader[4].ToString();
                        model.Email = reader[5].ToString();
                        model.City = reader[6].ToString();
                        model.Phone = reader[7].ToString();
                        List.Add(model);
                    }
                }
            }
            return List;
        }

        public void UpdateCustomer(CustomerModel Model)
        {
            using (var connection = new SqlConnection(connectionString))
            using (var command = new SqlCommand())
            {
                connection.Open();
                command.Connection = connection;
                command.CommandText = @"exec UpdateCus @id,@name,@gender,@birthDay,@address,@email,@city,@phone";
                command.Parameters.Add("@id", SqlDbType.Int).Value = Model.ID;
                command.Parameters.Add("@name", SqlDbType.NVarChar).Value = Model.Name;
                command.Parameters.Add("@gender", SqlDbType.Char).Value = Model.Gender;
                command.Parameters.Add("@birthDay", SqlDbType.Date).Value = Model.BirthYear;
                command.Parameters.Add("@address", SqlDbType.NVarChar).Value = Model.Address;
                command.Parameters.Add("@email", SqlDbType.NVarChar).Value = Model.Email;
                command.Parameters.Add("@city", SqlDbType.NVarChar).Value = Model.City;
                command.Parameters.Add("@phone", SqlDbType.Char).Value = Model.Phone;
                command.ExecuteNonQuery();
            }
        }


        public void UpdateEmployee(CustomerModel Model)
        {
            using (var connection = new SqlConnection(connectionString))
            using (var command = new SqlCommand())
            {
                connection.Open();
                command.Connection = connection;
                command.CommandText = @"exec UpdateEm @Id,@Name,@Gender,@BirthDay,@Address,@City,@Phone";
                command.Parameters.Add("@Id", SqlDbType.Int).Value = Model.ID;
                command.Parameters.Add("@Name", SqlDbType.NVarChar).Value = Model.Name;
                command.Parameters.Add("@Gender", SqlDbType.NVarChar).Value = Model.Gender;
                command.Parameters.Add("@BirthDay", SqlDbType.Date).Value = Model.BirthYear;
                command.Parameters.Add("@Address", SqlDbType.NVarChar).Value = Model.Address;
                command.Parameters.Add("@City", SqlDbType.NVarChar).Value = Model.City;
                command.Parameters.Add("@Phone", SqlDbType.Char).Value = Model.Phone;
                command.ExecuteNonQuery();
            }
        }


    }
}
