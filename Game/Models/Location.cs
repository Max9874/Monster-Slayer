using System;

public enum LocationType // Maksym - Types of locations in the game
{
    Home,
    Fountain,
    Shop,
    Guild,
    Dungeon
}

public class Location // Maksym - Represents a location in the game world
{
    public LocationType Type { get; }
    public string Description { get; }

    public Location(LocationType type, string description)
    {
        Type = type;
        Description = description;
    }
}