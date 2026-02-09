using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

public static class QuestFactory // Maksym - quests in the guild
{
    private static Random rnd = new Random();

    public static Quest GetRandomQuest()
    {
        int roll = rnd.Next(0, 3);

        return roll switch
        {
            0 => new Quest(
            "Goblin Slayer",
            "Defeat 3 goblins in the dungeon.",
            QuestType.KillEnemy,
            "Goblin",
            3),
            1 => new Quest(
            "Skeleton Slayer",
            "Defeat 3 Skeletons in the dungeon.",
            QuestType.KillEnemy,
            "Skeleton",
            3),
            2 => new Quest(
            "Wolf Slayer",
            "Defeat 3 Woolves in the dungeon.",
            QuestType.KillEnemy,
            "Wolf",
            3),
            _ => new Quest(
            "HopGoblin Slayer",
            "Defeat 3 HopGoblins in the dungeon.",
            QuestType.KillEnemy,
            "HopGoblin",
            3)
        };
    }
}
