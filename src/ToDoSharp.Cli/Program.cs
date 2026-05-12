using ToDoSharp.Cli.Menus;
using ToDoSharp.Cli.Services;

ListManager listManager = new ListManager();
MainMenu menu = new MainMenu(listManager);
menu.Run();