using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab19
{
    class Program
    {
        static void Main(string[] args)
        {
            const int n = 6;            
            List<Computer> listComputer = new List<Computer>()
            {
                new Computer(){Code=1,Name="Samsung",TypeProcessor="AMD",Frequency =2000,VolumeRAM=16,VolumeDisk=1024,VolumeVideoCard=3000,Price =44999.50,Count =25},
                new Computer(){Code=2,Name="Acer",TypeProcessor="Intel",Frequency =1500,VolumeRAM=8,VolumeDisk=2048,VolumeVideoCard=2000,Price =49999.50,Count =40},
                new Computer(){Code=3,Name="HP",TypeProcessor="AMD",Frequency =1000,VolumeRAM=8,VolumeDisk=512,VolumeVideoCard=1500,Price =44999.50,Count =10},
                new Computer(){Code=4,Name="Lenovo",TypeProcessor="Intel",Frequency =2500,VolumeRAM=16,VolumeDisk=512,VolumeVideoCard=1000,Price =54999.50,Count =15},
                new Computer(){Code=5,Name="Dell",TypeProcessor="Intel",Frequency =2300,VolumeRAM=4,VolumeDisk=1024,VolumeVideoCard=2500,Price =39999.50,Count =20},
                new Computer(){Code=6,Name="Huawei",TypeProcessor="AMD",Frequency =3000,VolumeRAM=4,VolumeDisk=256,VolumeVideoCard=3500,Price =34999.50,Count =31},
                new Computer(){Code=7,Name="Asus",TypeProcessor="AMD",Frequency =3000,VolumeRAM=4,VolumeDisk=256,VolumeVideoCard=3500,Price =44999.50,Count =50},
                new Computer(){Code=8,Name="Samsung",TypeProcessor="Intel",Frequency =3000,VolumeRAM=4,VolumeDisk=256,VolumeVideoCard=3500,Price =64999.50,Count =30},
                new Computer(){Code=9,Name="Xiaomi",TypeProcessor="Intel",Frequency =3000,VolumeRAM=4,VolumeDisk=256,VolumeVideoCard=3500,Price =54999.50,Count =12}
            };

            Console.WriteLine("Введите тип процессора");
            string type = Console.ReadLine();
            List<Computer> computer1 = listComputer.Where(x => x.TypeProcessor == type).ToList();
            Print(computer1);

            Console.WriteLine("Введите объём ОЗУ");
            int ram = Convert.ToInt32(Console.ReadLine());
            List<Computer> computer2 = listComputer.Where(x => x.VolumeRAM >= ram).ToList();
            Print(computer1);

            // Список, отсортированный по увеличению стоимости 
            var sortPrice = listComputer
                .OrderBy(d => d.Price)
                .ToList();
            Print(sortPrice);
            

            // Список, сгруппированный по типу процессора
            var typeProc = listComputer
                .Where (d=>d.TypeProcessor=="AMD")
                .ToList();
            Print(typeProc);
            

            // Нахождение компьютера с максимальной ценной
            var max = listComputer
                .OrderByDescending(d => d.Price)
                .FirstOrDefault();
            Console.WriteLine($"{max.Code} {max.Name} {max.TypeProcessor} {max.Frequency} {max.VolumeRAM} {max.VolumeDisk} {max.VolumeVideoCard} {max.Price} {max.Count}\n");
            

            // Нахождение компьютера с минимальной ценной
            var min = listComputer
                .OrderBy(d => d.Price)
                .FirstOrDefault();
            Console.WriteLine($"{min.Code} {min.Name} {min.TypeProcessor} {min.Frequency} {min.VolumeRAM} {min.VolumeDisk} {min.VolumeVideoCard} {min.Price} {min.Count}\n");

            // Нахождение списка компьютеров с количеством не менее 30 штук
            var count = listComputer
                .Where(d => d.Count>=30)
                .ToList();
            Print(count);

            
        }
        static void Print(List<Computer> computers)
        {
            foreach (Computer d in computers)
            {
                Console.WriteLine($"{d.Code} {d.Name} {d.TypeProcessor} {d.Frequency} {d.VolumeRAM} {d.VolumeDisk} {d.VolumeVideoCard} {d.Price} {d.Count}");
            }
            Console.WriteLine();                
        }
    }
}
