using System;
using System.Collections.Generic;

// Code scaffolded by EF Core assumes nullable reference types (NRTs) are not used or disabled.
// If you have enabled NRTs for your project, then un-comment the following line:
// #nullable disable

namespace HelpAssistant
{
    public partial class Task
    {
        public int Id { get; set; }
        public string TaskName { get; set; }
        public string Description { get; set; }
        public DateTime? Date { get; set; }
        public int? IdUser { get; set; }
        public int? IdUserAccept { get; set; }
        public int? IdStatus { get; set; }
        public string Status { get; set; }  

        public virtual StatusTask IdStatusNavigation { get; set; }
        public virtual User IdUserAcceptNavigation { get; set; }
        public virtual User IdUserNavigation { get; set; }
    }
}
