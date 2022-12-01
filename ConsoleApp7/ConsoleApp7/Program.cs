namespace Тортики
{
    internal class Program
    {

        static void Main(string[] args)
        {
            Class1.selector();
        }
        /*public static void selector()
        {
            while (true)
            {
                Console.SetCursorPosition(0, position);
                Console.WriteLine("->");
                ConsoleKeyInfo key = Console.ReadKey();
                Console.SetCursorPosition(0, position);
                Console.Write("  ");
                if (key.Key == ConsoleKey.UpArrow)
                {
                    position = position - 1;
                }
                if (key.Key == ConsoleKey.DownArrow)
                {
                    position = position + 1;
                }
                if (position == 0)
                {
                    position = position + 1;
                }
                if (position >= 7)
                {
                    position = position = 6;
                }
                if (position == 1)
                {
                }
            }
        }
        */




    }
}