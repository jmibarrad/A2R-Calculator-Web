using System;
using System.Collections.Generic;
using System.Configuration;
using System.Diagnostics;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using System.Windows.Forms;

namespace A2R.Controllers
{
    public class RomanCalculatorController: Controller
    {

        public ActionResult Calculator()
        {
           if (Session["oper"] == null)
                Session["oper"] = new List<Operations>();

            var calculator = new CalculatorClass
            {
                OperList = (List<Operations>) Session["oper"]
            };


            return View(calculator);
        }
        
        [HttpPost]
        public ActionResult Calculator(CalculatorClass objCalc)
        {

            var operation = new Operations
            {
                //input = objCalc.input,
                //output = objCalc.output,
                id= new Guid(),
                input="hola",
                output = "hello"
            };

            if (objCalc.OperList != null)
            {
             
                objCalc.OperList.Add(operation);
               Session["oper"] = objCalc.OperList;
            }
            else
            {
                MessageBox.Show("Error");
            }
           
            objCalc.OperList = (List<Operations>)Session["oper"];
            Session["oper"] = objCalc.OperList;

            return View(objCalc);
        }


    }

    public class CalculatorClass
    {
        
        public string input { get; set; }
        public string output { get; set; }
        public List<Operations> OperList { get; set; }


    }

    public class Operations
    {
        public Guid id { get; set; }
        public string output { get; set; }
        public string input { get; set; }
        //public DateTime date = new DateTime();
        public Boolean archived { get; set; }

    }
}