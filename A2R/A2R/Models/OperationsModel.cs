using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace A2R.Models
{
    public class OperationsModel
    {
        public Guid id { get; set; }
        public string input { get; set; }
        public string input2 { get; set; }
        public string op { get; set; } 
        public string output { get; set; }
        public int index { get; set; }

    }
}