using PeopleCounterNg.Handlers;
using PeopleCounterNg.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace EvidencijaRadnogVremena.Controllers
{
    public class LoginController : Controller
    {
        // GET: Login
        public ActionResult Index()
        {
            ViewBag.username = "";
            ViewBag.errors = "";
            ViewBag.errorStyle = "";
            if (Request.Form.Count > 0)
            {
                List<string> keys = new List<string>() { "username", "password" };
                Dictionary<string, string> postData = RequestHandler.get(Request.HttpMethod.ToString(), keys, Request);

                string username = postData["username"];
                string password = postData["password"];

                if (!username.Equals(""))
                {
                    ViewBag.username = username;
                    if (!password.Equals(""))
                    {
                        User user = PeopleCounterNg.Models.User.logiraj(username, password);

                        if (user != null)
                        {
                            Session["user"] = user;
                            if (user.Privileges.Equals("peoplecounteruser"))
                            {
                                return RedirectToAction("Index", "Home");
                            }
                            else if (user.Privileges.Equals("peoplecounteradmin"))
                            {
                                return RedirectToAction("Index", "Home");
                            }
                        }
                        else
                        {
                            ViewBag.errors = "Greška prilikom logiranja!";
                            ViewBag.errorStyle = "text text-danger";
                        }
                    }
                    else
                    {
                        ViewBag.errors = "Unesite lozinku!";
                        ViewBag.errorStyle = "text text-danger";
                    }
                }
                else
                {
                    ViewBag.errors = "Unesite korisnicko ime!";
                    ViewBag.errorStyle = "text text-danger";
                }
            }
            return View();
        }

        public ActionResult Logout()
        {
            Session.Abandon();
            return RedirectToAction("Index", "Login");
        }
    }
}