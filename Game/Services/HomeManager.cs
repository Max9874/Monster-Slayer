using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

public class HomeManager // Maksym - Adds activities in the Home location. 
{


    public void RestAtHome(Player player)
    {
        Console.WriteLine("\n1 — Rest");
        Console.WriteLine("2 — Exit");
        Console.Write("Choose action: "); 

        string choice = Console.ReadLine();

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