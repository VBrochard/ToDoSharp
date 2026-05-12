namespace ToDoSharp.Cli.Menus;
using ToDoSharp.Cli.Display;
using ToDoSharp.Cli.Models;
using ToDoSharp.Cli.Services;
using System.ComponentModel;
using System.Runtime.CompilerServices;

public class MainMenu
{
    private readonly ListManager _listManager;
    private readonly ListDisplay _listDisplay = new ListDisplay();

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
            var lists = _listManager.GetLists();
            _listDisplay.ShowLists(lists);
            Console.WriteLine();
            Console.WriteLine();
            Console.WriteLine();
            Console.WriteLine("1. Créer une nouvelle liste");
            Console.WriteLine("2. Ouvrir une liste");
            Console.WriteLine("3. Quitter le programme");

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
                            Console.WriteLine("Créateur de listes : ");
                            Console.WriteLine();
                            _listDisplay.ShowLists(lists);
                            Console.WriteLine();
                            Console.WriteLine();
                            string? title;
                            Console.Write("Titre : ");
                            title = Console.ReadLine();
                            if (string.IsNullOrWhiteSpace(title))
                            {
                                Console.Write("Nom incorrect");
                                break;
                            }
                            if (_listManager.CreateList(title))
                            {
                                Console.WriteLine($"Liste {title} crée ");
                                Console.WriteLine("Presse Enter pour retourner au menu");
                                Console.ReadLine();
                            }
                            else
                            {
                                Console.WriteLine("Nom incorrect ou déjà existant");
                                Console.WriteLine("Presse Enter pour retourner au menu");
                                Console.ReadLine();
                            }
                            break;

                        case "2":
                        {
                            Console.Clear();

                            lists = _listManager.GetLists();

                            if (lists.Count == 0)
                            {
                                Console.WriteLine("Aucune liste à ouvrir.");
                                Console.WriteLine("Appuie sur Entrée pour retourner au menu");
                                Console.ReadLine();
                                break;
                            }

                            Console.WriteLine("Choisis une liste :");
                            Console.WriteLine();

                            _listDisplay.ShowLists(lists);

                            Console.WriteLine();
                            Console.Write("Numéro de la liste : ");
                            string input = Console.ReadLine() ?? "";

                            if (!int.TryParse(input, out int selectedNumber))
                            {
                                Console.WriteLine("Numéro invalide.");
                                Console.WriteLine("Appuie sur Entrée pour retourner au menu");
                                Console.ReadLine();
                                break;
                            }

                            int index = selectedNumber - 1;

                            if (index < 0 || index >= lists.Count)
                            {
                                Console.WriteLine("Liste introuvable.");
                                Console.WriteLine("Appuie sur Entrée pour retourner au menu");
                                Console.ReadLine();
                                break;
                            }

                            ToDoList selectedList = lists[index];

                            ListMenu listMenu = new ListMenu(selectedList);
                            listMenu.Run();

                            break;
                        }

                        case "3":
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