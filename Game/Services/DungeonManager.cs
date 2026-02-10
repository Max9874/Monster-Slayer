using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

public class DungeonManager // Maksym - Manages dungeon exploration and battles
{
    public bool continueDungeon { get; set; } = true; // Maksym - Flag to control dungeon exploration loop
    /*public void Enter(Player player, QuestManager questManager)
    {
        Console.WriteLine("\nYou enter the dark dungeon...");

        Enemy enemy = EnemyFactory.GetRandomEnemy();
        BattleSystem battle = new BattleSystem();

        battle.StartBattle(player, enemy);

        if (enemy.HP <= 0)
        {
            questManager.UpdateProgress(enemy.Name, player);
        }
    }
    */

    public void Enter(Player player, QuestManager questManager)
    {
        Console.WriteLine("\nYou enter the dungeon...");


        while (continueDungeon)
        {
            Enemy enemy = EnemyFactory.GetRandomEnemy();
            BattleSystem battle = new BattleSystem();

            battle.StartBattle(player, enemy);

            // quest update
            questManager.UpdateProgress(enemy.Name, player);

            // New feature - possibility to go deaper into the dungeon 
            Console.WriteLine("\nDo you want to continue?");
            Console.WriteLine("1 — Go deeper");
            Console.WriteLine("2 — Leave dungeon");

            string choice = Console.ReadLine() ?? "1";

            if (choice == "2")
            {
                continueDungeon = false;
                Console.WriteLine("You leave the dungeon safely.");
            }
            else
            {
                Console.Clear();
                Console.WriteLine("You move deeper into the dungeon...");
            }
        }
    }


}