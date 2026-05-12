public class ToDoTask
{
    public string Title { get; set; } = "";
    public int Id { get; set; }
    public bool IsDone { get; set; }
    public DateTime CreatedAt { get; set; }
    public DateTime? DoneAt { get; set; }
    public DateTime? WarningDate { get; set; }

    public ToDoTask(string title)
    {
        Title = title;
        IsDone = false;
        CreatedAt = DateTime.Now;
    }
    public ToDoTask(string title, DateTime Warning)
    {
        Title = title;
        IsDone = false;
        CreatedAt = DateTime.Now;
        WarningDate = Warning;
    }
}