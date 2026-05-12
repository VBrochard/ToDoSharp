using ToDoSharp.Cli.Models;

namespace ToDoSharp.Cli.Services;

public class ListManager
{
    private readonly List<ToDoList> _lists = new();

    public bool CreateList(string title)

    {
        if (string.IsNullOrWhiteSpace(title))
        {
            return false;
        }

        title = title.Trim();

        foreach (ToDoList list in _lists)
        {
            if (string.Equals(list.Title, title, StringComparison.OrdinalIgnoreCase))
            {
                return false;
            }
        }
        ToDoList l = new ToDoList(title);
        _lists.Add(l);
        return true;
    }
    public bool CreateList(string title, DateTime warningDate)

    {
        if (string.IsNullOrWhiteSpace(title))
        {
            return false;
        }

        title = title.Trim();

        foreach (ToDoList list in _lists)
        {
            if (string.Equals(list.Title, title, StringComparison.OrdinalIgnoreCase))
            {
                return false;
            }
        }
        ToDoList l = new ToDoList(title, warningDate);
        _lists.Add(l);
        return true;
    }
    public List<ToDoList> GetLists()
    {
        return new List<ToDoList>(_lists);
    }
}