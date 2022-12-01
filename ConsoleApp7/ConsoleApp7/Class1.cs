using System.Collections.Generic;
using System.Drawing;
using System.IO;
using System.Linq;

internal class Class1
{
    public static bool mainFrame = true;
    public static List<int> price = new List<int>();
    public static List<string> Fullprice = new List<string>();
    public static ConsoleKeyInfo key;
    public static string vivod = "";
    public static int position = 1;
    public static int sum;
    public static int positionDopMeenu;
    private static string fileName = "История заказов.txt";
    public static void Menu()
    {
        List<string> torts = new List<string>();
        torts.Add("Форма                                ");
        torts.Add("Размер                               ");
        torts.Add("Вкус                                 ");
        torts.Add("Количество                           ");
        torts.Add("Глазурь                              ");
        torts.Add("Декор                                ");
        if (mainFrame == true)
        {
            Console.SetCursorPosition(0, 0);
            Console.WriteLine("      ");
            Console.SetCursorPosition(1, 0);
            Console.WriteLine("Выберите Параметры торта. Чтобы выйти нажмите ESC                  ");
            for (int i = 0; i < torts.Count; i++)
            {

                Console.WriteLine("   " + i + ".{0}", torts[i]);
            }
        }
    }
    public static void form()
    {
        Console.Clear();
        List<string> form = new List<string>();
        form.Add("Круг - 100                            ");
        form.Add("Квадрат - 200                         ");
        form.Add("Сердцечко - 800                       ");
        Console.SetCursorPosition(0, 0);
        Console.WriteLine("Выберите форму                                    ");
        for (int i = 0; i < form.Count; i++)
        {
            Console.WriteLine("   " + i + ".{0}", form[i]);
        }
    }
    public static void Size()
    {
        Console.Clear();
        List<string> Size = new List<string>();
        Size.Add("Маленький (Диаметр - 6см, 8 порций)   ");
        Size.Add("Обычнчый (Диаметр - 8см, 10 порций)   ");
        Size.Add("Большой (Диаметр - 16см, 24 порции)   ");
        Console.SetCursorPosition(0, 0);
        Console.WriteLine("Выберите размер                                 ");
        for (int i = 0; i < Size.Count; i++)
        {
            Console.WriteLine("   " + i + ".{0}", Size[i]);
        }
    }
    public static void Thetasteofcakes()
    {
        Console.Clear();
        List<string> Thetasteofcakes = new List<string>();
        Thetasteofcakes.Add("Ванильный - 100            ");
        Thetasteofcakes.Add("Шоколадный - 200           ");
        Thetasteofcakes.Add("Глазурь - 800             ");
        Console.SetCursorPosition(0, 0);
        Console.WriteLine("Выберите Вкус торта                              ");
        for (int i = 0; i < Thetasteofcakes.Count; i++)
        {
            Console.WriteLine("   " + i + ".{0}", Thetasteofcakes[i]);
        }
    }
    public static void numbers()
    {
        Console.Clear();
        List<string> numbers = new List<string>();
        numbers.Add("Два коржа - 100                    ");
        numbers.Add("Три коржа - 200                    ");
        numbers.Add("Семь коржей - 800                  ");
        Console.SetCursorPosition(0, 0);
        Console.WriteLine("Выберите количество                         ");
        for (int i = 0; i < numbers.Count; i++)
        {
            Console.WriteLine("   " + i + ".{0}", numbers[i]);
        }
    }
    public static void glaze()
    {
        Console.Clear();
        List<string> glaze = new List<string>();
        glaze.Add("Шоколад - 100                        ");
        glaze.Add("Крем - 200                           ");
        glaze.Add("Ваниль - 800                      ");
        Console.SetCursorPosition(0, 0);
        Console.WriteLine("Выберите глазурь                         ");
        for (int i = 0; i < glaze.Count; i++)
        {
            Console.WriteLine("   " + i + ".{0}", glaze[i]);
        }
    }
    public static void decor()
    {
        Console.Clear();
        List<string> decor = new List<string>();
        decor.Add("Шоколадный - 100                     ");
        decor.Add("Ягодный - 200                        ");
        decor.Add("Мармеладный - 800                       ");
        Console.SetCursorPosition(0, 0);
        Console.SetCursorPosition(0, 0);
        Console.WriteLine("Выберите декор                           ");
        for (int i = 0; i < decor.Count; i++)
        {
            Console.WriteLine("   " + i + ".{0}", decor[i]);
        }
    }
    public static void selector()
    {
        mainFrame = true;
        while (1 != 0)
        {
            Menu();
            Console.WriteLine("  Конец заказа");
            Console.WriteLine(" __________________________________");
            for (int i = 0; i < price.Count; i++)
            {
                Console.SetCursorPosition(25, i + 9);
                Console.WriteLine("Сумма: " + price[i] + "|");
            }
            for (int i = 0; i < price.Count; i++)
            {
                Console.SetCursorPosition(0, i + 9);
                Console.WriteLine("|" + Fullprice[i]);
            }
            Console.WriteLine(" __________________________________");
            sum = price.ToArray().Sum();
            Console.WriteLine("Итого: " + sum);
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
            if (position >= 8)
            {
                position = 7;
            }
            if (key.Key == ConsoleKey.Enter)
            {
                if (position == 1)
                {
                    mainFrame = false;
                    form();
                    dop_menu();
                    if (positionDopMeenu == 1)
                    {
                        Fullprice.Add("Форма:Круг");
                    }
                    if (positionDopMeenu == 2)
                    {
                        Fullprice.Add("Форма:Квадрат");
                    }
                    if (positionDopMeenu == 3)
                    {
                        Fullprice.Add("Форма:Сердечко");
                    }

                }
                if (position == 2)
                {
                    mainFrame = false;
                    Size();
                    dop_menu();
                    if (positionDopMeenu == 1)
                    {
                        Fullprice.Add("Размер:Маленький");
                    }
                    if (positionDopMeenu == 2)
                    {
                        Fullprice.Add("Размер:Обычный");
                    }
                    if (positionDopMeenu == 3)
                    {
                        Fullprice.Add("Размер:Большой");
                    }
                }
                if (position == 3)
                {
                    mainFrame = false;
                    Thetasteofcakes();
                    dop_menu();
                    if (positionDopMeenu == 1)
                    {
                        Fullprice.Add("Вкус:Ванильный");
                    }
                    if (positionDopMeenu == 2)
                    {
                        Fullprice.Add("Вкус:Шоколадный");
                    }
                    if (positionDopMeenu == 3)
                    {
                        Fullprice.Add("Вкус:Странный");
                    }
                }
                if (position == 4)
                {
                    mainFrame = false;
                    numbers();
                    dop_menu();
                    if (positionDopMeenu == 1)
                    {
                        Fullprice.Add("Количество:Два корда");
                    }
                    if (positionDopMeenu == 2)
                    {
                        Fullprice.Add("Количество:Три коржа");
                    }
                    if (positionDopMeenu == 3)
                    {
                        Fullprice.Add("Количество:Семь коржей");
                    }
                }
                if (position == 5)
                {
                    mainFrame = false;
                    glaze();
                    dop_menu();
                    if (positionDopMeenu == 1)
                    {
                        Fullprice.Add("Глазурь:Шоколадная");
                    }
                    if (positionDopMeenu == 2)
                    {
                        Fullprice.Add("Глазурь:Крем");
                    }
                    if (positionDopMeenu == 3)
                    {
                        Fullprice.Add("Глазурь:Аля бiбр");
                    }
                }
                if (position == 6)
                {
                    mainFrame = false;
                    decor();
                    dop_menu();
                    if (positionDopMeenu == 1)
                    {
                        Fullprice.Add("Декор:Шоколадный");
                    }
                    if (positionDopMeenu == 2)
                    {
                        Fullprice.Add("Декор:Ягодный");
                    }
                    if (positionDopMeenu == 3)
                    {
                        Fullprice.Add("Декор:С бобром");
                    }
                }
                if (position == 7)
                {
                    Add();

                }

            }
            if (key.Key == ConsoleKey.Escape)
            {
                break;
            }
        }
    }
    public static void dop_menu()
    {
        do
        {
            if (positionDopMeenu == 0)
            {
                positionDopMeenu = 1;
            }
            if (positionDopMeenu >= 4)
            {
                positionDopMeenu = 3;
            }
            Console.SetCursorPosition(0, positionDopMeenu);
            Console.WriteLine("->");
            ConsoleKeyInfo key = Console.ReadKey();
            Console.SetCursorPosition(0, positionDopMeenu);
            Console.Write("  ");

            if (key.Key == ConsoleKey.UpArrow)
            {
                positionDopMeenu = positionDopMeenu - 1;
            }
            if (key.Key == ConsoleKey.DownArrow)
            {
                positionDopMeenu = positionDopMeenu + 1;
            }
            if (key.Key == ConsoleKey.Escape)
            {
                mainFrame = true;
                break;
            }
            if (key.Key == ConsoleKey.Enter)
            {
                mainFrame = true;
                if (positionDopMeenu == 1)
                {
                    price.Add(100);
                }
                if (positionDopMeenu == 2)
                {
                    price.Add(200);
                }
                if (positionDopMeenu == 3)
                {
                    price.Add(800);
                }
                break;
            }
        } while (true);
    }
    public static void Add()
    {
        string time = DateTime.Now.ToString("MM/dd/yyyy HH:mm");
        Fullprice.Insert(0, time);
        string str = Convert.ToString(sum);
        Fullprice.Add(str);
        Fullprice.Add("--------------");
        File.AppendAllLines(fileName, Fullprice);
        do
        {
            for (int i = 0; i < Fullprice.Count; i++)
            {
                string? item = Fullprice[i];
                Fullprice.Remove(item);
            }
            for (int f = 0; f < price.Count; f++)
            {
                int a = price[f];
                price.Remove(a);
            }
        } while (Fullprice.Count != 0);
        sum = 0;
        Console.Clear();


    }


    /*public static void selectorSelectora()
    {
        position = 9;
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
            if (position <= 7)
            {
                position = position + 1;
            }
            if (position >= 12)
            {
                position = 11;
            }
            if (position == 1 && key.Key == ConsoleKey.Enter)
            {
                price.Add(100);
                position = 1;
                break;
            }
            if (position == 2 && key.Key == ConsoleKey.Enter)
            {
                price.Add(200);
                position = 1;
                break;
            }
            if (position == 3 && key.Key == ConsoleKey.Enter)
            {
                price.Add(800);
                position = 1;
                break;
            }
            if (position == 4 && key.Key == ConsoleKey.Enter)
            {
                price.Add(400);
                position = 1;
                break;
            }
        }
    }*/
}