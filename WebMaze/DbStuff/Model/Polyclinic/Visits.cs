using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace WebMaze.DbStuff.Model.Polyclinic
{
    public class Visits : BaseModel
    {
        public int PatientID { get; set; }

        public int DoctorID { get; set; }

        public DateTime VisitDate { get; set; }

        public string Complaints { get; set; }
        
        public string ObjResearchData { get; set; }

        public string Diagnosis { get; set; }

        public string Treatment { get; set; }

        public string SurveyPlan { get; set; }

        public DateTime NextVisitDate { get; set; }

        public int VisitCost { get; set; }


    }
}
