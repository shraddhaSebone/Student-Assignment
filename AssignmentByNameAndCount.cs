using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment
{
    internal class AssignmentByNameAndCount
    {
        public int studentId;
        public string studentName;
        public int assignmentCount;
        public int completionDays;

        public AssignmentByNameAndCount() { }

        public AssignmentByNameAndCount(int studentId, string studentName, int assignmentCount, int completionDays)
        {
            this.studentId = studentId;
            this.studentName = studentName;
            this.assignmentCount = assignmentCount;
            this.completionDays = completionDays;
        }
    }
}
