using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace Book.Models
{
    public class BookModel
    {
        //Fields
        private int idBook;
        private string title;
        private string category;
        private string author;
        private string age;
        private string status;
        private string percentgift;
        private int quantity;
        private float money;
        //Properties - Validations  
        [DisplayName("Book ID")]
        public int IDBook
        {
            get { return idBook; }
            set { idBook = value; }
        }
        [DisplayName("Book's Title")]
        [Required(ErrorMessage = "Book's Title is required")]
        [StringLength(50, MinimumLength = 2, ErrorMessage = "Book's Title must be between 2 and 50 characters")]
        public string Title
        {
            get { return title; }
            set { title = value; }
        }
        [DisplayName("Book's Category")]
        [Required(ErrorMessage = "Book's Category is required")]
        [StringLength(50, MinimumLength = 3, ErrorMessage = "Book's Category must be between 3 and 50 characters")]
        public string Category
        {
            get { return category; }
            set { category = value; }
        }
        [DisplayName("Book's Author")]
        [Required(ErrorMessage = "Book's Author is required")]
        [StringLength(50, MinimumLength = 3, ErrorMessage = "Book's Author must be between 3 and 50 characters")]
        public string Author
        {
            get { return author; }
            set { author = value; }
        }
        [DisplayName("Book's Age")]
        [Required(ErrorMessage = "Book's Age is required")]
        [StringLength(50, MinimumLength = 3, ErrorMessage = "Book's Age must be between 3 and 50 characters")]
        public string Age
        {
            get { return age; }
            set { age = value; }
        }
        [DisplayName("Book's Status")]
        [Required(ErrorMessage = "Book's Status is required")]
        [StringLength(50, MinimumLength = 3, ErrorMessage = "Book's Status must be between 3 and 50 characters")]
        public string Status
        {
            get { return status; }
            set { status = value; }
        }
        [DisplayName("Book's Percent Gift")]
        [Required(ErrorMessage = "Book's Percent Gift is required")]
        [StringLength(50, MinimumLength = 3, ErrorMessage = "Book's Percent Gift must be between 3 and 50 characters")]
        public string PercenGift
        {
            get { return percentgift; }
            set { percentgift = value; }
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
