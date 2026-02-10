using System;

public class QuestManager
{
    public List<Quest> ActiveQuests { get; } = new List<Quest>();

    public void GiveQuest()
    {
        Quest quest = QuestFactory.GetRandomQuest();

        ActiveQuests.Add(quest);
        Console.WriteLine($"New quest: {quest.Title}! (Reward: {quest.RewardCoins} coins)");
    }

    public void UpdateProgress(string target, Player player)
    {
        foreach (var quest in ActiveQuests)
        {
            if (quest.Target == target && !quest.IsCompleted)
            {
                quest.CurrentAmount++;
                Console.WriteLine($"Quest progress updated: {quest.Title} ({quest.CurrentAmount}/{quest.RequiredAmount})");
                if (quest.IsCompleted)
                {
                    Console.WriteLine($"Quest completed: {quest.Title}! You earned {quest.RewardCoins} coins.");
                    player.Coins += quest.RewardCoins;
                    ActiveQuests.Remove(quest);
                    return;

                }
            }
        }
    }

    public void ShowQuests()
    {
        Console.WriteLine("\n=== Active Quests ===");
        if (ActiveQuests.Count == 0)
        {
            Console.WriteLine("You have no active quests.");
            return;
        }
        else {
            foreach (var quest in ActiveQuests)
            {
                Console.WriteLine($"{quest.Title} — {quest.CurrentAmount}/{quest.RequiredAmount}");
            }
        }
            
        
    }
}