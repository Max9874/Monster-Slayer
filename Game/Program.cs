namespace Game
{
    class Program
    {
        static void Main()
        {
            Player player = new Player { };


            MainMenu menu = new MainMenu();
            menu.Show(player);

        }
    }
}

/* 
План доработки:
- добавить несколько боёв подряд в данже
- добавить зелья
- добавить случайные события в данжах
- добавить усиления для монстров
- добавить систему отдыха в доме(на кровати)
- добавить награды за квест




 */