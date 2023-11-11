using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Book.Models
{
    public class StatialModel
    {
        //Fields
        private int id;
        private string name;
        private string phone;
        private int quantity;
        private float money;

        //Properties
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
            set { name = value; }
        }
        [DisplayName("Phone")]
        [Required(ErrorMessage = "Phone is required")]
        [StringLength(10, MinimumLength = 9, ErrorMessage = "Phone must be 4 characters")]
        public string Phone
        {
            get { return phone; }
            set { phone = value; }
        }
        [DisplayName("Book's Quantity")]
        [Required(ErrorMessage = "Book's Quantity is required")]
        public int Quantity
        {
            get { return quantity; }
            set { quantity = value; }
        }
        [DisplayName("Book's Money")]
        [Required(ErrorMessage = "Book's Money is required")]
        public float Money
        {
            get { return money; }
            set { money = value; }
        }
    }
}
