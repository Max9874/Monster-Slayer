using System;

public class Enemy // Enemy class represents an enemy character in the game
{
    public string Name { get; set; }
    public int HP { get; set; }
    public int Attack { get; set; }

    public Enemy(string name, int hp, int attack) // Constructor to initialize enemy properties
    {
        Name = name;
        HP = hp;
        Attack = attack;
    }

    public int GetDamage() // Method to calculate damage dealt by the enemy
    {
        Random rnd = new Random();
        return rnd.Next(Attack - 2, Attack + 3);
    }
}