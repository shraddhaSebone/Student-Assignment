using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment
{
    public class AssignmentData
    {
        public int id;
        public string name;
        public string assignment;
        public string status;
        public int days;

        public AssignmentData()
        { }
        public AssignmentData(int id, string name, string assignment, string status, int days)
        {
            this.id = id;
            this.name = name;
            this.assignment = assignment;
            this.status = status;
            this.days = days;
        }
    }
}
