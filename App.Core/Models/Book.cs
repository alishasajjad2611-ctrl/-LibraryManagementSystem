using System;
using System.Collections.Generic;
using System.Text;

namespace App.Core.Models
{
    public class Book
    {
        public int Id { get; set; }
        public string BookTitle { get; set; }
        public string AuthorName { get; set; }
        public int Quantity { get; set; }
        public string Category{ get; set; }
    }
}