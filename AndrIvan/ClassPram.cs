using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AndrIvan
{
    public class ClassPram
    {
        public static bool brake = false;
        int x, y, shirina, visota;

        public ClassPram(int x, int y, int shirina, int visota)
        {
            this.x = x;
            this.y = y;
            this.shirina = shirina;
            this.visota = visota;
        }
        public void peremeshenie(int l, int h, ref int x, ref int y)
        {
            x -= l;
            y -= h;
            Console.ForegroundColor = ConsoleColor.Red;
            Console.WriteLine("Перемещение удачно! {0} {1}", x, y);
            Console.ResetColor();
        }

        public void sovmeshenie(int x1, int x2, int y1, int y2, int shirina1, int shirina2, int visota1, int visota2)
        {

            if (x1 > x2)
            {
                int buf = x1;
                x1 = x2;
                x2 = buf;
            }
            if (x1 + shirina1 < x2 + shirina2)
            {
                x = x1;
                shirina = x2 - x1 + shirina2;
            }
            else
            {
                x = x1;
                shirina = shirina2;
            }
            if (y1 > y2)
            {
                int buf = y1;
                y1 = y2;
                y2 = buf;
            }
            if (y1 + visota1 < y2 + visota2)
            {
                y = y1;
                visota = y2 - y1 + visota2;
            }
            else
            {
                y = y1;
                visota = visota2;
            }
            Console.ForegroundColor = ConsoleColor.Red;
            Console.WriteLine("x={0},y={1},Ширина={2},Высота={3}", x, y, shirina, visota);
            Console.WriteLine("Совмещение удачно!");
            Console.ResetColor();
        }

        public void izmenenie(int x, int y, ref int shirina, ref int visota)
        {
            shirina -= x;
            visota -= y;
            Console.ForegroundColor = ConsoleColor.Red;
            Console.WriteLine("Изменение удачно! {0} {1}", shirina, visota);
            Console.ResetColor();
        }

        public void show_Prim(int x, int y, int shirina, int visota)
        {
            Console.ForegroundColor = ConsoleColor.Red;
            Console.WriteLine("{0} {1} {2} {3}", x, y, shirina, visota);
            Console.WriteLine("Вывод удачен!");
            Console.ResetColor();
        }

    }
}
