using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace java2kkkk
{
    public class addTask
    {
        public string TaskTittle { get; set; } = "No Name";
        public static List<string> Tasks = new List<string>();
        public addTask(string taskTittle) 
        {
            TaskTittle = taskTittle;
        }

        public void AddTask() 
        {
            try 
            {
                if (TaskTittle.Length > 0 || TaskTittle.Length <= 50)
                {
                    Tasks.Add(TaskTittle);
                    Console.Write("--- Task added ");
                    Console.ForegroundColor = ConsoleColor.DarkGreen;
                    Console.Write("sucessfully!");
                    Console.ResetColor();
                    Console.WriteLine(" ---\n");
                }
                else 
                { 
                    Console.Write("Task ");
                    Console.ForegroundColor = ConsoleColor.DarkRed;
                    Console.Write("not added");
                    Console.ResetColor();
                    Console.WriteLine(", something is wrong.\n");
                }
            }
            catch (Exception e) { Console.WriteLine(e.Message); }
        }
    }
}