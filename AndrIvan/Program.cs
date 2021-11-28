using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AndrIvan
{
    class Program
    {
        static void Main(string[] args)
        {

            Console.WriteLine("Построение по левой нижней точке, высоте и длине!");
            Console.WriteLine("Введите x:");
            int x = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Введите y:");
            int y = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Введите ширину:");
            int shirina = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Введите высоту:");
            int visota = Convert.ToInt32(Console.ReadLine());
            /////////////////////////////////////////////////
            Console.WriteLine("Введите x2:");
            int x2 = Convert.ToInt32(Console.ReadLine()); 
            Console.WriteLine("Введите y2:");
            int y2 = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Введите ширину 2:");
            int shirina2 = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Введите высоту 2:");
            int visota2 = Convert.ToInt32(Console.ReadLine());
            //////////////////////////////////////////////////////
            ClassPram Func = new ClassPram(x, y, shirina, visota);
            //На сколько перемещать и изменять.
            int izmx = 1, izmy = 1;
            int perx = 1, pery = 1;
            //
            Console.WriteLine("Введите комманманду меню:");
            Console.ForegroundColor = ConsoleColor.Green;
            Console.WriteLine("Доступные команды: Перемещение, Изменение, Вывод, Совмешение, Выход");
            Console.ResetColor();
            do
            {
                switch (Console.ReadLine())
                {
                    case "Перемещение": Func.peremeshenie(perx, pery, ref x, ref y); break;
                    case "Изменение": Func.izmenenie(izmx, izmy, ref shirina, ref visota); break;
                    case "Вывод": Func.show_Prim(x, y, shirina, visota); break;
                    case "Совмешение": Func.sovmeshenie(x, x2, y, y2, shirina, shirina2, visota, visota2); break;
                    case "Выход": ClassPram.brake = true; break;
                    default: Console.WriteLine("Команда не распознона!"); break;
                }
            } while (!ClassPram.brake);
        }
    }
}
