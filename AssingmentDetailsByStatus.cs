using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment
{
    internal class AssingmentDetailsByStatus
    {
        public string assignmentName;
        public int noOfStudent;
        public int totalCompletionDays;
        public string assignmentStatus;
       
        public AssingmentDetailsByStatus(){}

        public AssingmentDetailsByStatus(string assignmentName, int noOfStudent, int totalCompletionDays,string assignmentStatus)
        {
            this.assignmentName = assignmentName;
            this.noOfStudent = noOfStudent;
            this.totalCompletionDays = totalCompletionDays;
            this.assignmentStatus = assignmentStatus;
        }
    }
}
