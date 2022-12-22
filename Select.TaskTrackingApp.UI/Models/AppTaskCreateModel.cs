using Microsoft.AspNetCore.Mvc.Rendering;
using System;
using System.Diagnostics.CodeAnalysis;

namespace Select.TaskTrackingApp.UI.Models
{
    public class AppTaskCreateModel 
    {
        [NotNull]
        public string Title { get; set; }
        
        [NotNull]
        public string Defination { get; set; }
        
        [NotNull]
        public int PriortryId { get; set; }

        public SelectList PriortrySelectList { get; set; }

        public DateTime CreatedTime { get; set; }

        public DateTime EndDateTime { get; set; }

        public bool IsActive { get; set; } = true;

    }
}
