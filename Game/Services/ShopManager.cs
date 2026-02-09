using System;

public class ShopManager // Maksym - Shop manager allows the player to buy weapons and items
{
    public List<Weapon> Weapons { get; } = new List<Weapon>()
    {
        new Weapon("Wooden Sword", 5, 10),
        new Weapon("Iron Sword", 10, 25),
        new Weapon("Hero's Blade", 20, 50)
    };

    /*public List<Item> Items { get; } = new List<Item>()
    {
        new Item("Health Potion", "Restores 50 HP", true, 15),
    };*/

    public void OpenShop(Player player)
    {
        Console.WriteLine("\n=== Weapon Shop ===");

        for (int i = 0; i < Weapons.Count; i++)
        {
            var w = Weapons[i];
            Console.WriteLine($"{i + 1}. {w.Name} — Damage: {w.Damage} — Price: {w.Price} coins");
        }

        Console.WriteLine("0. Exit shop");
        Console.Write("Choose an item: ");

        string input = Console.ReadLine();
        if (input == "0") return;

        int index = int.Parse(input) - 1;

        if (index < 0 || index >= Weapons.Count)
        {
            Console.WriteLine("Invalid choice.");
            return;
        }

        var weapon = Weapons[index];

        if (player.Coins >= weapon.Price)
        {
            player.Coins -= weapon.Price;
            player.EquippedWeapon = weapon;
            Console.WriteLine($"You bought {weapon.Name}!");
            player.Inventory.Add(weapon);

        }
        else
        {
            Console.WriteLine("Not enough coins.");
        }
    }
}