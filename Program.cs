using System;
using System.Collections.Generic;

namespace java2kkkk
{
    
    class Program
    {
        static void Main(string[] args)
        {
            List<addTask> tasks = new List<addTask>();
            
            AddTask(tasks, "Teste 1");
        }
    
        static void AddTask(List<addTask> tasks, string taskName)
        {
            int taskId = tasks.Count + 1; // Gera um novo ID para a tarefa
            addTask newTask = new addTask(taskId, "tadasokgtokgskdo");
            addTask taskTwo = new addTask(taskId, "tasdasd");
            tasks.Add(newTask);
            tasks.Add(taskTwo);
            foreach (var task in tasks)
            {
                Console.WriteLine("Tarefa adicionada: ID - {0}, Nome - {1}", task.TaskId, task.TaskName);
            }
        }

        static void DeleteTask(List<addTask> tasks, int taskId)
        {
            deleteTask deleteTask = new deleteTask();
            deleteTask.DeleteTask(taskId, tasks);
        }
    }
}
