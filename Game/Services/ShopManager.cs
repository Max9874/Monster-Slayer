public class ShopManager // Maksym - Shop manager allows the player to buy weapons and items
{
    public List<Weapon> Weapons { get; } = new List<Weapon>()
    {
        new Weapon("Wooden Sword", 5, 10),
        new Weapon("Iron Sword", 10, 25),
        new Weapon("Hero's Blade", 20, 50)
    };

    public List<Item> Items = new List<Item>()
    {
        ItemFactory.RegenerationPotion(),
        ItemFactory.StrenghtPotion()
    };


    public void OpenShop(Player player)
    {
        Console.WriteLine("\n=== Shop ===");


        Console.WriteLine("\n--- Weapons ---");
        for (int i = 0; i < Weapons.Count; i++)
        {
            var w = Weapons[i];
            Console.WriteLine($"{i + 1}. {w.Name} — Damage: {w.Damage} — Price: {w.Price} coins");
        }


        Console.WriteLine("\n--- Items ---");
        for (int i = 0; i < Items.Count; i++)
        {
            var item = Items[i];
            Console.WriteLine($"{Weapons.Count + i + 1}. {item.Name} — {item.Description} — Price: 15 coins");
        }


        Console.WriteLine("0. Exit shop");
        Console.Write("Choose an item: ");

        string input = Console.ReadLine() ?? "0"; // Setting default to "0" to handle null input.
        if (input == "0") return;

        if (!int.TryParse(input, out int indexx)) // Maksym - Handles incorrect input. 
        {
            Console.WriteLine("\nIncorrect input\n");
            return;
        }


        int index = int.Parse(input) - 1;


        if (index >= 0 && index < Weapons.Count)
        {
            var weapon_product = Weapons[index];
            if (player.Coins >= weapon_product.Price)
            {
                player.Coins -= weapon_product.Price;
                player.EquippedWeapon = weapon_product;
                Console.WriteLine($"You bought {weapon_product.Name}!");
            }
            else Console.WriteLine("Not enough coins.");
            return;
        }

        int itemIndex = index - Weapons.Count;
        if (itemIndex >= 0 && itemIndex < Items.Count)
        {
            if (player.Coins >= 15)
            {
                player.Coins -= 15;
                player.Inventory.Add(Items[itemIndex]);
                Console.WriteLine($"You bought {Items[itemIndex].Name}!");
            }
            else Console.WriteLine("Not enough coins.");
        }

    }
}