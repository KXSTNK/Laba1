using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1

{

    class CHHHEK

    {

        public string naim { get; set; }

        public int schet { get; set; }

        public double summa { get; set; }

        public void zapis()

        {

            CHHHEK[] a = new CHHHEK[1000];

            Console.Write("Введите кол-во записей: ");

            int n = Convert.ToInt16(Console.ReadLine());

            for (int i = 0; i < n; i++)

            {

                a[i] = new CHHHEK();

                Console.Write("Наименование: ");

                a[i].naim = Console.ReadLine();

                Console.Write("Номер счёта: ");

                a[i].schet = Convert.ToInt32(Console.ReadLine());

                Console.Write("Сумма: ");

                a[i].summa = Convert.ToDouble(Console.ReadLine());

                Console.WriteLine();

            }

            Print(a, n);

        }

        public void Print(CHHHEK[] a, int nz)

        {

            Console.WriteLine(" Наименование Номер счёта " +

            " Сумма");

            for (int i = 0; i < nz; i++)

            {

                Console.WriteLine($"{a[i].naim,10} {a[i].schet,15} {a[i].summa,13}");

            }

        }

        public void start()

        {

            CHHHEK qa = new CHHHEK();

            for (int z = 0; z < 99999; z++)

            {


                Console.WriteLine();

                Console.WriteLine($"  1. Начать программу. ");

                Console.WriteLine($"  2. Очистить консоль. ");
     
                Console.WriteLine($"  3. Выйти из программы. ");
                     
                            Console.Write(" Выберите команду: ");

                int x1 = Convert.ToInt16(Console.ReadLine());

                Console.WriteLine();

                switch (x1)

                {

                    case 1: qa.zapis(); break;

                    case 2: Console.Clear(); break;

                    case 3: Environment.Exit(0); break;

                }

            }

        }

    }

}
