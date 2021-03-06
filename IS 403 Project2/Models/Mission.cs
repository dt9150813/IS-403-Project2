﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;

namespace IS_403_Project2.Models
{
    [Table("Mission")]
    public class Mission
    {
        [Key]
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