using System;

namespace ConsoleApplication9

{

    class Program

    {

        static void Main(string[] args)
        {
            Console.WriteLine("1.");
            int k = Convert.ToInt32(Console.ReadLine());
            int l = Convert.ToInt32(Console.ReadLine());
            int[] array = new int[l];
            for (int i = 0; i < l; i++)
            {
                array[i] = Convert.ToInt32(Console.ReadLine());
            }
            int sum = 0;
            for (int i = 0; i < l; i++)
            {
                if (array[i] % k == 0) sum += array[i];
            }
            Console.WriteLine("Сумма равна " + firstTask(array, k));
            Console.WriteLine("2. ");
            array = new int[l];
            for (int i = 0; i < l; i++)
            {
                array[i] = Convert.ToInt32(Console.ReadLine());
            }
            if (array[0] > 0) Console.WriteLine("Положительные"); else Console.WriteLine("Отрицательные ");
            Console.WriteLine("3 ");
            double[] arr1 = new double[l];
            for (int i = 0; i < l; i++)
            {
                arr1[i] = Convert.ToDouble(Console.ReadLine());
            }
            Console.WriteLine(isArrayIncreasing(arr1));
            Console.WriteLine("4.");
            array = new int[l];
            for (int i = 0; i < l; i++)
            {
                array[i] = Convert.ToInt32(Console.ReadLine());
            }
            countEvenNumbers(array);
        }
        private static void countEvenNumbers(int[] arr)
        {
            int evenSum = 0;
            for (int i = 0; i < arr.Length; i++)
            {
                if (arr[i] % 2 == 0) evenSum += arr[i];
            }
            if (evenSum == 0) Console.WriteLine("Четных чисел нет ");
            Console.WriteLine("Четная сумма равна " + evenSum);
        }
        private static bool isArrayIncreasing(double[] arr)
        {
            for (int i = 0; i < arr.Length - 1; i++)
            {
                if (arr[i] > arr[i + 1]) return false;
            }
            return true;
        }
        private static int firstTask(int[] arr, int k)
        {
            int sum = 0;
            for (int i = 0; i < arr.Length; i++)
            {
                if (arr[i] % k == 0) sum += arr[i];

            }
            return sum;
        }
    }
}
