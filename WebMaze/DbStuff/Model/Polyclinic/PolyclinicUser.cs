using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace WebMaze.DbStuff.Model.Polyclinic
{
    public class PolyclinicUser : BaseModel
    {
        public string UserName { get; set; }

        public string Password { get; set; }

        public string FIO { get; set; }

        public DateTime BirthDate { get; set; }

        public string Position { get; set; }

    }
}
