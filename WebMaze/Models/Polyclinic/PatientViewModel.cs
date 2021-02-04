using Microsoft.AspNetCore.Http;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Threading.Tasks;

namespace WebMaze.Models.Polyclinic
{
    public class PatientViewModel
    {
        public string SearchBy { get; set; }
        
        public int PatientID { get; set; }

        public IFormFile Photo { get; set; }

        public string PhotoURL { get; set; }

        public string FirstName { get; set; }

        public string LastName { get; set; }
        
        public string MiddleName { get; set; }

        public DateTime BirthDate { get; set; }

        public int Years { get; set; }

        public int Months { get; set; }

        public string Gender { get; set; }

        public string AttendingPhysician { get; set; }

        public string DocumentNumber { get; set; }

        public int BloodGroup { get; set; }

        public string PhFactor { get; set; }

        public string Deseases { get; set; }


    }
}
