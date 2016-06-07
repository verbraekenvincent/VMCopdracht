using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace MVCopdracht.Models
{
    public class Component
    {
        public int ID { get; set; }
        public String Category { get; set; }
        public String Name { get; set; }
        public String Datasheeturl { get; set; }
        public int Amount { get; set; }
        public double Price { get; set; }
    }
}