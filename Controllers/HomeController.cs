using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;


namespace IS445.Controllers
{
    public class HomeController : Controller
    {
        //
        // GET: /Home/

        public ActionResult Index()
        {
            return View();
        }

        public ActionResult WebForm()
        {
            return View();
        }

        public ActionResult Aboutme()
        {
            return View();
        }


        public ActionResult ReWord(string inputwords)
        {

            String Newword = string.Join(" ", inputwords.Split(' ').Reverse());
            //string[] Newwords = inputwords.Split(' ');
            //Array.Reverse(Newwords);

            return View((object)Newword);
        }




        public ActionResult FormatPhoneNumber(string inputNumber)
        {

          if (string.IsNullOrEmpty(inputNumber))
          {
            return Content("invalid input, please try again");
          }
          else
          {
            //string formatted = string.Format("{0: (###) ###-####}", inputNumber);
            string formatted = formatNumber(inputNumber);
            return View((object)formatted);
          }
        }

        // please implement your phone number formatting logic here
        private string formatNumber(string inputNumber)
        {
          string newformat = string.Format("{0: (###) ###-####}", Convert.ToInt64(inputNumber)); 
            // imiplement formatting here
          return newformat;
        }




    }
}
