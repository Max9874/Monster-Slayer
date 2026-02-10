using System;

public class Item // Maksym - Represents base class for items 
{
    public string Name { get; }
    public string Description { get; }
    public bool IsConsumable { get; }
    public int HealAmount { get; }

    public Item(string name, string description, bool isConsumable = false, int healAmount = 0)
    {
        Name = name;
        Description = description;
        IsConsumable = isConsumable;
        HealAmount = healAmount;
    }
}