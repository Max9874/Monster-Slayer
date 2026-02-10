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
        
 */