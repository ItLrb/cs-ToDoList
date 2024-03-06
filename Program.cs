using System;
using System.Collections.Generic;

namespace java2kkkk
{
    class Program
    {
        static void Main(string[] args)
        {
            while (true) 
            {
                Console.Write("--- ToDoList --- \n1. Add Task \n2. Delete Task \n3. Verify your tasks \n4. Exit \n----------------\nChoose an option : ");
                int choosedOption = Convert.ToInt32(Console.ReadLine());

                switch (choosedOption) 
                {
                    case 1:
                        Console.Write("Write your task tittle : ");
                        string? taskName = Console.ReadLine();
                        if (taskName != null) 
                        {
                            addTask addTask = new addTask(taskName);
                            addTask.AddTask();
                        }
                        break;
                    case 2:
                        deleteTask deleteTask = new deleteTask();
                        deleteTask.DeleteTask();
                        break;
                    case 3:
                        Console.WriteLine("\n--- Your Tasks ---");
                        if (addTask.Tasks.Count == 0)
                        {
                            Console.WriteLine("No tasks.");
                        }
                        else
                        {
                            for (int i = 0; i < addTask.Tasks.Count; i++)
                            {
                                Console.WriteLine($"{i + 1}. {addTask.Tasks[i]}");
                            }
                        }
                        break;
                    case 4:
                        Console.WriteLine("Exiting...");
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
