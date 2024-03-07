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
        public DateTime ReminderDate { get; set; }
        public addTask(string taskTittle, DateTime reminderDate) 
        {
            TaskTittle = taskTittle;
            ReminderDate = reminderDate;
        }

        public override string ToString()
        {
            return $"{TaskTittle} - {ReminderDate}";
        }

        public void AddTask() 
        {
            try 
            {
                if (string.IsNullOrEmpty(TaskTittle) && TaskTittle.Length !> 50)
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