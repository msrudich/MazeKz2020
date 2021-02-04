using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace WebMaze.DbStuff.Model.Polyclinic
{
    public class PriceDoctors : BaseModel
    {
        public int PositionID { get; set; }

        public int CategoryID { get; set; }

        public int Cost { get; set; }

    }
}
