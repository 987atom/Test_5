using System.IO;
using System.Runtime.InteropServices;
using static System.Net.Mime.MediaTypeNames;

namespace Test_5
{
    internal class Program
    {
        static void Main(string[] args)
        {
            str1();
        }




        //static string muss = "Муссовый";
        //static string chok = "Шоколадный";
        //static string wanil = "Ванильный";
        public static int coast = 0;
        public static int pos = 1;
        public static int pos2 = 1;
        public static int pos3 = 1;
        public static int pos4 = 1;
        public static int pos31 = 1;
        public static int pos32 = 1;
        public static int pos33 = 1;
        public static int pos311 = 1;
        public static int pos312 = 1;
        public static int pos313 = 1;
        public static int pos321 = 1;
        public static int pos322 = 1;
        public static int pos323 = 1;
        public static int pos331 = 1;
        public static int pos332 = 1;
        public static int pos333 = 1;
        public static int pos211 = 1;
        public static int pos212 = 1;
        public static int pos213 = 1;
        public static int pos221 = 1;
        public static int pos222 = 1;
        public static int pos223 = 1;
        public static int pos0311 = 1;
        public static int pos0312 = 1;
        public static int pos0313 = 1;
        public static int pos0321 = 1;
        public static int pos0322 = 1;
        public static int pos0323 = 1;
        public static int pos0331 = 1;
        public static int pos0332 = 1;
        public static int pos0333 = 1;
        public static int pos22 = 1;
        public static int pos21 = 1;
        public static int pos23 = 1;
        public static int pos031 = 1;
        public static int pos032 = 1;
        public static int pos033 = 1;
        public static int pos231 = 1;
        public static int pos232 = 1;
        public static int pos233 = 1;

        public static Class1 tort = new Class1();



        public static void str1()
        {
            //Class1 tort = new Class1();
            //tort.torty = "l;kjsfgk";

            Class1 torty = new Class1();
            torty.name = "Манговый";
            Class1 tortyy = new Class1();
            tortyy.name = "Шоколадный";
            Class1 ttortyy = new Class1();
            ttortyy.name = "Ванильный";

            Console.Clear();
            Console.SetCursorPosition(2, 0);
            Console.WriteLine("Виды тортов:");

            Console.SetCursorPosition(0, pos);
            Console.WriteLine("->");

            Console.SetCursorPosition(2, 1);
            Console.WriteLine(torty.name);
            Console.SetCursorPosition(2, 2);
            Console.WriteLine(tortyy.name);
            Console.SetCursorPosition(2, 3);
            Console.WriteLine(ttortyy.name);
            Console.SetCursorPosition(2, 4);
            Console.WriteLine("Общая стоимость равна: " + coast);

            ConsoleKeyInfo key = Console.ReadKey();
            while (true)
            {
                if (key.Key == ConsoleKey.DownArrow)
                {
                    pos++;

                    if (pos < 4)
                    {
                        Console.SetCursorPosition(0, pos);
                        Console.WriteLine("->");
                        Console.SetCursorPosition(0, pos - 1);
                        Console.WriteLine("  ");

                    }
                    else
                    {
                        pos = 1;
                        Console.SetCursorPosition(0, pos);
                        Console.WriteLine("->");
                        Console.SetCursorPosition(0, pos + 2);
                        Console.WriteLine("  ");
                    }

                }//стрелка вниз
                 //coast = coast + 1;
                 //Console.SetCursorPosition(2, 4);
                 //Console.WriteLine("Общая стоимость равна: " + coast);
                if (key.Key == ConsoleKey.UpArrow)
                {
                    pos--;
                    Console.SetCursorPosition(0, pos);
                    Console.WriteLine("->");
                    Console.SetCursorPosition(0, pos + 1);
                    Console.WriteLine("  ");
                    if (pos <= 0)
                    {
                        pos = 4;
                        Console.SetCursorPosition(0, pos - 1);
                        Console.WriteLine("->");
                        Console.SetCursorPosition(0, pos - 4);
                        Console.WriteLine("  ");

                        //key = Console.ReadKey();
                    }

                }//стрелка вверх
                if (key.Key == ConsoleKey.Escape)
                {
                    Environment.Exit(0);
                }//выход
                if (key.Key == ConsoleKey.Enter)
                {
                    if (pos == 1)
                    {
                        pstr1muss();
                    }
                    if (pos == 2)
                    {
                        pstr1chok();
                    }
                    if (pos == 3)
                    {
                        pstr1wanil();
                    }
                }
                key = Console.ReadKey();
            }
        }//конец первого блока
        static void pstr1muss()
        {

            tort.circle = "Круглый";
            tort.square = "Квадратный";
            tort.triangular = "Треугольный";

            Console.Clear();
            Console.SetCursorPosition(2, 0);
            Console.WriteLine("Виды манговых тортов:");

            Console.SetCursorPosition(0, pos2);
            Console.WriteLine("->");

            Console.SetCursorPosition(2, 1);
            Console.WriteLine(tort.circle);
            Console.SetCursorPosition(2, 2);
            Console.WriteLine(tort.square);
            Console.SetCursorPosition(2, 3);
            Console.WriteLine(tort.triangular);
            Console.SetCursorPosition(2, 4);
            Console.WriteLine("Общая стоимость равна: " + coast);

            ConsoleKeyInfo key = Console.ReadKey();

            while (true)
            {
                if (key.Key == ConsoleKey.DownArrow)
                {
                    pos2++;

                    if (pos2 < 4)
                    {
                        Console.SetCursorPosition(0, pos2);
                        Console.WriteLine("->");
                        Console.SetCursorPosition(0, pos2 - 1);
                        Console.WriteLine("  ");
                    }
                    else
                    {
                        pos2 = 1;
                        Console.SetCursorPosition(0, pos2);
                        Console.WriteLine("->");
                        Console.SetCursorPosition(0, pos2 + 2);
                        Console.WriteLine("  ");
                    }

                }//стрелка вниз
                if (key.Key == ConsoleKey.UpArrow)
                {
                    pos2--;
                    Console.SetCursorPosition(0, pos2);
                    Console.WriteLine("->");
                    Console.SetCursorPosition(0, pos2 + 1);
                    Console.WriteLine("  ");
                    if (pos2 <= 0)
                    {
                        pos2 = 4;
                        Console.SetCursorPosition(0, pos2 - 1);
                        Console.WriteLine("->");
                        Console.SetCursorPosition(0, pos2 - 4);
                        Console.WriteLine("  ");
                    }
                }//стрелка вверх
                if (key.Key == ConsoleKey.Escape)
                {
                    str1();

                }//выход
                if (key.Key == ConsoleKey.Enter)
                {
                    if (pos2 == 1)
                    {
                        pstr1muss1();
                    }
                    if (pos2 == 2)
                    {
                        pstr1chok1();
                    }
                    if (pos2 == 3)
                    {
                        pstr1wanil1();
                    }
                }
                key = Console.ReadKey();
            }
        }//kon манговых тортов


        static void pstr1wanil1()
        {
            tort.yellow = "Желтый";
            tort.blue = "Синий";
            tort.red = "Красный";

            Console.Clear();
            Console.SetCursorPosition(2, 0);
            Console.WriteLine("Цвета треугольных манговых тортов:");

            Console.SetCursorPosition(0, pos33);
            Console.WriteLine("->");

            Console.SetCursorPosition(2, 1);
            Console.WriteLine(tort.yellow);
            Console.SetCursorPosition(2, 2);
            Console.WriteLine(tort.blue);
            Console.SetCursorPosition(2, 3);
            Console.WriteLine(tort.red);
            Console.SetCursorPosition(2, 4);
            Console.WriteLine("Общая стоимость равна: " + coast);

            ConsoleKeyInfo key = Console.ReadKey();

            while (true)
            {
                if (key.Key == ConsoleKey.DownArrow)
                {
                    pos33++;

                    if (pos33 < 4)
                    {
                        Console.SetCursorPosition(0, pos33);
                        Console.WriteLine("->");
                        Console.SetCursorPosition(0, pos33 - 1);
                        Console.WriteLine("  ");
                    }
                    else
                    {
                        pos33 = 1;
                        Console.SetCursorPosition(0, pos33);
                        Console.WriteLine("->");
                        Console.SetCursorPosition(0, pos33 + 2);
                        Console.WriteLine("  ");
                    }

                }//стрелка вниз
                if (key.Key == ConsoleKey.UpArrow)
                {
                    pos33--;
                    Console.SetCursorPosition(0, pos33);
                    Console.WriteLine("->");
                    Console.SetCursorPosition(0, pos33 + 1);
                    Console.WriteLine("  ");
                    if (pos33 <= 0)
                    {
                        pos33 = 4;
                        Console.SetCursorPosition(0, pos33 - 1);
                        Console.WriteLine("->");
                        Console.SetCursorPosition(0, pos33 - 4);
                        Console.WriteLine("  ");
                    }
                }//стрелка вверх
                if (key.Key == ConsoleKey.Escape)
                {
                    pstr1muss();

                }//выход
                if (key.Key == ConsoleKey.Enter)
                {
                    if (pos33 == 1)
                    {
                        mangtreuggekt();
                    }
                    if (pos33 == 2)
                    {
                        mangtreugBlue();
                    }
                    if (pos33 == 3)
                    {
                        mangtreugred();
                    }
                }
                key = Console.ReadKey();
            }
        }//кон треугольных манговых

        //нач манговых треугольных желтых
        static void mangtreuggekt()
        {
            tort.big = "Большой";
            tort.small = "Маленький";
            tort.average = "Средний";

            Console.Clear();
            Console.SetCursorPosition(2, 0);
            Console.WriteLine("Размеры треугольных манговых желтых тортов:");

            Console.SetCursorPosition(0, pos311);
            Console.WriteLine("->");

            Console.SetCursorPosition(2, 1);
            Console.WriteLine(tort.big);
            Console.SetCursorPosition(2, 2);
            Console.WriteLine(tort.small);
            Console.SetCursorPosition(2, 3);
            Console.WriteLine(tort.average);
            Console.SetCursorPosition(2, 4);
            Console.WriteLine("Общая стоимость равна: " + coast);

            ConsoleKeyInfo key = Console.ReadKey();

            while (true)
            {
                if (key.Key == ConsoleKey.DownArrow)
                {
                    pos311++;

                    if (pos311 < 4)
                    {
                        Console.SetCursorPosition(0, pos311);
                        Console.WriteLine("->");
                        Console.SetCursorPosition(0, pos311 - 1);
                        Console.WriteLine("  ");
                    }
                    else
                    {
                        pos311 = 1;
                        Console.SetCursorPosition(0, pos311);
                        Console.WriteLine("->");
                        Console.SetCursorPosition(0, pos311 + 2);
                        Console.WriteLine("  ");
                    }

                }//стрелка вниз
                if (key.Key == ConsoleKey.UpArrow)
                {
                    pos311--;
                    Console.SetCursorPosition(0, pos311);
                    Console.WriteLine("->");
                    Console.SetCursorPosition(0, pos311 + 1);
                    Console.WriteLine("  ");
                    if (pos311 <= 0)
                    {
                        pos311 = 4;
                        Console.SetCursorPosition(0, pos311 - 1);
                        Console.WriteLine("->");
                        Console.SetCursorPosition(0, pos311 - 4);
                        Console.WriteLine("  ");
                    }
                }//стрелка вверх
                if (key.Key == ConsoleKey.Escape)
                {
                    pstr1wanil1();

                }//выход
                if (key.Key == ConsoleKey.Enter)
                {
                    if (pos311 == 1)
                    {
                        itog43113();
                    }
                    if (pos311 == 2)
                    {
                        itog43111();
                    }
                    if (pos311 == 3)
                    {
                        itog43112();
                    }
                }
                key = Console.ReadKey();
            }
        }//кон манговых треугольных желтых

        static void itog43111()
        {
            Console.Clear();
            string Zakaz = "манговый, треугольный, желтый, малый торт";
            Console.SetCursorPosition(2, 0);
            Console.WriteLine("Значит вы сейчас выбрали " + Zakaz);
            Console.SetCursorPosition(2, 1);
            Console.WriteLine("Он стоит 500,если хотите купить, нажмите ентер, но если вы нажмете Эскейп то вернетесь в самое начало");
            ConsoleKeyInfo key = Console.ReadKey();
            if (key.Key == ConsoleKey.Enter)
            {
                coast = coast + 500;
                Console.SetCursorPosition(2, 2);
                Console.WriteLine("Итоговая сумма к оплате: " + coast);
            }
            if (key.Key == ConsoleKey.Escape)
            {
                str1();
            }

            string ZakazCoast = "К оплате: " + coast;
            string p = "";
            File.AppendAllText("C:\\Users\\PC_of_Matvey\\Desktop\\Zakaz.txt" + "<Заказ от текущая дата>", p);
            File.AppendAllText("C:\\Users\\PC_of_Matvey\\Desktop\\Zakaz.txt" + "<", Zakaz + ">");
            File.AppendAllText("C:\\Users\\PC_of_Matvey\\Desktop\\Zakaz.txt" + "Цена <", ZakazCoast + ">");

            Console.WriteLine("Если вы хотите сделать еще один заказ то нажмите Ентер");
            key = Console.ReadKey();
            if (key.Key == ConsoleKey.Enter)
            {
                str1();
            }
        }

        static void itog43112()
        {
            Console.Clear();
            string Zakaz = "манговый, треугольный, желтый, средний торт";
            Console.SetCursorPosition(2, 0);
            Console.WriteLine("Значит вы сейчас выбрали " + Zakaz);
            Console.SetCursorPosition(2, 1);
            Console.WriteLine("Он стоит 600,если хотите купить, нажмите ентер, но если вы нажмете Эскейп то вернетесь в самое начало");
            ConsoleKeyInfo key = Console.ReadKey();
            if (key.Key == ConsoleKey.Enter)
            {
                coast = coast + 600;
                Console.SetCursorPosition(2, 2);
                Console.WriteLine("Итоговая сумма к оплате: " + coast);
            }
            if (key.Key == ConsoleKey.Escape)
            {
                str1();
            }

            string ZakazCoast = "К оплате: " + coast;
            string p = "";
            File.AppendAllText("C:\\Users\\PC_of_Matvey\\Desktop\\Zakaz.txt" + "<Заказ от текущая дата>", p);
            File.AppendAllText("C:\\Users\\PC_of_Matvey\\Desktop\\Zakaz.txt" + "<", Zakaz + ">");
            File.AppendAllText("C:\\Users\\PC_of_Matvey\\Desktop\\Zakaz.txt" + "Цена <", ZakazCoast + ">");

            Console.WriteLine("Если вы хотите сделать еще один заказ то нажмите Ентер");
            key = Console.ReadKey();
            if (key.Key == ConsoleKey.Enter)
            {
                str1();
            }
        }

        static void itog43113()
        {
            Console.Clear();
            string Zakaz = "манговый, треугольный, желтый, большой торт";
            Console.SetCursorPosition(2, 0);
            Console.WriteLine("Значит вы сейчас выбрали " + Zakaz);
            Console.SetCursorPosition(2, 1);
            Console.WriteLine("Он стоит 700,если хотите купить, нажмите ентер, но если вы нажмете Эскейп то вернетесь в самое начало");
            ConsoleKeyInfo key = Console.ReadKey();
            if (key.Key == ConsoleKey.Enter)
            {
                coast = coast + 700;
                Console.SetCursorPosition(2, 2);
                Console.WriteLine("Итоговая сумма к оплате: " + coast);
            }
            if (key.Key == ConsoleKey.Escape)
            {
                str1();
            }

            string ZakazCoast = "К оплате: " + coast;
            string p = "";
            File.AppendAllText("C:\\Users\\PC_of_Matvey\\Desktop\\Zakaz.txt" + "<Заказ от текущая дата>", p);
            File.AppendAllText("C:\\Users\\PC_of_Matvey\\Desktop\\Zakaz.txt" + "<", Zakaz + ">");
            File.AppendAllText("C:\\Users\\PC_of_Matvey\\Desktop\\Zakaz.txt" + "Цена <", ZakazCoast + ">");

            Console.WriteLine("Если вы хотите сделать еще один заказ то нажмите Ентер");
            key = Console.ReadKey();
            if (key.Key == ConsoleKey.Enter)
            {
                str1();
            }
        }

        //нач манговых треугольных синих
        static void mangtreugBlue()
        {
            tort.big = "Большой";
            tort.small = "Маленький";
            tort.average = "Средний";

            Console.Clear();
            Console.SetCursorPosition(2, 0);
            Console.WriteLine("Размеры треугольных манговых синих тортов:");

            Console.SetCursorPosition(0, pos312);
            Console.WriteLine("->");

            Console.SetCursorPosition(2, 1);
            Console.WriteLine(tort.big);
            Console.SetCursorPosition(2, 2);
            Console.WriteLine(tort.small);
            Console.SetCursorPosition(2, 3);
            Console.WriteLine(tort.average);
            Console.SetCursorPosition(2, 4);
            Console.WriteLine("Общая стоимость равна: " + coast);

            ConsoleKeyInfo key = Console.ReadKey();

            while (true)
            {
                if (key.Key == ConsoleKey.DownArrow)
                {
                    pos312++;

                    if (pos312 < 4)
                    {
                        Console.SetCursorPosition(0, pos312);
                        Console.WriteLine("->");
                        Console.SetCursorPosition(0, pos312 - 1);
                        Console.WriteLine("  ");
                    }
                    else
                    {
                        pos312 = 1;
                        Console.SetCursorPosition(0, pos312);
                        Console.WriteLine("->");
                        Console.SetCursorPosition(0, pos312 + 2);
                        Console.WriteLine("  ");
                    }

                }//стрелка вниз
                if (key.Key == ConsoleKey.UpArrow)
                {
                    pos312--;
                    Console.SetCursorPosition(0, pos312);
                    Console.WriteLine("->");
                    Console.SetCursorPosition(0, pos312 + 1);
                    Console.WriteLine("  ");
                    if (pos312 <= 0)
                    {
                        pos312 = 4;
                        Console.SetCursorPosition(0, pos312 - 1);
                        Console.WriteLine("->");
                        Console.SetCursorPosition(0, pos312 - 4);
                        Console.WriteLine("  ");
                    }
                }//стрелка вверх
                if (key.Key == ConsoleKey.Escape)
                {
                    pstr1wanil1();

                }//выход
                if (key.Key == ConsoleKey.Enter)
                {
                    if (pos312 == 1)
                    {
                        itog3123();
                    }
                    if (pos312 == 2)
                    {
                        itog3121();
                    }
                    if (pos312 == 3)
                    {
                        itog3122();
                    }
                }
                key = Console.ReadKey();
            }
        }//kon манговых треугольных синих

        static void itog3121()
        {
            Console.Clear();
            string Zakaz = "манговый, треугольный, синий, малый торт";
            Console.SetCursorPosition(2, 0);
            Console.WriteLine("Значит вы сейчас выбрали " + Zakaz);
            Console.SetCursorPosition(2, 1);
            Console.WriteLine("Он стоит 500,если хотите купить, нажмите ентер, но если вы нажмете Эскейп то вернетесь в самое начало");
            ConsoleKeyInfo key = Console.ReadKey();
            if (key.Key == ConsoleKey.Enter)
            {
                coast = coast + 500;
                Console.SetCursorPosition(2, 2);
                Console.WriteLine("Итоговая сумма к оплате: " + coast);
            }
            if (key.Key == ConsoleKey.Escape)
            {
                str1();
            }

            string ZakazCoast = "К оплате: " + coast;
            string p = "";
            File.AppendAllText("C:\\Users\\PC_of_Matvey\\Desktop\\Zakaz.txt" + "<Заказ от текущая дата>", p);
            File.AppendAllText("C:\\Users\\PC_of_Matvey\\Desktop\\Zakaz.txt" + "<", Zakaz + ">");
            File.AppendAllText("C:\\Users\\PC_of_Matvey\\Desktop\\Zakaz.txt" + "Цена <", ZakazCoast + ">");

            Console.WriteLine("Если вы хотите сделать еще один заказ то нажмите Ентер");
            key = Console.ReadKey();
            if (key.Key == ConsoleKey.Enter)
            {
                str1();
            }
        }

        static void itog3122()
        {
            Console.Clear();
            string Zakaz = "манговый, треугольный, синий, средний торт";
            Console.SetCursorPosition(2, 0);
            Console.WriteLine("Значит вы сейчас выбрали " + Zakaz);
            Console.SetCursorPosition(2, 1);
            Console.WriteLine("Он стоит 600,если хотите купить, нажмите ентер, но если вы нажмете Эскейп то вернетесь в самое начало");
            ConsoleKeyInfo key = Console.ReadKey();
            if (key.Key == ConsoleKey.Enter)
            {
                coast = coast + 600;
                Console.SetCursorPosition(2, 2);
                Console.WriteLine("Итоговая сумма к оплате: " + coast);
            }
            if (key.Key == ConsoleKey.Escape)
            {
                str1();
            }

            string ZakazCoast = "К оплате: " + coast;
            string p = "";
            File.AppendAllText("C:\\Users\\PC_of_Matvey\\Desktop\\Zakaz.txt" + "<Заказ от текущая дата>", p);
            File.AppendAllText("C:\\Users\\PC_of_Matvey\\Desktop\\Zakaz.txt" + "<", Zakaz + ">");
            File.AppendAllText("C:\\Users\\PC_of_Matvey\\Desktop\\Zakaz.txt" + "Цена <", ZakazCoast + ">");

            Console.WriteLine("Если вы хотите сделать еще один заказ то нажмите Ентер");
            key = Console.ReadKey();
            if (key.Key == ConsoleKey.Enter)
            {
                str1();
            }
        }

        static void itog3123()
        {
            Console.Clear();
            string Zakaz = "манговый, треугольный, синий, большой торт";
            Console.SetCursorPosition(2, 0);
            Console.WriteLine("Значит вы сейчас выбрали " + Zakaz);
            Console.SetCursorPosition(2, 1);
            Console.WriteLine("Он стоит 700,если хотите купить, нажмите ентер, но если вы нажмете Эскейп то вернетесь в самое начало");
            ConsoleKeyInfo key = Console.ReadKey();
            if (key.Key == ConsoleKey.Enter)
            {
                coast = coast + 700;
                Console.SetCursorPosition(2, 2);
                Console.WriteLine("Итоговая сумма к оплате: " + coast);
            }
            if (key.Key == ConsoleKey.Escape)
            {
                str1();
            }

            string ZakazCoast = "К оплате: " + coast;
            string p = "";
            File.AppendAllText("C:\\Users\\PC_of_Matvey\\Desktop\\Zakaz.txt" + "<Заказ от текущая дата>", p);
            File.AppendAllText("C:\\Users\\PC_of_Matvey\\Desktop\\Zakaz.txt" + "<", Zakaz + ">");
            File.AppendAllText("C:\\Users\\PC_of_Matvey\\Desktop\\Zakaz.txt" + "Цена <", ZakazCoast + ">");

            Console.WriteLine("Если вы хотите сделать еще один заказ то нажмите Ентер");
            key = Console.ReadKey();
            if (key.Key == ConsoleKey.Enter)
            {
                str1();
            }
        }

        //нач манговых треугольных красных
        static void mangtreugred()
        {
            tort.big = "Большой";
            tort.small = "Маленький";
            tort.average = "Средний";

            Console.Clear();
            Console.SetCursorPosition(2, 0);
            Console.WriteLine("Размеры треугольных манговых красных тортов:");

            Console.SetCursorPosition(0, pos313);
            Console.WriteLine("->");

            Console.SetCursorPosition(2, 1);
            Console.WriteLine(tort.big);
            Console.SetCursorPosition(2, 2);
            Console.WriteLine(tort.small);
            Console.SetCursorPosition(2, 3);
            Console.WriteLine(tort.average);
            Console.SetCursorPosition(2, 4);
            Console.WriteLine("Общая стоимость равна: " + coast);

            ConsoleKeyInfo key = Console.ReadKey();

            while (true)
            {
                if (key.Key == ConsoleKey.DownArrow)
                {
                    pos313++;

                    if (pos313 < 4)
                    {
                        Console.SetCursorPosition(0, pos313);
                        Console.WriteLine("->");
                        Console.SetCursorPosition(0, pos313 - 1);
                        Console.WriteLine("  ");
                    }
                    else
                    {
                        pos313 = 1;
                        Console.SetCursorPosition(0, pos313);
                        Console.WriteLine("->");
                        Console.SetCursorPosition(0, pos313 + 2);
                        Console.WriteLine("  ");
                    }

                }//стрелка вниз
                if (key.Key == ConsoleKey.UpArrow)
                {
                    pos313--;
                    Console.SetCursorPosition(0, pos313);
                    Console.WriteLine("->");
                    Console.SetCursorPosition(0, pos313 + 1);
                    Console.WriteLine("  ");
                    if (pos313 <= 0)
                    {
                        pos313 = 4;
                        Console.SetCursorPosition(0, pos313 - 1);
                        Console.WriteLine("->");
                        Console.SetCursorPosition(0, pos313 - 4);
                        Console.WriteLine("  ");
                    }
                }//стрелка вверх
                if (key.Key == ConsoleKey.Escape)
                {
                    pstr1wanil1();

                }//выход
                if (key.Key == ConsoleKey.Enter)
                {
                    if (pos313 == 1)
                    {
                        itog3133();
                    }
                    if (pos313 == 2)
                    {
                        itog3131();
                    }
                    if (pos313 == 3)
                    {
                        itog3132();
                    }
                }
                key = Console.ReadKey();
            }
        }//кон манговых треугольных красных

        static void itog3131()
        {
            Console.Clear();
            string Zakaz = "манговый, треугольный, красныйый, малый торт";
            Console.SetCursorPosition(2, 0);
            Console.WriteLine("Значит вы сейчас выбрали " + Zakaz);
            Console.SetCursorPosition(2, 1);
            Console.WriteLine("Он стоит 500,если хотите купить, нажмите ентер, но если вы нажмете Эскейп то вернетесь в самое начало");
            ConsoleKeyInfo key = Console.ReadKey();
            if (key.Key == ConsoleKey.Enter)
            {
                coast = coast + 500;
                Console.SetCursorPosition(2, 2);
                Console.WriteLine("Итоговая сумма к оплате: " + coast);
            }
            if (key.Key == ConsoleKey.Escape)
            {
                str1();
            }

            string ZakazCoast = "К оплате: " + coast;
            string p = "";
            File.AppendAllText("C:\\Users\\PC_of_Matvey\\Desktop\\Zakaz.txt" + "<Заказ от текущая дата>", p);
            File.AppendAllText("C:\\Users\\PC_of_Matvey\\Desktop\\Zakaz.txt" + "<", Zakaz + ">");
            File.AppendAllText("C:\\Users\\PC_of_Matvey\\Desktop\\Zakaz.txt" + "Цена <", ZakazCoast + ">");

            Console.WriteLine("Если вы хотите сделать еще один заказ то нажмите Ентер");
            key = Console.ReadKey();
            if (key.Key == ConsoleKey.Enter)
            {
                str1();
            }
        }

