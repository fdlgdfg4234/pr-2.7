using System;
using System.Collections.Generic;

// Code scaffolded by EF Core assumes nullable reference types (NRTs) are not used or disabled.
// If you have enabled NRTs for your project, then un-comment the following line:
// #nullable disable

namespace HelpAssistant
{
    public partial class StatusTask
    {
        public StatusTask()
        {
            Task = new HashSet<Task>();
        }

        public int Id { get; set; }
        public string StatusName { get; set; }

        public virtual ICollection<Task> Task { get; set; }
    }
}
