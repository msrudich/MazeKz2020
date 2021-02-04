using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using WebMaze.DbStuff.Model.Polyclinic;

namespace WebMaze.DbStuff.Repository
{
    public class PolyclinicUserRepository : BaseRepository<PolyclinicUser>
    {
        public PolyclinicUserRepository(WebMazeContext context) : base(context) { }

        public PolyclinicUser GetUserByNameAndPassword(string userName, string password)
        {
            return dbSet.SingleOrDefault(x => x.UserName == userName && x.Password == password);
        }

    }
}
