using System;

public class QuestManager
{
    public List<Quest> ActiveQuests { get; } = new List<Quest>();

    public void GiveQuest()
    {
        Quest quest = QuestFactory.GetRandomQuest();

        ActiveQuests.Add(quest);
        Console.WriteLine($"New quest received: {quest.Title}!");
    }

    public void UpdateProgress(string target)
    {
        foreach (var quest in ActiveQuests)
        {
            if (quest.Target == target && !quest.IsCompleted)
            {
                quest.CurrentAmount++;
                Console.WriteLine($"Quest progress updated: {quest.Title} ({quest.CurrentAmount}/{quest.RequiredAmount})");
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