        static void itog3132()
        {
            Console.Clear();
            string Zakaz = "манговый, треугольный, красныйый, средний торт";
            Console.SetCursorPosition(2, 0);
            Console.WriteLine("Значит вы сейчас выбрали " + Zakaz);
            Console.SetCursorPosition(2, 1);
            Console.WriteLine("Он стоит 600,если хотите купить, нажмите ентер, но если вы нажмете Эскейп то вернетесь в самое начало");
            ConsoleKeyInfo key = Console.ReadKey();
            if (key.Key == ConsoleKey.Enter)
            {
                coast = coast + 600;
                Console.SetCursorPosition(2, 2);
                Console.WriteLine("Итоговая сумма к оплате: " + coast);
            }
            if (key.Key == ConsoleKey.Escape)
            {
                str1();
            }

            string ZakazCoast = "К оплате: " + coast;
            string p = "";
            File.AppendAllText("C:\\Users\\PC_of_Matvey\\Desktop\\Zakaz.txt" + "<Заказ от текущая дата>", p);
            File.AppendAllText("C:\\Users\\PC_of_Matvey\\Desktop\\Zakaz.txt" + "<", Zakaz + ">");
            File.AppendAllText("C:\\Users\\PC_of_Matvey\\Desktop\\Zakaz.txt" + "Цена <", ZakazCoast + ">");

            Console.WriteLine("Если вы хотите сделать еще один заказ то нажмите Ентер");
            key = Console.ReadKey();
            if (key.Key == ConsoleKey.Enter)
            {
                str1();
            }
        }

        static void itog3133()
        {
            Console.Clear();
            string Zakaz = "манговый, треугольный, красныйый, большой торт";
            Console.SetCursorPosition(2, 0);
            Console.WriteLine("Значит вы сейчас выбрали " + Zakaz);
            Console.SetCursorPosition(2, 1);
            Console.WriteLine("Он стоит 700,если хотите купить, нажмите ентер, но если вы нажмете Эскейп то вернетесь в самое начало");
            ConsoleKeyInfo key = Console.ReadKey();
            if (key.Key == ConsoleKey.Enter)
            {
                coast = coast + 700;
                Console.SetCursorPosition(2, 2);
                Console.WriteLine("Итоговая сумма к оплате: " + coast);
            }
            if (key.Key == ConsoleKey.Escape)
            {
                str1();
            }

            string ZakazCoast = "К оплате: " + coast;
            string p = "";
            File.AppendAllText("C:\\Users\\PC_of_Matvey\\Desktop\\Zakaz.txt" + "<Заказ от текущая дата>", p);
            File.AppendAllText("C:\\Users\\PC_of_Matvey\\Desktop\\Zakaz.txt" + "<", Zakaz + ">");
            File.AppendAllText("C:\\Users\\PC_of_Matvey\\Desktop\\Zakaz.txt" + "Цена <", ZakazCoast + ">");

            Console.WriteLine("Если вы хотите сделать еще один заказ то нажмите Ентер");
            key = Console.ReadKey();
            if (key.Key == ConsoleKey.Enter)
            {
                str1();
            }
        }

        static void pstr1muss1()//нач круг манг
        {
            tort.yellow = "Желтый";
            tort.blue = "Синий";
            tort.red = "Красный";

            Console.Clear();
            Console.SetCursorPosition(2, 0);
            Console.WriteLine("Цвета круглый манговых тортов:");

            Console.SetCursorPosition(0, pos31);
            Console.WriteLine("->");

            Console.SetCursorPosition(2, 1);
            Console.WriteLine(tort.yellow);
            Console.SetCursorPosition(2, 2);
            Console.WriteLine(tort.blue);
            Console.SetCursorPosition(2, 3);
            Console.WriteLine(tort.red);
            Console.SetCursorPosition(2, 4);
            Console.WriteLine("Общая стоимость равна: " + coast);

            ConsoleKeyInfo key = Console.ReadKey();

            while (true)
            {
                if (key.Key == ConsoleKey.DownArrow)
                {
                    pos31++;

                    if (pos31 < 4)
                    {
                        Console.SetCursorPosition(0, pos31);
                        Console.WriteLine("->");
                        Console.SetCursorPosition(0, pos31 - 1);
                        Console.WriteLine("  ");
                    }
                    else
                    {
                        pos31 = 1;
                        Console.SetCursorPosition(0, pos31);
                        Console.WriteLine("->");
                        Console.SetCursorPosition(0, pos31 + 2);
                        Console.WriteLine("  ");
                    }

                }//стрелка вниз
                if (key.Key == ConsoleKey.UpArrow)
                {
                    pos31--;
                    Console.SetCursorPosition(0, pos31);
                    Console.WriteLine("->");
                    Console.SetCursorPosition(0, pos31 + 1);
                    Console.WriteLine("  ");
                    if (pos31 <= 0)
                    {
                        pos31 = 4;
                        Console.SetCursorPosition(0, pos31 - 1);
                        Console.WriteLine("->");
                        Console.SetCursorPosition(0, pos31 - 4);
                        Console.WriteLine("  ");
                    }
                }//стрелка вверх
                if (key.Key == ConsoleKey.Escape)
                {
                    pstr1muss();

                }//выход
                if (key.Key == ConsoleKey.Enter)
                {
                    if (pos31 == 1)
                    {
                        krugmanggelt();
                    }
                    if (pos31 == 2)
                    {
                        krugmangblue();
                    }
                    if (pos31 == 3)
                    {
                        krugmangrad();
                    }
                }
                key = Console.ReadKey();
            }
        }//кон круглых манговых

        //нач круг манг желт
        static void krugmanggelt()
        {
            tort.big = "Большой";
            tort.small = "Маленький";
            tort.average = "Средний";

            Console.Clear();
            Console.SetCursorPosition(2, 0);
            Console.WriteLine("Размеры круглых манговых желтых тортов:");

            Console.SetCursorPosition(0, pos321);
            Console.WriteLine("->");

            Console.SetCursorPosition(2, 1);
            Console.WriteLine(tort.big);
            Console.SetCursorPosition(2, 2);
            Console.WriteLine(tort.small);
            Console.SetCursorPosition(2, 3);
            Console.WriteLine(tort.average);
            Console.SetCursorPosition(2, 4);
            Console.WriteLine("Общая стоимость равна: " + coast);

            ConsoleKeyInfo key = Console.ReadKey();

            while (true)
            {
                if (key.Key == ConsoleKey.DownArrow)
                {
                    pos321++;

                    if (pos321 < 4)
                    {
                        Console.SetCursorPosition(0, pos321);
                        Console.WriteLine("->");
                        Console.SetCursorPosition(0, pos321 - 1);
                        Console.WriteLine("  ");
                    }
                    else
                    {
                        pos321 = 1;
                        Console.SetCursorPosition(0, pos321);
                        Console.WriteLine("->");
                        Console.SetCursorPosition(0, pos321 + 2);
                        Console.WriteLine("  ");
                    }

                }//стрелка вниз
                if (key.Key == ConsoleKey.UpArrow)
                {
                    pos321--;
                    Console.SetCursorPosition(0, pos321);
                    Console.WriteLine("->");
                    Console.SetCursorPosition(0, pos321 + 1);
                    Console.WriteLine("  ");
                    if (pos321 <= 0)
                    {
                        pos321 = 4;
                        Console.SetCursorPosition(0, pos321 - 1);
                        Console.WriteLine("->");
                        Console.SetCursorPosition(0, pos321 - 4);
                        Console.WriteLine("  ");
                    }
                }//стрелка вверх
                if (key.Key == ConsoleKey.Escape)
                {
                    pstr1muss1();

                }//выход
                if (key.Key == ConsoleKey.Enter)
                {
                    if (pos321 == 1)
                    {
                        itog3213();
                    }
                    if (pos321 == 2)
                    {
                        itog3211();
                    }
                    if (pos321 == 3)
                    {
                        itog3212();
                    }
                }
                key = Console.ReadKey();
            }
        }
        //кон круг манг желт

        static void itog3211()
        {
            Console.Clear();
            string Zakaz = "манговый, круглый, желтый, малый торт";
            Console.SetCursorPosition(2, 0);
            Console.WriteLine("Значит вы сейчас выбрали " + Zakaz);
            Console.SetCursorPosition(2, 1);
            Console.WriteLine("Он стоит 500,если хотите купить, нажмите ентер, но если вы нажмете Эскейп то вернетесь в самое начало");
            ConsoleKeyInfo key = Console.ReadKey();
            if (key.Key == ConsoleKey.Enter)
            {
                coast = coast + 500;
                Console.SetCursorPosition(2, 2);
                Console.WriteLine("Итоговая сумма к оплате: " + coast);
            }
            if (key.Key == ConsoleKey.Escape)
            {
                str1();
            }

            string ZakazCoast = "К оплате: " + coast;
            string p = "";
            File.AppendAllText("C:\\Users\\PC_of_Matvey\\Desktop\\Zakaz.txt" + "<Заказ от текущая дата>", p);
            File.AppendAllText("C:\\Users\\PC_of_Matvey\\Desktop\\Zakaz.txt" + "<", Zakaz + ">");
            File.AppendAllText("C:\\Users\\PC_of_Matvey\\Desktop\\Zakaz.txt" + "Цена <", ZakazCoast + ">");

            Console.WriteLine("Если вы хотите сделать еще один заказ то нажмите Ентер");
            key = Console.ReadKey();
            if (key.Key == ConsoleKey.Enter)
            {
                str1();
            }
        }

        static void itog3212()
        {
            Console.Clear();
            string Zakaz = "манговый, круглый, желтый, средний торт";
            Console.SetCursorPosition(2, 0);
            Console.WriteLine("Значит вы сейчас выбрали " + Zakaz);
            Console.SetCursorPosition(2, 1);
            Console.WriteLine("Он стоит 600,если хотите купить, нажмите ентер, но если вы нажмете Эскейп то вернетесь в самое начало");
            ConsoleKeyInfo key = Console.ReadKey();
            if (key.Key == ConsoleKey.Enter)
            {
                coast = coast + 600;
                Console.SetCursorPosition(2, 2);
                Console.WriteLine("Итоговая сумма к оплате: " + coast);
            }
            if (key.Key == ConsoleKey.Escape)
            {
                str1();
            }

            string ZakazCoast = "К оплате: " + coast;
            string p = "";
            File.AppendAllText("C:\\Users\\PC_of_Matvey\\Desktop\\Zakaz.txt" + "<Заказ от текущая дата>", p);
            File.AppendAllText("C:\\Users\\PC_of_Matvey\\Desktop\\Zakaz.txt" + "<", Zakaz + ">");
            File.AppendAllText("C:\\Users\\PC_of_Matvey\\Desktop\\Zakaz.txt" + "Цена <", ZakazCoast + ">");

            Console.WriteLine("Если вы хотите сделать еще один заказ то нажмите Ентер");
            key = Console.ReadKey();
            if (key.Key == ConsoleKey.Enter)
            {
                str1();
            }
        }

        static void itog3213()
        {
            Console.Clear();
            string Zakaz = "манговый, круглый, желтый, большой торт";
            Console.SetCursorPosition(2, 0);
            Console.WriteLine("Значит вы сейчас выбрали " + Zakaz);
            Console.SetCursorPosition(2, 1);
            Console.WriteLine("Он стоит 700,если хотите купить, нажмите ентер, но если вы нажмете Эскейп то вернетесь в самое начало");
            ConsoleKeyInfo key = Console.ReadKey();
            if (key.Key == ConsoleKey.Enter)
            {
                coast = coast + 700;
                Console.SetCursorPosition(2, 2);
                Console.WriteLine("Итоговая сумма к оплате: " + coast);
            }
            if (key.Key == ConsoleKey.Escape)
            {
                str1();
            }

            string ZakazCoast = "К оплате: " + coast;
            string p = "";
            File.AppendAllText("C:\\Users\\PC_of_Matvey\\Desktop\\Zakaz.txt" + "<Заказ от текущая дата>", p);
            File.AppendAllText("C:\\Users\\PC_of_Matvey\\Desktop\\Zakaz.txt" + "<", Zakaz + ">");
            File.AppendAllText("C:\\Users\\PC_of_Matvey\\Desktop\\Zakaz.txt" + "Цена <", ZakazCoast + ">");

            Console.WriteLine("Если вы хотите сделать еще один заказ то нажмите Ентер");
            key = Console.ReadKey();
            if (key.Key == ConsoleKey.Enter)
            {
                str1();
            }
        }

        //нач круг манг голуб
        static void krugmangblue()
        {
            tort.big = "Большой";
            tort.small = "Маленький";
            tort.average = "Средний";

            Console.Clear();
            Console.SetCursorPosition(2, 0);
            Console.WriteLine("Размеры круглых манговых синих тортов:");

            Console.SetCursorPosition(0, pos322);
            Console.WriteLine("->");

            Console.SetCursorPosition(2, 1);
            Console.WriteLine(tort.big);
            Console.SetCursorPosition(2, 2);
            Console.WriteLine(tort.small);
            Console.SetCursorPosition(2, 3);
            Console.WriteLine(tort.average);
            Console.SetCursorPosition(2, 4);
            Console.WriteLine("Общая стоимость равна: " + coast);

            ConsoleKeyInfo key = Console.ReadKey();

            while (true)
            {
                if (key.Key == ConsoleKey.DownArrow)
                {
                    pos322++;

                    if (pos322 < 4)
                    {
                        Console.SetCursorPosition(0, pos322);
                        Console.WriteLine("->");
                        Console.SetCursorPosition(0, pos322 - 1);
                        Console.WriteLine("  ");
                    }
                    else
                    {
                        pos322 = 1;
                        Console.SetCursorPosition(0, pos322);
                        Console.WriteLine("->");
                        Console.SetCursorPosition(0, pos322 + 2);
                        Console.WriteLine("  ");
                    }

                }//стрелка вниз
                if (key.Key == ConsoleKey.UpArrow)
                {
                    pos322--;
                    Console.SetCursorPosition(0, pos322);
                    Console.WriteLine("->");
                    Console.SetCursorPosition(0, pos322 + 1);
                    Console.WriteLine("  ");
                    if (pos322 <= 0)
                    {
                        pos322 = 4;
                        Console.SetCursorPosition(0, pos322 - 1);
                        Console.WriteLine("->");
                        Console.SetCursorPosition(0, pos322 - 4);
                        Console.WriteLine("  ");
                    }
                }//стрелка вверх
                if (key.Key == ConsoleKey.Escape)
                {
                    pstr1muss1();

                }//выход
                if (key.Key == ConsoleKey.Enter)
                {
                    if (pos322 == 1)
                    {
                        itog3223();
                    }
                    if (pos322 == 2)
                    {
                        itog3221();
                    }
                    if (pos322 == 3)
                    {
                        itog3222();
                    }
                }
                key = Console.ReadKey();
            }
        }
        //кон круг манг голуб

        static void itog3221()
        {
            Console.Clear();
            string Zakaz = "манговый, круглый, голуб, малый торт";
            Console.SetCursorPosition(2, 0);
            Console.WriteLine("Значит вы сейчас выбрали " + Zakaz);
            Console.SetCursorPosition(2, 1);
            Console.WriteLine("Он стоит 500,если хотите купить, нажмите ентер, но если вы нажмете Эскейп то вернетесь в самое начало");
            ConsoleKeyInfo key = Console.ReadKey();
            if (key.Key == ConsoleKey.Enter)
            {
                coast = coast + 500;
                Console.SetCursorPosition(2, 2);
                Console.WriteLine("Итоговая сумма к оплате: " + coast);
            }
            if (key.Key == ConsoleKey.Escape)
            {
                str1();
            }

            string ZakazCoast = "К оплате: " + coast;
            string p = "";
            File.AppendAllText("C:\\Users\\PC_of_Matvey\\Desktop\\Zakaz.txt" + "<Заказ от текущая дата>", p);
            File.AppendAllText("C:\\Users\\PC_of_Matvey\\Desktop\\Zakaz.txt" + "<", Zakaz + ">");
            File.AppendAllText("C:\\Users\\PC_of_Matvey\\Desktop\\Zakaz.txt" + "Цена <", ZakazCoast + ">");

            Console.WriteLine("Если вы хотите сделать еще один заказ то нажмите Ентер");
            key = Console.ReadKey();
            if (key.Key == ConsoleKey.Enter)
            {
                str1();
            }
        }

        static void itog3222()
        {
            Console.Clear();
            string Zakaz = "манговый, круглый, голуб, средний торт";
            Console.SetCursorPosition(2, 0);
            Console.WriteLine("Значит вы сейчас выбрали " + Zakaz);
            Console.SetCursorPosition(2, 1);
            Console.WriteLine("Он стоит 600,если хотите купить, нажмите ентер, но если вы нажмете Эскейп то вернетесь в самое начало");
            ConsoleKeyInfo key = Console.ReadKey();
            if (key.Key == ConsoleKey.Enter)
            {
                coast = coast + 600;
                Console.SetCursorPosition(2, 2);
                Console.WriteLine("Итоговая сумма к оплате: " + coast);
            }
            if (key.Key == ConsoleKey.Escape)
            {
                str1();
            }

            string ZakazCoast = "К оплате: " + coast;
            string p = "";
            File.AppendAllText("C:\\Users\\PC_of_Matvey\\Desktop\\Zakaz.txt" + "<Заказ от текущая дата>", p);
            File.AppendAllText("C:\\Users\\PC_of_Matvey\\Desktop\\Zakaz.txt" + "<", Zakaz + ">");
            File.AppendAllText("C:\\Users\\PC_of_Matvey\\Desktop\\Zakaz.txt" + "Цена <", ZakazCoast + ">");

            Console.WriteLine("Если вы хотите сделать еще один заказ то нажмите Ентер");
            key = Console.ReadKey();
            if (key.Key == ConsoleKey.Enter)
            {
                str1();
            }
        }

        static void itog3223()
        {
            Console.Clear();
            string Zakaz = "манговый, круглый, голуб, большой торт";
            Console.SetCursorPosition(2, 0);
            Console.WriteLine("Значит вы сейчас выбрали " + Zakaz);
            Console.SetCursorPosition(2, 1);
            Console.WriteLine("Он стоит 700,если хотите купить, нажмите ентер, но если вы нажмете Эскейп то вернетесь в самое начало");
            ConsoleKeyInfo key = Console.ReadKey();
            if (key.Key == ConsoleKey.Enter)
            {
                coast = coast + 700;
                Console.SetCursorPosition(2, 2);
                Console.WriteLine("Итоговая сумма к оплате: " + coast);
            }
            if (key.Key == ConsoleKey.Escape)
            {
                str1();
            }

            string ZakazCoast = "К оплате: " + coast;
            string p = "";
            File.AppendAllText("C:\\Users\\PC_of_Matvey\\Desktop\\Zakaz.txt" + "<Заказ от текущая дата>", p);
            File.AppendAllText("C:\\Users\\PC_of_Matvey\\Desktop\\Zakaz.txt" + "<", Zakaz + ">");
            File.AppendAllText("C:\\Users\\PC_of_Matvey\\Desktop\\Zakaz.txt" + "Цена <", ZakazCoast + ">");

            Console.WriteLine("Если вы хотите сделать еще один заказ то нажмите Ентер");
            key = Console.ReadKey();
            if (key.Key == ConsoleKey.Enter)
            {
                str1();
            }
        }

        //нач круг манг rad
        static void krugmangrad()
        {
            tort.big = "Большой";
            tort.small = "Маленький";
            tort.average = "Средний";

            Console.Clear();
            Console.SetCursorPosition(2, 0);
            Console.WriteLine("Размеры круглых манговых красных тортов:");

            Console.SetCursorPosition(0, pos323);
            Console.WriteLine("->");

            Console.SetCursorPosition(2, 1);
            Console.WriteLine(tort.big);
            Console.SetCursorPosition(2, 2);
            Console.WriteLine(tort.small);
            Console.SetCursorPosition(2, 3);
            Console.WriteLine(tort.average);
            Console.SetCursorPosition(2, 4);
            Console.WriteLine("Общая стоимость равна: " + coast);

            ConsoleKeyInfo key = Console.ReadKey();

            while (true)
            {
                if (key.Key == ConsoleKey.DownArrow)
                {
                    pos323++;

                    if (pos323 < 4)
                    {
                        Console.SetCursorPosition(0, pos323);
                        Console.WriteLine("->");
                        Console.SetCursorPosition(0, pos323 - 1);
                        Console.WriteLine("  ");
                    }
                    else
                    {
                        pos323 = 1;
                        Console.SetCursorPosition(0, pos323);
                        Console.WriteLine("->");
                        Console.SetCursorPosition(0, pos323 + 2);
                        Console.WriteLine("  ");
                    }

                }//стрелка вниз
                if (key.Key == ConsoleKey.UpArrow)
                {
                    pos323--;
                    Console.SetCursorPosition(0, pos323);
                    Console.WriteLine("->");
                    Console.SetCursorPosition(0, pos323 + 1);
                    Console.WriteLine("  ");
                    if (pos323 <= 0)
                    {
                        pos323 = 4;
                        Console.SetCursorPosition(0, pos323 - 1);
                        Console.WriteLine("->");
                        Console.SetCursorPosition(0, pos323 - 4);
                        Console.WriteLine("  ");
                    }
                }//стрелка вверх
                if (key.Key == ConsoleKey.Escape)
                {
                    pstr1muss1();

                }//выход
                if (key.Key == ConsoleKey.Enter)
                {
                    if (pos323 == 1)
                    {
                        itog3233();
                    }
                    if (pos323 == 2)
                    {
                        itog3231();
                    }
                    if (pos323 == 3)
                    {
                        itog3232();
                    }
                }
                key = Console.ReadKey();
            }
        }
        //kon круг манг rad

        static void itog3231()
        {
            Console.Clear();
            string Zakaz = "манговый, круглый, красный, малый торт";
            Console.SetCursorPosition(2, 0);
            Console.WriteLine("Значит вы сейчас выбрали " + Zakaz);
            Console.SetCursorPosition(2, 1);
            Console.WriteLine("Он стоит 500,если хотите купить, нажмите ентер, но если вы нажмете Эскейп то вернетесь в самое начало");
            ConsoleKeyInfo key = Console.ReadKey();
            if (key.Key == ConsoleKey.Enter)
            {
                coast = coast + 500;
                Console.SetCursorPosition(2, 2);
                Console.WriteLine("Итоговая сумма к оплате: " + coast);
            }
            if (key.Key == ConsoleKey.Escape)
            {
                str1();
            }

            string ZakazCoast = "К оплате: " + coast;
            string p = "";
            File.AppendAllText("C:\\Users\\PC_of_Matvey\\Desktop\\Zakaz.txt" + "<Заказ от текущая дата>", p);
            File.AppendAllText("C:\\Users\\PC_of_Matvey\\Desktop\\Zakaz.txt" + "<", Zakaz + ">");
            File.AppendAllText("C:\\Users\\PC_of_Matvey\\Desktop\\Zakaz.txt" + "Цена <", ZakazCoast + ">");

            Console.WriteLine("Если вы хотите сделать еще один заказ то нажмите Ентер");
            key = Console.ReadKey();
            if (key.Key == ConsoleKey.Enter)
            {
                str1();
            }
        }

        static void itog3232()
        {
            Console.Clear();
            string Zakaz = "манговый, круглый, красны, средний торт";
            Console.SetCursorPosition(2, 0);
            Console.WriteLine("Значит вы сейчас выбрали " + Zakaz);
            Console.SetCursorPosition(2, 1);
            Console.WriteLine("Он стоит 600,если хотите купить, нажмите ентер, но если вы нажмете Эскейп то вернетесь в самое начало");
            ConsoleKeyInfo key = Console.ReadKey();
            if (key.Key == ConsoleKey.Enter)
            {
                coast = coast + 600;
                Console.SetCursorPosition(2, 2);
                Console.WriteLine("Итоговая сумма к оплате: " + coast);
            }
            if (key.Key == ConsoleKey.Escape)
            {
                str1();
            }

            string ZakazCoast = "К оплате: " + coast;
            string p = "";
            File.AppendAllText("C:\\Users\\PC_of_Matvey\\Desktop\\Zakaz.txt" + "<Заказ от текущая дата>", p);
            File.AppendAllText("C:\\Users\\PC_of_Matvey\\Desktop\\Zakaz.txt" + "<", Zakaz + ">");
            File.AppendAllText("C:\\Users\\PC_of_Matvey\\Desktop\\Zakaz.txt" + "Цена <", ZakazCoast + ">");

            Console.WriteLine("Если вы хотите сделать еще один заказ то нажмите Ентер");
            key = Console.ReadKey();
            if (key.Key == ConsoleKey.Enter)
            {
                str1();
            }
        }

        static void itog3233()
        {
            Console.Clear();
            string Zakaz = "манговый, круглый, красны, большой торт";
            Console.SetCursorPosition(2, 0);
            Console.WriteLine("Значит вы сейчас выбрали " + Zakaz);
            Console.SetCursorPosition(2, 1);
            Console.WriteLine("Он стоит 700,если хотите купить, нажмите ентер, но если вы нажмете Эскейп то вернетесь в самое начало");
            ConsoleKeyInfo key = Console.ReadKey();
            if (key.Key == ConsoleKey.Enter)
            {
                coast = coast + 700;
                Console.SetCursorPosition(2, 2);
                Console.WriteLine("Итоговая сумма к оплате: " + coast);
            }
            if (key.Key == ConsoleKey.Escape)
            {
                str1();
            }

            string ZakazCoast = "К оплате: " + coast;
            string p = "";
            File.AppendAllText("C:\\Users\\PC_of_Matvey\\Desktop\\Zakaz.txt" + "<Заказ от текущая дата>", p);
            File.AppendAllText("C:\\Users\\PC_of_Matvey\\Desktop\\Zakaz.txt" + "<", Zakaz + ">");
            File.AppendAllText("C:\\Users\\PC_of_Matvey\\Desktop\\Zakaz.txt" + "Цена <", ZakazCoast + ">");

            Console.WriteLine("Если вы хотите сделать еще один заказ то нажмите Ентер");
            key = Console.ReadKey();
            if (key.Key == ConsoleKey.Enter)
            {
                str1();
            }
        }

        static void pstr1chok1()//нач квадр манговых
        {
            tort.yellow = "Желтый";
            tort.blue = "Синий";
            tort.red = "Красный";

            Console.Clear();
            Console.SetCursorPosition(2, 0);
            Console.WriteLine("Цвета квадратных манговых тортов:");

            Console.SetCursorPosition(0, pos32);
            Console.WriteLine("->");

            Console.SetCursorPosition(2, 1);
            Console.WriteLine(tort.yellow);
            Console.SetCursorPosition(2, 2);
            Console.WriteLine(tort.blue);
            Console.SetCursorPosition(2, 3);
            Console.WriteLine(tort.red);
            Console.SetCursorPosition(2, 4);
            Console.WriteLine("Общая стоимость равна: " + coast);

            ConsoleKeyInfo key = Console.ReadKey();

            while (true)
            {
                if (key.Key == ConsoleKey.DownArrow)
                {
                    pos32++;

                    if (pos32 < 4)
                    {
                        Console.SetCursorPosition(0, pos32);
                        Console.WriteLine("->");
                        Console.SetCursorPosition(0, pos32 - 1);
                        Console.WriteLine("  ");
                    }
                    else
                    {
                        pos32 = 1;
                        Console.SetCursorPosition(0, pos32);
                        Console.WriteLine("->");
                        Console.SetCursorPosition(0, pos32 + 2);
                        Console.WriteLine("  ");
                    }

                }//стрелка вниз
                if (key.Key == ConsoleKey.UpArrow)
                {
                    pos32--;
                    Console.SetCursorPosition(0, pos32);
                    Console.WriteLine("->");
                    Console.SetCursorPosition(0, pos32 + 1);
                    Console.WriteLine("  ");
                    if (pos32 <= 0)
                    {
                        pos32 = 4;
                        Console.SetCursorPosition(0, pos32 - 1);
                        Console.WriteLine("->");
                        Console.SetCursorPosition(0, pos32 - 4);
                        Console.WriteLine("  ");
                    }
                }//стрелка вверх
                if (key.Key == ConsoleKey.Escape)
                {
                    pstr1muss();

                }//выход
                if (key.Key == ConsoleKey.Enter)
                {
                    if (pos32 == 1)
                    {
                        KwadMangGelt();
                    }
                    if (pos32 == 2)
                    {
                        KwadMangBlue();
                    }
                    if (pos32 == 3)
                    {
                        KwadMangRad();
                    }
                }
                key = Console.ReadKey();
            }
        }//кон квадр манговых

