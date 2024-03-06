using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace java2kkkk
{
    public class deleteTask
    {
        public void DeleteTask(int taskId, List<addTask> tasks)
        {
            addTask? taskToDelete = tasks.FirstOrDefault(task => task.TaskId == taskId);
            if (taskToDelete != null)
            {
                tasks.Remove(taskToDelete);
                Console.WriteLine("Task deleted");
            }
            else
                Console.WriteLine("Task not found");
        }
    }
}