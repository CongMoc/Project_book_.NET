using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Book.Models
{
    public class CustomerModel
    {
        //Fields
        private int id;
        private string name;
        private DateTime birthYear;
        private string gender;
        private string email;
        private string address;
        private string city;
        private string phone;
        //Properties - Validations
        [DisplayName("ID")]
        public int ID
        {
            get { return id; }
            set { id = value; }
        }
        [DisplayName("Name")]
        [Required(ErrorMessage = "Name customer is required")]
        [StringLength(50, MinimumLength = 2, ErrorMessage = "Name customer must be between 2 and 50 characters")]
        public string Name
        {
            get { return name; }
            set { name= value; }
        }
        [DisplayName("Birth Year")]
        [Required(ErrorMessage = "Birth Year is required")]
        [StringLength(4, MinimumLength = 4, ErrorMessage = "Birth Year must be 4 characters")]
        public DateTime BirthYear
        {
            get { return birthYear; }
            set { birthYear = value; }
        }
        [DisplayName("Gender")]
        [Required(ErrorMessage = "Gender is required")]
        [StringLength(4, MinimumLength = 3, ErrorMessage = "Gender must be 3 -> 4 characters")]
        public string Gender
        {
            get { return gender; }
            set { gender = value; }
        }
        [DisplayName("Email")]
        [Required(ErrorMessage = "Email is required")]
        [StringLength(50, MinimumLength = 2, ErrorMessage = "Email must be between 2 and 50 characters")]
        public string Email
        {
            get { return email; }
            set { email = value; }
        }
        [DisplayName("Address")]
        [Required(ErrorMessage = "Address is required")]
        [StringLength(50, MinimumLength = 4, ErrorMessage = "Address must be 4 -> 50 characters")]
        public string Address
        {
            get { return address; }
            set { address = value; }
        }
        [DisplayName("City")]
        [Required(ErrorMessage = "City is required")]
        [StringLength(50, MinimumLength = 2, ErrorMessage = "City must be between 2 and 50 characters")]
        public string City
        {
            get { return city; }
            set { city = value; }
        }
        [DisplayName("Phone")]
        [Required(ErrorMessage = "Phone is required")]
        [StringLength(10, MinimumLength = 9, ErrorMessage = "Phone must be 4 characters")]
        public string Phone
        {
            get { return phone; }
            set { phone = value; }
        }
    }
}
