using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Deligate
{
    internal class Program
    {
        delegate void Reform(int idx);

        class Reforms
        {
            public string[] first = { "Інноваційна", "Ліберальна", "Надихаюча", "Незалежна", "Проривна", "Демократична", "Вільна", "Громадська", "Цифрова", "Лідерська" };
            public string[] second = { "", "економічна", "судова", "європейська", "інституційна", "урядова", "податкова", "інтегрована", "післявоєнна", "інфраструктурна", "державна", "президентська", "законотворча" };
            public string[] third = { "відбудова", "стратегія", "місія", "реформа", "візія", "модернізація", "екосистема", "реконструкція", "політика", "спроможність" };
            public void f_ref(int idx)
            {
                Console.Write(first[idx % 10] );
                Console.Write(' ');
            }
            public void s_ref(int idx)
            {
                Console.Write(second[idx]);
                Console.Write(' ');
            }
            public void t_ref(int idx)
            {
                idx = idx - (idx/1000) * 1000;
                idx = idx - (idx / 100) * 100;
                idx = idx - (idx / 10) * 10;
                Console.Write(third[idx]);
                Console.WriteLine();
            }
        }




        static void Main(string[] args)
        {
            Console.OutputEncoding = Encoding.UTF8;
            Reform ref1,ref2,ref3;
            Console.WriteLine("Напишіть дату");
            Console.WriteLine("день:");
            ref1 = new Reforms().f_ref;
            int id1 = Convert.ToInt32(Console.ReadLine());
            
            Console.WriteLine("місяць:");
            ref2 = new Reforms().s_ref;
            int id2 = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("рік:");
            ref3 = new Reforms().t_ref;
            int id3 = Convert.ToInt32(Console.ReadLine());
            ref1(id1);
            ref2(id2);
            ref3(id3);


            Console.ReadKey();
        }
    }
}
