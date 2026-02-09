using System;

public class LocationManager // Maksymm - Location manager handles player movement and interactions in different locations
{
    

    public void GoToHome()
    {
        Console.WriteLine("You are at your home. It's peaceful here.");
    }

    public void GoToFountain()
    {
        Console.WriteLine("You arrive at the town fountain. People are walking around.");
    }

    public void GoToShop(Player player)
    {
        new ShopManager().OpenShop(player);
    }

    public void GoToGuild(QuestManager questManager)
    {
        Console.WriteLine("Welcome to the Adventurer's Guild!");
        questManager.GiveQuest();
    }

    public void GoToDungeon(Player player, QuestManager questManager) // rewrite, not done yet
    {
        Enemy enemy = EnemyFactory.GetRandomEnemy();
        BattleSystem battle = new BattleSystem();

        battle.StartBattle(player, enemy);

        if (enemy.HP <= 0)
        {

            questManager.UpdateProgress(enemy.Name);
        }
    }
}