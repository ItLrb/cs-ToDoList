using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using java2kkkk;

namespace cs_ToDoList.functions.reminder
{
    public class ReminderTask
    {
        static public void CheckReminders(object? state) 
        {
            if (state == null) { Console.WriteLine("Error"); return; }

            List<addTask> Tasks = (List<addTask>)state;
            foreach (addTask Task in Tasks) 
            {
                if (Task.ReminderDate <= DateTime.Now) 
                {
                    Console.WriteLine("Your reminder: " + Task.TaskTittle + " is due!");
                    Console.Beep();
                }
            }
        }
    }
}