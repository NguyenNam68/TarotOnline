using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace Tarot.Web.Models
{
    public class LoginModel
    {
        [Required(ErrorMessage ="Vui lòng nhập tài khoản")]
        public string UserName { set; get; }

        [Required(ErrorMessage = "Vui lòng nhập mật khẩu")]
        public string PassWord { set; get; }

        public bool RememberMe { set; get; }
    }
}