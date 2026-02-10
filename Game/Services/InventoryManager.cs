using System;


// Somehow none of the methods in this class are used, I don't know where they will be needed and IF they will be needed.
public class InventoryManager // Maksym - Manages player's inventory, including adding, removing, and using items.
{
    // Adds an item to the player's inventory and displays a message.
    public void AddItem(Player player, Item item)  
    {
        player.Inventory.Add(item);
        Console.WriteLine($"You obtained: {item.Name}");
    }

    // Removes an item from the player's inventory and displays a message.
    public void RemoveItem(Player player, Item item)
    {
        player.Inventory.Remove(item);
        Console.WriteLine($"{item.Name} was removed from your inventory.");
    }

    // Checks if the player has a specific item in their inventory.
    public bool HasItem(Player player, string itemName)
    {
        return player.Inventory.Items.Any(i => i.Name == itemName);
    }

    // Uses a consumable item from the player's inventory, restores HP, and removes the item.
    public void UseItem(Player player, int index)
    {
        if (index < 0 || index >= player.Inventory.Items.Count)
        {
            Console.WriteLine("Invalid item index.");
            return;
        }

        Item item = player.Inventory.Items[index];

        if (!item.IsConsumable)
        {
            Console.WriteLine("This item cannot be used.");
            return;
        }

        player.HP = Math.Min(player.MaxHP, player.HP + item.HealAmount);
        Console.WriteLine($"You used {item.Name} and restored {item.HealAmount} HP!");

        player.Inventory.Remove(item);
    }

    
}