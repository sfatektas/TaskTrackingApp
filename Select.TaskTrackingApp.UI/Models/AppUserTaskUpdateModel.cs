using Microsoft.AspNetCore.Http;
using System.Diagnostics.CodeAnalysis;

namespace Select.TaskTrackingApp.UI.Models
{
    public class AppUserTaskUpdateModel
    {
        public int AppUserTaskId { get; set; }
        [NotNull]
        public string CompleteDocumentDefination { get; set; }

        public IFormFile TaskComplateFile { get; set; }
    }
}
