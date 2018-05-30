using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace MVC_Exercise.Models
{
    public class Product
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public int Price { get; set; }
        public string Category { get; set; }
        public string Shelf { get; set; }
        public int Count { get; set; }
        public string Description { get; set; }
        public DateTime DateTime { get; set; }

    }
    public class Time :Product
    {
    public DateTime CreatedAt { get; set; }

    public Time()
    {
        CreatedAt = DateTime.Now;
    }
}
 
}