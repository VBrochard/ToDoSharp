using ToDoSharp.Cli.Models;

namespace ToDoSharp.Cli.Display;

public class ListDisplay
{
    public void ShowLists(List<ToDoList> lists)
    {
        Console.WriteLine("=== Tes listes ===");
        Console.WriteLine();

        if (lists.Count == 0)
        {
            Console.WriteLine("Aucune liste créée.");
            return;
        }

        for (int i = 0; i < lists.Count; i++)
        {
            ToDoList list = lists[i];

            Console.WriteLine($"{i + 1}. {list.Title}");
        }
    }
}