        //нач квадр манговых желтых
        static void KwadMangGelt()
        {
            tort.big = "Большой";
            tort.small = "Маленький";
            tort.average = "Средний";

            Console.Clear();
            Console.SetCursorPosition(2, 0);
            Console.WriteLine("Размеры квадратных манговых желтых тортов:");

            Console.SetCursorPosition(0, pos331);
            Console.WriteLine("->");

            Console.SetCursorPosition(2, 1);
            Console.WriteLine(tort.big);
            Console.SetCursorPosition(2, 2);
            Console.WriteLine(tort.small);
            Console.SetCursorPosition(2, 3);
            Console.WriteLine(tort.average);
            Console.SetCursorPosition(2, 4);
            Console.WriteLine("Общая стоимость равна: " + coast);

            ConsoleKeyInfo key = Console.ReadKey();

            while (true)
            {
                if (key.Key == ConsoleKey.DownArrow)
                {
                    pos331++;

                    if (pos331 < 4)
                    {
                        Console.SetCursorPosition(0, pos331);
                        Console.WriteLine("->");
                        Console.SetCursorPosition(0, pos331 - 1);
                        Console.WriteLine("  ");
                    }
                    else
                    {
                        pos331 = 1;
                        Console.SetCursorPosition(0, pos331);
                        Console.WriteLine("->");
                        Console.SetCursorPosition(0, pos331 + 2);
                        Console.WriteLine("  ");
                    }

                }//стрелка вниз
                if (key.Key == ConsoleKey.UpArrow)
                {
                    pos331--;
                    Console.SetCursorPosition(0, pos331);
                    Console.WriteLine("->");
                    Console.SetCursorPosition(0, pos331 + 1);
                    Console.WriteLine("  ");
                    if (pos331 <= 0)
                    {
                        pos331 = 4;
                        Console.SetCursorPosition(0, pos331 - 1);
                        Console.WriteLine("->");
                        Console.SetCursorPosition(0, pos331 - 4);
                        Console.WriteLine("  ");
                    }
                }//стрелка вверх
                if (key.Key == ConsoleKey.Escape)
                {
                    pstr1chok1();

                }//выход
                if (key.Key == ConsoleKey.Enter)
                {
                    if (pos331 == 1)
                    {
                        itog3313();
                    }
                    if (pos331 == 2)
                    {
                        itog3311();
                    }
                    if (pos331 == 3)
                    {
                        itog3312();
                    }
                }
                key = Console.ReadKey();
            }
        }
        //кон квадр манговых желтых

        static void itog3311()
        {
            Console.Clear();
            string Zakaz = "манговый, квадратный, желтый, малый торт";
            Console.SetCursorPosition(2, 0);
            Console.WriteLine("Значит вы сейчас выбрали " + Zakaz);
            Console.SetCursorPosition(2, 1);
            Console.WriteLine("Он стоит 500,если хотите купить, нажмите ентер, но если вы нажмете Эскейп то вернетесь в самое начало");
            ConsoleKeyInfo key = Console.ReadKey();
            if (key.Key == ConsoleKey.Enter)
            {
                coast = coast + 500;
                Console.SetCursorPosition(2, 2);
                Console.WriteLine("Итоговая сумма к оплате: " + coast);
            }
            if (key.Key == ConsoleKey.Escape)
            {
                str1();
            }

            string ZakazCoast = "К оплате: " + coast;
            string p = "";
            File.AppendAllText("C:\\Users\\PC_of_Matvey\\Desktop\\Zakaz.txt" + "<Заказ от текущая дата>", p);
            File.AppendAllText("C:\\Users\\PC_of_Matvey\\Desktop\\Zakaz.txt" + "<", Zakaz + ">");
            File.AppendAllText("C:\\Users\\PC_of_Matvey\\Desktop\\Zakaz.txt" + "Цена <", ZakazCoast + ">");

            Console.WriteLine("Если вы хотите сделать еще один заказ то нажмите Ентер");
            key = Console.ReadKey();
            if (key.Key == ConsoleKey.Enter)
            {
                str1();
            }
        }

        static void itog3312()
        {
            Console.Clear();
            string Zakaz = "манговый, квадратный, желтый, средний торт";
            Console.SetCursorPosition(2, 0);
            Console.WriteLine("Значит вы сейчас выбрали " + Zakaz);
            Console.SetCursorPosition(2, 1);
            Console.WriteLine("Он стоит 600,если хотите купить, нажмите ентер, но если вы нажмете Эскейп то вернетесь в самое начало");
            ConsoleKeyInfo key = Console.ReadKey();
            if (key.Key == ConsoleKey.Enter)
            {
                coast = coast + 600;
                Console.SetCursorPosition(2, 2);
                Console.WriteLine("Итоговая сумма к оплате: " + coast);
            }
            if (key.Key == ConsoleKey.Escape)
            {
                str1();
            }

            string ZakazCoast = "К оплате: " + coast;
            string p = "";
            File.AppendAllText("C:\\Users\\PC_of_Matvey\\Desktop\\Zakaz.txt" + "<Заказ от текущая дата>", p);
            File.AppendAllText("C:\\Users\\PC_of_Matvey\\Desktop\\Zakaz.txt" + "<", Zakaz + ">");
            File.AppendAllText("C:\\Users\\PC_of_Matvey\\Desktop\\Zakaz.txt" + "Цена <", ZakazCoast + ">");

            Console.WriteLine("Если вы хотите сделать еще один заказ то нажмите Ентер");
            key = Console.ReadKey();
            if (key.Key == ConsoleKey.Enter)
            {
                str1();
            }
        }

        static void itog3313()
        {
            Console.Clear();
            string Zakaz = "манговый, квадратный, желтый, большой торт";
            Console.SetCursorPosition(2, 0);
            Console.WriteLine("Значит вы сейчас выбрали " + Zakaz);
            Console.SetCursorPosition(2, 1);
            Console.WriteLine("Он стоит 700,если хотите купить, нажмите ентер, но если вы нажмете Эскейп то вернетесь в самое начало");
            ConsoleKeyInfo key = Console.ReadKey();
            if (key.Key == ConsoleKey.Enter)
            {
                coast = coast + 700;
                Console.SetCursorPosition(2, 2);
                Console.WriteLine("Итоговая сумма к оплате: " + coast);
            }
            if (key.Key == ConsoleKey.Escape)
            {
                str1();
            }

            string ZakazCoast = "К оплате: " + coast;
            string p = "";
            File.AppendAllText("C:\\Users\\PC_of_Matvey\\Desktop\\Zakaz.txt" + "<Заказ от текущая дата>", p);
            File.AppendAllText("C:\\Users\\PC_of_Matvey\\Desktop\\Zakaz.txt" + "<", Zakaz + ">");
            File.AppendAllText("C:\\Users\\PC_of_Matvey\\Desktop\\Zakaz.txt" + "Цена <", ZakazCoast + ">");

            Console.WriteLine("Если вы хотите сделать еще один заказ то нажмите Ентер");
            key = Console.ReadKey();
            if (key.Key == ConsoleKey.Enter)
            {
                str1();
            }
        }

        //нач квадр манговых синих
        static void KwadMangBlue()
        {
            tort.big = "Большой";
            tort.small = "Маленький";
            tort.average = "Средний";

            Console.Clear();
            Console.SetCursorPosition(2, 0);
            Console.WriteLine("Размеры квадратных манговых синих тортов:");

            Console.SetCursorPosition(0, pos332);
            Console.WriteLine("->");

            Console.SetCursorPosition(2, 1);
            Console.WriteLine(tort.big);
            Console.SetCursorPosition(2, 2);
            Console.WriteLine(tort.small);
            Console.SetCursorPosition(2, 3);
            Console.WriteLine(tort.average);
            Console.SetCursorPosition(2, 4);
            Console.WriteLine("Общая стоимость равна: " + coast);

            ConsoleKeyInfo key = Console.ReadKey();

            while (true)
            {
                if (key.Key == ConsoleKey.DownArrow)
                {
                    pos332++;

                    if (pos332 < 4)
                    {
                        Console.SetCursorPosition(0, pos332);
                        Console.WriteLine("->");
                        Console.SetCursorPosition(0, pos332 - 1);
                        Console.WriteLine("  ");
                    }
                    else
                    {
                        pos332 = 1;
                        Console.SetCursorPosition(0, pos332);
                        Console.WriteLine("->");
                        Console.SetCursorPosition(0, pos332 + 2);
                        Console.WriteLine("  ");
                    }

                }//стрелка вниз
                if (key.Key == ConsoleKey.UpArrow)
                {
                    pos332--;
                    Console.SetCursorPosition(0, pos332);
                    Console.WriteLine("->");
                    Console.SetCursorPosition(0, pos332 + 1);
                    Console.WriteLine("  ");
                    if (pos332 <= 0)
                    {
                        pos332 = 4;
                        Console.SetCursorPosition(0, pos332 - 1);
                        Console.WriteLine("->");
                        Console.SetCursorPosition(0, pos332 - 4);
                        Console.WriteLine("  ");
                    }
                }//стрелка вверх
                if (key.Key == ConsoleKey.Escape)
                {
                    pstr1chok1();

                }//выход
                if (key.Key == ConsoleKey.Enter)
                {
                    if (pos332 == 1)
                    {
                        itog3323();
                    }
                    if (pos332 == 2)
                    {
                        itog3321();
                    }
                    if (pos332 == 3)
                    {
                        itog3322();
                    }
                }
                key = Console.ReadKey();
            }
        }
        //кон квадр манговых синих

        static void itog3321()
        {
            Console.Clear();
            string Zakaz = "манговый, квадратный, синий, малый торт";
            Console.SetCursorPosition(2, 0);
            Console.WriteLine("Значит вы сейчас выбрали " + Zakaz);
            Console.SetCursorPosition(2, 1);
            Console.WriteLine("Он стоит 500,если хотите купить, нажмите ентер, но если вы нажмете Эскейп то вернетесь в самое начало");
            ConsoleKeyInfo key = Console.ReadKey();
            if (key.Key == ConsoleKey.Enter)
            {
                coast = coast + 500;
                Console.SetCursorPosition(2, 2);
                Console.WriteLine("Итоговая сумма к оплате: " + coast);
            }
            if (key.Key == ConsoleKey.Escape)
            {
                str1();
            }

            string ZakazCoast = "К оплате: " + coast;
            string p = "";
            File.AppendAllText("C:\\Users\\PC_of_Matvey\\Desktop\\Zakaz.txt" + "<Заказ от текущая дата>", p);
            File.AppendAllText("C:\\Users\\PC_of_Matvey\\Desktop\\Zakaz.txt" + "<", Zakaz + ">");
            File.AppendAllText("C:\\Users\\PC_of_Matvey\\Desktop\\Zakaz.txt" + "Цена <", ZakazCoast + ">");

            Console.WriteLine("Если вы хотите сделать еще один заказ то нажмите Ентер");
            key = Console.ReadKey();
            if (key.Key == ConsoleKey.Enter)
            {
                str1();
            }
        }

        static void itog3322()
        {
            Console.Clear();
            string Zakaz = "манговый, квадратный, синий, средний торт";
            Console.SetCursorPosition(2, 0);
            Console.WriteLine("Значит вы сейчас выбрали " + Zakaz);
            Console.SetCursorPosition(2, 1);
            Console.WriteLine("Он стоит 600,если хотите купить, нажмите ентер, но если вы нажмете Эскейп то вернетесь в самое начало");
            ConsoleKeyInfo key = Console.ReadKey();
            if (key.Key == ConsoleKey.Enter)
            {
                coast = coast + 600;
                Console.SetCursorPosition(2, 2);
                Console.WriteLine("Итоговая сумма к оплате: " + coast);
            }
            if (key.Key == ConsoleKey.Escape)
            {
                str1();
            }

            string ZakazCoast = "К оплате: " + coast;
            string p = "";
            File.AppendAllText("C:\\Users\\PC_of_Matvey\\Desktop\\Zakaz.txt" + "<Заказ от текущая дата>", p);
            File.AppendAllText("C:\\Users\\PC_of_Matvey\\Desktop\\Zakaz.txt" + "<", Zakaz + ">");
            File.AppendAllText("C:\\Users\\PC_of_Matvey\\Desktop\\Zakaz.txt" + "Цена <", ZakazCoast + ">");

            Console.WriteLine("Если вы хотите сделать еще один заказ то нажмите Ентер");
            key = Console.ReadKey();
            if (key.Key == ConsoleKey.Enter)
            {
                str1();
            }
        }

        static void itog3323()
        {
            Console.Clear();
            string Zakaz = "манговый, квадратный, синий, большой торт";
            Console.SetCursorPosition(2, 0);
            Console.WriteLine("Значит вы сейчас выбрали " + Zakaz);
            Console.SetCursorPosition(2, 1);
            Console.WriteLine("Он стоит 700,если хотите купить, нажмите ентер, но если вы нажмете Эскейп то вернетесь в самое начало");
            ConsoleKeyInfo key = Console.ReadKey();
            if (key.Key == ConsoleKey.Enter)
            {
                coast = coast + 700;
                Console.SetCursorPosition(2, 2);
                Console.WriteLine("Итоговая сумма к оплате: " + coast);
            }
            if (key.Key == ConsoleKey.Escape)
            {
                str1();
            }

            string ZakazCoast = "К оплате: " + coast;
            string p = "";
            File.AppendAllText("C:\\Users\\PC_of_Matvey\\Desktop\\Zakaz.txt" + "<Заказ от текущая дата>", p);
            File.AppendAllText("C:\\Users\\PC_of_Matvey\\Desktop\\Zakaz.txt" + "<", Zakaz + ">");
            File.AppendAllText("C:\\Users\\PC_of_Matvey\\Desktop\\Zakaz.txt" + "Цена <", ZakazCoast + ">");

            Console.WriteLine("Если вы хотите сделать еще один заказ то нажмите Ентер");
            key = Console.ReadKey();
            if (key.Key == ConsoleKey.Enter)
            {
                str1();
            }
        }

        //нач квадр манговых красных
        static void KwadMangRad()
        {
            tort.big = "Большой";
            tort.small = "Маленький";
            tort.average = "Средний";

            Console.Clear();
            Console.SetCursorPosition(2, 0);
            Console.WriteLine("Размеры квадратных манговых красных тортов:");

            Console.SetCursorPosition(0, pos333);
            Console.WriteLine("->");

            Console.SetCursorPosition(2, 1);
            Console.WriteLine(tort.big);
            Console.SetCursorPosition(2, 2);
            Console.WriteLine(tort.small);
            Console.SetCursorPosition(2, 3);
            Console.WriteLine(tort.average);
            Console.SetCursorPosition(2, 4);
            Console.WriteLine("Общая стоимость равна: " + coast);

            ConsoleKeyInfo key = Console.ReadKey();

            while (true)
            {
                if (key.Key == ConsoleKey.DownArrow)
                {
                    pos333++;

                    if (pos333 < 4)
                    {
                        Console.SetCursorPosition(0, pos333);
                        Console.WriteLine("->");
                        Console.SetCursorPosition(0, pos333 - 1);
                        Console.WriteLine("  ");
                    }
                    else
                    {
                        pos333 = 1;
                        Console.SetCursorPosition(0, pos333);
                        Console.WriteLine("->");
                        Console.SetCursorPosition(0, pos333 + 2);
                        Console.WriteLine("  ");
                    }

                }//стрелка вниз
                if (key.Key == ConsoleKey.UpArrow)
                {
                    pos333--;
                    Console.SetCursorPosition(0, pos333);
                    Console.WriteLine("->");
                    Console.SetCursorPosition(0, pos333 + 1);
                    Console.WriteLine("  ");
                    if (pos333 <= 0)
                    {
                        pos333 = 4;
                        Console.SetCursorPosition(0, pos333 - 1);
                        Console.WriteLine("->");
                        Console.SetCursorPosition(0, pos333 - 4);
                        Console.WriteLine("  ");
                    }
                }//стрелка вверх
                if (key.Key == ConsoleKey.Escape)
                {
                    pstr1chok1();

                }//выход
                if (key.Key == ConsoleKey.Enter)
                {
                    if (pos333 == 1)
                    {
                        itog3333();
                    }
                    if (pos333 == 2)
                    {
                        itog3331();
                    }
                    if (pos333 == 3)
                    {
                        itog3332();
                    }
                }
                key = Console.ReadKey();
            }
        }
        //кон квадр манговых красных

        static void itog3331()
        {
            Console.Clear();
            string Zakaz = "манговый, квадратный, красный, малый торт";
            Console.SetCursorPosition(2, 0);
            Console.WriteLine("Значит вы сейчас выбрали " + Zakaz);
            Console.SetCursorPosition(2, 1);
            Console.WriteLine("Он стоит 500,если хотите купить, нажмите ентер, но если вы нажмете Эскейп то вернетесь в самое начало");
            ConsoleKeyInfo key = Console.ReadKey();
            if (key.Key == ConsoleKey.Enter)
            {
                coast = coast + 500;
                Console.SetCursorPosition(2, 2);
                Console.WriteLine("Итоговая сумма к оплате: " + coast);
            }
            if (key.Key == ConsoleKey.Escape)
            {
                str1();
            }

            string ZakazCoast = "К оплате: " + coast;
            string p = "";
            File.AppendAllText("C:\\Users\\PC_of_Matvey\\Desktop\\Zakaz.txt" + "<Заказ от текущая дата>", p);
            File.AppendAllText("C:\\Users\\PC_of_Matvey\\Desktop\\Zakaz.txt" + "<", Zakaz + ">");
            File.AppendAllText("C:\\Users\\PC_of_Matvey\\Desktop\\Zakaz.txt" + "Цена <", ZakazCoast + ">");

            Console.WriteLine("Если вы хотите сделать еще один заказ то нажмите Ентер");
            key = Console.ReadKey();
            if (key.Key == ConsoleKey.Enter)
            {
                str1();
            }
        }

        static void itog3332()
        {
            Console.Clear();
            string Zakaz = "манговый, квадратный, красный, средний торт";
            Console.SetCursorPosition(2, 0);
            Console.WriteLine("Значит вы сейчас выбрали " + Zakaz);
            Console.SetCursorPosition(2, 1);
            Console.WriteLine("Он стоит 600,если хотите купить, нажмите ентер, но если вы нажмете Эскейп то вернетесь в самое начало");
            ConsoleKeyInfo key = Console.ReadKey();
            if (key.Key == ConsoleKey.Enter)
            {
                coast = coast + 600;
                Console.SetCursorPosition(2, 2);
                Console.WriteLine("Итоговая сумма к оплате: " + coast);
            }
            if (key.Key == ConsoleKey.Escape)
            {
                str1();
            }

            string ZakazCoast = "К оплате: " + coast;
            string p = "";
            File.AppendAllText("C:\\Users\\PC_of_Matvey\\Desktop\\Zakaz.txt" + "<Заказ от текущая дата>", p);
            File.AppendAllText("C:\\Users\\PC_of_Matvey\\Desktop\\Zakaz.txt" + "<", Zakaz + ">");
            File.AppendAllText("C:\\Users\\PC_of_Matvey\\Desktop\\Zakaz.txt" + "Цена <", ZakazCoast + ">");

            Console.WriteLine("Если вы хотите сделать еще один заказ то нажмите Ентер");
            key = Console.ReadKey();
            if (key.Key == ConsoleKey.Enter)
            {
                str1();
            }
        }

        static void itog3333()
        {
            Console.Clear();
            string Zakaz = "манговый, квадратный, красный, большой торт";
            Console.SetCursorPosition(2, 0);
            Console.WriteLine("Значит вы сейчас выбрали " + Zakaz);
            Console.SetCursorPosition(2, 1);
            Console.WriteLine("Он стоит 700,если хотите купить, нажмите ентер, но если вы нажмете Эскейп то вернетесь в самое начало");
            ConsoleKeyInfo key = Console.ReadKey();
            if (key.Key == ConsoleKey.Enter)
            {
                coast = coast + 700;
                Console.SetCursorPosition(2, 2);
                Console.WriteLine("Итоговая сумма к оплате: " + coast);
            }
            if (key.Key == ConsoleKey.Escape)
            {
                str1();
            }

            string ZakazCoast = "К оплате: " + coast;
            string p = "";
            File.AppendAllText("C:\\Users\\PC_of_Matvey\\Desktop\\Zakaz.txt" + "<Заказ от текущая дата>", p);
            File.AppendAllText("C:\\Users\\PC_of_Matvey\\Desktop\\Zakaz.txt" + "<", Zakaz + ">");
            File.AppendAllText("C:\\Users\\PC_of_Matvey\\Desktop\\Zakaz.txt" + "Цена <", ZakazCoast + ">");

            Console.WriteLine("Если вы хотите сделать еще один заказ то нажмите Ентер");
            key = Console.ReadKey();
            if (key.Key == ConsoleKey.Enter)
            {
                str1();
            }
        }







        //начало шоколадных зайцев
        static void pstr1chok()
        {
            Class1 torty = new Class1();
            torty.name = "Круглый";
            Class1 tortyy = new Class1();
            tortyy.name = "Квадратный";
            Class1 ttortyy = new Class1();
            ttortyy.name = "Треугольный";

            Console.Clear();
            Console.SetCursorPosition(2, 0);
            Console.WriteLine("Виды шоколадных тортов:");

            Console.SetCursorPosition(0, pos3);
            Console.WriteLine("->");

            Console.SetCursorPosition(2, 1);
            Console.WriteLine(torty.name);
            Console.SetCursorPosition(2, 2);
            Console.WriteLine(tortyy.name);
            Console.SetCursorPosition(2, 3);
            Console.WriteLine(ttortyy.name);
            Console.SetCursorPosition(2, 4);
            Console.WriteLine("Общая стоимость равна: " + coast);

            ConsoleKeyInfo key = Console.ReadKey();

            while (true)
            {
                if (key.Key == ConsoleKey.DownArrow)
                {
                    pos3++;

                    if (pos3 < 4)
                    {
                        Console.SetCursorPosition(0, pos3);
                        Console.WriteLine("->");
                        Console.SetCursorPosition(0, pos3 - 1);
                        Console.WriteLine("  ");
                    }
                    else
                    {
                        pos3 = 1;
                        Console.SetCursorPosition(0, pos3);
                        Console.WriteLine("->");
                        Console.SetCursorPosition(0, pos3 + 2);
                        Console.WriteLine("  ");
                    }

                }//стрелка вниз
                if (key.Key == ConsoleKey.UpArrow)
                {
                    pos3--;
                    Console.SetCursorPosition(0, pos3);
                    Console.WriteLine("->");
                    Console.SetCursorPosition(0, pos3 + 1);
                    Console.WriteLine("  ");
                    if (pos3 <= 0)
                    {
                        pos3 = 4;
                        Console.SetCursorPosition(0, pos3 - 1);
                        Console.WriteLine("->");
                        Console.SetCursorPosition(0, pos3 - 4);
                        Console.WriteLine("  ");
                    }
                }//стрелка вверх
                if (key.Key == ConsoleKey.Escape)
                {
                    str1();

                }//выход
                if (key.Key == ConsoleKey.Enter)
                {
                    if (pos3 == 1)
                    {
                        ChocKrug();
                    }
                    if (pos3 == 2)
                    {
                        ChocSq();
                    }
                    if (pos3 == 3)
                    {
                        Choctriangular();
                    }
                }
                key = Console.ReadKey();
            }
        }//kon шоколадных 


        //нач шоколадный круглый 
        static void ChocKrug()
        {
            tort.yellow = "Желтый";
            tort.blue = "Синий";
            tort.red = "Красный";

            Console.Clear();
            Console.SetCursorPosition(2, 0);
            Console.WriteLine("Цвета круглых шоколадных тортов:");

            Console.SetCursorPosition(0, pos22);
            Console.WriteLine("->");

            Console.SetCursorPosition(2, 1);
            Console.WriteLine(tort.yellow);
            Console.SetCursorPosition(2, 2);
            Console.WriteLine(tort.blue);
            Console.SetCursorPosition(2, 3);
            Console.WriteLine(tort.red);
            Console.SetCursorPosition(2, 4);
            Console.WriteLine("Общая стоимость равна: " + coast);

            ConsoleKeyInfo key = Console.ReadKey();

            while (true)
            {
                if (key.Key == ConsoleKey.DownArrow)
                {
                    pos22++;

                    if (pos22 < 4)
                    {
                        Console.SetCursorPosition(0, pos22);
                        Console.WriteLine("->");
                        Console.SetCursorPosition(0, pos22 - 1);
                        Console.WriteLine("  ");
                    }
                    else
                    {
                        pos22 = 1;
                        Console.SetCursorPosition(0, pos22);
                        Console.WriteLine("->");
                        Console.SetCursorPosition(0, pos22 + 2);
                        Console.WriteLine("  ");
                    }

                }//стрелка вниз
                if (key.Key == ConsoleKey.UpArrow)
                {
                    pos22--;
                    Console.SetCursorPosition(0, pos22);
                    Console.WriteLine("->");
                    Console.SetCursorPosition(0, pos22 + 1);
                    Console.WriteLine("  ");
                    if (pos22 <= 0)
                    {
                        pos22 = 4;
                        Console.SetCursorPosition(0, pos22 - 1);
                        Console.WriteLine("->");
                        Console.SetCursorPosition(0, pos22 - 4);
                        Console.WriteLine("  ");
                    }
                }//стрелка вверх
                if (key.Key == ConsoleKey.Escape)
                {
                    pstr1chok();

                }//выход
                if (key.Key == ConsoleKey.Enter)
                {
                    if (pos22 == 1)
                    {
                        Chockruggelt();
                    }
                    if (pos22 == 2)
                    {
                        ChockrugBlue();
                    }
                    if (pos22 == 3)
                    {
                        ChockrugRad();
                    }
                }
                key = Console.ReadKey();
            }
        }
        //кон шоколадный круглый 

        //нач шоколад круг желт
        static void Chockruggelt()
        {
            tort.big = "Большой";
            tort.small = "Маленький";
            tort.average = "Средний";

            Console.Clear();
            Console.SetCursorPosition(2, 0);
            Console.WriteLine("Размеры круглых шоколадных желтых тортов:");

            Console.SetCursorPosition(0, pos211);
            Console.WriteLine("->");

            Console.SetCursorPosition(2, 1);
            Console.WriteLine(tort.big);
            Console.SetCursorPosition(2, 2);
            Console.WriteLine(tort.small);
            Console.SetCursorPosition(2, 3);
            Console.WriteLine(tort.average);
            Console.SetCursorPosition(2, 4);
            Console.WriteLine("Общая стоимость равна: " + coast);

            ConsoleKeyInfo key = Console.ReadKey();

            while (true)
            {
                if (key.Key == ConsoleKey.DownArrow)
                {
                    pos211++;

                    if (pos211 < 4)
                    {
                        Console.SetCursorPosition(0, pos211);
                        Console.WriteLine("->");
                        Console.SetCursorPosition(0, pos211 - 1);
                        Console.WriteLine("  ");
                    }
                    else
                    {
                        pos211 = 1;
                        Console.SetCursorPosition(0, pos211);
                        Console.WriteLine("->");
                        Console.SetCursorPosition(0, pos211 + 2);
                        Console.WriteLine("  ");
                    }

                }//стрелка вниз
                if (key.Key == ConsoleKey.UpArrow)
                {
                    pos211--;
                    Console.SetCursorPosition(0, pos211);
                    Console.WriteLine("->");
                    Console.SetCursorPosition(0, pos211 + 1);
                    Console.WriteLine("  ");
                    if (pos211 <= 0)
                    {
                        pos211 = 4;
                        Console.SetCursorPosition(0, pos211 - 1);
                        Console.WriteLine("->");
                        Console.SetCursorPosition(0, pos211 - 4);
                        Console.WriteLine("  ");
                    }
                }//стрелка вверх
                if (key.Key == ConsoleKey.Escape)
                {
                    ChocKrug();

                }//выход
                if (key.Key == ConsoleKey.Enter)
                {
                    if (pos211 == 1)
                    {
                        itog2113();
                    }
                    if (pos211 == 2)
                    {
                        itog2111();
                    }
                    if (pos211 == 3)
                    {
                        itog2112();
                    }
                }
                key = Console.ReadKey();
            }
        }
        //кон шоколад круг желт

