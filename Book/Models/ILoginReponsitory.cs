using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Book.Models
{
    public interface ILoginReponsitory
    {
        void Add(LoginModel loginModel);
        void Edit(LoginModel loginModel);
        void Delete(LoginModel loginModel);
        string OutputPass(string email,string pass);
        int Check(string email, string pass);
        int CheckUser(string email);
        int CheckEmailBeforeRegister(string email);   
    }
}
