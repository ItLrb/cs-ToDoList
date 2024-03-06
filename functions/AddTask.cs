using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace java2kkkk
{
    public class addTask
    {
        public string TaskTittle { get; set; } = "No Name";
        public static List<string> Tasks = new List<string> { "No Tasks" };
        public addTask(string taskTittle) 
        {
            TaskTittle = taskTittle;
        }
        public void AddTask() 
        {
            try 
            {
                if (TaskTittle.Length != 0 || TaskTittle.Length !> 50)
                {
                    Tasks.Add(TaskTittle);
                    Console.WriteLine("Task added sucessufully!");
                }
                else { Console.WriteLine("Task not added, something is wrong."); }
            }
            catch (Exception e) { Console.WriteLine(e.Message); }
        }
    }
}