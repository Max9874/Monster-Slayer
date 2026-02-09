using System;

public class InventoryManager
{
    public void AddItem(Player player, Item item)
    {
        player.Inventory.Add(item);
        Console.WriteLine($"You obtained: {item.Name}");
    }

    public void RemoveItem(Player player, Item item)
    {
        player.Inventory.Remove(item);
        Console.WriteLine($"{item.Name} was removed from your inventory.");
    }

    public bool HasItem(Player player, string itemName)
    {
        return player.Inventory.Items.Any(i => i.Name == itemName);
    }

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

    public void ShowInventory(Player player)
    {
        player.Inventory.Show();
    }
}