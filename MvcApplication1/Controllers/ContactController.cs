using MvcApplication1.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace MvcApplication1.Controllers
{
    public class ContactController : Controller
    {
        //
        // GET: /Contact/
        [HttpGet]
        public ActionResult ContactForm()
        {
            return View();
        }

        [HttpPost]
        public ActionResult ContactForm(ContactModel model)
        {
            if (ModelState.IsValid)
            {
                InsertContact(model.Name, model.Email, model.Comments);
                TempData["notice"] = "Your form was submitted.";
                //Envoi à nouveau les informations
                //return view();

                //Ne peut réenvoyer les données avec un refresh
                return RedirectToAction("Index", "Home");
            }
            return View();
        }


        private void InsertContact(string name, string email, string comments)
        {

        }
    }
}
