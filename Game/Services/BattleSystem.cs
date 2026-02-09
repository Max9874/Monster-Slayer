using System;

public class BattleSystem
{
    public void StartBattle(Player player, Enemy enemy)
    {
        // Show active buffs
        if (player.ActiveBuffs.Count > 0)
        {
            Console.Write("Active buffs: ");
            foreach (var buff in player.ActiveBuffs)
            {
                if (buff == "Strength")
                    Console.Write("[STR] ");
            }
            Console.WriteLine();
        }

        Console.WriteLine($"\nA wild {enemy.Name} appears!");

        while (player.HP > 0 && enemy.HP > 0)
        {
            Console.WriteLine($"\nYour HP: {player.HP}/{player.MaxHP}");
            Console.WriteLine($"{enemy.Name} HP: {enemy.HP}");

            Console.WriteLine("\n1 — Attack");
            Console.WriteLine("2 — Use Item");
            Console.Write("Choose action: ");

            string choice = Console.ReadLine();

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

            int enemyDmg = enemy.GetDamage();
            player.HP -= enemyDmg;
            Console.WriteLine($"{enemy.Name} hits you for {enemyDmg} damage!");

            if (player.HP <= 0)
            {
                Console.WriteLine("You have been defeated...");
                player.Coins -= 5;
                player.BonusAttack = 0;
                player.ActiveBuffs.Clear();
                player.HP = player.MaxHP;
                return;
            }
        }
    }
}