using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;

namespace IS_403_Project2.Models
{
    [Table("MissionQuestion")]
    public class MissionQuestions
    {
        public int missionQuestionID { get; set; }
        public int MissionID { get; set; }
        public int UserID { get; set; }
        public string question { get; set; }
        public string answer { get; set; }
    }
}