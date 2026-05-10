namespace ToDoSharp.Cli.Menus;

public class MainMenu
{
    public void Run()
    {
        Console.Clear();
Console.WriteLine("Bonjour et bienvenue dans ToDoSharp !");
bool running = true;

while (running){
    Console.Clear();
    Console.WriteLine($"1. Voir tes listes");
    Console.WriteLine("2. Créer une nouvelle listes");
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
            Console.WriteLine("Vous avez choisie 1");
            break;

            case "2":
            Console.WriteLine("Vous avez choisie 2");
            break;

            case "3":   
            Console.Clear();
            Console.WriteLine($"Au revoir !");
            running = false;
            break;

            default:
                Console.WriteLine("Choix inconnu.");
                break;
        
        }
}}}


    }
}