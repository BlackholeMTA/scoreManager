using ScoreDatabase.EF;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace ScoreManager.Models
{
    public class LoginModels
    {
        public string Student_Id { set; get; }
        public string Password { set; get; }
        
    }
}