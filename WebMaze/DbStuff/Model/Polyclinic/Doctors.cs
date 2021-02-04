using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace WebMaze.DbStuff.Model.Polyclinic
{
    public class Doctors : BaseModel
    {
        public int PositionID { get; set; }

        public int SpecializationID { get; set; }

        public int CategoryID { get; set; }

        public string FirstName { get; set; }

        public string MiddleName { get; set; }

        public string LastName { get; set; }

        public string FIOkratko { get; set; }


    }
}
