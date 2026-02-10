using System;

public class InventoryMenu
{
    public void Show(Player player)
    {
        Console.WriteLine("\n=== Inventory ===");
        Console.WriteLine($"HP: {player.HP}/{player.MaxHP}");
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
        string input = Console.ReadLine() ?? "0";

        if (input == "0") return;

        int index = int.Parse(input) - 1;

        if (index >= 0 && index < player.Inventory.Items.Count)
        {
            Item item = player.Inventory.Items[index];

            if (item.IsConsumable)
            {
                if (item.Name == "Strength Potion")
                {
                    player.BonusAttack += 5;
                    Console.WriteLine("You feel stronger! Attack increased by 5 for this battle.");
                    player.ActiveBuffs.Add("Strength");
                    player.Inventory.Items.RemoveAt(index);
                    return;
                }

                // Maksym - Healing potion
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
