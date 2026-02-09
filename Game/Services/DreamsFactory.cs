using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

public static class DreamsFactory // Maksym - All types of dreams for resting at home. 
{
    private static Random rnd = new Random();
    public static string GetRandomDream()
    {
        int roll = rnd.Next(0, 3);
        return roll switch
        {
            0 =>  "You are soaring through the skies, feeling the wind beneath your wings." +
            "\nYou wake up just as you are about to dive into a flock of birds.",
            1 => "You find yourself in a labyrinth filled with glittering treasures." +
                    "\nYou wake up before reaching any of them",
            2 => "You are a hero fighting against overwhelming odds to save the kingdom. " +
            "\nYou wake up rigth before enemies spear reaches your face",
            _ => "You are lying in a serene meadow, surrounded by flowers and gentle breezes. " +
            "\nYou wake up from a kid that stole an apple from your garden. "
            };
    }
}