        static void itog2111()
        {
            Console.Clear();
            string Zakaz = "шоколадный, круглый, желтый, малый торт";
            Console.SetCursorPosition(2, 0);
            Console.WriteLine("Значит вы сейчас выбрали " + Zakaz);
            Console.SetCursorPosition(2, 1);
            Console.WriteLine("Он стоит 500,если хотите купить, нажмите ентер, но если вы нажмете Эскейп то вернетесь в самое начало");
            ConsoleKeyInfo key = Console.ReadKey();
            if (key.Key == ConsoleKey.Enter)
            {
                coast = coast + 500;
                Console.SetCursorPosition(2, 2);
                Console.WriteLine("Итоговая сумма к оплате: " + coast);
            }
            if (key.Key == ConsoleKey.Escape)
            {
                str1();
            }

            string ZakazCoast = "К оплате: " + coast;
            string p = "";
            File.AppendAllText("C:\\Users\\PC_of_Matvey\\Desktop\\Zakaz.txt" + "<Заказ от текущая дата>", p);
            File.AppendAllText("C:\\Users\\PC_of_Matvey\\Desktop\\Zakaz.txt" + "<", Zakaz + ">");
            File.AppendAllText("C:\\Users\\PC_of_Matvey\\Desktop\\Zakaz.txt" + "Цена <", ZakazCoast + ">");

            Console.WriteLine("Если вы хотите сделать еще один заказ то нажмите Ентер");
            key = Console.ReadKey();
            if (key.Key == ConsoleKey.Enter)
            {
                str1();
            }
        }

        static void itog2112()
        {
            Console.Clear();
            string Zakaz = "шоколадный, круглый, желтый, средний торт";
            Console.SetCursorPosition(2, 0);
            Console.WriteLine("Значит вы сейчас выбрали " + Zakaz);
            Console.SetCursorPosition(2, 1);
            Console.WriteLine("Он стоит 600,если хотите купить, нажмите ентер, но если вы нажмете Эскейп то вернетесь в самое начало");
            ConsoleKeyInfo key = Console.ReadKey();
            if (key.Key == ConsoleKey.Enter)
            {
                coast = coast + 600;
                Console.SetCursorPosition(2, 2);
                Console.WriteLine("Итоговая сумма к оплате: " + coast);
            }
            if (key.Key == ConsoleKey.Escape)
            {
                str1();
            }

            string ZakazCoast = "К оплате: " + coast;
            string p = "";
            File.AppendAllText("C:\\Users\\PC_of_Matvey\\Desktop\\Zakaz.txt" + "<Заказ от текущая дата>", p);
            File.AppendAllText("C:\\Users\\PC_of_Matvey\\Desktop\\Zakaz.txt" + "<", Zakaz + ">");
            File.AppendAllText("C:\\Users\\PC_of_Matvey\\Desktop\\Zakaz.txt" + "Цена <", ZakazCoast + ">");

            Console.WriteLine("Если вы хотите сделать еще один заказ то нажмите Ентер");
            key = Console.ReadKey();
            if (key.Key == ConsoleKey.Enter)
            {
                str1();
            }
        }

        static void itog2113()
        {
            Console.Clear();
            string Zakaz = "шоколадный, круглый, желтый, большой торт";
            Console.SetCursorPosition(2, 0);
            Console.WriteLine("Значит вы сейчас выбрали " + Zakaz);
            Console.SetCursorPosition(2, 1);
            Console.WriteLine("Он стоит 700,если хотите купить, нажмите ентер, но если вы нажмете Эскейп то вернетесь в самое начало");
            ConsoleKeyInfo key = Console.ReadKey();
            if (key.Key == ConsoleKey.Enter)
            {
                coast = coast + 700;
                Console.SetCursorPosition(2, 2);
                Console.WriteLine("Итоговая сумма к оплате: " + coast);
            }
            if (key.Key == ConsoleKey.Escape)
            {
                str1();
            }

            string ZakazCoast = "К оплате: " + coast;
            string p = "";
            File.AppendAllText("C:\\Users\\PC_of_Matvey\\Desktop\\Zakaz.txt" + "<Заказ от текущая дата>", p);
            File.AppendAllText("C:\\Users\\PC_of_Matvey\\Desktop\\Zakaz.txt" + "<", Zakaz + ">");
            File.AppendAllText("C:\\Users\\PC_of_Matvey\\Desktop\\Zakaz.txt" + "Цена <", ZakazCoast + ">");

            Console.WriteLine("Если вы хотите сделать еще один заказ то нажмите Ентер");
            key = Console.ReadKey();
            if (key.Key == ConsoleKey.Enter)
            {
                str1();
            }
        }

        //нач шоколад круг син
        static void ChockrugBlue()
        {
            tort.big = "Большой";
            tort.small = "Маленький";
            tort.average = "Средний";

            Console.Clear();
            Console.SetCursorPosition(2, 0);
            Console.WriteLine("Размеры круглых шоколадных синих тортов:");

            Console.SetCursorPosition(0, pos212);
            Console.WriteLine("->");

            Console.SetCursorPosition(2, 1);
            Console.WriteLine(tort.big);
            Console.SetCursorPosition(2, 2);
            Console.WriteLine(tort.small);
            Console.SetCursorPosition(2, 3);
            Console.WriteLine(tort.average);
            Console.SetCursorPosition(2, 4);
            Console.WriteLine("Общая стоимость равна: " + coast);

            ConsoleKeyInfo key = Console.ReadKey();

            while (true)
            {
                if (key.Key == ConsoleKey.DownArrow)
                {
                    pos212++;

                    if (pos212 < 4)
                    {
                        Console.SetCursorPosition(0, pos212);
                        Console.WriteLine("->");
                        Console.SetCursorPosition(0, pos212 - 1);
                        Console.WriteLine("  ");
                    }
                    else
                    {
                        pos212 = 1;
                        Console.SetCursorPosition(0, pos212);
                        Console.WriteLine("->");
                        Console.SetCursorPosition(0, pos212 + 2);
                        Console.WriteLine("  ");
                    }

                }//стрелка вниз
                if (key.Key == ConsoleKey.UpArrow)
                {
                    pos212--;
                    Console.SetCursorPosition(0, pos212);
                    Console.WriteLine("->");
                    Console.SetCursorPosition(0, pos212 + 1);
                    Console.WriteLine("  ");
                    if (pos212 <= 0)
                    {
                        pos212 = 4;
                        Console.SetCursorPosition(0, pos212 - 1);
                        Console.WriteLine("->");
                        Console.SetCursorPosition(0, pos212 - 4);
                        Console.WriteLine("  ");
                    }
                }//стрелка вверх
                if (key.Key == ConsoleKey.Escape)
                {
                    ChocKrug();

                }//выход
                if (key.Key == ConsoleKey.Enter)
                {
                    if (pos212 == 1)
                    {
                        itog2123();
                    }
                    if (pos212 == 2)
                    {
                        itog2121();
                    }
                    if (pos212 == 3)
                    {
                        itog2122();
                    }
                }
                key = Console.ReadKey();
            }
        }
        //кон шоколад круг син

        static void itog2121()
        {
            Console.Clear();
            string Zakaz = "шоколадный, круглый, синий, малый торт";
            Console.SetCursorPosition(2, 0);
            Console.WriteLine("Значит вы сейчас выбрали " + Zakaz);
            Console.SetCursorPosition(2, 1);
            Console.WriteLine("Он стоит 500,если хотите купить, нажмите ентер, но если вы нажмете Эскейп то вернетесь в самое начало");
            ConsoleKeyInfo key = Console.ReadKey();
            if (key.Key == ConsoleKey.Enter)
            {
                coast = coast + 500;
                Console.SetCursorPosition(2, 2);
                Console.WriteLine("Итоговая сумма к оплате: " + coast);
            }
            if (key.Key == ConsoleKey.Escape)
            {
                str1();
            }

            string ZakazCoast = "К оплате: " + coast;
            string p = "";
            File.AppendAllText("C:\\Users\\PC_of_Matvey\\Desktop\\Zakaz.txt" + "<Заказ от текущая дата>", p);
            File.AppendAllText("C:\\Users\\PC_of_Matvey\\Desktop\\Zakaz.txt" + "<", Zakaz + ">");
            File.AppendAllText("C:\\Users\\PC_of_Matvey\\Desktop\\Zakaz.txt" + "Цена <", ZakazCoast + ">");

            Console.WriteLine("Если вы хотите сделать еще один заказ то нажмите Ентер");
            key = Console.ReadKey();
            if (key.Key == ConsoleKey.Enter)
            {
                str1();
            }
        }

        static void itog2122()
        {
            Console.Clear();
            string Zakaz = "шоколадный, круглый, синий, средний торт";
            Console.SetCursorPosition(2, 0);
            Console.WriteLine("Значит вы сейчас выбрали " + Zakaz);
            Console.SetCursorPosition(2, 1);
            Console.WriteLine("Он стоит 600,если хотите купить, нажмите ентер, но если вы нажмете Эскейп то вернетесь в самое начало");
            ConsoleKeyInfo key = Console.ReadKey();
            if (key.Key == ConsoleKey.Enter)
            {
                coast = coast + 600;
                Console.SetCursorPosition(2, 2);
                Console.WriteLine("Итоговая сумма к оплате: " + coast);
            }
            if (key.Key == ConsoleKey.Escape)
            {
                str1();
            }

            string ZakazCoast = "К оплате: " + coast;
            string p = "";
            File.AppendAllText("C:\\Users\\PC_of_Matvey\\Desktop\\Zakaz.txt" + "<Заказ от текущая дата>", p);
            File.AppendAllText("C:\\Users\\PC_of_Matvey\\Desktop\\Zakaz.txt" + "<", Zakaz + ">");
            File.AppendAllText("C:\\Users\\PC_of_Matvey\\Desktop\\Zakaz.txt" + "Цена <", ZakazCoast + ">");

            Console.WriteLine("Если вы хотите сделать еще один заказ то нажмите Ентер");
            key = Console.ReadKey();
            if (key.Key == ConsoleKey.Enter)
            {
                str1();
            }
        }

        static void itog2123()
        {
            Console.Clear();
            string Zakaz = "шоколадный, круглый, синий, большой торт";
            Console.SetCursorPosition(2, 0);
            Console.WriteLine("Значит вы сейчас выбрали " + Zakaz);
            Console.SetCursorPosition(2, 1);
            Console.WriteLine("Он стоит 700,если хотите купить, нажмите ентер, но если вы нажмете Эскейп то вернетесь в самое начало");
            ConsoleKeyInfo key = Console.ReadKey();
            if (key.Key == ConsoleKey.Enter)
            {
                coast = coast + 700;
                Console.SetCursorPosition(2, 2);
                Console.WriteLine("Итоговая сумма к оплате: " + coast);
            }
            if (key.Key == ConsoleKey.Escape)
            {
                str1();
            }

            string ZakazCoast = "К оплате: " + coast;
            string p = "";
            File.AppendAllText("C:\\Users\\PC_of_Matvey\\Desktop\\Zakaz.txt" + "<Заказ от текущая дата>", p);
            File.AppendAllText("C:\\Users\\PC_of_Matvey\\Desktop\\Zakaz.txt" + "<", Zakaz + ">");
            File.AppendAllText("C:\\Users\\PC_of_Matvey\\Desktop\\Zakaz.txt" + "Цена <", ZakazCoast + ">");

            Console.WriteLine("Если вы хотите сделать еще один заказ то нажмите Ентер");
            key = Console.ReadKey();
            if (key.Key == ConsoleKey.Enter)
            {
                str1();
            }
        }

        //нач шоколад круг красн
        static void ChockrugRad()
        {
            tort.big = "Большой";
            tort.small = "Маленький";
            tort.average = "Средний";

            Console.Clear();
            Console.SetCursorPosition(2, 0);
            Console.WriteLine("Размеры круглых шоколадных красных тортов:");

            Console.SetCursorPosition(0, pos213);
            Console.WriteLine("->");

            Console.SetCursorPosition(2, 1);
            Console.WriteLine(tort.big);
            Console.SetCursorPosition(2, 2);
            Console.WriteLine(tort.small);
            Console.SetCursorPosition(2, 3);
            Console.WriteLine(tort.average);
            Console.SetCursorPosition(2, 4);
            Console.WriteLine("Общая стоимость равна: " + coast);

            ConsoleKeyInfo key = Console.ReadKey();

            while (true)
            {
                if (key.Key == ConsoleKey.DownArrow)
                {
                    pos213++;

                    if (pos213 < 4)
                    {
                        Console.SetCursorPosition(0, pos213);
                        Console.WriteLine("->");
                        Console.SetCursorPosition(0, pos213 - 1);
                        Console.WriteLine("  ");
                    }
                    else
                    {
                        pos213 = 1;
                        Console.SetCursorPosition(0, pos213);
                        Console.WriteLine("->");
                        Console.SetCursorPosition(0, pos213 + 2);
                        Console.WriteLine("  ");
                    }

                }//стрелка вниз
                if (key.Key == ConsoleKey.UpArrow)
                {
                    pos213--;
                    Console.SetCursorPosition(0, pos213);
                    Console.WriteLine("->");
                    Console.SetCursorPosition(0, pos213 + 1);
                    Console.WriteLine("  ");
                    if (pos213 <= 0)
                    {
                        pos213 = 4;
                        Console.SetCursorPosition(0, pos213 - 1);
                        Console.WriteLine("->");
                        Console.SetCursorPosition(0, pos213 - 4);
                        Console.WriteLine("  ");
                    }
                }//стрелка вверх
                if (key.Key == ConsoleKey.Escape)
                {
                    ChocKrug();

                }//выход
                if (key.Key == ConsoleKey.Enter)
                {
                    if (pos213 == 1)
                    {
                        itog2133();
                    }
                    if (pos213 == 2)
                    {
                        itog2131();
                    }
                    if (pos213 == 3)
                    {
                        itog2132();
                    }
                }
                key = Console.ReadKey();
            }
        }
        //кон шоколад круг красн

        static void itog2131()
        {
            Console.Clear();
            string Zakaz = "шоколадный, круглый, красный, малый торт";
            Console.SetCursorPosition(2, 0);
            Console.WriteLine("Значит вы сейчас выбрали " + Zakaz);
            Console.SetCursorPosition(2, 1);
            Console.WriteLine("Он стоит 500,если хотите купить, нажмите ентер, но если вы нажмете Эскейп то вернетесь в самое начало");
            ConsoleKeyInfo key = Console.ReadKey();
            if (key.Key == ConsoleKey.Enter)
            {
                coast = coast + 500;
                Console.SetCursorPosition(2, 2);
                Console.WriteLine("Итоговая сумма к оплате: " + coast);
            }
            if (key.Key == ConsoleKey.Escape)
            {
                str1();
            }

            string ZakazCoast = "К оплате: " + coast;
            string p = "";
            File.AppendAllText("C:\\Users\\PC_of_Matvey\\Desktop\\Zakaz.txt" + "<Заказ от текущая дата>", p);
            File.AppendAllText("C:\\Users\\PC_of_Matvey\\Desktop\\Zakaz.txt" + "<", Zakaz + ">");
            File.AppendAllText("C:\\Users\\PC_of_Matvey\\Desktop\\Zakaz.txt" + "Цена <", ZakazCoast + ">");

            Console.WriteLine("Если вы хотите сделать еще один заказ то нажмите Ентер");
            key = Console.ReadKey();
            if (key.Key == ConsoleKey.Enter)
            {
                str1();
            }
        }

        static void itog2132()
        {
            Console.Clear();
            string Zakaz = "шоколадный, круглый, красный, средний торт";
            Console.SetCursorPosition(2, 0);
            Console.WriteLine("Значит вы сейчас выбрали " + Zakaz);
            Console.SetCursorPosition(2, 1);
            Console.WriteLine("Он стоит 600,если хотите купить, нажмите ентер, но если вы нажмете Эскейп то вернетесь в самое начало");
            ConsoleKeyInfo key = Console.ReadKey();
            if (key.Key == ConsoleKey.Enter)
            {
                coast = coast + 600;
                Console.SetCursorPosition(2, 2);
                Console.WriteLine("Итоговая сумма к оплате: " + coast);
            }
            if (key.Key == ConsoleKey.Escape)
            {
                str1();
            }

            string ZakazCoast = "К оплате: " + coast;
            string p = "";
            File.AppendAllText("C:\\Users\\PC_of_Matvey\\Desktop\\Zakaz.txt" + "<Заказ от текущая дата>", p);
            File.AppendAllText("C:\\Users\\PC_of_Matvey\\Desktop\\Zakaz.txt" + "<", Zakaz + ">");
            File.AppendAllText("C:\\Users\\PC_of_Matvey\\Desktop\\Zakaz.txt" + "Цена <", ZakazCoast + ">");

            Console.WriteLine("Если вы хотите сделать еще один заказ то нажмите Ентер");
            key = Console.ReadKey();
            if (key.Key == ConsoleKey.Enter)
            {
                str1();
            }
        }

        static void itog2133()
        {
            Console.Clear();
            string Zakaz = "шоколадный, круглый, красный, большой торт";
            Console.SetCursorPosition(2, 0);
            Console.WriteLine("Значит вы сейчас выбрали " + Zakaz);
            Console.SetCursorPosition(2, 1);
            Console.WriteLine("Он стоит 700,если хотите купить, нажмите ентер, но если вы нажмете Эскейп то вернетесь в самое начало");
            ConsoleKeyInfo key = Console.ReadKey();
            if (key.Key == ConsoleKey.Enter)
            {
                coast = coast + 700;
                Console.SetCursorPosition(2, 2);
                Console.WriteLine("Итоговая сумма к оплате: " + coast);
            }
            if (key.Key == ConsoleKey.Escape)
            {
                str1();
            }

            string ZakazCoast = "К оплате: " + coast;
            string p = "";
            File.AppendAllText("C:\\Users\\PC_of_Matvey\\Desktop\\Zakaz.txt" + "<Заказ от текущая дата>", p);
            File.AppendAllText("C:\\Users\\PC_of_Matvey\\Desktop\\Zakaz.txt" + "<", Zakaz + ">");
            File.AppendAllText("C:\\Users\\PC_of_Matvey\\Desktop\\Zakaz.txt" + "Цена <", ZakazCoast + ">");

            Console.WriteLine("Если вы хотите сделать еще один заказ то нажмите Ентер");
            key = Console.ReadKey();
            if (key.Key == ConsoleKey.Enter)
            {
                str1();
            }
        }

        //нач шоколадный квад 
        static void ChocSq()
        {
            tort.yellow = "Желтый";
            tort.blue = "Синий";
            tort.red = "Красный";

            Console.Clear();
            Console.SetCursorPosition(2, 0);
            Console.WriteLine("Цвета квадратных шоколадных тортов:");

            Console.SetCursorPosition(0, pos21);
            Console.WriteLine("->");

            Console.SetCursorPosition(2, 1);
            Console.WriteLine(tort.yellow);
            Console.SetCursorPosition(2, 2);
            Console.WriteLine(tort.blue);
            Console.SetCursorPosition(2, 3);
            Console.WriteLine(tort.red);
            Console.SetCursorPosition(2, 4);
            Console.WriteLine("Общая стоимость равна: " + coast);

            ConsoleKeyInfo key = Console.ReadKey();

            while (true)
            {
                if (key.Key == ConsoleKey.DownArrow)
                {
                    pos21++;

                    if (pos21 < 4)
                    {
                        Console.SetCursorPosition(0, pos21);
                        Console.WriteLine("->");
                        Console.SetCursorPosition(0, pos21 - 1);
                        Console.WriteLine("  ");
                    }
                    else
                    {
                        pos21 = 1;
                        Console.SetCursorPosition(0, pos21);
                        Console.WriteLine("->");
                        Console.SetCursorPosition(0, pos21 + 2);
                        Console.WriteLine("  ");
                    }

                }//стрелка вниз
                if (key.Key == ConsoleKey.UpArrow)
                {
                    pos21--;
                    Console.SetCursorPosition(0, pos21);
                    Console.WriteLine("->");
                    Console.SetCursorPosition(0, pos21 + 1);
                    Console.WriteLine("  ");
                    if (pos21 <= 0)
                    {
                        pos21 = 4;
                        Console.SetCursorPosition(0, pos21 - 1);
                        Console.WriteLine("->");
                        Console.SetCursorPosition(0, pos21 - 4);
                        Console.WriteLine("  ");
                    }
                }//стрелка вверх
                if (key.Key == ConsoleKey.Escape)
                {
                    pstr1chok();

                }//выход
                if (key.Key == ConsoleKey.Enter)
                {
                    if (pos21 == 1)
                    {
                        ChokSqGelt();
                    }
                    if (pos21 == 2)
                    {
                        ChokSqBlue();
                    }
                    if (pos21 == 3)
                    {
                        ChokSqRad();
                    }
                }
                key = Console.ReadKey();
            }
        }

        //кон шоколадный квад 

        //нач шоколад квад желт
        static void ChokSqGelt()
        {
            tort.big = "Большой";
            tort.small = "Маленький";
            tort.average = "Средний";

            Console.Clear();
            Console.SetCursorPosition(2, 0);
            Console.WriteLine("Размеры квадратных шоколадных желтых тортов:");

            Console.SetCursorPosition(0, pos221);
            Console.WriteLine("->");

            Console.SetCursorPosition(2, 1);
            Console.WriteLine(tort.big);
            Console.SetCursorPosition(2, 2);
            Console.WriteLine(tort.small);
            Console.SetCursorPosition(2, 3);
            Console.WriteLine(tort.average);
            Console.SetCursorPosition(2, 4);
            Console.WriteLine("Общая стоимость равна: " + coast);

            ConsoleKeyInfo key = Console.ReadKey();

            while (true)
            {
                if (key.Key == ConsoleKey.DownArrow)
                {
                    pos221++;

                    if (pos221 < 4)
                    {
                        Console.SetCursorPosition(0, pos221);
                        Console.WriteLine("->");
                        Console.SetCursorPosition(0, pos221 - 1);
                        Console.WriteLine("  ");
                    }
                    else
                    {
                        pos221 = 1;
                        Console.SetCursorPosition(0, pos221);
                        Console.WriteLine("->");
                        Console.SetCursorPosition(0, pos221 + 2);
                        Console.WriteLine("  ");
                    }

                }//стрелка вниз
                if (key.Key == ConsoleKey.UpArrow)
                {
                    pos221--;
                    Console.SetCursorPosition(0, pos221);
                    Console.WriteLine("->");
                    Console.SetCursorPosition(0, pos221 + 1);
                    Console.WriteLine("  ");
                    if (pos221 <= 0)
                    {
                        pos221 = 4;
                        Console.SetCursorPosition(0, pos221 - 1);
                        Console.WriteLine("->");
                        Console.SetCursorPosition(0, pos221 - 4);
                        Console.WriteLine("  ");
                    }
                }//стрелка вверх
                if (key.Key == ConsoleKey.Escape)
                {
                    ChocSq();

                }//выход
                if (key.Key == ConsoleKey.Enter)
                {
                    if (pos221 == 1)
                    {
                        itog2213();
                    }
                    if (pos221 == 2)
                    {
                        itog2211();
                    }
                    if (pos221 == 3)
                    {
                        itog2212();
                    }
                }
                key = Console.ReadKey();
            }
        }
        //кон шоколад квад желт

        static void itog2211()
        {
            Console.Clear();
            string Zakaz = "шоколадный, квадратный, желтый, малый торт";
            Console.SetCursorPosition(2, 0);
            Console.WriteLine("Значит вы сейчас выбрали " + Zakaz);
            Console.SetCursorPosition(2, 1);
            Console.WriteLine("Он стоит 500,если хотите купить, нажмите ентер, но если вы нажмете Эскейп то вернетесь в самое начало");
            ConsoleKeyInfo key = Console.ReadKey();
            if (key.Key == ConsoleKey.Enter)
            {
                coast = coast + 500;
                Console.SetCursorPosition(2, 2);
                Console.WriteLine("Итоговая сумма к оплате: " + coast);
            }
            if (key.Key == ConsoleKey.Escape)
            {
                str1();
            }

            string ZakazCoast = "К оплате: " + coast;
            string p = "";
            File.AppendAllText("C:\\Users\\PC_of_Matvey\\Desktop\\Zakaz.txt" + "<Заказ от текущая дата>", p);
            File.AppendAllText("C:\\Users\\PC_of_Matvey\\Desktop\\Zakaz.txt" + "<", Zakaz + ">");
            File.AppendAllText("C:\\Users\\PC_of_Matvey\\Desktop\\Zakaz.txt" + "Цена <", ZakazCoast + ">");

            Console.WriteLine("Если вы хотите сделать еще один заказ то нажмите Ентер");
            key = Console.ReadKey();
            if (key.Key == ConsoleKey.Enter)
            {
                str1();
            }
        }

        static void itog2212()
        {
            Console.Clear();
            string Zakaz = "шоколадный, квадратный, желтый, средний торт";
            Console.SetCursorPosition(2, 0);
            Console.WriteLine("Значит вы сейчас выбрали " + Zakaz);
            Console.SetCursorPosition(2, 1);
            Console.WriteLine("Он стоит 600,если хотите купить, нажмите ентер, но если вы нажмете Эскейп то вернетесь в самое начало");
            ConsoleKeyInfo key = Console.ReadKey();
            if (key.Key == ConsoleKey.Enter)
            {
                coast = coast + 600;
                Console.SetCursorPosition(2, 2);
                Console.WriteLine("Итоговая сумма к оплате: " + coast);
            }
            if (key.Key == ConsoleKey.Escape)
            {
                str1();
            }

            string ZakazCoast = "К оплате: " + coast;
            string p = "";
            File.AppendAllText("C:\\Users\\PC_of_Matvey\\Desktop\\Zakaz.txt" + "<Заказ от текущая дата>", p);
            File.AppendAllText("C:\\Users\\PC_of_Matvey\\Desktop\\Zakaz.txt" + "<", Zakaz + ">");
            File.AppendAllText("C:\\Users\\PC_of_Matvey\\Desktop\\Zakaz.txt" + "Цена <", ZakazCoast + ">");

            Console.WriteLine("Если вы хотите сделать еще один заказ то нажмите Ентер");
            key = Console.ReadKey();
            if (key.Key == ConsoleKey.Enter)
            {
                str1();
            }
        }

        static void itog2213()
        {
            Console.Clear();
            string Zakaz = "шоколадный, квадратный, желтый, большой торт";
            Console.SetCursorPosition(2, 0);
            Console.WriteLine("Значит вы сейчас выбрали " + Zakaz);
            Console.SetCursorPosition(2, 1);
            Console.WriteLine("Он стоит 700,если хотите купить, нажмите ентер, но если вы нажмете Эскейп то вернетесь в самое начало");
            ConsoleKeyInfo key = Console.ReadKey();
            if (key.Key == ConsoleKey.Enter)
            {
                coast = coast + 700;
                Console.SetCursorPosition(2, 2);
                Console.WriteLine("Итоговая сумма к оплате: " + coast);
            }
            if (key.Key == ConsoleKey.Escape)
            {
                str1();
            }

            string ZakazCoast = "К оплате: " + coast;
            string p = "";
            File.AppendAllText("C:\\Users\\PC_of_Matvey\\Desktop\\Zakaz.txt" + "<Заказ от текущая дата>", p);
            File.AppendAllText("C:\\Users\\PC_of_Matvey\\Desktop\\Zakaz.txt" + "<", Zakaz + ">");
            File.AppendAllText("C:\\Users\\PC_of_Matvey\\Desktop\\Zakaz.txt" + "Цена <", ZakazCoast + ">");

            Console.WriteLine("Если вы хотите сделать еще один заказ то нажмите Ентер");
            key = Console.ReadKey();
            if (key.Key == ConsoleKey.Enter)
            {
                str1();
            }
        }

