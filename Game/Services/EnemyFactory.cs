using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

public static class EnemyFactory // Maksym - All types of enemies
{
    private static Random rnd = new Random();

    public static Enemy GetRandomEnemy() // Maksym - Randomly generates an enemy with possible attributes
    {
        int roll = rnd.Next(0, 3);

        Enemy enemy = roll switch // Maksym - Enemies list
        {
            0 => new Enemy("Goblin", 10, 5),
            1 => new Enemy("Skeleton", 20, 7),
            2 => new Enemy("Wolf", 15, 6),
            _ => new Enemy("HopGoblin", 5, 5)
        };

        // Chance to add "Rage" attribute to the enemy 
        int rageChance = rnd.Next(0, 100);
        if (rageChance < 10)
        {
            enemy.Attribute = "Rage";
            enemy.BonusDamage = 3; // +n damage
        }

        return enemy;
    }

    /* Old method version without attributes
      
     
    public static Enemy GetRandomEnemy()
    {
        int roll = rnd.Next(0, 3);

        return roll switch
        {
            0 => new Enemy("Goblin", 10, 5),
            1 => new Enemy("Skeleton", 20, 7),
            2 => new Enemy("Wolf", 15, 6),
            _ => new Enemy("HopGoblin", 5, 5)
        };
    }*/
}
