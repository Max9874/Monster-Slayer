using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

public class HomeManager // Maksym - Adds activities in the Home location. 
{


    public void RestAtHome(Player player) // Maksym - Method to handle resting at home
    {
        // Restores player's HP and shows a random dream
        Console.WriteLine("\n1 — Rest");
        Console.WriteLine("2 — Exit");
        Console.Write("Choose action: "); 

        string choice = Console.ReadLine() ?? "2";

        if (choice == "1")
        {
            Console.WriteLine("\nYou lie down on your bed...");
            Console.WriteLine("You feel your strength returning.");

            player.HP = player.MaxHP;
            player.BonusAttack = 0;
            player.ActiveBuffs.Clear();
            Console.WriteLine("\n\n===  Dream  ===\n");
            Console.WriteLine(DreamsFactory.GetRandomDream() + "\n");

            Console.WriteLine("You are fully rested. HP restored!");
        }
        else return;


        
    }
}