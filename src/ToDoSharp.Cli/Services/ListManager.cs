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
    public bool CreateList(string title, DateTime Warning)
    
    {
        foreach (ToDoList list in _lists)
        {
        if (list.Title == title)
        {
            return false;
        }
        }
        if (string.IsNullOrWhiteSpace(title))
        {
            return false;
        }
            ToDoList l = new ToDoList(title, Warning);
            _lists.Add(l);
            return true;
    }
    public List<ToDoList> GetLists()
{
    return new List<ToDoList>(_lists);
}
}