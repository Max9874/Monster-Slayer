using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


public static class TextAnimator // Maksym - (defective method) Utility class for animating text in the console
{
    private static string[] Colors = new[]
    {
        "\u001b[31m", 
        "\u001b[33m", 
        "\u001b[32m", 
        "\u001b[36m", 
        "\u001b[34m", 
        "\u001b[35m", 
    };

    public static void FlashText(string text, int flashes = 3, int delay = 120)
    {
        for (int i = 0; i < flashes; i++)
        {
            string color = Colors[i % Colors.Length];
            Console.Write(color + text + "\u001b[0m\r");
            Thread.Sleep(delay);
        }

        // Final display without color
        Console.WriteLine(text);
    }
}


public static class Colorizer // Maksym - Utility class for adding color to console output
{
    private static Random rnd = new Random();

    private static string[] Colors = new[] // Array of ANSI color codes for colored text
    {
        "\u001b[31m", // red
        "\u001b[32m", // green
        "\u001b[33m", // yellow
        "\u001b[34m", // blue
        "\u001b[35m", // purple
        "\u001b[36m", // light blue
    };

    public static string Flash(string text) // Method to wrap text in a random color 
    {
        string color = Colors[rnd.Next(Colors.Length)];
        return color + text + "\u001b[0m";
    }

    public static string ColorizeString(string text, string color) // Method to wrap text in a specific color 
    {
        string colorCode = color switch
        {
            "Red" => "\u001b[31m",
            "Green" => "\u001b[32m",
            "Yellow" => "\u001b[33m",
            "Blue" => "\u001b[34m",
            "Magenta" => "\u001b[35m",
            "Cyan" => "\u001b[36m",
            "White" => "\u001b[37m",
            "DarkGray" => "\u001b[90m",
            _ => "\u001b[0m"
        };
        return colorCode + text + "\u001b[0m";
    }
    public static string ColorizeInt(int text, string color) // Method to wrap text in a specific color 
    {
        string colorCode = color switch
        {
            "Red" => "\u001b[31m",
            "Green" => "\u001b[32m",
            "Yellow" => "\u001b[33m",
            "Blue" => "\u001b[34m",
            "Magenta" => "\u001b[35m",
            "Cyan" => "\u001b[36m",
            "White" => "\u001b[37m",
            "DarkGray" => "\u001b[90m",
            _ => "\u001b[0m"
        };
        return colorCode + text + "\u001b[0m";
    }




}