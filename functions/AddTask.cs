using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace java2kkkk
{
    public class addTask
    {
        public int TaskId { get; set; }
        public string TaskName { get; set; } = string.Empty;
        public DateTime TaskDate { get; set; } = DateTime.Now;

        public addTask(int taskId, string taskName) 
        {
            TaskId = taskId;
            TaskName = taskName;
        }
        /* public void AddTask() 
        {
            try 
            {
                if (string.IsNullOrWhiteSpace(TaskName)) 
                { 
                    throw new Exception("Task name cannot be empty"); 
                }

                int taskId = Tasks.Count + 1;
                addTask taskAddItem = new addTask(taskId, TaskName);
                Tasks.Add(taskAddItem);

                Console.WriteLine("ID: {2} \nTask \"{0}\" added \nDate: {1} \n", TaskName, TaskDate);
            } 
            catch (Exception e) 
            {
                Console.WriteLine(e.Message);
            }
        } */
    }
}