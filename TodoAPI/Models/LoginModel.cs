using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace TodoAPI.Models
{
    public class LoginModel
    {
        [Required(ErrorMessage = "Username is required")]
        public string UserName { get; set; }

        [Required(ErrorMessage ="Password is required")]
        public string PassWord { get; set; }
    }
}
