using System;

public enum LocationType
{
    Home,
    Fountain,
    Shop,
    Guild,
    Dungeon
}

public class Location
{
    public LocationType Type { get; }
    public string Description { get; }

    public Location(LocationType type, string description)
    {
        Type = type;
        Description = description;
    }
}