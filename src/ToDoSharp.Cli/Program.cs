Console.Clear();
Console.WriteLine("Bonjour et bienvenue dans ToDoSharp !");
string? input;

while(true){
Console.Write("Entrez votre nom : ");
input = Console.ReadLine();
if (string.IsNullOrWhiteSpace(input))
{
    Console.WriteLine("Aucun nom saisi.");
}
else
{
    Console.Clear();
    Console.WriteLine($"Bonjour {input}");
    break;
}
}
bool running = true;

while (running){
    Console.Clear();
    Console.WriteLine($"1. Voir les listes de {input}");
    Console.WriteLine("2. Créer une nouvelle listes");
    Console.WriteLine("3. Quitter le programme");

        Console.Write("Votre choix : ");
{
    string? choice = Console.ReadLine();
    if (string.IsNullOrWhiteSpace(input))
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
            Console.WriteLine($"Au revoir {input} !");
            running = false;
            break;

            default:
                Console.WriteLine("Choix inconnu.");
                break;
        
        }
}}}

