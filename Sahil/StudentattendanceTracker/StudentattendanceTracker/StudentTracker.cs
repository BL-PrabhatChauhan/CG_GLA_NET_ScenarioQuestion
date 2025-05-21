using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StudentattendanceTracker
{
    public class StudentTracker
    {
        public Dictionary<String,int> attendancePerDay(List<List<string>> attendance)
        {
            Dictionary<String,int> students = new Dictionary<String,int>();

            foreach (var studentInThatDay in attendance)
            {
                foreach (var student in studentInThatDay) {
                    if (students.ContainsKey(student))
                    {
                        students[student]++;
                    }
                    else
                    {
                        students[student] = 1;
                    }
                }
            }
            return students;
        }
    }
}
