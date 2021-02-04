using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using WebMaze.DbStuff.Model.Polyclinic;

namespace WebMaze.DbStuff.Repository
{
    public class PatientRepository : BaseRepository<Patients>
    {
        public PatientRepository(WebMazeContext context) : base(context) { }

        public Patients GetPatientById(int id)
        {
            return dbSet.SingleOrDefault(x => x.Id == id);
        }

    }
}
