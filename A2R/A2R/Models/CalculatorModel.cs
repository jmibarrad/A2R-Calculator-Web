using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace A2R.Models
{
    public class CalculatorModel
    {
        public string expresion { get; set; }
        public string answer { get; set; }
        public List<OperationsModel> Operaciones { get; set; }

    }
}