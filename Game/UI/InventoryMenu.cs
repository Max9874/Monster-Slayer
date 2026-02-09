using System;

public class InventoryMenu
{
    public void Show(Player player)
    {
        Console.WriteLine("\n=== Inventory ===");
        Console.WriteLine($"Coins: {player.Coins}");

        if (player.Inventory.Items.Count == 0)
        {
            Console.WriteLine("Your inventory is empty.");
            return;
        }

        for (int i = 0; i < player.Inventory.Items.Count; i++)
        {
            Console.WriteLine($"{i + 1}. {player.Inventory.Items[i].Name} — {player.Inventory.Items[i].Description}");
        }

        Console.WriteLine("Select an item to use or press 0 to exit:");
        string input = Console.ReadLine();

        if (input == "0") return;

        int index = int.Parse(input) - 1;

        if (index >= 0 && index < player.Inventory.Items.Count)
        {
            Item item = player.Inventory.Items[index];

            if (item.IsConsumable)
            {
                player.HP = Math.Min(player.MaxHP, player.HP + item.HealAmount);
                Console.WriteLine($"You used {item.Name} and restored {item.HealAmount} HP!");
                player.Inventory.Items.RemoveAt(index);
            }
            else
            {
                Console.WriteLine("This item cannot be used.");
            }
        }
    }
}
