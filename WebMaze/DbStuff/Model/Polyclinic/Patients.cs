using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace WebMaze.DbStuff.Model.Polyclinic
{
    public class Patients : BaseModel
    {
        public int ModifiedByID { get; set; }

        public string Category { get; set; }

        public virtual string PhotoURL { get; set; }

        public string FirstName { get; set; }

        public string MiddleName { get; set; }

        public string LastName { get; set; }

        public DateTime BirthDate { get; set; }

        public int Years { get; set; }

        public int Months { get; set; }

        public string Gender { get; set; }

        public string DocumentType { get; set; }

        public string DocumentNumber { get; set; }

        public string TelephoneNumber { get; set; }

        public string HomeAddress { get; set; }

        public int BloodGroup { get; set; }

        public string PhFactor { get; set; }

        public int Height { get; set; }

        public int Weight { get; set; }

        public string AttendingPhysician { get; set; }

        public string Deseases { get; set; }

        public string Allergies { get; set; }


    }
}
