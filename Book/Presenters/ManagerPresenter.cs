using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Book.Models;
using Book.Views;
using Book.Reponsitories;
using System.Windows.Forms;
using Microsoft.Office.Interop.Excel;

namespace Book.Presenters
{
    public class ManagerPresenter
    {
        private ICustomerView view;
        private BindingSource sourceEm;
        private BindingSource sourceStatital;
        private IEnumerable<CartModel> cartModels;
        private IEnumerable<StatialModel> statials;
        private IEnumerable<CustomerModel> customerModels;
        private ICustomerReponsitory reponsitory;

        public ManagerPresenter(ICustomerView view, string sqlconnectionString)
        {
            sourceEm = new BindingSource();
            sourceStatital = new BindingSource();
            this.view = view;
            this.reponsitory = new CustomerReponsitory(sqlconnectionString);
            this.view.AddEmployee += AddEmployees;
            this.view.UpdateEmployee += LoadInformationOfEmployee;
            this.view.RemoveEmployee += RemoveEmployees;
            this.view.SaveEmployee += SaveInformation;
            this.view.CustomerEvent += StatialView;
            this.view.SearchStatital += StatialCustomerTop;
            this.view.EmployeeEvent += ShowEmployee;
            this.view.Cancel += CancelEvent;
            this.view.SetDataEmployee(sourceEm);
            this.view.SetDataStatial(sourceStatital);
            LoadAllEmployee();
            ClearviewFields();
            this.view.Show();
        }

        private void CancelEvent(object sender, EventArgs e)
        {
            ClearviewFields();
        }

        private void ShowEmployee(object sender, EventArgs e)
        {
            LoadAllEmployee();
        }

        private void StatialView(object sender, EventArgs e)
        {
            cartModels  = reponsitory.GetAllValueFollowTime(this.view.start, this.view.end);
            sourceStatital.DataSource = cartModels;  
        }

        private void StatialCustomerTop(object sender, EventArgs e)
        {
            statials = reponsitory.GetAllValueWithTopCustomer(int.Parse(view.Top));
            sourceStatital.DataSource = statials;
        }

        private void LoadAllEmployee()
        {
            customerModels = reponsitory.GetAllEmployees();
            sourceEm.DataSource= customerModels;
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
                if (view.IsEdit)
                {
                    reponsitory.UpdateEmployee(employee);
                    view.Message = "Employee updated successfully";
                    view.IsSuccessful = true;
                    LoadAllEmployee();
                    ClearviewFields();
                }
                else
                {
                    int check = reponsitory.checkEmail(view.email);
                    if (check == 2)
                    {
                        reponsitory.AddEmployee(employee);
                        view.Message = "Employee added successfully";
                        view.IsSuccessful = true;
                        LoadAllEmployee();
                    }
                    else if(check == 0)
                    {
                        view.Message = "Existsed this email in list!!!";
                    }
                    else
                    {
                        view.Message = "Email is invaid!!!";
                    }
                }
            }
            catch (Exception ex)
            {
                view.IsSuccessful = false;
                view.Message = ex.Message;
            }
        }
        private void ClearviewFields()
        {
            view.name = "";
            view.gender = "";
            view.address = "";
            view.city = "";
            view.email = "";
            view.phone = "";
        }
        private void RemoveEmployees(object sender, EventArgs e)
        {
            var customer = (CustomerModel)sourceEm.Current;
            if(customer is null)
            {
                view.IsSuccessful = false;
                view.Message = "You must choose any people before remove!!!";
            }
            else
            {
                reponsitory.DeleteEmployee(customer);
                view.IsSuccessful = true;
                view.Message = "Removed is successfully";
                LoadAllEmployee();
                ClearviewFields();
            }
        }

        private void LoadInformationOfEmployee(object sender, EventArgs e)
        {
            var customer = (CustomerModel)sourceEm.Current;
            if (customer is null)
            {
                view.Message = "You must choose any people before edit!!!";
            }
            else
            {
                view.id = customer.ID.ToString();
                view.name = customer.Name;
                view.gender = customer.Gender;
                view.birthyear = customer.BirthYear;
                view.address = customer.Address;
                view.email = customer.Email;
                view.city = customer.City;
                view.phone = customer.Phone;
                view.IsEdit = true;
            }
        }

        private void AddEmployees(object sender, EventArgs e)
        {
            view.IsEdit = false;
        }
    }
}
