using System;
using System.Collections.Generic;

// Code scaffolded by EF Core assumes nullable reference types (NRTs) are not used or disabled.
// If you have enabled NRTs for your project, then un-comment the following line:
// #nullable disable

namespace HelpAssistant
{
    public partial class User
    {
        public User()
        {
            TaskIdUserAcceptNavigation = new HashSet<Task>();
            TaskIdUserNavigation = new HashSet<Task>();
        }

        public int Id { get; set; }
        public string Surname { get; set; }
        public string Name { get; set; }
        public string Patronymic { get; set; }
        public string Login { get; set; }
        public string Password { get; set; }
        public string Phone { get; set; }

        public virtual ICollection<Task> TaskIdUserAcceptNavigation { get; set; }
        public virtual ICollection<Task> TaskIdUserNavigation { get; set; }
    }
}
