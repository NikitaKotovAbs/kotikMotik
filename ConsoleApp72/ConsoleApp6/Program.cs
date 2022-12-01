namespace ConsoleApp6
{
    internal class Program
    {
        static int position = Switch.position, max = Switch.max, min = Switch.min;
        static ConsoleKey key = Switch.key;
        static string path = Base.path;
        static void Main()
        {
            Menu(position, max, min, key, path);
        }
        static void Menu(int position, int max, int min, ConsoleKey key, string path)
        {
            min = 1; max = 2;
            position = 1;
            Base.Base2(key, position, max, min, path);
        }
    }
}
