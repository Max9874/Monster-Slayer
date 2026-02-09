using System;

public class MainMenu
{

    private QuestManager _questManager = new QuestManager();

    private QuestMenu _questMenu;

    public MainMenu()
    {
        _questMenu = new QuestMenu(_questManager);
    }

    public void Show(Player player)
    {
        LocationManager loc = new LocationManager();

        while (true)
        {

            Console.WriteLine("\n=== Main menu ===");
            Console.WriteLine("1 — Inventory");
            Console.WriteLine("2 — Quests");
            Console.WriteLine("3 — Go to phountain");
            Console.WriteLine("4 — To the shop");
            Console.WriteLine("5 — To the guild");
            Console.WriteLine("6 — Dungeon");
            Console.WriteLine("7 — Home");
            Console.WriteLine("0 — Exit");

            string choice = Console.ReadLine();

            switch (choice)
            {
                case "1": new InventoryMenu().Show(player); break;
                case "2": _questMenu.Show(); break;
                case "3": loc.GoToFountain(); break;
                case "4": loc.GoToShop(player); break;
                case "5": loc.GoToGuild(_questManager); break;
                case "6": loc.GoToDungeon(player, _questManager); break;
                case "7": loc.GoToHome(player); break;
                case "0": return;
            }
            // player.Inventory.Show()
            // InventoryMenu().Show(player)
        }
    }
}