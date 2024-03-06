using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace java2kkkk
{
    public class deleteTask
    {
        public void DeleteTask() 
        {
            if (addTask.Tasks.Count == 0) 
            {
                Console.WriteLine("No tasks to remove.");
            }
            else 
            {
                Console.Write("Enter the task ID : ");
                if (int.TryParse(Console.ReadLine(), out int index) && index > 0 && index <= addTask.Tasks.Count) 
                {
                    addTask.Tasks.RemoveAt(index - 1);
                    Console.WriteLine("Task removed sucessfully!");
                }
                else { Console.WriteLine("Invalid task number."); }
            }
        }
    }
}