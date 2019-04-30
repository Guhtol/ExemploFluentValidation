using System;
using System.Collections.Generic;
using System.Text;

namespace GenericFluent
{

    public class Customer : Base
    {
        public int Id { get; set; }
        public string Forename { get; set; }
        public decimal Discount { get; set; }
        public string Address { get; set; }
    }

}
