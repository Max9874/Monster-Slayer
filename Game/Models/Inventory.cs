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

    public void Show()
    {
        Console.WriteLine("\n=== Inventory ===");
        Console.WriteLine("=== === === === ===");

        if (Items.Count == 0)
        {
            Console.WriteLine("Your inventory is empty.");
            return;
        }

        for (int i = 0; i < Items.Count; i++)
        {
            Console.WriteLine($"{i + 1}. {Items[i].Name} — {Items[i].Description}");
        }
    }
}