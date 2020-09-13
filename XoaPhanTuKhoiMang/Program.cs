using System;
using System.Text;

namespace XoaPhanTuKhoiMang
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.OutputEncoding = Encoding.UTF8;
            int[] array = { 10, 4, 6, 7, 8 };
            int k;
            Console.Write("Mảng ");
            HienMang(array, array.Length);
            Console.WriteLine("Nhập phần tử cần xoá trong mảng");
            k = Convert.ToInt32(Console.ReadLine());
            Xoa(array, k);
            Console.WriteLine("Mảng sau khi xóa là: ");
            HienMang(array, array.Length - 1);
        }

        static bool Xoa(int[] a, int k)
        {
            bool found = false;
            for (int i = 0; i < a.Length; ++i)
            {
                if (found)
                {
                    a[i - 1] = a[i];
                }
                else if (a[i] == k)
                {
                    int x = i;
                    Console.WriteLine($"Vị trí của phần tử {k} là: {x} ");
                    found = true;
                }
            }
            return found;
        }

        static void HienMang(int[] a, int size)
        {
            for (int i = 0; i < size; i++)
            {
                Console.Write(a[i] + " ");
            }
            Console.WriteLine();
        }
    }
}
