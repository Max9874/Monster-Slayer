using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

public static class EnemyFactory
{
    private static Random rnd = new Random();

    public static Enemy GetRandomEnemy()
    {
        int roll = rnd.Next(0, 3);

        return roll switch
        {
            0 => new Enemy("HopGoblin", 10, 5),
            1 => new Enemy("Skeleton", 20, 7),
            2 => new Enemy("Wolf", 15, 6),
            _ => new Enemy("Goblin", 5, 5)
        };
    }
}
