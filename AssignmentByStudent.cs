using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment
{
    public class AssignmentByStudent
    {
        public string assignmentName { get; set; } 
        public int noOfStudent { get; set; }

        public AssignmentByStudent() { }
        public AssignmentByStudent(string assignment, int noOfStudent)
        {
            this.assignmentName = assignment;
            this.noOfStudent = noOfStudent;
        }
    }
}
