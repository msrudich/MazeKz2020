using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Threading.Tasks;

namespace WebMaze.Models.Polyclinic
{
    public class PolyclinicUserViewModel
    {
        [DisplayName("User name")]
        public string UserName { get; set; }

        [DisplayName("Password")]
        public string Password { get; set; }

        public string Position { get; set; }

        public string ReturnURL { get; set; }
    }
}
