using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;

namespace Bookshelf.Models
{
    public class Book
    {
        [Key]//always want an id when building a model in C#.....it's also called the Primary Key
        public int ID { get; set; }
        public string Title { get; set; }
        public DateTime PublishedDate { get; set; }
        public string Description { get; set; }
        public string ISBN { get; set; }

        [ForeignKey("Category")]//establishes a relationship with another class (or table)
        public int CategoryID { get; set; }
        public virtual Category Category { get; set; }
        //the first word is a navigation property.

    }
}