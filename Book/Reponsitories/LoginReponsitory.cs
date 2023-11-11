using Book.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Data;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.ProgressBar;

namespace Book.Reponsitories
{
    public class LoginReponsitory : BaseReponsitory, ILoginReponsitory
    {
        public LoginReponsitory(string connectionString)
        {
            this.connectionString = connectionString;
        }
        public void Add(LoginModel loginModel)
        {
            using (var connection = new SqlConnection(connectionString))
            using (var command = new SqlCommand())
            {
                connection.Open();
                command.Connection = connection;
                command.CommandText = @"exec AddLogin @email,@pass,@name,@last";
                command.Parameters.Add("@email", SqlDbType.NVarChar).Value = loginModel.Email;
                command.Parameters.Add("@pass", SqlDbType.NVarChar).Value = loginModel.Password;
                command.Parameters.Add("@name", SqlDbType.NVarChar).Value = loginModel.Name;
                command.Parameters.Add("@last", SqlDbType.NVarChar).Value = loginModel.LastName;
                command.ExecuteNonQuery();
            }
        }

        public void Delete(LoginModel loginModel)
        {
            throw new NotImplementedException();
        }

        public void Edit(LoginModel loginModel)
        {
            using (var connection = new SqlConnection(connectionString))
            using (var command = new SqlCommand())
            {
                connection.Open();
                command.Connection = connection;
                command.CommandText = @"exec Change @email,@pa";
                command.Parameters.Add("@email", SqlDbType.NVarChar).Value = loginModel.Email;
                command.Parameters.Add("@pa", SqlDbType.NChar).Value = loginModel.Password;
                command.ExecuteNonQuery();
            }
        }

        public int Check(string email,string pass)
        {
            var check = 0;
            using (var connection = new SqlConnection(connectionString))
            using (var command = new SqlCommand())
            {
                connection.Open();
                command.Connection = connection;
                command.CommandText = "select dbo.CheckLogin('" + email + "','" + pass + "')";
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

        public int CheckUser(string email)
        {
            int check = 0;
            using (var connection = new SqlConnection(connectionString))
            using (var command = new SqlCommand())
            {
                connection.Open();
                command.Connection = connection;
                command.CommandText = "select dbo.PrintIDCustomer('" + email + "')";
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

        public int CheckEmailBeforeRegister(string email)
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

        public string OutputPass(string email,string pass)
        {
            using (var connection = new SqlConnection(connectionString))
            using (var command = new SqlCommand())
            {
                connection.Open();
                command.Connection = connection;
                command.CommandText = "select dbo.OutputPassword('" + email + "')";
                using (var reader = command.ExecuteReader())
                {
                    while (reader.Read())
                    {
                        pass = reader[0].ToString();
                    }
                }
            }
            return pass;
        }
    }
}
