using System;

public class Enemy // Enemy class represents an enemy character in the game
{
    public string Name { get; set; }
    public int HP { get; set; }
    public int Attack { get; set; }
    public string Attribute { get; set; } = ""; // Maksym - adds special attributes, that adds various effects 
    public int BonusDamage { get; set; } = 0; // Maksym - bonus damage from attributes

    // Maksym - more attributes can be added in EnemyFactory.cs,
    // and then used in BattleSystem.cs


    public Enemy(string name, int hp, int attack) // Constructor to initialize enemy properties
    {
        Name = name;
        HP = hp;
        Attack = attack;
    }

    public int GetDamage() // Method to calculate damage dealt by the enemy
    {
        Random rnd = new Random();
        int baseDamage = Attack + BonusDamage;
        return rnd.Next(baseDamage - 2, baseDamage + 3);
    }

    public string ColoredName
    {
        get
        {
            if (Attribute == "Rage")
                return "\u001b[31m" + Name + "\u001b[0m"; // red 

            return Name;
        }
    }

}