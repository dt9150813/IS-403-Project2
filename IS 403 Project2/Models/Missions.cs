using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace IS_403_Project2.Models
{
    public class Missions
    {
        public int MissionID { get; set; }
        public string missionName { get; set; }
        public string missionPresidentsName { get; set; }
        public string missionAddress { get; set; }
        public string language { get; set; }
        public string climate { get; set; }
        public string dominantReligion { get; set; }
        public string flagSymbol { get; set; }
    }
}