        //нач шоколад квад син
        static void ChokSqBlue()
        {
            tort.big = "Большой";
            tort.small = "Маленький";
            tort.average = "Средний";

            Console.Clear();
            Console.SetCursorPosition(2, 0);
            Console.WriteLine("Размеры квадратных шоколадных синих тортов:");

            Console.SetCursorPosition(0, pos222);
            Console.WriteLine("->");

            Console.SetCursorPosition(2, 1);
            Console.WriteLine(tort.big);
            Console.SetCursorPosition(2, 2);
            Console.WriteLine(tort.small);
            Console.SetCursorPosition(2, 3);
            Console.WriteLine(tort.average);
            Console.SetCursorPosition(2, 4);
            Console.WriteLine("Общая стоимость равна: " + coast);

            ConsoleKeyInfo key = Console.ReadKey();

            while (true)
            {
                if (key.Key == ConsoleKey.DownArrow)
                {
                    pos222++;

                    if (pos222 < 4)
                    {
                        Console.SetCursorPosition(0, pos222);
                        Console.WriteLine("->");
                        Console.SetCursorPosition(0, pos222 - 1);
                        Console.WriteLine("  ");
                    }
                    else
                    {
                        pos222 = 1;
                        Console.SetCursorPosition(0, pos222);
                        Console.WriteLine("->");
                        Console.SetCursorPosition(0, pos222 + 2);
                        Console.WriteLine("  ");
                    }

                }//стрелка вниз
                if (key.Key == ConsoleKey.UpArrow)
                {
                    pos222--;
                    Console.SetCursorPosition(0, pos222);
                    Console.WriteLine("->");
                    Console.SetCursorPosition(0, pos222 + 1);
                    Console.WriteLine("  ");
                    if (pos222 <= 0)
                    {
                        pos222 = 4;
                        Console.SetCursorPosition(0, pos222 - 1);
                        Console.WriteLine("->");
                        Console.SetCursorPosition(0, pos222 - 4);
                        Console.WriteLine("  ");
                    }
                }//стрелка вверх
                if (key.Key == ConsoleKey.Escape)
                {
                    ChocSq();

                }//выход
                if (key.Key == ConsoleKey.Enter)
                {
                    if (pos222 == 1)
                    {
                        itog2223();
                    }
                    if (pos222 == 2)
                    {
                        itog2221();
                    }
                    if (pos222 == 3)
                    {
                        itog2222();
                    }
                }
                key = Console.ReadKey();
            }
        }
        //кон шоколад квад син

        static void itog2221()
        {
            Console.Clear();
            string Zakaz = "шоколадный, квадратный, синий, малый торт";
            Console.SetCursorPosition(2, 0);
            Console.WriteLine("Значит вы сейчас выбрали " + Zakaz);
            Console.SetCursorPosition(2, 1);
            Console.WriteLine("Он стоит 500,если хотите купить, нажмите ентер, но если вы нажмете Эскейп то вернетесь в самое начало");
            ConsoleKeyInfo key = Console.ReadKey();
            if (key.Key == ConsoleKey.Enter)
            {
                coast = coast + 500;
                Console.SetCursorPosition(2, 2);
                Console.WriteLine("Итоговая сумма к оплате: " + coast);
            }
            if (key.Key == ConsoleKey.Escape)
            {
                str1();
            }

            string ZakazCoast = "К оплате: " + coast;
            string p = "";
            File.AppendAllText("C:\\Users\\PC_of_Matvey\\Desktop\\Zakaz.txt" + "<Заказ от текущая дата>", p);
            File.AppendAllText("C:\\Users\\PC_of_Matvey\\Desktop\\Zakaz.txt" + "<", Zakaz + ">");
            File.AppendAllText("C:\\Users\\PC_of_Matvey\\Desktop\\Zakaz.txt" + "Цена <", ZakazCoast + ">");

            Console.WriteLine("Если вы хотите сделать еще один заказ то нажмите Ентер");
            key = Console.ReadKey();
            if (key.Key == ConsoleKey.Enter)
            {
                str1();
            }
        }

        static void itog2222()
        {
            Console.Clear();
            string Zakaz = "шоколадный, квадратный, синий, средний торт";
            Console.SetCursorPosition(2, 0);
            Console.WriteLine("Значит вы сейчас выбрали " + Zakaz);
            Console.SetCursorPosition(2, 1);
            Console.WriteLine("Он стоит 600,если хотите купить, нажмите ентер, но если вы нажмете Эскейп то вернетесь в самое начало");
            ConsoleKeyInfo key = Console.ReadKey();
            if (key.Key == ConsoleKey.Enter)
            {
                coast = coast + 600;
                Console.SetCursorPosition(2, 2);
                Console.WriteLine("Итоговая сумма к оплате: " + coast);
            }
            if (key.Key == ConsoleKey.Escape)
            {
                str1();
            }

            string ZakazCoast = "К оплате: " + coast;
            string p = "";
            File.AppendAllText("C:\\Users\\PC_of_Matvey\\Desktop\\Zakaz.txt" + "<Заказ от текущая дата>", p);
            File.AppendAllText("C:\\Users\\PC_of_Matvey\\Desktop\\Zakaz.txt" + "<", Zakaz + ">");
            File.AppendAllText("C:\\Users\\PC_of_Matvey\\Desktop\\Zakaz.txt" + "Цена <", ZakazCoast + ">");

            Console.WriteLine("Если вы хотите сделать еще один заказ то нажмите Ентер");
            key = Console.ReadKey();
            if (key.Key == ConsoleKey.Enter)
            {
                str1();
            }
        }

        static void itog2223()
        {
            Console.Clear();
            string Zakaz = "шоколадный, квадратный, синий, большой торт";
            Console.SetCursorPosition(2, 0);
            Console.WriteLine("Значит вы сейчас выбрали " + Zakaz);
            Console.SetCursorPosition(2, 1);
            Console.WriteLine("Он стоит 700,если хотите купить, нажмите ентер, но если вы нажмете Эскейп то вернетесь в самое начало");
            ConsoleKeyInfo key = Console.ReadKey();
            if (key.Key == ConsoleKey.Enter)
            {
                coast = coast + 700;
                Console.SetCursorPosition(2, 2);
                Console.WriteLine("Итоговая сумма к оплате: " + coast);
            }
            if (key.Key == ConsoleKey.Escape)
            {
                str1();
            }

            string ZakazCoast = "К оплате: " + coast;
            string p = "";
            File.AppendAllText("C:\\Users\\PC_of_Matvey\\Desktop\\Zakaz.txt" + "<Заказ от текущая дата>", p);
            File.AppendAllText("C:\\Users\\PC_of_Matvey\\Desktop\\Zakaz.txt" + "<", Zakaz + ">");
            File.AppendAllText("C:\\Users\\PC_of_Matvey\\Desktop\\Zakaz.txt" + "Цена <", ZakazCoast + ">");

            Console.WriteLine("Если вы хотите сделать еще один заказ то нажмите Ентер");
            key = Console.ReadKey();
            if (key.Key == ConsoleKey.Enter)
            {
                str1();
            }
        }

        //нач шоколад квад красн
        static void ChokSqRad()
        {
            tort.big = "Большой";
            tort.small = "Маленький";
            tort.average = "Средний";

            Console.Clear();
            Console.SetCursorPosition(2, 0);
            Console.WriteLine("Размеры квадратных шоколадных красных тортов:");

            Console.SetCursorPosition(0, pos223);
            Console.WriteLine("->");

            Console.SetCursorPosition(2, 1);
            Console.WriteLine(tort.big);
            Console.SetCursorPosition(2, 2);
            Console.WriteLine(tort.small);
            Console.SetCursorPosition(2, 3);
            Console.WriteLine(tort.average);
            Console.SetCursorPosition(2, 4);
            Console.WriteLine("Общая стоимость равна: " + coast);

            ConsoleKeyInfo key = Console.ReadKey();

            while (true)
            {
                if (key.Key == ConsoleKey.DownArrow)
                {
                    pos223++;

                    if (pos223 < 4)
                    {
                        Console.SetCursorPosition(0, pos223);
                        Console.WriteLine("->");
                        Console.SetCursorPosition(0, pos223 - 1);
                        Console.WriteLine("  ");
                    }
                    else
                    {
                        pos223 = 1;
                        Console.SetCursorPosition(0, pos223);
                        Console.WriteLine("->");
                        Console.SetCursorPosition(0, pos223 + 2);
                        Console.WriteLine("  ");
                    }

                }//стрелка вниз
                if (key.Key == ConsoleKey.UpArrow)
                {
                    pos223--;
                    Console.SetCursorPosition(0, pos223);
                    Console.WriteLine("->");
                    Console.SetCursorPosition(0, pos223 + 1);
                    Console.WriteLine("  ");
                    if (pos223 <= 0)
                    {
                        pos223 = 4;
                        Console.SetCursorPosition(0, pos223 - 1);
                        Console.WriteLine("->");
                        Console.SetCursorPosition(0, pos223 - 4);
                        Console.WriteLine("  ");
                    }
                }//стрелка вверх
                if (key.Key == ConsoleKey.Escape)
                {
                    ChocSq();

                }//выход
                if (key.Key == ConsoleKey.Enter)
                {
                    if (pos223 == 1)
                    {
                        itog2233();
                    }
                    if (pos223 == 2)
                    {
                        itog2231();
                    }
                    if (pos223 == 3)
                    {
                        itog2232();
                    }
                }
                key = Console.ReadKey();
            }
        }
        //кон шоколад квад красн

        static void itog2231()
        {
            Console.Clear();
            string Zakaz = "шоколадный, квадратный, красный, малый торт";
            Console.SetCursorPosition(2, 0);
            Console.WriteLine("Значит вы сейчас выбрали " + Zakaz);
            Console.SetCursorPosition(2, 1);
            Console.WriteLine("Он стоит 500,если хотите купить, нажмите ентер, но если вы нажмете Эскейп то вернетесь в самое начало");
            ConsoleKeyInfo key = Console.ReadKey();
            if (key.Key == ConsoleKey.Enter)
            {
                coast = coast + 500;
                Console.SetCursorPosition(2, 2);
                Console.WriteLine("Итоговая сумма к оплате: " + coast);
            }
            if (key.Key == ConsoleKey.Escape)
            {
                str1();
            }

            string ZakazCoast = "К оплате: " + coast;
            string p = "";
            File.AppendAllText("C:\\Users\\PC_of_Matvey\\Desktop\\Zakaz.txt" + "<Заказ от текущая дата>", p);
            File.AppendAllText("C:\\Users\\PC_of_Matvey\\Desktop\\Zakaz.txt" + "<", Zakaz + ">");
            File.AppendAllText("C:\\Users\\PC_of_Matvey\\Desktop\\Zakaz.txt" + "Цена <", ZakazCoast + ">");

            Console.WriteLine("Если вы хотите сделать еще один заказ то нажмите Ентер");
            key = Console.ReadKey();
            if (key.Key == ConsoleKey.Enter)
            {
                str1();
            }
        }

        static void itog2232()
        {
            Console.Clear();
            string Zakaz = "шоколадный, квадратный, красный, средний торт";
            Console.SetCursorPosition(2, 0);
            Console.WriteLine("Значит вы сейчас выбрали " + Zakaz);
            Console.SetCursorPosition(2, 1);
            Console.WriteLine("Он стоит 600,если хотите купить, нажмите ентер, но если вы нажмете Эскейп то вернетесь в самое начало");
            ConsoleKeyInfo key = Console.ReadKey();
            if (key.Key == ConsoleKey.Enter)
            {
                coast = coast + 600;
                Console.SetCursorPosition(2, 2);
                Console.WriteLine("Итоговая сумма к оплате: " + coast);
            }
            if (key.Key == ConsoleKey.Escape)
            {
                str1();
            }

            string ZakazCoast = "К оплате: " + coast;
            string p = "";
            File.AppendAllText("C:\\Users\\PC_of_Matvey\\Desktop\\Zakaz.txt" + "<Заказ от текущая дата>", p);
            File.AppendAllText("C:\\Users\\PC_of_Matvey\\Desktop\\Zakaz.txt" + "<", Zakaz + ">");
            File.AppendAllText("C:\\Users\\PC_of_Matvey\\Desktop\\Zakaz.txt" + "Цена <", ZakazCoast + ">");

            Console.WriteLine("Если вы хотите сделать еще один заказ то нажмите Ентер");
            key = Console.ReadKey();
            if (key.Key == ConsoleKey.Enter)
            {
                str1();
            }
        }

        static void itog2233()
        {
            Console.Clear();
            string Zakaz = "шоколадный, квадратный, красный, большой торт";
            Console.SetCursorPosition(2, 0);
            Console.WriteLine("Значит вы сейчас выбрали " + Zakaz);
            Console.SetCursorPosition(2, 1);
            Console.WriteLine("Он стоит 700,если хотите купить, нажмите ентер, но если вы нажмете Эскейп то вернетесь в самое начало");
            ConsoleKeyInfo key = Console.ReadKey();
            if (key.Key == ConsoleKey.Enter)
            {
                coast = coast + 700;
                Console.SetCursorPosition(2, 2);
                Console.WriteLine("Итоговая сумма к оплате: " + coast);
            }
            if (key.Key == ConsoleKey.Escape)
            {
                str1();
            }

            string ZakazCoast = "К оплате: " + coast;
            string p = "";
            File.AppendAllText("C:\\Users\\PC_of_Matvey\\Desktop\\Zakaz.txt" + "<Заказ от текущая дата>", p);
            File.AppendAllText("C:\\Users\\PC_of_Matvey\\Desktop\\Zakaz.txt" + "<", Zakaz + ">");
            File.AppendAllText("C:\\Users\\PC_of_Matvey\\Desktop\\Zakaz.txt" + "Цена <", ZakazCoast + ">");

            Console.WriteLine("Если вы хотите сделать еще один заказ то нажмите Ентер");
            key = Console.ReadKey();
            if (key.Key == ConsoleKey.Enter)
            {
                str1();
            }
        }

        //нач шоколадный треуг 
        static void Choctriangular()
        {
            tort.yellow = "Желтый";
            tort.blue = "Синий";
            tort.red = "Красный";

            Console.Clear();
            Console.SetCursorPosition(2, 0);
            Console.WriteLine("Цвета треугольных шоколадных тортов:");

            Console.SetCursorPosition(0, pos23);
            Console.WriteLine("->");

            Console.SetCursorPosition(2, 1);
            Console.WriteLine(tort.yellow);
            Console.SetCursorPosition(2, 2);
            Console.WriteLine(tort.blue);
            Console.SetCursorPosition(2, 3);
            Console.WriteLine(tort.red);
            Console.SetCursorPosition(2, 4);
            Console.WriteLine("Общая стоимость равна: " + coast);

            ConsoleKeyInfo key = Console.ReadKey();

            while (true)
            {
                if (key.Key == ConsoleKey.DownArrow)
                {
                    pos23++;

                    if (pos23 < 4)
                    {
                        Console.SetCursorPosition(0, pos23);
                        Console.WriteLine("->");
                        Console.SetCursorPosition(0, pos23 - 1);
                        Console.WriteLine("  ");
                    }
                    else
                    {
                        pos23 = 1;
                        Console.SetCursorPosition(0, pos23);
                        Console.WriteLine("->");
                        Console.SetCursorPosition(0, pos23 + 2);
                        Console.WriteLine("  ");
                    }

                }//стрелка вниз
                if (key.Key == ConsoleKey.UpArrow)
                {
                    pos23--;
                    Console.SetCursorPosition(0, pos23);
                    Console.WriteLine("->");
                    Console.SetCursorPosition(0, pos23 + 1);
                    Console.WriteLine("  ");
                    if (pos23 <= 0)
                    {
                        pos23 = 4;
                        Console.SetCursorPosition(0, pos23 - 1);
                        Console.WriteLine("->");
                        Console.SetCursorPosition(0, pos23 - 4);
                        Console.WriteLine("  ");
                    }
                }//стрелка вверх
                if (key.Key == ConsoleKey.Escape)
                {
                    pstr1chok();

                }//выход
                if (key.Key == ConsoleKey.Enter)
                {
                    if (pos23 == 1)
                    {
                        ChocTrGelt();
                    }
                    if (pos23 == 2)
                    {
                        ChocTrBlue();
                    }
                    if (pos23 == 3)
                    {
                        ChocTrRad();
                    }
                }
                key = Console.ReadKey();
            }
        }
        //кон шоколадный треуг 


        //нач шоколадный треуг желт
        static void ChocTrGelt()
        {
            tort.big = "Большой";
            tort.small = "Маленький";
            tort.average = "Средний";

            Console.Clear();
            Console.SetCursorPosition(2, 0);
            Console.WriteLine("Размеры треугольных шоколадных желтых тортов:");

            Console.SetCursorPosition(0, pos231);
            Console.WriteLine("->");

            Console.SetCursorPosition(2, 1);
            Console.WriteLine(tort.big);
            Console.SetCursorPosition(2, 2);
            Console.WriteLine(tort.small);
            Console.SetCursorPosition(2, 3);
            Console.WriteLine(tort.average);
            Console.SetCursorPosition(2, 4);
            Console.WriteLine("Общая стоимость равна: " + coast);

            ConsoleKeyInfo key = Console.ReadKey();

            while (true)
            {
                if (key.Key == ConsoleKey.DownArrow)
                {
                    pos231++;

                    if (pos231 < 4)
                    {
                        Console.SetCursorPosition(0, pos231);
                        Console.WriteLine("->");
                        Console.SetCursorPosition(0, pos231 - 1);
                        Console.WriteLine("  ");
                    }
                    else
                    {
                        pos231 = 1;
                        Console.SetCursorPosition(0, pos231);
                        Console.WriteLine("->");
                        Console.SetCursorPosition(0, pos231 + 2);
                        Console.WriteLine("  ");
                    }

                }//стрелка вниз
                if (key.Key == ConsoleKey.UpArrow)
                {
                    pos231--;
                    Console.SetCursorPosition(0, pos231);
                    Console.WriteLine("->");
                    Console.SetCursorPosition(0, pos231 + 1);
                    Console.WriteLine("  ");
                    if (pos231 <= 0)
                    {
                        pos231 = 4;
                        Console.SetCursorPosition(0, pos231 - 1);
                        Console.WriteLine("->");
                        Console.SetCursorPosition(0, pos231 - 4);
                        Console.WriteLine("  ");
                    }
                }//стрелка вверх
                if (key.Key == ConsoleKey.Escape)
                {
                    Choctriangular();

                }//выход
                if (key.Key == ConsoleKey.Enter)
                {
                    if (pos231 == 1)
                    {
                        itog2313();
                    }
                    if (pos231 == 2)
                    {
                        itog2311();
                    }
                    if (pos231 == 3)
                    {
                        itog2312();
                    }
                }
                key = Console.ReadKey();
            }
        }
        //кон шоколадный треуг желт

        static void itog2311()
        {
            Console.Clear();
            string Zakaz = "шоколадный, треугольный, желтый, малый торт";
            Console.SetCursorPosition(2, 0);
            Console.WriteLine("Значит вы сейчас выбрали " + Zakaz);
            Console.SetCursorPosition(2, 1);
            Console.WriteLine("Он стоит 500,если хотите купить, нажмите ентер, но если вы нажмете Эскейп то вернетесь в самое начало");
            ConsoleKeyInfo key = Console.ReadKey();
            if (key.Key == ConsoleKey.Enter)
            {
                coast = coast + 500;
                Console.SetCursorPosition(2, 2);
                Console.WriteLine("Итоговая сумма к оплате: " + coast);
            }
            if (key.Key == ConsoleKey.Escape)
            {
                str1();
            }

            string ZakazCoast = "К оплате: " + coast;
            string p = "";
            File.AppendAllText("C:\\Users\\PC_of_Matvey\\Desktop\\Zakaz.txt" + "<Заказ от текущая дата>", p);
            File.AppendAllText("C:\\Users\\PC_of_Matvey\\Desktop\\Zakaz.txt" + "<", Zakaz + ">");
            File.AppendAllText("C:\\Users\\PC_of_Matvey\\Desktop\\Zakaz.txt" + "Цена <", ZakazCoast + ">");

            Console.WriteLine("Если вы хотите сделать еще один заказ то нажмите Ентер");
            key = Console.ReadKey();
            if (key.Key == ConsoleKey.Enter)
            {
                str1();
            }
        }

        static void itog2312()
        {
            Console.Clear();
            string Zakaz = "шоколадный, треугольный, желтый, средний торт";
            Console.SetCursorPosition(2, 0);
            Console.WriteLine("Значит вы сейчас выбрали " + Zakaz);
            Console.SetCursorPosition(2, 1);
            Console.WriteLine("Он стоит 600,если хотите купить, нажмите ентер, но если вы нажмете Эскейп то вернетесь в самое начало");
            ConsoleKeyInfo key = Console.ReadKey();
            if (key.Key == ConsoleKey.Enter)
            {
                coast = coast + 600;
                Console.SetCursorPosition(2, 2);
                Console.WriteLine("Итоговая сумма к оплате: " + coast);
            }
            if (key.Key == ConsoleKey.Escape)
            {
                str1();
            }

            string ZakazCoast = "К оплате: " + coast;
            string p = "";
            File.AppendAllText("C:\\Users\\PC_of_Matvey\\Desktop\\Zakaz.txt" + "<Заказ от текущая дата>", p);
            File.AppendAllText("C:\\Users\\PC_of_Matvey\\Desktop\\Zakaz.txt" + "<", Zakaz + ">");
            File.AppendAllText("C:\\Users\\PC_of_Matvey\\Desktop\\Zakaz.txt" + "Цена <", ZakazCoast + ">");

            Console.WriteLine("Если вы хотите сделать еще один заказ то нажмите Ентер");
            key = Console.ReadKey();
            if (key.Key == ConsoleKey.Enter)
            {
                str1();
            }
        }

        static void itog2313()
        {
            Console.Clear();
            string Zakaz = "шоколадный, треугольный, желтый, большой торт";
            Console.SetCursorPosition(2, 0);
            Console.WriteLine("Значит вы сейчас выбрали " + Zakaz);
            Console.SetCursorPosition(2, 1);
            Console.WriteLine("Он стоит 700,если хотите купить, нажмите ентер, но если вы нажмете Эскейп то вернетесь в самое начало");
            ConsoleKeyInfo key = Console.ReadKey();
            if (key.Key == ConsoleKey.Enter)
            {
                coast = coast + 700;
                Console.SetCursorPosition(2, 2);
                Console.WriteLine("Итоговая сумма к оплате: " + coast);
            }
            if (key.Key == ConsoleKey.Escape)
            {
                str1();
            }

            string ZakazCoast = "К оплате: " + coast;
            string p = "";
            File.AppendAllText("C:\\Users\\PC_of_Matvey\\Desktop\\Zakaz.txt" + "<Заказ от текущая дата>", p);
            File.AppendAllText("C:\\Users\\PC_of_Matvey\\Desktop\\Zakaz.txt" + "<", Zakaz + ">");
            File.AppendAllText("C:\\Users\\PC_of_Matvey\\Desktop\\Zakaz.txt" + "Цена <", ZakazCoast + ">");

            Console.WriteLine("Если вы хотите сделать еще один заказ то нажмите Ентер");
            key = Console.ReadKey();
            if (key.Key == ConsoleKey.Enter)
            {
                str1();
            }
        }

        //нач шоколадный треуг син
        static void ChocTrBlue()
        {
            tort.big = "Большой";
            tort.small = "Маленький";
            tort.average = "Средний";

            Console.Clear();
            Console.SetCursorPosition(2, 0);
            Console.WriteLine("Размеры треугольных шоколадных синих тортов:");

            Console.SetCursorPosition(0, pos232);
            Console.WriteLine("->");

            Console.SetCursorPosition(2, 1);
            Console.WriteLine(tort.big);
            Console.SetCursorPosition(2, 2);
            Console.WriteLine(tort.small);
            Console.SetCursorPosition(2, 3);
            Console.WriteLine(tort.average);
            Console.SetCursorPosition(2, 4);
            Console.WriteLine("Общая стоимость равна: " + coast);

            ConsoleKeyInfo key = Console.ReadKey();

            while (true)
            {
                if (key.Key == ConsoleKey.DownArrow)
                {
                    pos232++;

                    if (pos232 < 4)
                    {
                        Console.SetCursorPosition(0, pos232);
                        Console.WriteLine("->");
                        Console.SetCursorPosition(0, pos232 - 1);
                        Console.WriteLine("  ");
                    }
                    else
                    {
                        pos232 = 1;
                        Console.SetCursorPosition(0, pos232);
                        Console.WriteLine("->");
                        Console.SetCursorPosition(0, pos232 + 2);
                        Console.WriteLine("  ");
                    }

                }//стрелка вниз
                if (key.Key == ConsoleKey.UpArrow)
                {
                    pos232--;
                    Console.SetCursorPosition(0, pos232);
                    Console.WriteLine("->");
                    Console.SetCursorPosition(0, pos232 + 1);
                    Console.WriteLine("  ");
                    if (pos232 <= 0)
                    {
                        pos232 = 4;
                        Console.SetCursorPosition(0, pos232 - 1);
                        Console.WriteLine("->");
                        Console.SetCursorPosition(0, pos232 - 4);
                        Console.WriteLine("  ");
                    }
                }//стрелка вверх
                if (key.Key == ConsoleKey.Escape)
                {
                    Choctriangular();

                }//выход
                if (key.Key == ConsoleKey.Enter)
                {
                    if (pos232 == 1)
                    {
                        itog2323();
                    }
                    if (pos232 == 2)
                    {
                        itog2321();
                    }
                    if (pos232 == 3)
                    {
                        itog2322();
                    }
                }
                key = Console.ReadKey();
            }
        }
        //кон шоколадный треуг син

        static void itog2321()
        {
            Console.Clear();
            string Zakaz = "шоколадный, треугольный, синий, малый торт";
            Console.SetCursorPosition(2, 0);
            Console.WriteLine("Значит вы сейчас выбрали " + Zakaz);
            Console.SetCursorPosition(2, 1);
            Console.WriteLine("Он стоит 500,если хотите купить, нажмите ентер, но если вы нажмете Эскейп то вернетесь в самое начало");
            ConsoleKeyInfo key = Console.ReadKey();
            if (key.Key == ConsoleKey.Enter)
            {
                coast = coast + 500;
                Console.SetCursorPosition(2, 2);
                Console.WriteLine("Итоговая сумма к оплате: " + coast);
            }
            if (key.Key == ConsoleKey.Escape)
            {
                str1();
            }

            string ZakazCoast = "К оплате: " + coast;
            string p = "";
            File.AppendAllText("C:\\Users\\PC_of_Matvey\\Desktop\\Zakaz.txt" + "<Заказ от текущая дата>", p);
            File.AppendAllText("C:\\Users\\PC_of_Matvey\\Desktop\\Zakaz.txt" + "<", Zakaz + ">");
            File.AppendAllText("C:\\Users\\PC_of_Matvey\\Desktop\\Zakaz.txt" + "Цена <", ZakazCoast + ">");

            Console.WriteLine("Если вы хотите сделать еще один заказ то нажмите Ентер");
            key = Console.ReadKey();
            if (key.Key == ConsoleKey.Enter)
            {
                str1();
            }
        }

