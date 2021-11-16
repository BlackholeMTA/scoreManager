using ShipDatabase.EF;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace ShipManager.Models
{
    public class LoginModels
    {
        public string UserName { set; get; }
        public string Password { set; get; }
        public  int User_ID { get; set; }
        public  int Class_ID { get; set; }
        public  int Department_ID { get; set; }
        public string Department_Name { get; set; }

        public string Name { get; set; }
        public string Role { set; get; }
        public List<string> Permissions { get; set; }
        public List<Permission> listPermissions { get; set; }
        public bool Rememberme { set; get; }
    }
}