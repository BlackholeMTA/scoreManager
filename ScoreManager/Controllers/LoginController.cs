using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using ScoreManager.Common;
using ScoreDatabase.EF;
using ScoreManager.Models;

namespace ScoreManager.Controllers
{
    public class LoginController : Controller
    {
        // GET: Login
        public ActionResult Index()
        {
            return View();
        }
        public ActionResult Login(string Student_Id, string Password)
        {
            //string pass_hash = new HASH_MD5().ToMD5(Password);
            if (ModelState.IsValid)
            {
                    ScoreManagerDBContext db = new ScoreManagerDBContext();
                //USER result = fuser.GetSingleByCondition(x => x.UserName == Username && x.Password == pass_hash);
                 var result = db.C_LOGIN.Count(x => x.Student_Id == Student_Id && x.Password.ToString() == Password);

                    if (result > 0)
                    {
                         
                         var user_session = new LoginModels();
                         user_session.Student_Id = Student_Id;
                         Session.Add(CommonConstants.USER_SESSION, user_session);
                         return RedirectToAction("Index", "Home");
                    }
                    
                    else
                    {
                         ViewBag.Notification = "Sai tài khoản hoặc mật khẩu";
                    }
            }
            return View("Index");
        }
        public ActionResult Logout()
        {
            Session[CommonConstants.USER_SESSION] = null;
            return RedirectToAction("Index", "Login");
        }

       
    }
}
