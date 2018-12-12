using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;
using IS_403_Project2.Models;

namespace IS_403_Project2.DAL
{
    public class MissionContext : DbContext
    {
        public MissionContext() : base("MissionContext")
        {

        }

        public System.Data.Entity.DbSet<IS_403_Project2.Models.MissionQuestions> MissionQuestions { get; set; }

        public System.Data.Entity.DbSet<IS_403_Project2.Models.Mission> Missions { get; set; }
    }
}