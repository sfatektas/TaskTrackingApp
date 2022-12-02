using Microsoft.AspNetCore.Http;

namespace Select.TaskTrackingApp.UI.Models
{
    public class AppUserTaskUpdateModel
    {
        public int AppTaskId { get; set; }

        public string ComplateDocumentDefination { get; set; }

        public IFormFile TaskComplateFile { get; set; }
    }
}
