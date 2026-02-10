using System;

public class Inventory // Maksym - inventory
{
    public List<Item> Items { get; } = new List<Item>();

    public void Add(Item item)
    {
        Items.Add(item);
        Console.WriteLine($"You received: {item.Name}");
    }

    public void Remove(Item item)
    {
        Items.Remove(item);
    }

    // deleted method ShowInvenroty due to another method in UI InventoryMenu. 
    // In case anything goes wrong copy it from branch game-version-1 from GitHub. 
}