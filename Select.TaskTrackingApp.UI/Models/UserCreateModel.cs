using Microsoft.AspNetCore.Mvc.Rendering;

namespace Select.TaskTrackingApp.UI.Models
{
    public class UserCreateModel
    {
        public string FirstName { get; set; }

        public string LastName { get; set; }

        public string Username { get; set; }

        public string Email { get; set; }

        public int DegreeId { get; set; } //Ünvan

        public SelectList DegreesSelectList { get; set; }

        public string Password { get; set; }
    }
}
// todo UserCreateModel için controller yazılacak user ekleme işlemi yapılacak. 
