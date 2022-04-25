using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment
{
    public class StudentData
    {
        public int studentId;
        public string studentName;
        public string assignmentName;
        public string assignmentStatus;
        public int completionDays;

        public StudentData(int studentId, string studentName, string assignmentName, string assignmentStatus, int completionDays)
        {
            this.studentId = studentId;
            this.studentName = studentName;
            this.assignmentName = assignmentName;
            this.assignmentStatus = assignmentStatus;
            this.completionDays = completionDays;
        }
    }
}
