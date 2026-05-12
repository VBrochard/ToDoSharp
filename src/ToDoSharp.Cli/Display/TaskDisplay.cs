using ToDoSharp.Cli.Models;

namespace ToDoSharp.Cli.Display;

public class TaskDisplay
{
    public void ShowTasks(ToDoList list)
    {
        Console.WriteLine($"=== {list.Title} ===");
        Console.WriteLine();

        if (list.Tasks.Count == 0)
        {
            Console.WriteLine("Aucune tâche dans cette liste.");
            return;
        }

        for (int i = 0; i < list.Tasks.Count; i++)
        {
            ToDoTask task = list.Tasks[i];

            string status = task.IsDone ? "[x]" : "[ ]";

            Console.WriteLine($"{i + 1}. {status} {task.Title}");
        }
    }
}