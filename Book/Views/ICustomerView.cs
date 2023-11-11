using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Book.Views
{
    public interface ICustomerView
    {
        //Propeties
        string id { get; set; }
        string name { get; set; }
        DateTime birthyear { get; set; }
        DateTime start { get; set; }
        DateTime end { get; set; }
        string gender { get; set; }
        string email { get; set; }
        string address { get; set; }
        string city { get; set; }
        string phone { get; set; }
        string Top { get; set; }
        bool IsEdit { get; set; }
        bool IsSuccessful { get; set; }
        string Message { get; set; }

        //Events
        event EventHandler CustomerEvent;
        event EventHandler EmployeeEvent;
        event EventHandler AddEmployee;
        event EventHandler RemoveEmployee;
        event EventHandler UpdateEmployee;
        event EventHandler SaveEmployee;
        event EventHandler SearchStatital;
        event EventHandler TopCustomer;
        event EventHandler Cancel;
        event EventHandler ShowChangePass;

        //Methods
        void SetDataEmployee(BindingSource EmployeeList);
        void SetDataStatial(BindingSource StatialList);
        void SetDataTopCustomer(BindingSource TopCustomer);
        void Show();
    }
}
