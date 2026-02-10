using System;


public class Player // Maksym - Represents the player character in the game
{
    public int MaxHP { get; set; } = 100;
    public int HP { get; set; } = 100;
    public int Attack { get; set; } = 1;
    public int Coins { get; set; } = 10;
    public int BonusAttack { get; set; } = 0;
    public List<string> ActiveBuffs { get; set; } = new List<string>(); // Maksym - List of active buffs


    public Inventory Inventory { get; set; } = new Inventory();
    public Weapon EquippedWeapon { get; set; } = new Weapon("Fists", 0, 0); // Default weapon with no damage

    
    public int GetDamage() // Maksym - Method to calculate damage dealt by the player
    {
        Random rnd = new Random();
        int baseDamage = Attack + BonusAttack;
        int weaponDamage = EquippedWeapon?.Damage ?? 0;

        return rnd.Next(baseDamage, baseDamage + weaponDamage + 1);
    }

}