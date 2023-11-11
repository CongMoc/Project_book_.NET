using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Book.Models
{
    public class LoginModel
    {
        //Fields
        private string email;
        private string password;
        private string name;
        private string lastName;
        //Properties - Validations  
        [Required(ErrorMessage = "Email is required")]
        [StringLength(50, MinimumLength = 2, ErrorMessage = "Email must be between 2 and 50 characters and have '@gmail.com'")]
        public string Email
        {
            get { return email; }
            set { email = value; }
        }
        [Required(ErrorMessage = "Password is required")]
        [StringLength(50, MinimumLength = 3, ErrorMessage = "Password must be between 3 and 50 characters")]
        public string Password
        {
            get { return password; }
            set { password = value; }
        }
        [Required(ErrorMessage = "Name is required")]
        [StringLength(50, MinimumLength = 2, ErrorMessage = "Name must be between 2 and 50 characters")]
        public string Name
        {
            get { return name; }
            set { name = value; }
        }
        [Required(ErrorMessage = "Last name is required")]
        [StringLength(50, MinimumLength = 3, ErrorMessage = "Last name must be between 3 and 50 characters")]
        public string LastName
        {
            get { return lastName; }
            set { lastName = value; }
        }
    }
}