        static void itog2322()
        {
            Console.Clear();
            string Zakaz = "шоколадный, треугольный, красный, средний торт";
            Console.SetCursorPosition(2, 0);
            Console.WriteLine("Значит вы сейчас выбрали " + Zakaz);
            Console.SetCursorPosition(2, 1);
            Console.WriteLine("Он стоит 600,если хотите купить, нажмите ентер, но если вы нажмете Эскейп то вернетесь в самое начало");
            ConsoleKeyInfo key = Console.ReadKey();
            if (key.Key == ConsoleKey.Enter)
            {
                coast = coast + 600;
                Console.SetCursorPosition(2, 2);
                Console.WriteLine("Итоговая сумма к оплате: " + coast);
            }
            if (key.Key == ConsoleKey.Escape)
            {
                str1();
            }

            string ZakazCoast = "К оплате: " + coast;
            string p = "";
            File.AppendAllText("C:\\Users\\PC_of_Matvey\\Desktop\\Zakaz.txt" + "<Заказ от текущая дата>", p);
            File.AppendAllText("C:\\Users\\PC_of_Matvey\\Desktop\\Zakaz.txt" + "<", Zakaz + ">");
            File.AppendAllText("C:\\Users\\PC_of_Matvey\\Desktop\\Zakaz.txt" + "Цена <", ZakazCoast + ">");

            Console.WriteLine("Если вы хотите сделать еще один заказ то нажмите Ентер");
            key = Console.ReadKey();
            if (key.Key == ConsoleKey.Enter)
            {
                str1();
            }
        }

        static void itog2323()
        {
            Console.Clear();
            string Zakaz = "шоколадный, треугольный, красный, большой торт";
            Console.SetCursorPosition(2, 0);
            Console.WriteLine("Значит вы сейчас выбрали " + Zakaz);
            Console.SetCursorPosition(2, 1);
            Console.WriteLine("Он стоит 700,если хотите купить, нажмите ентер, но если вы нажмете Эскейп то вернетесь в самое начало");
            ConsoleKeyInfo key = Console.ReadKey();
            if (key.Key == ConsoleKey.Enter)
            {
                coast = coast + 700;
                Console.SetCursorPosition(2, 2);
                Console.WriteLine("Итоговая сумма к оплате: " + coast);
            }
            if (key.Key == ConsoleKey.Escape)
            {
                str1();
            }

            string ZakazCoast = "К оплате: " + coast;
            string p = "";
            File.AppendAllText("C:\\Users\\PC_of_Matvey\\Desktop\\Zakaz.txt" + "<Заказ от текущая дата>", p);
            File.AppendAllText("C:\\Users\\PC_of_Matvey\\Desktop\\Zakaz.txt" + "<", Zakaz + ">");
            File.AppendAllText("C:\\Users\\PC_of_Matvey\\Desktop\\Zakaz.txt" + "Цена <", ZakazCoast + ">");

            Console.WriteLine("Если вы хотите сделать еще один заказ то нажмите Ентер");
            key = Console.ReadKey();
            if (key.Key == ConsoleKey.Enter)
            {
                str1();
            }
        }

        //нач шоколадный треуг крас
        static void ChocTrRad()
        {
            tort.big = "Большой";
            tort.small = "Маленький";
            tort.average = "Средний";

            Console.Clear();
            Console.SetCursorPosition(2, 0);
            Console.WriteLine("Размеры треугольных шоколадных красных тортов:");

            Console.SetCursorPosition(0, pos233);
            Console.WriteLine("->");

            Console.SetCursorPosition(2, 1);
            Console.WriteLine(tort.big);
            Console.SetCursorPosition(2, 2);
            Console.WriteLine(tort.small);
            Console.SetCursorPosition(2, 3);
            Console.WriteLine(tort.average);
            Console.SetCursorPosition(2, 4);
            Console.WriteLine("Общая стоимость равна: " + coast);

            ConsoleKeyInfo key = Console.ReadKey();

            while (true)
            {
                if (key.Key == ConsoleKey.DownArrow)
                {
                    pos233++;

                    if (pos233 < 4)
                    {
                        Console.SetCursorPosition(0, pos233);
                        Console.WriteLine("->");
                        Console.SetCursorPosition(0, pos233 - 1);
                        Console.WriteLine("  ");
                    }
                    else
                    {
                        pos233 = 1;
                        Console.SetCursorPosition(0, pos233);
                        Console.WriteLine("->");
                        Console.SetCursorPosition(0, pos233 + 2);
                        Console.WriteLine("  ");
                    }

                }//стрелка вниз
                if (key.Key == ConsoleKey.UpArrow)
                {
                    pos233--;
                    Console.SetCursorPosition(0, pos233);
                    Console.WriteLine("->");
                    Console.SetCursorPosition(0, pos233 + 1);
                    Console.WriteLine("  ");
                    if (pos233 <= 0)
                    {
                        pos233 = 4;
                        Console.SetCursorPosition(0, pos233 - 1);
                        Console.WriteLine("->");
                        Console.SetCursorPosition(0, pos233 - 4);
                        Console.WriteLine("  ");
                    }
                }//стрелка вверх
                if (key.Key == ConsoleKey.Escape)
                {
                    Choctriangular();

                }//выход
                if (key.Key == ConsoleKey.Enter)
                {
                    if (pos233 == 1)
                    {
                        itog2333();
                    }
                    if (pos233 == 2)
                    {
                        itog2331();
                    }
                    if (pos233 == 3)
                    {
                        itog2332();
                    }
                }
                key = Console.ReadKey();
            }
        }
        //кон шоколадный треуг крас


        static void itog2331()
        {
            Console.Clear();
            string Zakaz = "шоколадный, треугольный, красный, малый торт";
            Console.SetCursorPosition(2, 0);
            Console.WriteLine("Значит вы сейчас выбрали " + Zakaz);
            Console.SetCursorPosition(2, 1);
            Console.WriteLine("Он стоит 500,если хотите купить, нажмите ентер, но если вы нажмете Эскейп то вернетесь в самое начало");
            ConsoleKeyInfo key = Console.ReadKey();
            if (key.Key == ConsoleKey.Enter)
            {
                coast = coast + 500;
                Console.SetCursorPosition(2, 2);
                Console.WriteLine("Итоговая сумма к оплате: " + coast);
            }
            if (key.Key == ConsoleKey.Escape)
            {
                str1();
            }

            string ZakazCoast = "К оплате: " + coast;
            string p = "";
            File.AppendAllText("C:\\Users\\PC_of_Matvey\\Desktop\\Zakaz.txt" + "<Заказ от текущая дата>", p);
            File.AppendAllText("C:\\Users\\PC_of_Matvey\\Desktop\\Zakaz.txt" + "<", Zakaz + ">");
            File.AppendAllText("C:\\Users\\PC_of_Matvey\\Desktop\\Zakaz.txt" + "Цена <", ZakazCoast + ">");

            Console.WriteLine("Если вы хотите сделать еще один заказ то нажмите Ентер");
            key = Console.ReadKey();
            if (key.Key == ConsoleKey.Enter)
            {
                str1();
            }
        }

        static void itog2332()
        {
            Console.Clear();
            string Zakaz = "шоколадный, треугольный, красный, средний торт";
            Console.SetCursorPosition(2, 0);
            Console.WriteLine("Значит вы сейчас выбрали " + Zakaz);
            Console.SetCursorPosition(2, 1);
            Console.WriteLine("Он стоит 600,если хотите купить, нажмите ентер, но если вы нажмете Эскейп то вернетесь в самое начало");
            ConsoleKeyInfo key = Console.ReadKey();
            if (key.Key == ConsoleKey.Enter)
            {
                coast = coast + 600;
                Console.SetCursorPosition(2, 2);
                Console.WriteLine("Итоговая сумма к оплате: " + coast);
            }
            if (key.Key == ConsoleKey.Escape)
            {
                str1();
            }

            string ZakazCoast = "К оплате: " + coast;
            string p = "";
            File.AppendAllText("C:\\Users\\PC_of_Matvey\\Desktop\\Zakaz.txt" + "<Заказ от текущая дата>", p);
            File.AppendAllText("C:\\Users\\PC_of_Matvey\\Desktop\\Zakaz.txt" + "<", Zakaz + ">");
            File.AppendAllText("C:\\Users\\PC_of_Matvey\\Desktop\\Zakaz.txt" + "Цена <", ZakazCoast + ">");

            Console.WriteLine("Если вы хотите сделать еще один заказ то нажмите Ентер");
            key = Console.ReadKey();
            if (key.Key == ConsoleKey.Enter)
            {
                str1();
            }
        }

        static void itog2333()
        {
            Console.Clear();
            string Zakaz = "шоколадный, трецгольный, красный, большой торт";
            Console.SetCursorPosition(2, 0);
            Console.WriteLine("Значит вы сейчас выбрали " + Zakaz);
            Console.SetCursorPosition(2, 1);
            Console.WriteLine("Он стоит 700,если хотите купить, нажмите ентер, но если вы нажмете Эскейп то вернетесь в самое начало");
            ConsoleKeyInfo key = Console.ReadKey();
            if (key.Key == ConsoleKey.Enter)
            {
                coast = coast + 700;
                Console.SetCursorPosition(2, 2);
                Console.WriteLine("Итоговая сумма к оплате: " + coast);
            }
            if (key.Key == ConsoleKey.Escape)
            {
                str1();
            }

            string ZakazCoast = "К оплате: " + coast;
            string p = "";
            File.AppendAllText("C:\\Users\\PC_of_Matvey\\Desktop\\Zakaz.txt" + "<Заказ от текущая дата>", p);
            File.AppendAllText("C:\\Users\\PC_of_Matvey\\Desktop\\Zakaz.txt" + "<", Zakaz + ">");
            File.AppendAllText("C:\\Users\\PC_of_Matvey\\Desktop\\Zakaz.txt" + "Цена <", ZakazCoast + ">");

            Console.WriteLine("Если вы хотите сделать еще один заказ то нажмите Ентер");
            key = Console.ReadKey();
            if (key.Key == ConsoleKey.Enter)
            {
                str1();
            }
        }


        static void pstr1wanil()
        {
            Class1 torty = new Class1();
            torty.name = "Круглый";
            Class1 tortyy = new Class1();
            tortyy.name = "Квадратный";
            Class1 ttortyy = new Class1();
            ttortyy.name = "Треугольный";

            Console.Clear();
            Console.SetCursorPosition(2, 0);
            Console.WriteLine("Виды ванильных тортов:");

            Console.SetCursorPosition(0, pos4);
            Console.WriteLine("->");

            Console.SetCursorPosition(2, 1);
            Console.WriteLine(torty.name);
            Console.SetCursorPosition(2, 2);
            Console.WriteLine(tortyy.name);
            Console.SetCursorPosition(2, 3);
            Console.WriteLine(ttortyy.name);
            Console.SetCursorPosition(2, 4);
            Console.WriteLine("Общая стоимость равна: " + coast);

            ConsoleKeyInfo key = Console.ReadKey();

            while (true)
            {
                if (key.Key == ConsoleKey.DownArrow)
                {
                    pos4++;

                    if (pos4 < 4)
                    {
                        Console.SetCursorPosition(0, pos4);
                        Console.WriteLine("->");
                        Console.SetCursorPosition(0, pos4 - 1);
                        Console.WriteLine("  ");
                    }
                    else
                    {
                        pos4 = 1;
                        Console.SetCursorPosition(0, pos4);
                        Console.WriteLine("->");
                        Console.SetCursorPosition(0, pos4 + 2);
                        Console.WriteLine("  ");
                    }

                }//стрелка вниз
                if (key.Key == ConsoleKey.UpArrow)
                {
                    pos4--;
                    Console.SetCursorPosition(0, pos4);
                    Console.WriteLine("->");
                    Console.SetCursorPosition(0, pos4 + 1);
                    Console.WriteLine("  ");
                    if (pos4 <= 0)
                    {
                        pos4 = 4;
                        Console.SetCursorPosition(0, pos4 - 1);
                        Console.WriteLine("->");
                        Console.SetCursorPosition(0, pos4 - 4);
                        Console.WriteLine("  ");
                    }
                }//стрелка вверх
                if (key.Key == ConsoleKey.Escape)
                {
                    str1();

                }//выход
                if (key.Key == ConsoleKey.Enter)
                {
                    if (pos4 == 1)
                    {
                        WanilKrug();
                    }
                    if (pos4 == 2)
                    {
                        WanilSq();
                    }
                    if (pos4 == 3)
                    {
                        WanilTriangular();
                    }
                }
                key = Console.ReadKey();
            }
            if (key.Key == ConsoleKey.Escape)
            {
                str1();
            }
        }//kon ванильных тортов








        //нач ванил круглый 
        static void WanilKrug()
        {
            tort.yellow = "Желтый";
            tort.blue = "Синий";
            tort.red = "Красный";

            Console.Clear();
            Console.SetCursorPosition(2, 0);
            Console.WriteLine("Цвета круглых ванильных тортов:");

            Console.SetCursorPosition(0, pos31);
            Console.WriteLine("->");

            Console.SetCursorPosition(2, 1);
            Console.WriteLine(tort.yellow);
            Console.SetCursorPosition(2, 2);
            Console.WriteLine(tort.blue);
            Console.SetCursorPosition(2, 3);
            Console.WriteLine(tort.red);
            Console.SetCursorPosition(2, 4);
            Console.WriteLine("Общая стоимость равна: " + coast);

            ConsoleKeyInfo key = Console.ReadKey();

            while (true)
            {
                if (key.Key == ConsoleKey.DownArrow)
                {
                    pos31++;

                    if (pos31 < 4)
                    {
                        Console.SetCursorPosition(0, pos31);
                        Console.WriteLine("->");
                        Console.SetCursorPosition(0, pos31 - 1);
                        Console.WriteLine("  ");
                    }
                    else
                    {
                        pos31 = 1;
                        Console.SetCursorPosition(0, pos31);
                        Console.WriteLine("->");
                        Console.SetCursorPosition(0, pos31 + 2);
                        Console.WriteLine("  ");
                    }

                }//стрелка вниз
                if (key.Key == ConsoleKey.UpArrow)
                {
                    pos31--;
                    Console.SetCursorPosition(0, pos31);
                    Console.WriteLine("->");
                    Console.SetCursorPosition(0, pos31 + 1);
                    Console.WriteLine("  ");
                    if (pos31 <= 0)
                    {
                        pos31 = 4;
                        Console.SetCursorPosition(0, pos31 - 1);
                        Console.WriteLine("->");
                        Console.SetCursorPosition(0, pos31 - 4);
                        Console.WriteLine("  ");
                    }
                }//стрелка вверх
                if (key.Key == ConsoleKey.Escape)
                {
                    pstr1wanil();

                }//выход
                if (key.Key == ConsoleKey.Enter)
                {
                    if (pos31 == 1)
                    {
                        WanilKrugGelt();
                    }
                    if (pos31 == 2)
                    {
                        WanilKrugBlue();
                    }
                    if (pos31 == 3)
                    {
                        WanilKrugRad();
                    }
                }
                key = Console.ReadKey();
            }
        }
        //кон шоколадный круглый 

        //нач шоколад круг желт
        static void WanilKrugGelt()
        {
            tort.big = "Большой";
            tort.small = "Маленький";
            tort.average = "Средний";

            Console.Clear();
            Console.SetCursorPosition(2, 0);
            Console.WriteLine("Размеры круглых ванильных желтых тортов:");

            Console.SetCursorPosition(0, pos311);
            Console.WriteLine("->");

            Console.SetCursorPosition(2, 1);
            Console.WriteLine(tort.big);
            Console.SetCursorPosition(2, 2);
            Console.WriteLine(tort.small);
            Console.SetCursorPosition(2, 3);
            Console.WriteLine(tort.average);
            Console.SetCursorPosition(2, 4);
            Console.WriteLine("Общая стоимость равна: " + coast);

            ConsoleKeyInfo key = Console.ReadKey();

            while (true)
            {
                if (key.Key == ConsoleKey.DownArrow)
                {
                    pos311++;

                    if (pos311 < 4)
                    {
                        Console.SetCursorPosition(0, pos311);
                        Console.WriteLine("->");
                        Console.SetCursorPosition(0, pos311 - 1);
                        Console.WriteLine("  ");
                    }
                    else
                    {
                        pos311 = 1;
                        Console.SetCursorPosition(0, pos311);
                        Console.WriteLine("->");
                        Console.SetCursorPosition(0, pos311 + 2);
                        Console.WriteLine("  ");
                    }

                }//стрелка вниз
                if (key.Key == ConsoleKey.UpArrow)
                {
                    pos311--;
                    Console.SetCursorPosition(0, pos311);
                    Console.WriteLine("->");
                    Console.SetCursorPosition(0, pos311 + 1);
                    Console.WriteLine("  ");
                    if (pos311 <= 0)
                    {
                        pos311 = 4;
                        Console.SetCursorPosition(0, pos311 - 1);
                        Console.WriteLine("->");
                        Console.SetCursorPosition(0, pos311 - 4);
                        Console.WriteLine("  ");
                    }
                }//стрелка вверх
                if (key.Key == ConsoleKey.Escape)
                {
                    WanilKrug();

                }//выход
                if (key.Key == ConsoleKey.Enter)
                {
                    if (pos311 == 1)
                    {
                        itog3113();
                    }
                    if (pos311 == 2)
                    {
                        itog3111();
                    }
                    if (pos311 == 3)
                    {
                        itog3112();
                    }
                }
                key = Console.ReadKey();
            }
        }
        //кон ванил круг желт


        static void itog3111()
        {
            Console.Clear();
            string Zakaz = "ванильны, круглый, желтых, малый торт";
            Console.SetCursorPosition(2, 0);
            Console.WriteLine("Значит вы сейчас выбрали " + Zakaz);
            Console.SetCursorPosition(2, 1);
            Console.WriteLine("Он стоит 500,если хотите купить, нажмите ентер, но если вы нажмете Эскейп то вернетесь в самое начало");
            ConsoleKeyInfo key = Console.ReadKey();
            if (key.Key == ConsoleKey.Enter)
            {
                coast = coast + 500;
                Console.SetCursorPosition(2, 2);
                Console.WriteLine("Итоговая сумма к оплате: " + coast);
            }
            if (key.Key == ConsoleKey.Escape)
            {
                str1();
            }

            string ZakazCoast = "К оплате: " + coast;
            string p = "";
            File.AppendAllText("C:\\Users\\PC_of_Matvey\\Desktop\\Zakaz.txt" + "<Заказ от текущая дата>", p);
            File.AppendAllText("C:\\Users\\PC_of_Matvey\\Desktop\\Zakaz.txt" + "<", Zakaz + ">");
            File.AppendAllText("C:\\Users\\PC_of_Matvey\\Desktop\\Zakaz.txt" + "Цена <", ZakazCoast + ">");

            Console.WriteLine("Если вы хотите сделать еще один заказ то нажмите Ентер");
            key = Console.ReadKey();
            if (key.Key == ConsoleKey.Enter)
            {
                str1();
            }
        }

        static void itog3112()
        {
            Console.Clear();
            string Zakaz = "ванильны, круглый, желтых, средний торт";
            Console.SetCursorPosition(2, 0);
            Console.WriteLine("Значит вы сейчас выбрали " + Zakaz);
            Console.SetCursorPosition(2, 1);
            Console.WriteLine("Он стоит 600,если хотите купить, нажмите ентер, но если вы нажмете Эскейп то вернетесь в самое начало");
            ConsoleKeyInfo key = Console.ReadKey();
            if (key.Key == ConsoleKey.Enter)
            {
                coast = coast + 600;
                Console.SetCursorPosition(2, 2);
                Console.WriteLine("Итоговая сумма к оплате: " + coast);
            }
            if (key.Key == ConsoleKey.Escape)
            {
                str1();
            }

            string ZakazCoast = "К оплате: " + coast;
            string p = "";
            File.AppendAllText("C:\\Users\\PC_of_Matvey\\Desktop\\Zakaz.txt" + "<Заказ от текущая дата>", p);
            File.AppendAllText("C:\\Users\\PC_of_Matvey\\Desktop\\Zakaz.txt" + "<", Zakaz + ">");
            File.AppendAllText("C:\\Users\\PC_of_Matvey\\Desktop\\Zakaz.txt" + "Цена <", ZakazCoast + ">");

            Console.WriteLine("Если вы хотите сделать еще один заказ то нажмите Ентер");
            key = Console.ReadKey();
            if (key.Key == ConsoleKey.Enter)
            {
                str1();
            }
        }

        static void itog3113()
        {
            Console.Clear();
            string Zakaz = "ванильны, круглый, желтых, большой торт";
            Console.SetCursorPosition(2, 0);
            Console.WriteLine("Значит вы сейчас выбрали " + Zakaz);
            Console.SetCursorPosition(2, 1);
            Console.WriteLine("Он стоит 700,если хотите купить, нажмите ентер, но если вы нажмете Эскейп то вернетесь в самое начало");
            ConsoleKeyInfo key = Console.ReadKey();
            if (key.Key == ConsoleKey.Enter)
            {
                coast = coast + 700;
                Console.SetCursorPosition(2, 2);
                Console.WriteLine("Итоговая сумма к оплате: " + coast);
            }
            if (key.Key == ConsoleKey.Escape)
            {
                str1();
            }

            string ZakazCoast = "К оплате: " + coast;
            string p = "";
            File.AppendAllText("C:\\Users\\PC_of_Matvey\\Desktop\\Zakaz.txt" + "<Заказ от текущая дата>", p);
            File.AppendAllText("C:\\Users\\PC_of_Matvey\\Desktop\\Zakaz.txt" + "<", Zakaz + ">");
            File.AppendAllText("C:\\Users\\PC_of_Matvey\\Desktop\\Zakaz.txt" + "Цена <", ZakazCoast + ">");

            Console.WriteLine("Если вы хотите сделать еще один заказ то нажмите Ентер");
            key = Console.ReadKey();
            if (key.Key == ConsoleKey.Enter)
            {
                str1();
            }
        }

        //нач ванил круг син
        static void WanilKrugBlue()
        {
            tort.big = "Большой";
            tort.small = "Маленький";
            tort.average = "Средний";

            Console.Clear();
            Console.SetCursorPosition(2, 0);
            Console.WriteLine("Размеры круглых ванильных синих тортов:");

            Console.SetCursorPosition(0, pos0312);
            Console.WriteLine("->");

            Console.SetCursorPosition(2, 1);
            Console.WriteLine(tort.big);
            Console.SetCursorPosition(2, 2);
            Console.WriteLine(tort.small);
            Console.SetCursorPosition(2, 3);
            Console.WriteLine(tort.average);
            Console.SetCursorPosition(2, 4);
            Console.WriteLine("Общая стоимость равна: " + coast);

            ConsoleKeyInfo key = Console.ReadKey();

            while (true)
            {
                if (key.Key == ConsoleKey.DownArrow)
                {
                    pos0312++;

                    if (pos0312 < 4)
                    {
                        Console.SetCursorPosition(0, pos0312);
                        Console.WriteLine("->");
                        Console.SetCursorPosition(0, pos0312 - 1);
                        Console.WriteLine("  ");
                    }
                    else
                    {
                        pos0312 = 1;
                        Console.SetCursorPosition(0, pos0312);
                        Console.WriteLine("->");
                        Console.SetCursorPosition(0, pos0312 + 2);
                        Console.WriteLine("  ");
                    }

                }//стрелка вниз
                if (key.Key == ConsoleKey.UpArrow)
                {
                    pos0312--;
                    Console.SetCursorPosition(0, pos0312);
                    Console.WriteLine("->");
                    Console.SetCursorPosition(0, pos0312 + 1);
                    Console.WriteLine("  ");
                    if (pos0312 <= 0)
                    {
                        pos0312 = 4;
                        Console.SetCursorPosition(0, pos0312 - 1);
                        Console.WriteLine("->");
                        Console.SetCursorPosition(0, pos0312 - 4);
                        Console.WriteLine("  ");
                    }
                }//стрелка вверх
                if (key.Key == ConsoleKey.Escape)
                {
                    WanilKrug();

                }//выход
                if (key.Key == ConsoleKey.Enter)
                {
                    if (pos0312 == 1)
                    {
                        itog03123();
                    }
                    if (pos0312 == 2)
                    {
                        itog03121();
                    }
                    if (pos0312 == 3)
                    {
                        itog03122();
                    }
                }
                key = Console.ReadKey();
            }
        }
        //кон ванил круг син


        static void itog03121()
        {
            Console.Clear();
            string Zakaz = "ванильны, круглый, синий, малый торт";
            Console.SetCursorPosition(2, 0);
            Console.WriteLine("Значит вы сейчас выбрали " + Zakaz);
            Console.SetCursorPosition(2, 1);
            Console.WriteLine("Он стоит 500,если хотите купить, нажмите ентер, но если вы нажмете Эскейп то вернетесь в самое начало");
            ConsoleKeyInfo key = Console.ReadKey();
            if (key.Key == ConsoleKey.Enter)
            {
                coast = coast + 500;
                Console.SetCursorPosition(2, 2);
                Console.WriteLine("Итоговая сумма к оплате: " + coast);
            }
            if (key.Key == ConsoleKey.Escape)
            {
                str1();
            }

            string ZakazCoast = "К оплате: " + coast;
            string p = "";
            File.AppendAllText("C:\\Users\\PC_of_Matvey\\Desktop\\Zakaz.txt" + "<Заказ от текущая дата>", p);
            File.AppendAllText("C:\\Users\\PC_of_Matvey\\Desktop\\Zakaz.txt" + "<", Zakaz + ">");
            File.AppendAllText("C:\\Users\\PC_of_Matvey\\Desktop\\Zakaz.txt" + "Цена <", ZakazCoast + ">");

            Console.WriteLine("Если вы хотите сделать еще один заказ то нажмите Ентер");
            key = Console.ReadKey();
            if (key.Key == ConsoleKey.Enter)
            {
                str1();
            }
        }

        static void itog03122()
        {
            Console.Clear();
            string Zakaz = "ванильны, круглый, синий, средний торт";
            Console.SetCursorPosition(2, 0);
            Console.WriteLine("Значит вы сейчас выбрали " + Zakaz);
            Console.SetCursorPosition(2, 1);
            Console.WriteLine("Он стоит 600,если хотите купить, нажмите ентер, но если вы нажмете Эскейп то вернетесь в самое начало");
            ConsoleKeyInfo key = Console.ReadKey();
            if (key.Key == ConsoleKey.Enter)
            {
                coast = coast + 600;
                Console.SetCursorPosition(2, 2);
                Console.WriteLine("Итоговая сумма к оплате: " + coast);
            }
            if (key.Key == ConsoleKey.Escape)
            {
                str1();
            }

            string ZakazCoast = "К оплате: " + coast;
            string p = "";
            File.AppendAllText("C:\\Users\\PC_of_Matvey\\Desktop\\Zakaz.txt" + "<Заказ от текущая дата>", p);
            File.AppendAllText("C:\\Users\\PC_of_Matvey\\Desktop\\Zakaz.txt" + "<", Zakaz + ">");
            File.AppendAllText("C:\\Users\\PC_of_Matvey\\Desktop\\Zakaz.txt" + "Цена <", ZakazCoast + ">");

            Console.WriteLine("Если вы хотите сделать еще один заказ то нажмите Ентер");
            key = Console.ReadKey();
            if (key.Key == ConsoleKey.Enter)
            {
                str1();
            }
        }

