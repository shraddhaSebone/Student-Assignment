using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment
{
    public class Program
    {
        static void Main(string[] args)
        {
            List<AssignmentData> list = new List<AssignmentData>();
            AssignmentData assignmentData9 = new AssignmentData(101, "Bhanu", "C#", "Complete", 12);
            list.Add(assignmentData9);
            AssignmentData assignmentData1 = new AssignmentData(101,"Bhanu","Java","Complete",5);
            list.Add(assignmentData1);
            AssignmentData assignmentData2 = new AssignmentData(103, "Sajal", "Java", "Complete", 5);
            list.Add(assignmentData2);
            AssignmentData assignmentData4 = new AssignmentData(101, "Bhanu", "UnitTest", "Not Done", 0);
            list.Add(assignmentData4);
            AssignmentData assignmentData5 = new AssignmentData(105, "Ritika", "Java", "Not Done", 0);
            list.Add(assignmentData5);
            AssignmentData assignmentData6 = new AssignmentData(106, "Utkarsh", "Web", "Progress", 4);
            list.Add(assignmentData6);
            AssignmentData assignmentData7 = new AssignmentData(105, "Ritika", "Web", "Complete", 6);
            list.Add(assignmentData7);
            AssignmentData assignmentData8 = new AssignmentData(106, "Utkarsh", "Java", "Complete", 8);
            list.Add(assignmentData8);
            AssignmentData assignmentData3 = new AssignmentData(102, "Bhawana", "Java", "Progress", 3);
            list.Add(assignmentData3);
            AssignmentData assignmentData10 = new AssignmentData(102, "Bhawana", "UnitTest", "Complete", 6);
            list.Add(assignmentData10);

            AssignmentOperations assignmentOperations = new AssignmentOperations();
            List<AssignmentByStudent> list1 = assignmentOperations.getAssignmentDetails(list);

            foreach (AssignmentByStudent assignment in list1)
            {
                Console.WriteLine($"{assignment.assignmentName},{assignment.noOfStudent}");
            }

            Console.WriteLine("************************************************************************************");
            List<AssingmentDetailsByStatus> list2 = assignmentOperations.getTotalAssignmentByStatus(list);

            foreach (AssingmentDetailsByStatus assignment in list2)
            {
                Console.WriteLine($"{assignment.assignmentName},{assignment.noOfStudent},{assignment.totalCompletionDays},{assignment.assignmentStatus}");
            }

            Console.WriteLine("************************************************************************************");

            List<AssignmentByNameAndCount> list3 = assignmentOperations.getStudentDetailsByNameAndCount(list);
            foreach(AssignmentByNameAndCount assignment in list3)
            {
                Console.WriteLine($"{assignment.studentId},{assignment.studentName},{assignment.assignmentCount},{assignment.completionDays}");
            }
        }
    }
}
