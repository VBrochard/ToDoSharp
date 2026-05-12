namespace ToDoSharp.Cli.Menus;

using System.ComponentModel;
using System.Runtime.CompilerServices;
using ToDoSharp.Cli.Services;

public class MainMenu
{
    private readonly ListManager _listManager;

    public MainMenu(ListManager listManager)
    {
        _listManager = listManager;
    }
    public void Run()
    {
        Console.Clear();
        Console.WriteLine("Bonjour et bienvenue dans ToDoSharp !");
        bool running = true;

        while (running)
        {
            Console.Clear();
            Console.WriteLine("1. Voir tes listes");
            Console.WriteLine("2. Créer une nouvelle listes");
            Console.WriteLine("3. Ouvrir une liste");
            Console.WriteLine("4. Quitter le programme");

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
                            Console.WriteLine("Vos listes : ");
                            _listManager.GetLists();
                            Console.WriteLine("Presse Enter pour retourner au menu");
                            Console.ReadLine();
                            break;

                        case "2":
                            Console.Clear();
                            Console.WriteLine("Créateur de listes");
                            string? title;
                            Console.Write("Titre :");
                            title = Console.ReadLine();
                            if (string.IsNullOrWhiteSpace(title))
                            {
                                Console.Write("Nom incorrect");
                                break;
                            }
                            if (_listManager.CreateList(title))
                            {
                                Console.WriteLine($"Liste {title} crée ");
                            }
                            else
                            {
                                Console.WriteLine("Erreur création liste");
                            }
                            break;

                        case "3":
                        break;

                        case "4":
                            Console.Clear();
                            Console.WriteLine("Au revoir !");
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