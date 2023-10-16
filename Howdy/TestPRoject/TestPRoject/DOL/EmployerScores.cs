﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TestPRoject.Common
{
    [Serializable]
    public class EmployerScores
    {
        public int employeeId { get; set; }
        public int groupId { get; set; }
        public DateTime answeredOn { get; set; }
        public int answer1 { get; set; }
        public int answer2 { get; set; }
        public int answer3 { get; set; }
        public int answer4 { get; set; }
        public int answer5 { get; set; }

    }
}
