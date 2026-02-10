using System;

public class Weapon : Item // Class representing weapons 
{
    public int Damage { get; }
    public int Price { get; }

    public Weapon(string name, int damage, int price)
        : base(name, $"A weapon that deals {damage} damage.")
    {
        Damage = damage;
        Price = price;
    }
}