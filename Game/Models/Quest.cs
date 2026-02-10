using System;

public enum QuestType // Maksym - Quest typer
{
    KillEnemy,
    CollectItem
}

public class Quest // Maksym - Represents a quest that the player can complete for rewards
{
    public string Title { get; }
    public string Description { get; }
    public QuestType Type { get; }
    public string Target { get; }
    public int RequiredAmount { get; }
    public int CurrentAmount { get; set; }
    public bool IsCompleted => CurrentAmount >= RequiredAmount;

    public int RewardCoins { get; set; }

    // Constructor to initialize base quest properties
    public Quest(string title, string description, QuestType type, string target, int requiredAmount, int rewardCoins)
    {
        Title = title;
        Description = description;
        Type = type;
        Target = target;
        RequiredAmount = requiredAmount;
        RewardCoins = rewardCoins;
    }
}