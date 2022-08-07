using System;

namespace Select.TaskTrackingApp.Entities
{
    public class AppUser
    {
        public string FirstName { get; set; }

        public string  LastName { get; set; }

        public string  Email { get; set; }

        public int DegreeId { get; set; } //Ünvan

        public string Password { get; set; }

    }
}
