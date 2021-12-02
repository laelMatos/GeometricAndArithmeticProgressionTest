using System;
using System.Diagnostics;

namespace GeometricAndArithmeticProgression
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] arr1 = { 2, 4, 6, 8, 10, 12 };
            int[] arr2 = { 2, 4, 4, 8, 7, 12 };

            int[] arr3 = { 2,4,8,16};
            int[] arr4 = { 2,4,5,16};

            var stopwatch = new Stopwatch();

            Console.WriteLine("Arithmetic test");
            stopwatch.Start();
            Progression.IsArithmetic(arr1);
            stopwatch.Stop();
            Console.WriteLine($"Time IsArithmetic:     {stopwatch.Elapsed}");

            stopwatch.Restart();
            Progression.IsArithmeticFast(arr1);
            Console.WriteLine($"Time IsArithmeticFast: {stopwatch.Elapsed}");
            stopwatch.Stop();

            stopwatch.Restart();
            Progression.IsArithmetic(arr2);
            stopwatch.Stop();
            Console.WriteLine($"Time IsArithmetic fail:     {stopwatch.Elapsed}");

            stopwatch.Restart();
            Progression.IsArithmeticFast(arr2);
            Console.WriteLine($"Time IsArithmeticFast fail: {stopwatch.Elapsed}");
            stopwatch.Stop();
            Console.WriteLine("///////////////////////////////////////\n\r");

            Console.WriteLine("Geometric test");
            stopwatch.Start();
            Progression.IsGeometric(arr3);
            stopwatch.Stop();
            Console.WriteLine($"Time IsGeometric:     {stopwatch.Elapsed}");

            stopwatch.Restart();
            Progression.IsGeometricFast(arr3);
            Console.WriteLine($"Time IsGeometricFast: {stopwatch.Elapsed}");
            stopwatch.Stop();

            stopwatch.Restart();
            Progression.IsGeometric(arr4);
            stopwatch.Stop();
            Console.WriteLine($"Time IsGeometric fail:     {stopwatch.Elapsed}");

            stopwatch.Restart();
            Progression.IsGeometricFast(arr4);
            Console.WriteLine($"Time IsGeometricFast fail: {stopwatch.Elapsed}");
            stopwatch.Stop();

            Console.WriteLine("///////////////////////////////////////");

            Console.ReadKey();
        }
        
    }
}
