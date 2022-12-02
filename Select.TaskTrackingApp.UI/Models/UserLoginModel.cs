using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace Select.TaskTrackingApp.UI.Models
{
    public class UserLoginModel
    {
        [Required]
        [MaxLength(50,ErrorMessage ="50 karakterden uzun olamaz.")]
        public string Username { get; set; }
        [Required]
        [MaxLength(150)]
        public string Password { get; set; }

        public bool RememberMe { get; set; }
    }
}
