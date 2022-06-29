namespace OneTwo
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Corected corected = new Corected();
            
            //public int[] AreaSystem = { 1, 2, 3, 4, 5, 6, 7, 8, 9 }; Если мы тут создаем и оправляем то все ок/ ПОБЕЖДЕНО
            Console.WriteLine("Hi! This game OTG");
            
            Console.WriteLine("This is position for game!  Ok?");
            Fun.Timer();
            Area.Print(corected.AreaSystem);
            Fun.Timer();
            Area.ClearArea(corected.AreaSystem);
            Fun.Timer();
        }

       

    }
}