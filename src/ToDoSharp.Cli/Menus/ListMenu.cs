namespace ToDoSharp.Cli.Menus;

using ToDoSharp.Cli.Display;
using ToDoSharp.Cli.Models;

public class ListMenu
{
    private readonly ToDoList _list;
    private readonly TaskDisplay _taskDisplay = new TaskDisplay();

    public ListMenu(ToDoList list)
    {
        _list = list;
    }
    public void Run()
    {
        bool running = true;
        while (running)
        {
            Console.Clear();
            _taskDisplay.ShowTasks(_list);
            Console.WriteLine();
            Console.WriteLine();
            Console.WriteLine();
            Console.WriteLine("1. Ajouter une tâche");
            Console.WriteLine("2. Marquer une tâche");
            Console.WriteLine("3. Modifier une tâche");
            Console.WriteLine("4. Retour au menu des listes");

            Console.Write("Votre choix : ");
            {
                string? choice = Console.ReadLine();
                if (string.IsNullOrWhiteSpace(choice))
                {
                    Console.WriteLine("Aucun choix saisie");
                }
                else
                {
                    switch (choice)
                    {
                        case "1":
                            Console.Clear();
                            _taskDisplay.ShowTasks(_list);
                            Console.WriteLine();
                            Console.WriteLine();
                            Console.WriteLine();
                            Console.Write("Titre de la tâche : ");
                            string title = Console.ReadLine() ?? "";

                            if (string.IsNullOrWhiteSpace(title))
                            {
                                Console.WriteLine("Titre invalide.");
                                Console.WriteLine();
                                Console.WriteLine("Presse Enter");
                                Console.ReadLine();
                                break;
                            }

                            _list.Tasks.Add(new ToDoTask(title.Trim()));

                            Console.WriteLine("Tâche ajoutée.");
                            Console.WriteLine();
                            Console.WriteLine("Presse Enter ");
                            Console.ReadLine();
                            break;

                        case "2":
                            break;

                        case "3":
                            break;

                        case "4":
                            running = false;
                            break;

                        default:
                            Console.WriteLine("Choix inconnu.");
                            break;

                    }
                }
            }
        }


    }

}