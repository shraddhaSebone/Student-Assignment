using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment
{
    internal class AssignmentOperations
    {
        public List<AssignmentByStudent> getAssignmentDetails(List<AssignmentData> list)
        {
            Dictionary<string, AssignmentByStudent> key = new Dictionary<string, AssignmentByStudent>();
            List<AssignmentByStudent> assignment = new List<AssignmentByStudent>();

            foreach(AssignmentData studentDataDO in list)
            {
                if (key.ContainsKey(studentDataDO.assignment))
                    key[studentDataDO.assignment].noOfStudent++;
                else
                {
                    key.Add(studentDataDO.assignment, new AssignmentByStudent());
                    key[studentDataDO.assignment].assignmentName = studentDataDO.assignment;
                    key[studentDataDO.assignment].noOfStudent = 1;
                }
            }
            var myList = key.ToList();

            myList.Sort((pair1, pair2) => pair2.Value.noOfStudent.CompareTo(pair1.Value.noOfStudent));

            foreach (var pair in myList)
            {
                AssignmentByStudent assignmentByStudentAsc = new AssignmentByStudent();
                assignmentByStudentAsc.assignmentName = pair.Value.assignmentName;
                assignmentByStudentAsc.noOfStudent = pair.Value.noOfStudent;
                assignment.Add(assignmentByStudentAsc);
            }
            return assignment;
        }


        public List<AssingmentDetailsByStatus> getTotalAssignmentByStatus(List<AssignmentData> list)
        {
            Dictionary<KeyValuePair<string, string>, AssingmentDetailsByStatus> dict = new Dictionary<KeyValuePair<string, string>, AssingmentDetailsByStatus>();
            List<AssingmentDetailsByStatus> assingmentDetails = new List<AssingmentDetailsByStatus>();
            foreach (AssignmentData data in list)
            {
                var keyValue = new KeyValuePair<string, string>(data.assignment, data.status);

                if (dict.ContainsKey(keyValue))
                {
                    dict[keyValue].noOfStudent++;
                    dict[keyValue].totalCompletionDays += data.days;
                }
                else
                {
                    dict.Add(keyValue, new AssingmentDetailsByStatus());
                    dict[keyValue].assignmentName = data.assignment;
                    dict[keyValue].assignmentStatus = data.status;
                    dict[keyValue].noOfStudent =  1;
                    dict[keyValue].totalCompletionDays = data.days;
                }
            }
            foreach (AssingmentDetailsByStatus assignmentByStatus in dict.Values)
            {
                assingmentDetails.Add(assignmentByStatus);
            }
            return assingmentDetails;
        }


        public List<AssignmentByNameAndCount> getStudentDetailsByNameAndCount(List<AssignmentData> list)
        {
            Dictionary<int, AssignmentByNameAndCount> key = new Dictionary<int, AssignmentByNameAndCount>();
            List<AssignmentByNameAndCount> assignments = new List<AssignmentByNameAndCount>();
            foreach (AssignmentData data in list)
            {
                if (key.ContainsKey(data.id))
                {
                    key[data.id].assignmentCount++;
                    key[data.id].completionDays += data.days;
                }
                else
                {
                    key.Add(data.id, new AssignmentByNameAndCount());
                    key[data.id].studentId = data.id;
                    key[data.id].studentName = data.name;
                    key[data.id].assignmentCount = 1;
                    key[data.id].completionDays = data.days;
                }
            }

            foreach(AssignmentByNameAndCount assignment in key.Values)
            {
                assignments.Add(assignment);
            }
            return assignments;
        }
    }
}

