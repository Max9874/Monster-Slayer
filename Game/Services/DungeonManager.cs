using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

public class DungeonManager
{
    public void Enter(Player player, QuestManager questManager)
    {
        Console.WriteLine("\nYou enter the dark dungeon...");

        Enemy enemy = EnemyFactory.GetRandomEnemy();
        BattleSystem battle = new BattleSystem();

        battle.StartBattle(player, enemy);

        if (enemy.HP <= 0)
        {
            questManager.UpdateProgress(enemy.Name);
        }
    }



}