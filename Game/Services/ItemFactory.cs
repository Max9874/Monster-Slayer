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
}