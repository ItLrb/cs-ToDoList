using System;
using System.Collections.Generic;
using cs_ToDoList.functions.reminder;

namespace java2kkkk
{
    class Program
    {
        static Timer reminderTimer = new Timer(ReminderTask.CheckReminders, addTask.Tasks, TimeSpan.Zero, TimeSpan.FromMinutes(1));
        static void Main(string[] args)
        {
            while (true) 
            {
                Console.WriteLine("\n--- To-Do-List ---");
                Console.WriteLine("1. Add Task");
                Console.WriteLine("2. Verify your tasks");
                Console.WriteLine("3. Delete Task");
                Console.WriteLine("4. Exit");
                
                Console.Write("Choose an option : ");
                int choosedOption = Convert.ToInt32(Console.ReadLine());


                switch (choosedOption) 
                {
                    case 1:
                        Console.Write("Write your task tittle : ");
                        string? taskName = Console.ReadLine();
                        Console.Write("Enter the reminder date (yyyy-mm-dd HH:mm): ");
                        if (DateTime.TryParse(Console.ReadLine(), out DateTime reminderDate)) 
                        {
                            if (taskName != null) 
                            {
                                addTask addTask = new addTask(taskName, reminderDate);
                                addTask.AddTask();
                            }
                        }
                        break;
                    case 2:
                        Console.WriteLine("\n--- Your Tasks ---");
                        if (addTask.Tasks.Count == 0)
                        {
                            Console.WriteLine("No tasks.\n------------------\n");
                        }
                        else
                        {
                            for (int i = 0; i < addTask.Tasks.Count; i++)
                            {
                                Console.WriteLine($"{i + 1}. {addTask.Tasks[i]}\n");
                            }
                        }
                        break;
                    case 3:
                        deleteTask deleteTask = new deleteTask();
                        deleteTask.DeleteTask();
                        break;
                    case 4:
                        Console.WriteLine("Exiting...");
                        reminderTimer.Dispose();
                        Environment.Exit(0);
                        break;
                    default:
                        Console.WriteLine("Invalid option, try again.");
                        break;
                }
            }
        }
    }
}
