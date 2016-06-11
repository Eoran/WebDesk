using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using System.Net.Mail;
using System.Net;

namespace WebDesk.Controllers
{
    public class HomeController : Controller
    {
        public ActionResult Index()
        {
            return View();
        }

        public ActionResult About()
        {
            ViewBag.Message = "Your application description page.";

            return View();
        }
        public ActionResult Konsulent()
        {
            return View();
        }
        public ActionResult Contact()
        {
            ViewBag.Message = "Your contact page.";

            return View();
        }
        [HttpPost]
        public ActionResult Contact(string Email, string Message, string Navn, string Emne)
        {
            MailMessage mailMessage = new MailMessage();
            mailMessage.To.Add("info@wbdesk.dk");
            mailMessage.From = new MailAddress(Email,Navn);
            mailMessage.Subject = Emne;
            mailMessage.Body = Message;
            mailMessage.IsBodyHtml = false;

            
            


            using (var smtp = new SmtpClient())
            {
                var credential = new NetworkCredential
                {
                    UserName = "louisenjensen@gmail.com",  // replace with valid value
                    Password = "LNJ060392"  // replace with valid value
                };
                smtp.Credentials = credential;
                smtp.Host = "smtp.gmail.com";
                smtp.Port = 587;
                smtp.EnableSsl = true;
                smtp.Send(mailMessage);
                return RedirectToAction("Index");
            }

            return View();
        }
        public ActionResult Computer()
        {
            ViewBag.Message = "Your contact page.";

            return View();
        }
        public ActionResult Web()
        {
            ViewBag.Message = "Your contact page.";

            return View();
        }
        public ActionResult Office()
        {
            ViewBag.Message = "Your contact page.";

            return View();
        }
        public ActionResult TEst()
        {
            ViewBag.Message = "Your contact page.";

            return View();
        }

    }
}