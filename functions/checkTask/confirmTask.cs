using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using java2kkkk;

namespace cs_ToDoList.functions.checkTask
{
    public class confirmTask
    {
        public void ConfirmTask() 
        {
            if (addTask.Tasks.Count == 0) 
            {
                Console.WriteLine("No tasks to check.\n");
            }
            else 
            {
                Console.Write("Enter the task ID : ");
                if (int.TryParse(Console.ReadLine(), out int index) && index > 0 && index <= addTask.Tasks.Count) 
                {
                    addTask.Tasks.RemoveAt(index - 1);
                    Console.Write($"--- Task {addTask.Tasks[index]} checked ");
                    Console.ForegroundColor = ConsoleColor.DarkGreen;
                    Console.Write("sucessfully!");
                    Console.ResetColor();
                    Console.WriteLine(" ---\n");
                }
                else 
                { 
                    Console.ForegroundColor = ConsoleColor.DarkRed;
                    Console.Write("Invalid ");
                    Console.ResetColor();
                    Console.WriteLine("task ID.");
                }
            }
        }
    }
}