namespace Game
{
    class Program
    {
        static void Main()
        {
            StoryMenu.ShowIntro();

            Player player = new Player { };


            MainMenu menu = new MainMenu();
            menu.Show(player);

        }
    }
}

/* 
    Updating plan:
        Add level and experience system for the player
            - Implement a method to calculate experience points gained from defeating enemies
            - Create a level-up system that increases player stats 
            - Quests experience rewards 
            - Add visual feedback for leveling up (e.g., flashing text)
       Add colors to the console output using Colorizer utility class 
       Add more mobs and quests to the game
       Add boss every 5-10 levels 
       
 */