        static void itog03123()
        {
            Console.Clear();
            string Zakaz = "ванильны, круглый, синий, большой торт";
            Console.SetCursorPosition(2, 0);
            Console.WriteLine("Значит вы сейчас выбрали " + Zakaz);
            Console.SetCursorPosition(2, 1);
            Console.WriteLine("Он стоит 700,если хотите купить, нажмите ентер, но если вы нажмете Эскейп то вернетесь в самое начало");
            ConsoleKeyInfo key = Console.ReadKey();
            if (key.Key == ConsoleKey.Enter)
            {
                coast = coast + 700;
                Console.SetCursorPosition(2, 2);
                Console.WriteLine("Итоговая сумма к оплате: " + coast);
            }
            if (key.Key == ConsoleKey.Escape)
            {
                str1();
            }

            string ZakazCoast = "К оплате: " + coast;
            string p = "";
            File.AppendAllText("C:\\Users\\PC_of_Matvey\\Desktop\\Zakaz.txt" + "<Заказ от текущая дата>", p);
            File.AppendAllText("C:\\Users\\PC_of_Matvey\\Desktop\\Zakaz.txt" + "<", Zakaz + ">");
            File.AppendAllText("C:\\Users\\PC_of_Matvey\\Desktop\\Zakaz.txt" + "Цена <", ZakazCoast + ">");

            Console.WriteLine("Если вы хотите сделать еще один заказ то нажмите Ентер");
            key = Console.ReadKey();
            if (key.Key == ConsoleKey.Enter)
            {
                str1();
            }
        }


        //нач шоколад круг красн
        static void WanilKrugRad()
        {
            tort.big = "Большой";
            tort.small = "Маленький";
            tort.average = "Средний";

            Console.Clear();
            Console.SetCursorPosition(2, 0);
            Console.WriteLine("Размеры круглых ванильных красных тортов:");

            Console.SetCursorPosition(0, pos0313);
            Console.WriteLine("->");

            Console.SetCursorPosition(2, 1);
            Console.WriteLine(tort.big);
            Console.SetCursorPosition(2, 2);
            Console.WriteLine(tort.small);
            Console.SetCursorPosition(2, 3);
            Console.WriteLine(tort.average);
            Console.SetCursorPosition(2, 4);
            Console.WriteLine("Общая стоимость равна: " + coast);

            ConsoleKeyInfo key = Console.ReadKey();

            while (true)
            {
                if (key.Key == ConsoleKey.DownArrow)
                {
                    pos0313++;

                    if (pos0313 < 4)
                    {
                        Console.SetCursorPosition(0, pos0313);
                        Console.WriteLine("->");
                        Console.SetCursorPosition(0, pos0313 - 1);
                        Console.WriteLine("  ");
                    }
                    else
                    {
                        pos0313 = 1;
                        Console.SetCursorPosition(0, pos0313);
                        Console.WriteLine("->");
                        Console.SetCursorPosition(0, pos0313 + 2);
                        Console.WriteLine("  ");
                    }

                }//стрелка вниз
                if (key.Key == ConsoleKey.UpArrow)
                {
                    pos0313--;
                    Console.SetCursorPosition(0, pos0313);
                    Console.WriteLine("->");
                    Console.SetCursorPosition(0, pos0313 + 1);
                    Console.WriteLine("  ");
                    if (pos0313 <= 0)
                    {
                        pos0313 = 4;
                        Console.SetCursorPosition(0, pos0313 - 1);
                        Console.WriteLine("->");
                        Console.SetCursorPosition(0, pos0313 - 4);
                        Console.WriteLine("  ");
                    }
                }//стрелка вверх
                if (key.Key == ConsoleKey.Escape)
                {
                    WanilKrug();

                }//выход
                if (key.Key == ConsoleKey.Enter)
                {
                    if (pos0313 == 1)
                    {
                        itog03133();
                    }
                    if (pos0313 == 2)
                    {
                        itog03131();
                    }
                    if (pos0313 == 3)
                    {
                        itog03132();
                    }
                }
                key = Console.ReadKey();
            }
        }
        //кон ванил круг красн


        static void itog03131()
        {
            Console.Clear();
            string Zakaz = "ванильны, круглый, красный, малый торт";
            Console.SetCursorPosition(2, 0);
            Console.WriteLine("Значит вы сейчас выбрали " + Zakaz);
            Console.SetCursorPosition(2, 1);
            Console.WriteLine("Он стоит 500,если хотите купить, нажмите ентер, но если вы нажмете Эскейп то вернетесь в самое начало");
            ConsoleKeyInfo key = Console.ReadKey();
            if (key.Key == ConsoleKey.Enter)
            {
                coast = coast + 500;
                Console.SetCursorPosition(2, 2);
                Console.WriteLine("Итоговая сумма к оплате: " + coast);
            }
            if (key.Key == ConsoleKey.Escape)
            {
                str1();
            }

            string ZakazCoast = "К оплате: " + coast;
            string p = "";
            File.AppendAllText("C:\\Users\\PC_of_Matvey\\Desktop\\Zakaz.txt" + "<Заказ от текущая дата>", p);
            File.AppendAllText("C:\\Users\\PC_of_Matvey\\Desktop\\Zakaz.txt" + "<", Zakaz + ">");
            File.AppendAllText("C:\\Users\\PC_of_Matvey\\Desktop\\Zakaz.txt" + "Цена <", ZakazCoast + ">");

            Console.WriteLine("Если вы хотите сделать еще один заказ то нажмите Ентер");
            key = Console.ReadKey();
            if (key.Key == ConsoleKey.Enter)
            {
                str1();
            }
        }

        static void itog03132()
        {
            Console.Clear();
            string Zakaz = "ванильны, круглый, красный, средний торт";
            Console.SetCursorPosition(2, 0);
            Console.WriteLine("Значит вы сейчас выбрали " + Zakaz);
            Console.SetCursorPosition(2, 1);
            Console.WriteLine("Он стоит 600,если хотите купить, нажмите ентер, но если вы нажмете Эскейп то вернетесь в самое начало");
            ConsoleKeyInfo key = Console.ReadKey();
            if (key.Key == ConsoleKey.Enter)
            {
                coast = coast + 600;
                Console.SetCursorPosition(2, 2);
                Console.WriteLine("Итоговая сумма к оплате: " + coast);
            }
            if (key.Key == ConsoleKey.Escape)
            {
                str1();
            }

            string ZakazCoast = "К оплате: " + coast;
            string p = "";
            File.AppendAllText("C:\\Users\\PC_of_Matvey\\Desktop\\Zakaz.txt" + "<Заказ от текущая дата>", p);
            File.AppendAllText("C:\\Users\\PC_of_Matvey\\Desktop\\Zakaz.txt" + "<", Zakaz + ">");
            File.AppendAllText("C:\\Users\\PC_of_Matvey\\Desktop\\Zakaz.txt" + "Цена <", ZakazCoast + ">");

            Console.WriteLine("Если вы хотите сделать еще один заказ то нажмите Ентер");
            key = Console.ReadKey();
            if (key.Key == ConsoleKey.Enter)
            {
                str1();
            }
        }

        static void itog03133()
        {
            Console.Clear();
            string Zakaz = "ванильны, круглый, красный, большой торт";
            Console.SetCursorPosition(2, 0);
            Console.WriteLine("Значит вы сейчас выбрали " + Zakaz);
            Console.SetCursorPosition(2, 1);
            Console.WriteLine("Он стоит 700,если хотите купить, нажмите ентер, но если вы нажмете Эскейп то вернетесь в самое начало");
            ConsoleKeyInfo key = Console.ReadKey();
            if (key.Key == ConsoleKey.Enter)
            {
                coast = coast + 700;
                Console.SetCursorPosition(2, 2);
                Console.WriteLine("Итоговая сумма к оплате: " + coast);
            }
            if (key.Key == ConsoleKey.Escape)
            {
                str1();
            }

            string ZakazCoast = "К оплате: " + coast;
            string p = "";
            File.AppendAllText("C:\\Users\\PC_of_Matvey\\Desktop\\Zakaz.txt" + "<Заказ от текущая дата>", p);
            File.AppendAllText("C:\\Users\\PC_of_Matvey\\Desktop\\Zakaz.txt" + "<", Zakaz + ">");
            File.AppendAllText("C:\\Users\\PC_of_Matvey\\Desktop\\Zakaz.txt" + "Цена <", ZakazCoast + ">");

            Console.WriteLine("Если вы хотите сделать еще один заказ то нажмите Ентер");
            key = Console.ReadKey();
            if (key.Key == ConsoleKey.Enter)
            {
                str1();
            }
        }


        //нач ванил квад 
        static void WanilSq()
        {
            tort.yellow = "Желтый";
            tort.blue = "Синий";
            tort.red = "Красный";

            Console.Clear();
            Console.SetCursorPosition(2, 0);
            Console.WriteLine("Цвета квадратных ванильных тортов:");

            Console.SetCursorPosition(0, pos31);
            Console.WriteLine("->");

            Console.SetCursorPosition(2, 1);
            Console.WriteLine(tort.yellow);
            Console.SetCursorPosition(2, 2);
            Console.WriteLine(tort.blue);
            Console.SetCursorPosition(2, 3);
            Console.WriteLine(tort.red);
            Console.SetCursorPosition(2, 4);
            Console.WriteLine("Общая стоимость равна: " + coast);

            ConsoleKeyInfo key = Console.ReadKey();

            while (true)
            {
                if (key.Key == ConsoleKey.DownArrow)
                {
                    pos31++;

                    if (pos31 < 4)
                    {
                        Console.SetCursorPosition(0, pos31);
                        Console.WriteLine("->");
                        Console.SetCursorPosition(0, pos31 - 1);
                        Console.WriteLine("  ");
                    }
                    else
                    {
                        pos31 = 1;
                        Console.SetCursorPosition(0, pos31);
                        Console.WriteLine("->");
                        Console.SetCursorPosition(0, pos31 + 2);
                        Console.WriteLine("  ");
                    }

                }//стрелка вниз
                if (key.Key == ConsoleKey.UpArrow)
                {
                    pos31--;
                    Console.SetCursorPosition(0, pos31);
                    Console.WriteLine("->");
                    Console.SetCursorPosition(0, pos31 + 1);
                    Console.WriteLine("  ");
                    if (pos31 <= 0)
                    {
                        pos31 = 4;
                        Console.SetCursorPosition(0, pos31 - 1);
                        Console.WriteLine("->");
                        Console.SetCursorPosition(0, pos31 - 4);
                        Console.WriteLine("  ");
                    }
                }//стрелка вверх
                if (key.Key == ConsoleKey.Escape)
                {
                    pstr1wanil();

                }//выход
                if (key.Key == ConsoleKey.Enter)
                {
                    if (pos31 == 1)
                    {
                        WanilSqgelt();
                    }
                    if (pos31 == 2)
                    {
                        WanilSqBlue();
                    }
                    if (pos31 == 3)
                    {
                        WanilSqRad();
                    }
                }
                key = Console.ReadKey();
            }
        }

        //кон ванил квад 

        //нач ванил квад желт
        static void WanilSqgelt()
        {
            tort.big = "Большой";
            tort.small = "Маленький";
            tort.average = "Средний";

            Console.Clear();
            Console.SetCursorPosition(2, 0);
            Console.WriteLine("Размеры квадратных ванильных желтых тортов:");

            Console.SetCursorPosition(0, pos0321);
            Console.WriteLine("->");

            Console.SetCursorPosition(2, 1);
            Console.WriteLine(tort.big);
            Console.SetCursorPosition(2, 2);
            Console.WriteLine(tort.small);
            Console.SetCursorPosition(2, 3);
            Console.WriteLine(tort.average);
            Console.SetCursorPosition(2, 4);
            Console.WriteLine("Общая стоимость равна: " + coast);

            ConsoleKeyInfo key = Console.ReadKey();

            while (true)
            {
                if (key.Key == ConsoleKey.DownArrow)
                {
                    pos0321++;

                    if (pos0321 < 4)
                    {
                        Console.SetCursorPosition(0, pos0321);
                        Console.WriteLine("->");
                        Console.SetCursorPosition(0, pos0321 - 1);
                        Console.WriteLine("  ");
                    }
                    else
                    {
                        pos0321 = 1;
                        Console.SetCursorPosition(0, pos0321);
                        Console.WriteLine("->");
                        Console.SetCursorPosition(0, pos0321 + 2);
                        Console.WriteLine("  ");
                    }

                }//стрелка вниз
                if (key.Key == ConsoleKey.UpArrow)
                {
                    pos0321--;
                    Console.SetCursorPosition(0, pos0321);
                    Console.WriteLine("->");
                    Console.SetCursorPosition(0, pos0321 + 1);
                    Console.WriteLine("  ");
                    if (pos0321 <= 0)
                    {
                        pos0321 = 4;
                        Console.SetCursorPosition(0, pos0321 - 1);
                        Console.WriteLine("->");
                        Console.SetCursorPosition(0, pos0321 - 4);
                        Console.WriteLine("  ");
                    }
                }//стрелка вверх
                if (key.Key == ConsoleKey.Escape)
                {
                    WanilSq();

                }//выход
                if (key.Key == ConsoleKey.Enter)
                {
                    if (pos0321 == 1)
                    {
                        itog03213();
                    }
                    if (pos0321 == 2)
                    {
                        itog03211();
                    }
                    if (pos0321 == 3)
                    {
                        itog03212();
                    }
                }
                key = Console.ReadKey();
            }
        }
        //кон шоколад квад желт

        static void itog03211()
        {
            Console.Clear();
            string Zakaz = "ванильны, круглый, желтый, малый торт";
            Console.SetCursorPosition(2, 0);
            Console.WriteLine("Значит вы сейчас выбрали " + Zakaz);
            Console.SetCursorPosition(2, 1);
            Console.WriteLine("Он стоит 500,если хотите купить, нажмите ентер, но если вы нажмете Эскейп то вернетесь в самое начало");
            ConsoleKeyInfo key = Console.ReadKey();
            if (key.Key == ConsoleKey.Enter)
            {
                coast = coast + 500;
                Console.SetCursorPosition(2, 2);
                Console.WriteLine("Итоговая сумма к оплате: " + coast);
            }
            if (key.Key == ConsoleKey.Escape)
            {
                str1();
            }

            string ZakazCoast = "К оплате: " + coast;
            string p = "";
            File.AppendAllText("C:\\Users\\PC_of_Matvey\\Desktop\\Zakaz.txt" + "<Заказ от текущая дата>", p);
            File.AppendAllText("C:\\Users\\PC_of_Matvey\\Desktop\\Zakaz.txt" + "<", Zakaz + ">");
            File.AppendAllText("C:\\Users\\PC_of_Matvey\\Desktop\\Zakaz.txt" + "Цена <", ZakazCoast + ">");

            Console.WriteLine("Если вы хотите сделать еще один заказ то нажмите Ентер");
            key = Console.ReadKey();
            if (key.Key == ConsoleKey.Enter)
            {
                str1();
            }
        }

        static void itog03212()
        {
            Console.Clear();
            string Zakaz = "ванильны, круглый, желтый, средний торт";
            Console.SetCursorPosition(2, 0);
            Console.WriteLine("Значит вы сейчас выбрали " + Zakaz);
            Console.SetCursorPosition(2, 1);
            Console.WriteLine("Он стоит 600,если хотите купить, нажмите ентер, но если вы нажмете Эскейп то вернетесь в самое начало");
            ConsoleKeyInfo key = Console.ReadKey();
            if (key.Key == ConsoleKey.Enter)
            {
                coast = coast + 600;
                Console.SetCursorPosition(2, 2);
                Console.WriteLine("Итоговая сумма к оплате: " + coast);
            }
            if (key.Key == ConsoleKey.Escape)
            {
                str1();
            }

            string ZakazCoast = "К оплате: " + coast;
            string p = "";
            File.AppendAllText("C:\\Users\\PC_of_Matvey\\Desktop\\Zakaz.txt" + "<Заказ от текущая дата>", p);
            File.AppendAllText("C:\\Users\\PC_of_Matvey\\Desktop\\Zakaz.txt" + "<", Zakaz + ">");
            File.AppendAllText("C:\\Users\\PC_of_Matvey\\Desktop\\Zakaz.txt" + "Цена <", ZakazCoast + ">");

            Console.WriteLine("Если вы хотите сделать еще один заказ то нажмите Ентер");
            key = Console.ReadKey();
            if (key.Key == ConsoleKey.Enter)
            {
                str1();
            }
        }

        static void itog03213()
        {
            Console.Clear();
            string Zakaz = "ванильны, круглый, желтый, большой торт";
            Console.SetCursorPosition(2, 0);
            Console.WriteLine("Значит вы сейчас выбрали " + Zakaz);
            Console.SetCursorPosition(2, 1);
            Console.WriteLine("Он стоит 700,если хотите купить, нажмите ентер, но если вы нажмете Эскейп то вернетесь в самое начало");
            ConsoleKeyInfo key = Console.ReadKey();
            if (key.Key == ConsoleKey.Enter)
            {
                coast = coast + 700;
                Console.SetCursorPosition(2, 2);
                Console.WriteLine("Итоговая сумма к оплате: " + coast);
            }
            if (key.Key == ConsoleKey.Escape)
            {
                str1();
            }

            string ZakazCoast = "К оплате: " + coast;
            string p = "";
            File.AppendAllText("C:\\Users\\PC_of_Matvey\\Desktop\\Zakaz.txt" + "<Заказ от текущая дата>", p);
            File.AppendAllText("C:\\Users\\PC_of_Matvey\\Desktop\\Zakaz.txt" + "<", Zakaz + ">");
            File.AppendAllText("C:\\Users\\PC_of_Matvey\\Desktop\\Zakaz.txt" + "Цена <", ZakazCoast + ">");

            Console.WriteLine("Если вы хотите сделать еще один заказ то нажмите Ентер");
            key = Console.ReadKey();
            if (key.Key == ConsoleKey.Enter)
            {
                str1();
            }
        }

        //нач шоколад квад син
        static void WanilSqBlue()
        {
            tort.big = "Большой";
            tort.small = "Маленький";
            tort.average = "Средний";

            Console.Clear();
            Console.SetCursorPosition(2, 0);
            Console.WriteLine("Размеры квадратных ванильных синих тортов:");

            Console.SetCursorPosition(0, pos0322);
            Console.WriteLine("->");

            Console.SetCursorPosition(2, 1);
            Console.WriteLine(tort.big);
            Console.SetCursorPosition(2, 2);
            Console.WriteLine(tort.small);
            Console.SetCursorPosition(2, 3);
            Console.WriteLine(tort.average);
            Console.SetCursorPosition(2, 4);
            Console.WriteLine("Общая стоимость равна: " + coast);

            ConsoleKeyInfo key = Console.ReadKey();

            while (true)
            {
                if (key.Key == ConsoleKey.DownArrow)
                {
                    pos0322++;

                    if (pos0322 < 4)
                    {
                        Console.SetCursorPosition(0, pos0322);
                        Console.WriteLine("->");
                        Console.SetCursorPosition(0, pos0322 - 1);
                        Console.WriteLine("  ");
                    }
                    else
                    {
                        pos0322 = 1;
                        Console.SetCursorPosition(0, pos0322);
                        Console.WriteLine("->");
                        Console.SetCursorPosition(0, pos0322 + 2);
                        Console.WriteLine("  ");
                    }

                }//стрелка вниз
                if (key.Key == ConsoleKey.UpArrow)
                {
                    pos0322--;
                    Console.SetCursorPosition(0, pos0322);
                    Console.WriteLine("->");
                    Console.SetCursorPosition(0, pos0322 + 1);
                    Console.WriteLine("  ");
                    if (pos0322 <= 0)
                    {
                        pos0322 = 4;
                        Console.SetCursorPosition(0, pos0322 - 1);
                        Console.WriteLine("->");
                        Console.SetCursorPosition(0, pos0322 - 4);
                        Console.WriteLine("  ");
                    }
                }//стрелка вверх
                if (key.Key == ConsoleKey.Escape)
                {
                    WanilSq();

                }//выход
                if (key.Key == ConsoleKey.Enter)
                {
                    if (pos0322 == 1)
                    {
                        itog03223();
                    }
                    if (pos0322 == 2)
                    {
                        itog03221();
                    }
                    if (pos0322 == 3)
                    {
                        itog03222();
                    }
                }
                key = Console.ReadKey();
            }
        }
        //кон шоколад квад син

        static void itog03223()
        {
            Console.Clear();
            string Zakaz = "ванильны, квадратный, синий, большой торт";
            Console.SetCursorPosition(2, 0);
            Console.WriteLine("Значит вы сейчас выбрали " + Zakaz);
            Console.SetCursorPosition(2, 1);
            Console.WriteLine("Он стоит 700,если хотите купить, нажмите ентер, но если вы нажмете Эскейп то вернетесь в самое начало");
            ConsoleKeyInfo key = Console.ReadKey();
            if (key.Key == ConsoleKey.Enter)
            {
                coast = coast + 700;
                Console.SetCursorPosition(2, 2);
                Console.WriteLine("Итоговая сумма к оплате: " + coast);
            }
            if (key.Key == ConsoleKey.Escape)
            {
                str1();
            }

            string ZakazCoast = "К оплате: " + coast;
            string p = "";
            File.AppendAllText("C:\\Users\\PC_of_Matvey\\Desktop\\Zakaz.txt" + "<Заказ от текущая дата>", p);
            File.AppendAllText("C:\\Users\\PC_of_Matvey\\Desktop\\Zakaz.txt" + "<", Zakaz + ">");
            File.AppendAllText("C:\\Users\\PC_of_Matvey\\Desktop\\Zakaz.txt" + "Цена <", ZakazCoast + ">");

            Console.WriteLine("Если вы хотите сделать еще один заказ то нажмите Ентер");
            key = Console.ReadKey();
            if (key.Key == ConsoleKey.Enter)
            {
                str1();
            }
        }

        static void itog03222()
        {
            Console.Clear();
            string Zakaz = "ванильны, квадратный, синий, средний торт";
            Console.SetCursorPosition(2, 0);
            Console.WriteLine("Значит вы сейчас выбрали " + Zakaz);
            Console.SetCursorPosition(2, 1);
            Console.WriteLine("Он стоит 600,если хотите купить, нажмите ентер, но если вы нажмете Эскейп то вернетесь в самое начало");
            ConsoleKeyInfo key = Console.ReadKey();
            if (key.Key == ConsoleKey.Enter)
            {
                coast = coast + 600;
                Console.SetCursorPosition(2, 2);
                Console.WriteLine("Итоговая сумма к оплате: " + coast);
            }
            if (key.Key == ConsoleKey.Escape)
            {
                str1();
            }

            string ZakazCoast = "К оплате: " + coast;
            string p = "";
            File.AppendAllText("C:\\Users\\PC_of_Matvey\\Desktop\\Zakaz.txt" + "<Заказ от текущая дата>", p);
            File.AppendAllText("C:\\Users\\PC_of_Matvey\\Desktop\\Zakaz.txt" + "<", Zakaz + ">");
            File.AppendAllText("C:\\Users\\PC_of_Matvey\\Desktop\\Zakaz.txt" + "Цена <", ZakazCoast + ">");

            Console.WriteLine("Если вы хотите сделать еще один заказ то нажмите Ентер");
            key = Console.ReadKey();
            if (key.Key == ConsoleKey.Enter)
            {
                str1();
            }
        }

        static void itog03221()
        {
            Console.Clear();
            string Zakaz = "ванильны, квадратный, синий, малый торт";
            Console.SetCursorPosition(2, 0);
            Console.WriteLine("Значит вы сейчас выбрали " + Zakaz);
            Console.SetCursorPosition(2, 1);
            Console.WriteLine("Он стоит 500,если хотите купить, нажмите ентер, но если вы нажмете Эскейп то вернетесь в самое начало");
            ConsoleKeyInfo key = Console.ReadKey();
            if (key.Key == ConsoleKey.Enter)
            {
                coast = coast + 500;
                Console.SetCursorPosition(2, 2);
                Console.WriteLine("Итоговая сумма к оплате: " + coast);
            }
            if (key.Key == ConsoleKey.Escape)
            {
                str1();
            }

            string ZakazCoast = "К оплате: " + coast;
            string p = "";
            File.AppendAllText("C:\\Users\\PC_of_Matvey\\Desktop\\Zakaz.txt" + "<Заказ от текущая дата>", p);
            File.AppendAllText("C:\\Users\\PC_of_Matvey\\Desktop\\Zakaz.txt" + "<", Zakaz + ">");
            File.AppendAllText("C:\\Users\\PC_of_Matvey\\Desktop\\Zakaz.txt" + "Цена <", ZakazCoast + ">");

            Console.WriteLine("Если вы хотите сделать еще один заказ то нажмите Ентер");
            key = Console.ReadKey();
            if (key.Key == ConsoleKey.Enter)
            {
                str1();
            }
        }

        //нач шоколад квад красн
        static void WanilSqRad()
        {
            tort.big = "Большой";
            tort.small = "Маленький";
            tort.average = "Средний";

            Console.Clear();
            Console.SetCursorPosition(2, 0);
            Console.WriteLine("Размеры квадратных ванильных красных тортов:");

            Console.SetCursorPosition(0, pos0323);
            Console.WriteLine("->");

            Console.SetCursorPosition(2, 1);
            Console.WriteLine(tort.big);
            Console.SetCursorPosition(2, 2);
            Console.WriteLine(tort.small);
            Console.SetCursorPosition(2, 3);
            Console.WriteLine(tort.average);
            Console.SetCursorPosition(2, 4);
            Console.WriteLine("Общая стоимость равна: " + coast);

            ConsoleKeyInfo key = Console.ReadKey();

            while (true)
            {
                if (key.Key == ConsoleKey.DownArrow)
                {
                    pos0323++;

                    if (pos0323 < 4)
                    {
                        Console.SetCursorPosition(0, pos0323);
                        Console.WriteLine("->");
                        Console.SetCursorPosition(0, pos0323 - 1);
                        Console.WriteLine("  ");
                    }
                    else
                    {
                        pos0323 = 1;
                        Console.SetCursorPosition(0, pos0323);
                        Console.WriteLine("->");
                        Console.SetCursorPosition(0, pos0323 + 2);
                        Console.WriteLine("  ");
                    }

                }//стрелка вниз
                if (key.Key == ConsoleKey.UpArrow)
                {
                    pos0323--;
                    Console.SetCursorPosition(0, pos0323);
                    Console.WriteLine("->");
                    Console.SetCursorPosition(0, pos0323 + 1);
                    Console.WriteLine("  ");
                    if (pos0323 <= 0)
                    {
                        pos0323 = 4;
                        Console.SetCursorPosition(0, pos0323 - 1);
                        Console.WriteLine("->");
                        Console.SetCursorPosition(0, pos0323 - 4);
                        Console.WriteLine("  ");
                    }
                }//стрелка вверх
                if (key.Key == ConsoleKey.Escape)
                {
                    WanilSq();

                }//выход
                if (key.Key == ConsoleKey.Enter)
                {
                    if (pos0323 == 1)
                    {
                        itog03233();
                    }
                    if (pos0323 == 2)
                    {
                        itog03231();
                    }
                    if (pos0323 == 3)
                    {
                        itog03232();
                    }
                }
                key = Console.ReadKey();
            }
        }
        //кон шоколад квад красн

