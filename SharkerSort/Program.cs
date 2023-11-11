using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SharkerSort
{
    internal class Program
    {
        static void TestShakerSort()
        {
            Console.WriteLine("Shaker Sort");
            Console.Write("Nhap cac phan tu cua mang: ");
            var parts = Console.ReadLine().Split(new[] { "", ",", ";" }, StringSplitOptions.RemoveEmptyEntries);
            var array = new int[parts.Length];
            for (int i = 0; i < parts.Length; i++)
            {
                array[i] = int.Parse(parts[i]);
            }

            Console.WriteLine("mang sau khi sap xep: {0}", string.Join(",", (array)));
        }
        

        static void Main(string[] args)
        {
            TestShakerSort();
            Console.ReadLine();
        }
    }
}
