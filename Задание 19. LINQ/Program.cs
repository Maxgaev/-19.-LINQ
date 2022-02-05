using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Задание_19.LINQ
{
    internal class Program
    {
        static void Main(string[] args)
        {
            List<Notebook> notebooks = new List<Notebook>()
            {
                new Notebook(){Id=10001, Name="DeLL", Cpu="Intel Core i3", Proc=2000, Ram=4, HDD=250, Graphics=1024, Price=20990, Stock=12},
                new Notebook(){Id=10021, Name="DeLL", Cpu="Intel Core i7", Proc=2850, Ram=16, HDD=500, Graphics=4095, Price=118990, Stock=2},
                new Notebook(){Id=20001, Name="Acer", Cpu="Intel Core i5", Proc=1600, Ram=8, HDD=500, Graphics=2048, Price=50990, Stock=8},
                new Notebook(){Id=20031, Name="Acer", Cpu="AMD Ryzen", Proc=2200, Ram=16, HDD=1000, Graphics=2048, Price=80990, Stock=6},
                new Notebook(){Id=30001, Name="HP", Cpu="AMD Ryzen", Proc=3100, Ram=16, HDD=1000, Graphics=6095, Price=150990, Stock=1},
                new Notebook(){Id=21201, Name="Asus", Cpu="AMD Ryzen", Proc=1800, Ram=8, HDD=500, Graphics=2048, Price=92990, Stock=3},
                new Notebook(){Id=21211, Name="Asus", Cpu="Intel Core i5", Proc=1600, Ram=6, HDD=1000, Graphics=1024, Price=62990, Stock=4},
                new Notebook(){Id=50001, Name="Lenovo", Cpu="Intel Core i5", Proc=2300, Ram=8, HDD=600, Graphics=1095, Price=75990, Stock=3},
                new Notebook(){Id=60001, Name="MSI", Cpu="AMD Ryzen", Proc=3100, Ram=16, HDD=1000, Graphics=6095, Price=135990, Stock=1},
                new Notebook(){Id=70001, Name="Honor", Cpu="Intel Core i7", Proc=2100, Ram=16, HDD=5000, Graphics=1024, Price=95990, Stock=1},
            };
            Console.WriteLine("\nведите характеристики Notebook: тип процессора\n");
            string cpu = Console.ReadLine();
            List<Notebook> noteCpu = notebooks.Where(x => x.Cpu == cpu).ToList();
            foreach (var x in noteCpu)
                Console.WriteLine($"{x.Id} {x.Name} {x.Cpu} {x.Proc} {x.Ram} {x.HDD} {x.Graphics} {x.Price} {x.Stock}");

            Console.WriteLine("\nведите характеристики Notebook: объем ОЗУ\n");
            int ram = Convert.ToInt32(Console.ReadLine());
            List<Notebook> noteRam = notebooks.Where(x => x.Ram == ram).ToList();
            foreach (var x in noteRam)
                Console.WriteLine($"{x.Id} {x.Name} {x.Cpu} {x.Proc} {x.Ram} {x.HDD} {x.Graphics} {x.Price} {x.Stock}");

            Console.Clear();
            Console.WriteLine("Cписок по стоимости:");
            var notesPrice = notebooks
                .OrderBy(x => x.Price)
                .ToList();
            foreach (var x in notesPrice)
                Console.WriteLine($"{x.Id} {x.Name} {x.Cpu} {x.Proc} {x.Ram} {x.HDD} {x.Graphics} {x.Price} {x.Stock}");
            Console.ReadKey();
            Console.Clear();
            Console.WriteLine("\nСамый дорогой компьютер:");
            var notesMax = notebooks
                .Max(x => x.Price);
            Console.WriteLine(notesMax);

            Console.WriteLine("\nСамый дешевый компьютер:");
            var notesMin = notebooks
                .Min(x => x.Price);
            Console.WriteLine(notesMin);
            Console.ReadKey();

            Console.WriteLine("\nНаличие notebook:");
            bool noteStock = notebooks
                .Any(x => x.Stock > 2);
            if (noteStock)
                Console.WriteLine("\nНа складе есть более 2 notebook");
            else
                Console.WriteLine("\nна складе отсутствует");
            Console.ReadKey();
        }
    }
}
