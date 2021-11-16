using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using ScoreManager.Common;

namespace ScoreManager.Controllers
{
    public class LoginController : Controller
    {
        // GET: Login
        public ActionResult Index()
        {
            return View();
        }
        public ActionResult Login(string Username, string Password)
        {
            string pass_hash = new HASH_MD5().ToMD5(Password);
            if (ModelState.IsValid)
            {
                F_USER fuser = new F_USER();
                //USER result = fuser.GetSingleByCondition(x => x.UserName == Username && x.Password == pass_hash);
                User result = fuser.GetSingleByCondition(x => x.Username == Username && x.Password == pass_hash);

                if (result != null && result.User_STT == 1)
                {
                    var user_session = new LoginModels();
                    user_session.UserName = result.Name;
                    user_session.Password = pass_hash;
                    user_session.User_ID = result.ID;
                    user_session.Name = result.Name;
                    user_session.Role = result.User_Role1.Name;
             
                    foreach (var item in LstuserRole_Permissions)
                    {

                        user_session.listPermissions.Add(item.Permission);
                    }

                    user_session.Permissions = fuser.GetListPermission((int)result.User_Role);
                    user_session.Department_ID = (int)result.Organization_ID;
                    user_session.Department_Name = result.Organization.Organization_Name;
                    Session.Add(CommonConstants.USER_SESSION, user_session);
                    return RedirectToAction("Dashboad", "Home");
                }

                else if (result != null && result.User_STT != 1)
                {
                    ViewBag.Notification = "Tài khoản đang bị khóa";
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

        // GET: Login/Details/5
        public ActionResult Details(int id)
        {
            return View();
        }

        // GET: Login/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: Login/Create
        [HttpPost]
        public ActionResult Create(FormCollection collection)
        {
            try
            {
                // TODO: Add insert logic here

                return RedirectToAction("Index");
            }
            catch
            {
                return View();
            }
        }

        // GET: Login/Edit/5
        public ActionResult Edit(int id)
        {
            return View();
        }

        // POST: Login/Edit/5
        [HttpPost]
        public ActionResult Edit(int id, FormCollection collection)
        {
            try
            {
                // TODO: Add update logic here

                return RedirectToAction("Index");
            }
            catch
            {
                return View();
            }
        }

        // GET: Login/Delete/5
        public ActionResult Delete(int id)
        {
            return View();
        }

        // POST: Login/Delete/5
        [HttpPost]
        public ActionResult Delete(int id, FormCollection collection)
        {
            try
            {
                // TODO: Add delete logic here

                return RedirectToAction("Index");
            }
            catch
            {
                return View();
            }
        }
    }
}
