using System;

public class QuestMenu 
{
    private QuestManager _questManager;

    public QuestMenu(QuestManager questManager)
    {
        _questManager = questManager;
    }

    public void Show()
    {
        _questManager.ShowQuests();
    }
}