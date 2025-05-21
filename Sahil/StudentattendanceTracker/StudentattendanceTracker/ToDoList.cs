using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StudentattendanceTracker
{
    public class ToDoList
    {
        private List<String> tasks=new List<String>();
        public void AddTask(string task)
        {
            if (!tasks.Contains(task))
            {
                tasks.Add(task);
                Console.WriteLine(task+" added successfully");
            }
            else
            {
                Console.WriteLine(task + " is not present");
            }
                
        }

        public void RemoveTask(string task)
        {
            if (tasks.Contains(task))
            {
                tasks.Remove(task);
                Console.WriteLine(task+" removed successfully");
            }
            else
            {
                Console.WriteLine(task+" is not present");
            }
        }

        public void displayTask()
        {
            var taskinSortedOrder=tasks.OrderBy(x=>x).ToList();
            foreach (var task in taskinSortedOrder)
            {
                Console.WriteLine($"-{task}");
            }
    }
}
