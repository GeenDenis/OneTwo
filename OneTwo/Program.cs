namespace OneTwo
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Corected corected = new Corected();
            int GameNumber = 1;

            //public int[] AreaSystem = { 1, 2, 3, 4, 5, 6, 7, 8, 9 }; Если мы тут создаем и оправляем то все ок/ ПОБЕЖДЕНО
            Console.WriteLine("Hi! This game OTG");
            
            Console.WriteLine("This is position for game!  Ok?");
            Fun.Timer();
            Area.Print(corected.AreaSystem);
            Fun.Timer();
            Area.ClearArea(corected.AreaSystem);
            Fun.Timer();

            for (int i = 0; i < 5; i++)
            {
                Corected.AreaCorrected(corected.AreaSystem, GameNumber);
                Area.Print(corected.AreaSystem);
                Fun.Timer();
                GameNumber++;
            }

        }

       

    }
}