using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Lesson2_Routing
{
    public class Product
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public ProdType? ProductType { get; set; }
    }
    public enum ProdType
    {
        Computer,
        Headphone,
        Cellphone
    }
}