        static void itog03231()
        {
            Console.Clear();
            string Zakaz = "ванильны, квадратный, красный, малый торт";
            Console.SetCursorPosition(2, 0);
            Console.WriteLine("Значит вы сейчас выбрали " + Zakaz);
            Console.SetCursorPosition(2, 1);
            Console.WriteLine("Он стоит 500,если хотите купить, нажмите ентер, но если вы нажмете Эскейп то вернетесь в самое начало");
            ConsoleKeyInfo key = Console.ReadKey();
            if (key.Key == ConsoleKey.Enter)
            {
                coast = coast + 500;
                Console.SetCursorPosition(2, 2);
                Console.WriteLine("Итоговая сумма к оплате: " + coast);
            }
            if (key.Key == ConsoleKey.Escape)
            {
                str1();
            }

            string ZakazCoast = "К оплате: " + coast;
            string p = "";
            File.AppendAllText("C:\\Users\\PC_of_Matvey\\Desktop\\Zakaz.txt" + "<Заказ от текущая дата>", p);
            File.AppendAllText("C:\\Users\\PC_of_Matvey\\Desktop\\Zakaz.txt" + "<", Zakaz + ">");
            File.AppendAllText("C:\\Users\\PC_of_Matvey\\Desktop\\Zakaz.txt" + "Цена <", ZakazCoast + ">");

            Console.WriteLine("Если вы хотите сделать еще один заказ то нажмите Ентер");
            key = Console.ReadKey();
            if (key.Key == ConsoleKey.Enter)
            {
                str1();
            }
        }

        static void itog03232()
        {
            Console.Clear();
            string Zakaz = "ванильны, квадратный, красный, средний торт";
            Console.SetCursorPosition(2, 0);
            Console.WriteLine("Значит вы сейчас выбрали " + Zakaz);
            Console.SetCursorPosition(2, 1);
            Console.WriteLine("Он стоит 600,если хотите купить, нажмите ентер, но если вы нажмете Эскейп то вернетесь в самое начало");
            ConsoleKeyInfo key = Console.ReadKey();
            if (key.Key == ConsoleKey.Enter)
            {
                coast = coast + 700;
                Console.SetCursorPosition(2, 2);
                Console.WriteLine("Итоговая сумма к оплате: " + coast);
            }
            if (key.Key == ConsoleKey.Escape)
            {
                str1();
            }

            string ZakazCoast = "К оплате: " + coast;
            string p = "";
            File.AppendAllText("C:\\Users\\PC_of_Matvey\\Desktop\\Zakaz.txt" + "<Заказ от текущая дата>", p);
            File.AppendAllText("C:\\Users\\PC_of_Matvey\\Desktop\\Zakaz.txt" + "<", Zakaz + ">");
            File.AppendAllText("C:\\Users\\PC_of_Matvey\\Desktop\\Zakaz.txt" + "Цена <", ZakazCoast + ">");

            Console.WriteLine("Если вы хотите сделать еще один заказ то нажмите Ентер");
            key = Console.ReadKey();
            if (key.Key == ConsoleKey.Enter)
            {
                str1();
            }
        }

        static void itog03233()
        {
            Console.Clear();
            string Zakaz = "ванильны, квадратный, красный, большой торт";
            Console.SetCursorPosition(2, 0);
            Console.WriteLine("Значит вы сейчас выбрали " + Zakaz);
            Console.SetCursorPosition(2, 1);
            Console.WriteLine("Он стоит 700,если хотите купить, нажмите ентер, но если вы нажмете Эскейп то вернетесь в самое начало");
            ConsoleKeyInfo key = Console.ReadKey();
            if (key.Key == ConsoleKey.Enter)
            {
                coast = coast + 700;
                Console.SetCursorPosition(2, 2);
                Console.WriteLine("Итоговая сумма к оплате: " + coast);
            }
            if (key.Key == ConsoleKey.Escape)
            {
                str1();
            }

            string ZakazCoast = "К оплате: " + coast;
            string p = "";
            File.AppendAllText("C:\\Users\\PC_of_Matvey\\Desktop\\Zakaz.txt" + "<Заказ от текущая дата>", p);
            File.AppendAllText("C:\\Users\\PC_of_Matvey\\Desktop\\Zakaz.txt" + "<", Zakaz + ">");
            File.AppendAllText("C:\\Users\\PC_of_Matvey\\Desktop\\Zakaz.txt" + "Цена <", ZakazCoast + ">");

            //Console.Clear();
            Console.WriteLine("Если вы хотите сделать еще один заказ то нажмите Ентер");
            key = Console.ReadKey();
            if (key.Key == ConsoleKey.Enter)
            {
                str1();
            }
        }


        //нач шоколадный треуг 
        static void WanilTriangular()
        {
            tort.yellow = "Желтый";
            tort.blue = "Синий";
            tort.red = "Красный";

            Console.Clear();
            Console.SetCursorPosition(2, 0);
            Console.WriteLine("Цвета треугольных ванильных тортов:");

            Console.SetCursorPosition(0, pos33);
            Console.WriteLine("->");

            Console.SetCursorPosition(2, 1);
            Console.WriteLine(tort.yellow);
            Console.SetCursorPosition(2, 2);
            Console.WriteLine(tort.blue);
            Console.SetCursorPosition(2, 3);
            Console.WriteLine(tort.red);
            Console.SetCursorPosition(2, 4);
            Console.WriteLine("Общая стоимость равна: " + coast);

            ConsoleKeyInfo key = Console.ReadKey();

            while (true)
            {
                if (key.Key == ConsoleKey.DownArrow)
                {
                    pos33++;

                    if (pos33 < 4)
                    {
                        Console.SetCursorPosition(0, pos33);
                        Console.WriteLine("->");
                        Console.SetCursorPosition(0, pos33 - 1);
                        Console.WriteLine("  ");
                    }
                    else
                    {
                        pos33 = 1;
                        Console.SetCursorPosition(0, pos33);
                        Console.WriteLine("->");
                        Console.SetCursorPosition(0, pos33 + 2);
                        Console.WriteLine("  ");
                    }

                }//стрелка вниз
                if (key.Key == ConsoleKey.UpArrow)
                {
                    pos33--;
                    Console.SetCursorPosition(0, pos33);
                    Console.WriteLine("->");
                    Console.SetCursorPosition(0, pos33 + 1);
                    Console.WriteLine("  ");
                    if (pos33 <= 0)
                    {
                        pos33 = 4;
                        Console.SetCursorPosition(0, pos33 - 1);
                        Console.WriteLine("->");
                        Console.SetCursorPosition(0, pos33 - 4);
                        Console.WriteLine("  ");
                    }
                }//стрелка вверх
                if (key.Key == ConsoleKey.Escape)
                {
                    pstr1wanil();

                }//выход
                if (key.Key == ConsoleKey.Enter)
                {
                    if (pos33 == 1)
                    {
                        WanilTriangularGelt();
                    }
                    if (pos33 == 2)
                    {
                        WanilTriangularBlue();
                    }
                    if (pos33 == 3)
                    {
                        WanilTriangularRad();
                    }
                }
                key = Console.ReadKey();
            }
        }
        //кон шоколадный треуг 


        //нач wanil треуг желт
        static void WanilTriangularGelt()
        {
            tort.big = "Большой";
            tort.small = "Маленький";
            tort.average = "Средний";

            Console.Clear();
            Console.SetCursorPosition(2, 0);
            Console.WriteLine("Размеры треугольных ванильных желтых тортов:");

            Console.SetCursorPosition(0, pos0331);
            Console.WriteLine("->");

            Console.SetCursorPosition(2, 1);
            Console.WriteLine(tort.big);
            Console.SetCursorPosition(2, 2);
            Console.WriteLine(tort.small);
            Console.SetCursorPosition(2, 3);
            Console.WriteLine(tort.average);
            Console.SetCursorPosition(2, 4);
            Console.WriteLine("Общая стоимость равна: " + coast);

            ConsoleKeyInfo key = Console.ReadKey();

            while (true)
            {
                if (key.Key == ConsoleKey.DownArrow)
                {
                    pos0331++;

                    if (pos0331 < 4)
                    {
                        Console.SetCursorPosition(0, pos0331);
                        Console.WriteLine("->");
                        Console.SetCursorPosition(0, pos0331 - 1);
                        Console.WriteLine("  ");
                    }
                    else
                    {
                        pos0331 = 1;
                        Console.SetCursorPosition(0, pos0331);
                        Console.WriteLine("->");
                        Console.SetCursorPosition(0, pos0331 + 2);
                        Console.WriteLine("  ");
                    }

                }//стрелка вниз
                if (key.Key == ConsoleKey.UpArrow)
                {
                    pos0331--;
                    Console.SetCursorPosition(0, pos0331);
                    Console.WriteLine("->");
                    Console.SetCursorPosition(0, pos0331 + 1);
                    Console.WriteLine("  ");
                    if (pos0331 <= 0)
                    {
                        pos0331 = 4;
                        Console.SetCursorPosition(0, pos0331 - 1);
                        Console.WriteLine("->");
                        Console.SetCursorPosition(0, pos0331 - 4);
                        Console.WriteLine("  ");
                    }
                }//стрелка вверх
                if (key.Key == ConsoleKey.Escape)
                {
                    WanilTriangular();

                }//выход
                if (key.Key == ConsoleKey.Enter)
                {
                    if (pos0331 == 1)
                    {
                        itog03313();
                    }
                    if (pos0331 == 2)
                    {
                        itog03311();
                    }
                    if (pos0331 == 3)
                    {
                        itog03312();
                    }
                }
                key = Console.ReadKey();
            }
        }
        //кон шоколадный треуг желт

        static void itog03311()
        {
            Console.Clear();
            string Zakaz = "ванильны, треугольный, желтый, малый торт";
            Console.SetCursorPosition(2, 0);
            Console.WriteLine("Значит вы сейчас выбрали " + Zakaz);
            Console.SetCursorPosition(2, 1);
            Console.WriteLine("Он стоит 500,если хотите купить, нажмите ентер, но если вы нажмете Эскейп то вернетесь в самое начало");
            ConsoleKeyInfo key = Console.ReadKey();
            if (key.Key == ConsoleKey.Enter)
            {
                coast = coast + 500;
                Console.SetCursorPosition(2, 2);
                Console.WriteLine("Итоговая сумма к оплате: " + coast);
            }
            if (key.Key == ConsoleKey.Escape)
            {
                str1();
            }

            string ZakazCoast = "К оплате: " + coast;
            string p = "";
            File.AppendAllText("C:\\Users\\PC_of_Matvey\\Desktop\\Zakaz.txt" + "<Заказ от текущая дата>", p);
            File.AppendAllText("C:\\Users\\PC_of_Matvey\\Desktop\\Zakaz.txt" + "<", Zakaz + ">");
            File.AppendAllText("C:\\Users\\PC_of_Matvey\\Desktop\\Zakaz.txt" + "Цена <", ZakazCoast + ">");

            //Console.Clear();
            Console.WriteLine("Если вы хотите сделать еще один заказ то нажмите Ентер");
            key = Console.ReadKey();
            if (key.Key == ConsoleKey.Enter)
            {
                str1();
            }
        }

        static void itog03312()
        {
            Console.Clear();
            string Zakaz = "ванильны, треугольный, желтый, средний торт";
            Console.SetCursorPosition(2, 0);
            Console.WriteLine("Значит вы сейчас выбрали " + Zakaz);
            Console.SetCursorPosition(2, 1);
            Console.WriteLine("Он стоит 600,если хотите купить, нажмите ентер, но если вы нажмете Эскейп то вернетесь в самое начало");
            ConsoleKeyInfo key = Console.ReadKey();
            if (key.Key == ConsoleKey.Enter)
            {
                coast = coast + 600;
                Console.SetCursorPosition(2, 2);
                Console.WriteLine("Итоговая сумма к оплате: " + coast);
            }
            if (key.Key == ConsoleKey.Escape)
            {
                str1();
            }

            string ZakazCoast = "К оплате: " + coast;
            string p = "";
            File.AppendAllText("C:\\Users\\PC_of_Matvey\\Desktop\\Zakaz.txt" + "<Заказ от текущая дата>", p);
            File.AppendAllText("C:\\Users\\PC_of_Matvey\\Desktop\\Zakaz.txt" + "<", Zakaz + ">");
            File.AppendAllText("C:\\Users\\PC_of_Matvey\\Desktop\\Zakaz.txt" + "Цена <", ZakazCoast + ">");

            //Console.Clear();
            Console.WriteLine("Если вы хотите сделать еще один заказ то нажмите Ентер");
            key = Console.ReadKey();
            if (key.Key == ConsoleKey.Enter)
            {
                str1();
            }
        }

        static void itog03313()
        {
            Console.Clear();
            string Zakaz = "ванильны, треугольный, желтый, большой торт";
            Console.SetCursorPosition(2, 0);
            Console.WriteLine("Значит вы сейчас выбрали " + Zakaz);
            Console.SetCursorPosition(2, 1);
            Console.WriteLine("Он стоит 700,если хотите купить, нажмите ентер, но если вы нажмете Эскейп то вернетесь в самое начало");
            ConsoleKeyInfo key = Console.ReadKey();
            if (key.Key == ConsoleKey.Enter)
            {
                coast = coast + 700;
                Console.SetCursorPosition(2, 2);
                Console.WriteLine("Итоговая сумма к оплате: " + coast);
            }
            if (key.Key == ConsoleKey.Escape)
            {
                str1();
            }

            string ZakazCoast = "К оплате: " + coast;
            string p = "";
            File.AppendAllText("C:\\Users\\PC_of_Matvey\\Desktop\\Zakaz.txt" + "<Заказ от текущая дата>", p);
            File.AppendAllText("C:\\Users\\PC_of_Matvey\\Desktop\\Zakaz.txt" + "<", Zakaz + ">");
            File.AppendAllText("C:\\Users\\PC_of_Matvey\\Desktop\\Zakaz.txt" + "Цена <", ZakazCoast + ">");

            //Console.Clear();
            Console.WriteLine("Если вы хотите сделать еще один заказ то нажмите Ентер");
            key = Console.ReadKey();
            if (key.Key == ConsoleKey.Enter)
            {
                str1();
            }
        }

        //нач шоколадный треуг син
        static void WanilTriangularBlue()
        {
            tort.big = "Большой";
            tort.small = "Маленький";
            tort.average = "Средний";

            Console.Clear();
            Console.SetCursorPosition(2, 0);
            Console.WriteLine("Размеры треугольных ванильных синих тортов:");

            Console.SetCursorPosition(0, pos0332);
            Console.WriteLine("->");

            Console.SetCursorPosition(2, 1);
            Console.WriteLine(tort.big);
            Console.SetCursorPosition(2, 2);
            Console.WriteLine(tort.small);
            Console.SetCursorPosition(2, 3);
            Console.WriteLine(tort.average);
            Console.SetCursorPosition(2, 4);
            Console.WriteLine("Общая стоимость равна: " + coast);

            ConsoleKeyInfo key = Console.ReadKey();

            while (true)
            {
                if (key.Key == ConsoleKey.DownArrow)
                {
                    pos0332++;

                    if (pos0332 < 4)
                    {
                        Console.SetCursorPosition(0, pos0332);
                        Console.WriteLine("->");
                        Console.SetCursorPosition(0, pos0332 - 1);
                        Console.WriteLine("  ");
                    }
                    else
                    {
                        pos0332 = 1;
                        Console.SetCursorPosition(0, pos0332);
                        Console.WriteLine("->");
                        Console.SetCursorPosition(0, pos0332 + 2);
                        Console.WriteLine("  ");
                    }

                }//стрелка вниз
                if (key.Key == ConsoleKey.UpArrow)
                {
                    pos0332--;
                    Console.SetCursorPosition(0, pos0332);
                    Console.WriteLine("->");
                    Console.SetCursorPosition(0, pos0332 + 1);
                    Console.WriteLine("  ");
                    if (pos0332 <= 0)
                    {
                        pos0332 = 4;
                        Console.SetCursorPosition(0, pos0332 - 1);
                        Console.WriteLine("->");
                        Console.SetCursorPosition(0, pos0332 - 4);
                        Console.WriteLine("  ");
                    }
                }//стрелка вверх
                if (key.Key == ConsoleKey.Escape)
                {
                    WanilTriangular();

                }//выход
                if (key.Key == ConsoleKey.Enter)
                {
                    if (pos0332 == 1)
                    {
                        itog03323();
                    }
                    if (pos0332 == 2)
                    {
                        itog03321();
                    }
                    if (pos0332 == 3)
                    {
                        itog03322();
                    }
                }
                key = Console.ReadKey();
            }
        }
        //кон шоколадный треуг син

        static void itog03323()
        {
            Console.Clear();
            string Zakaz = "ванильны, треугольный, синий, большой торт";
            Console.SetCursorPosition(2, 0);
            Console.WriteLine("Значит вы сейчас выбрали " + Zakaz);
            Console.SetCursorPosition(2, 1);
            Console.WriteLine("Он стоит 700,если хотите купить, нажмите ентер, но если вы нажмете Эскейп то вернетесь в самое начало");
            ConsoleKeyInfo key = Console.ReadKey();
            if (key.Key == ConsoleKey.Enter)
            {
                coast = coast + 700;
                Console.SetCursorPosition(2, 2);
                Console.WriteLine("Итоговая сумма к оплате: " + coast);
            }
            if (key.Key == ConsoleKey.Escape)
            {
                str1();
            }

            string ZakazCoast = "К оплате: " + coast;
            string p = "";
            File.AppendAllText("C:\\Users\\PC_of_Matvey\\Desktop\\Zakaz.txt" + "<Заказ от текущая дата>", p);
            File.AppendAllText("C:\\Users\\PC_of_Matvey\\Desktop\\Zakaz.txt" + "<", Zakaz + ">");
            File.AppendAllText("C:\\Users\\PC_of_Matvey\\Desktop\\Zakaz.txt" + "Цена <", ZakazCoast + ">");

            //Console.Clear();
            Console.WriteLine("Если вы хотите сделать еще один заказ то нажмите Ентер");
            key = Console.ReadKey();
            if (key.Key == ConsoleKey.Enter)
            {
                str1();
            }
        }

        static void itog03321()
        {
            Console.Clear();
            string Zakaz = "ванильны, треугольный, синий, маленький торт";
            Console.SetCursorPosition(2, 0);
            Console.WriteLine("Значит вы сейчас выбрали " + Zakaz);
            Console.SetCursorPosition(2, 1);
            Console.WriteLine("Он стоит 500,если хотите купить, нажмите ентер, но если вы нажмете Эскейп то вернетесь в самое начало");
            ConsoleKeyInfo key = Console.ReadKey();
            if (key.Key == ConsoleKey.Enter)
            {
                coast = coast + 500;
                Console.SetCursorPosition(2, 2);
                Console.WriteLine("Итоговая сумма к оплате: " + coast);
            }
            if (key.Key == ConsoleKey.Escape)
            {
                str1();
            }
            
            string ZakazCoast = "К оплате: " + coast;
            string p = "";
            File.AppendAllText("C:\\Users\\PC_of_Matvey\\Desktop\\Zakaz.txt" + "<Заказ от текущая дата>", p);
            File.AppendAllText("C:\\Users\\PC_of_Matvey\\Desktop\\Zakaz.txt" + "<", Zakaz + ">");
            File.AppendAllText("C:\\Users\\PC_of_Matvey\\Desktop\\Zakaz.txt" + "Цена <", ZakazCoast + ">");

            //Console.Clear();
            Console.WriteLine("Если вы хотите сделать еще один заказ то нажмите Ентер");
            key = Console.ReadKey();
            if (key.Key == ConsoleKey.Enter)
            {
                str1();
            }
        }

        static void itog03322()
        {
            Console.Clear();
            Console.SetCursorPosition(2, 0);
            Console.WriteLine("Значит вы сейчас выбрали ванильны, треугольный, синий, средний торт");
            Console.SetCursorPosition(2, 1);
            Console.WriteLine("Он стоит 600,если хотите купить, нажмите ентер, но если вы нажмете Эскейп то вернетесь в самое начало");
            ConsoleKeyInfo key = Console.ReadKey();
            if (key.Key == ConsoleKey.Enter)
            {
                coast = coast + 600;
                Console.SetCursorPosition(2, 2);
                Console.WriteLine("Итоговая сумма к оплате: " + coast);
            }
            if (key.Key == ConsoleKey.Escape)
            {
                str1();
            }
            string Zakaz = "ванильны, треугольный, красный, маленький торт";
            string ZakazCoast = "К оплате: " + coast;
            string p = "";
            File.AppendAllText("C:\\Users\\PC_of_Matvey\\Desktop\\Zakaz.txt" + "<Заказ от текущая дата>", p);
            File.AppendAllText("C:\\Users\\PC_of_Matvey\\Desktop\\Zakaz.txt" + "<", Zakaz + ">");
            File.AppendAllText("C:\\Users\\PC_of_Matvey\\Desktop\\Zakaz.txt" + "Цена <", ZakazCoast + ">");

            //Console.Clear();
            Console.WriteLine("Если вы хотите сделать еще один заказ то нажмите Ентер");
            key = Console.ReadKey();
            if (key.Key == ConsoleKey.Enter)
            {
                str1();
            }
        }






        //нач шоколадный треуг крас
        static void WanilTriangularRad()
        {
            tort.big = "Большой";
            tort.small = "Маленький";
            tort.average = "Средний";

            Console.Clear();
            Console.SetCursorPosition(2, 0);
            Console.WriteLine("Размеры треугольных ванильных красных тортов:");

            Console.SetCursorPosition(0, pos0333);
            Console.WriteLine("->");

            Console.SetCursorPosition(2, 1);
            Console.WriteLine(tort.big);
            Console.SetCursorPosition(2, 2);
            Console.WriteLine(tort.small);
            Console.SetCursorPosition(2, 3);
            Console.WriteLine(tort.average);
            Console.SetCursorPosition(2, 4);
            Console.WriteLine("Общая стоимость равна: " + coast);

            ConsoleKeyInfo key = Console.ReadKey();

            while (true)
            {
                if (key.Key == ConsoleKey.DownArrow)
                {
                    pos0333++;

                    if (pos0333 < 4)
                    {
                        Console.SetCursorPosition(0, pos0333);
                        Console.WriteLine("->");
                        Console.SetCursorPosition(0, pos0333 - 1);
                        Console.WriteLine("  ");
                    }
                    else
                    {
                        pos0333 = 1;
                        Console.SetCursorPosition(0, pos0333);
                        Console.WriteLine("->");
                        Console.SetCursorPosition(0, pos0333 + 2);
                        Console.WriteLine("  ");
                    }

                }//стрелка вниз
                if (key.Key == ConsoleKey.UpArrow)
                {
                    pos0333--;
                    Console.SetCursorPosition(0, pos0333);
                    Console.WriteLine("->");
                    Console.SetCursorPosition(0, pos0333 + 1);
                    Console.WriteLine("  ");
                    if (pos0333 <= 0)
                    {
                        pos0333 = 4;
                        Console.SetCursorPosition(0, pos0333 - 1);
                        Console.WriteLine("->");
                        Console.SetCursorPosition(0, pos0333 - 4);
                        Console.WriteLine("  ");
                    }
                }//стрелка вверх
                if (key.Key == ConsoleKey.Escape)
                {
                    WanilTriangular();

                }//выход
                if (key.Key == ConsoleKey.Enter)
                {
                    if (pos0333 == 1)
                    {
                        itog03333();
                    }
                    if (pos0333 == 2)
                    {
                        itog03331();
                    }
                    if (pos0333 == 3)
                    {
                        itog03332();
                    }
                }
                key = Console.ReadKey();
            }
        }
        //кон шоколадный треуг крас
        static void itog03333()
        {
            Console.Clear();
            Console.SetCursorPosition(2, 0);
            Console.WriteLine("Значит вы сейчас выбрали ванильны, треугольный, красный, большой торт");
            Console.SetCursorPosition(2, 1);
            Console.WriteLine("Он стоит 700,если хотите купить, нажмите ентер, но если вы нажмете Эскейп то вернетесь в самое начало");
            ConsoleKeyInfo key = Console.ReadKey();
            if (key.Key == ConsoleKey.Enter)
            {
                coast = coast + 700;
                Console.SetCursorPosition(2, 2);
                Console.WriteLine("Итоговая сумма к оплате: " + coast);
            }
            if (key.Key == ConsoleKey.Escape)
            {
                str1();
            }
            string Zakaz = "ванильны, треугольный, красный, большой торт";
            string ZakazCoast = "К оплате: " + coast;
            string p = "";
            File.AppendAllText("C:\\Users\\PC_of_Matvey\\Desktop\\Zakaz.txt" + "<Заказ от текущая дата>", p);
            File.AppendAllText("C:\\Users\\PC_of_Matvey\\Desktop\\Zakaz.txt" + "<", Zakaz + ">");
            File.AppendAllText("C:\\Users\\PC_of_Matvey\\Desktop\\Zakaz.txt" + "Цена <", ZakazCoast + ">");

            //Console.Clear();
            Console.WriteLine("Если вы хотите сделать еще один заказ то нажмите Ентер");
            key = Console.ReadKey();
            if (key.Key == ConsoleKey.Enter)
            {
                str1();
            }
        }


        static void itog03332()
        {
            Console.Clear();
            Console.SetCursorPosition(2, 0);
            Console.WriteLine("Значит вы сейчас выбрали ванильны, треугольный, красный, средний торт");
            Console.SetCursorPosition(2, 1);
            Console.WriteLine("Он стоит 600,если хотите купить, нажмите ентер, но если вы нажмете Эскейп то вернетесь в самое начало");
            ConsoleKeyInfo key = Console.ReadKey();
            if (key.Key == ConsoleKey.Enter)
            {
                coast = coast + 600;
                Console.SetCursorPosition(2, 2);
                Console.WriteLine("Итоговая сумма к оплате: " + coast);
            }
            if (key.Key == ConsoleKey.Escape)
            {
                str1();
            }
            string Zakaz = "ванильны, треугольный, красный, средний торт";
            string ZakazCoast = "К оплате: " + coast;
            string p = "";
            File.AppendAllText("C:\\Users\\PC_of_Matvey\\Desktop\\Zakaz.txt" + "<Заказ от текущая дата>", p);
            File.AppendAllText("C:\\Users\\PC_of_Matvey\\Desktop\\Zakaz.txt" + "<", Zakaz + ">");
            File.AppendAllText("C:\\Users\\PC_of_Matvey\\Desktop\\Zakaz.txt" + "Цена <", ZakazCoast + ">");

            //Console.Clear();
            Console.WriteLine("Если вы хотите сделать еще один заказ то нажмите Ентер");
            key = Console.ReadKey();
            if (key.Key == ConsoleKey.Enter)
            {
                str1();
            }


        }
        static void itog03331()
        {
            Console.Clear();
            Console.SetCursorPosition(2, 0);
            Console.WriteLine("Значит вы сейчас выбрали ванильны, треугольный, красный, маленький торт");
            Console.SetCursorPosition(2, 1);
            Console.WriteLine("Он стоит 500,если хотите купить, нажмите ентер, но если вы нажмете Эскейп то вернетесь в самое начало");
            ConsoleKeyInfo key = Console.ReadKey();
            if (key.Key == ConsoleKey.Enter)
            {
                coast = coast + 500;
                Console.SetCursorPosition(2, 2);
                Console.WriteLine("Итоговая сумма к оплате: " + coast);
            }
            if (key.Key == ConsoleKey.Escape)
            {
                str1();
            }
            string Zakaz = "ванильны, треугольный, красный, маленький торт";
            string ZakazCoast = "К оплате: " + coast;
            string p = "";
            File.AppendAllText("C:\\Users\\PC_of_Matvey\\Desktop\\Zakaz.txt" + "<Заказ от текущая дата>", p);
            File.AppendAllText("C:\\Users\\PC_of_Matvey\\Desktop\\Zakaz.txt" + "<", Zakaz + ">");
            File.AppendAllText("C:\\Users\\PC_of_Matvey\\Desktop\\Zakaz.txt" + "Цена <", ZakazCoast + ">");

            //Console.Clear();
            Console.WriteLine("Если вы хотите сделать еще один заказ то нажмите Ентер");
            key = Console.ReadKey();
            if (key.Key == ConsoleKey.Enter)
            {
                str1();
            }
        }//кон итогов 03331



    }
}