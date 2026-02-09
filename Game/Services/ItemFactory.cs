using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

public static class ItemFactory // Maksym - All items
{
    public static Item RegenerationPotion()
    {
        return new Item(
            "Regeneration Potion",
            "Restores 50 HP.",
            true,
            50
        );
    }

    public static Item StrenghtPotion()
    {
        return new Item(
            "Strenght Potion",
            "Increases your attack by 5 for the next battle",
            true,
            0
            );
    }
}