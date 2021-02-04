using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace WebMaze.DbStuff.Model.Polyclinic
{
    public class Schedule : BaseModel
    {
        public long PositionID { get; set; }

        public DayOfWeek DayOfWeek { get; set; }

        public TimeSpan Time { get; set; }

    }
}
