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
    public class ProfilePresenter
    {
        private ICustomerView view;
        private ICustomerReponsitory reponsitory;
        private readonly string sqlconnectionString;
        // If check = false => employee else customer
        public ProfilePresenter(ICustomerView view, string sqlConnectionString,int iduser,bool check)
        {
            this.view = view;
            this.view.id = iduser.ToString();
            this.view.IsEdit = check;
            this.reponsitory = new CustomerReponsitory(sqlConnectionString);
            this.sqlconnectionString = sqlConnectionString;
            this.view.EmployeeEvent += ShowInformation;
            this.view.SaveEmployee += SaveInformation;
            this.view.ShowChangePass += ShowChangePassView;
            loadAll();
            this.view.Show();
        }

        private void ShowChangePassView(object sender, EventArgs e)
        {
            ILoginView loginview = new ChangePassView();
            ILoginReponsitory loginReponsitory = new LoginReponsitory(sqlconnectionString);
            new ChangePassPresenter(loginview, loginReponsitory, sqlconnectionString, view.email, false);
        }

        private void SaveInformation(object sender, EventArgs e)
        {
            var employee = new CustomerModel();
            employee.ID = Convert.ToInt32(view.id);
            employee.Name = view.name;
            employee.Gender = view.gender;
            employee.Address = view.address;
            employee.BirthYear = view.birthyear;
            employee.City = view.city;
            employee.Email = view.email;
            employee.Phone = view.phone;
            view.IsSuccessful = false;
            try
            {
                if (this.view.IsEdit)
                {
                    reponsitory.UpdateCustomer(employee);
                    view.Message = "Information updated successfully!!!";
                    view.IsSuccessful = true;
                    loadAll();
                }
                else
                {
                    reponsitory.UpdateEmployee(employee);
                    view.Message = "Information updated successfully!!!";
                    view.IsSuccessful = true;
                    loadAll();
                }
            }
            catch (Exception ex)
            {
                view.IsSuccessful = false;
                view.Message = ex.Message;
            }
        }

        private void loadAll()
        {
            var list = new CustomerModel();
            if (this.view.IsEdit)
            {
                reponsitory.GetCus(list,Convert.ToInt32(view.id));
                view.name = list.Name;
                view.phone = list.Phone;
                view.email = list.Email;
                view.gender = list.Gender;
                view.address = list.Address;
                view.birthyear = list.BirthYear;
                view.city = list.City;
            }
            else
            {
                reponsitory.GetInformation(list,Convert.ToInt32(view.id.ToString()));
                view.name = list.Name;
                view.phone = list.Phone;
                view.email = list.Email;
                view.address = list.Address;
                view.birthyear = list.BirthYear;
                view.gender = list.Gender;
                view.city = list.City;
            }
        }

        private void ShowInformation(object sender, EventArgs e)
        {
            loadAll();
        }
    }
}
