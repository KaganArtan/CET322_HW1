using System;
using System.Collections.Generic;

namespace CET322_HW1.Models
{
    public class BookManager
    {
        public class Book
        {
            public string BookName { get; set; }
            public string Author { get; set; }
            public int PageNumber { get; set; }
            public DateTime DueDate { get; set; }

        }       
    }  
}
