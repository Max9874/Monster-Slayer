using System;

public class BattleSystem
{
    public void StartBattle(Player player, Enemy enemy)
    {
        // Show active buffs
        if (player.ActiveBuffs.Count > 0) // Maksym - Show active buffs before battle
        {
            Console.Write("Active buffs: ");
            foreach (var buff in player.ActiveBuffs)
            {
                if (buff == "Strength")
                    Console.Write("[STR] ");
            }
            Console.WriteLine();
        }

        string isRaged = enemy.Attribute == "Rage" ? "Raging" : ""; // Maksym - Show if enemy is raging

        Console.WriteLine($"\nA wild {"\u001b[31m" + isRaged + "\u001b[0m"} {enemy.ColoredName} appears!"); // Maksym - Show enemy name 

        if (enemy.Attribute == "Rage") // Maksym - Show special message if enemy has Rage attribute
        {
            Console.WriteLine("The enemy is filled with RAGE! Damage increased!");
        }


        while (player.HP > 0 && enemy.HP > 0) // Maksym - Main battle loop, continues until either player or enemy is defeated
        {
            // Show current HP of player and enemy and available actions
            Console.WriteLine($"\nYour HP: {player.HP}/{player.MaxHP}"); 
            Console.WriteLine($"{enemy.Name} HP: {enemy.HP}");

            Console.WriteLine("\n1 — Attack");
            Console.WriteLine("2 — Use Item");
            Console.Write("Choose action: ");
            // User input for action choice and handling of attack and item usage
            string choice = Console.ReadLine() ?? "1"; // Default to attack if input is null


            if (choice == "1")
            {
                int dmg = player.GetDamage();
                enemy.HP -= dmg;
                Console.WriteLine($"You dealt {dmg} damage!");

                if (enemy.HP <= 0)
                {
                    Console.WriteLine($"You defeated the {enemy.Name}!");
                    player.Coins += 10;
                    player.BonusAttack = 0;
                    player.ActiveBuffs.Clear();

                    return;
                }
            }
            else if (choice == "2")
            {
                new InventoryMenu().Show(player);
            }
            // Enemy's turn to attack, calculating damage and applying it to the player, and checking for defeat
            int enemyDmg = enemy.GetDamage();
            player.HP -= enemyDmg;
            Console.WriteLine($"{enemy.Name} hits you for {enemyDmg} damage!");

            if (player.HP <= 0)
            {
                Console.WriteLine("You have been defeated...");
                player.Coins -= 5;
                player.BonusAttack = 0;
                player.ActiveBuffs.Clear();
                // Maksym - Important - player HP is restored to max after defeat, to prevent softlock and allow player to continue playing
                player.HP = player.MaxHP;
                return;
            }
        }
    }
}