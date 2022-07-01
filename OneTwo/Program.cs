namespace OneTwo
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Corected corected = new Corected();
            int GameNumber = 1;
            int GameStop = 0;

            Console.WriteLine("Hi! This game OTG");
            
            Console.WriteLine("This is position for game!  Ok?");
            Fun.Timer();
            Area.Print(corected.AreaSystem);
            Fun.Timer();
            Area.ClearArea(corected.AreaSystem);
            Fun.Timer();

            while (GameStop <=1)
            {
                Corected.AreaCorrected(corected.AreaSystem, GameNumber);
                Area.Print(corected.AreaSystem);
                Fun.Timer();
                GameNumber++;
                WinTest.WinDiaganal(corected.AreaSystem);
                WinTest.WinVertical(corected.AreaSystem);
                WinTest.WinCenter(corected.AreaSystem);
                Console.WriteLine("Для продолжения нажмите 0, для выхода 1");
                GameStop = int.Parse(Console.ReadLine());
            }

        }

       

    }
}