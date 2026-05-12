namespace ToDoSharp.Cli.Models;

public class ToDoList
{
    public string Title { get; set; } = "";
    public int Id { get; set; }
    public DateTime CreatedAt { get; set; }
    public DateTime? WarningDate { get; set; }
    public List<Task> Todo { get; set; } = new();

    public ToDoList(string title)
    {
        Title = title;
        CreatedAt = DateTime.Now;
    }
    public ToDoList(string title, DateTime warning)
    {
        Title = title;
        CreatedAt = DateTime.Now;
        WarningDate = warning;
    }
}