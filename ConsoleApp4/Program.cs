using System;

namespace ConsoleApp4
{
    class Program
    {
        static void Main(string[] args)
        {
            //int min = 0, max = 0;
            //int min1 = 0, max1 = 0;
            //int min2 = 0, max2 = 0;
            //int sum = 0, sum1 = 0, sum2 = 0;
            //double pro = 1, pro1 = 1, pro2 = 1;
            //int even = 0;
            //int odd = 0;
            //int[] A = new int[5];
            //int[,] B = new int[3, 4];
            //Random r = new Random();
            //for (int i = 0; i < A.Length; i++)
            //{
            //    A[i] = int.Parse(Console.ReadLine());
            //    min1 = A[0];
            //    if (A[i] > max1)
            //    {
            //        max1 = A[i];
            //    }
            //    if (A[i] < min1)
            //    {
            //        min1 = A[i];
            //    }
            //    sum1 += A[i];
            //    pro1 *= A[i];
            //    if (A[i] / 2 == 0)
            //    {
            //        even += A[i];
            //    }
            //}
            //for (int i = 0; i < B.GetLength(0); i++)
            //{
            //    for (int j = 0; j < B.GetLength(1); j++)
            //    {
            //        B[i, j] = r.Next(1, 100);
            //    if (B[i,j] > max2)
            //    {
            //        max2 = B[i,j];
            //    }
            //    if (B[i,j] < min2)
            //    {
            //        min2 = B[i,j];
            //    }
            //        Console.Write(String.Format("{0,3}", B[i, j]));
            //        if (B[i, j] / 2 != 0)
            //        {
            //            odd += B[i, j];
            //        }
            //        sum2 += B[i, j];
            //        pro2 *= B[i, j];
            //    }
            //    Console.WriteLine("\n");
            //}
            //string s = string.Join(" ", A);
            //Console.WriteLine(s);
            //if (max1 > max2)
            //{
            //    max = max1;
            //}
            //else
            //{
            //    max = max2;
            //}
            //if (min1 < min2)
            //{
            //    min = min1;
            //}
            //else
            //{
            //    min = min2;
            //}
            //sum = sum + sum2;
            //pro = pro1 * pro2;
            //Console.WriteLine("Максимальное:");
            //Console.WriteLine(max);
            //Console.WriteLine("Минимальное:");
            //Console.WriteLine(min);

            //Console.WriteLine("Общая сумма:");
            //Console.WriteLine(sum);
            //Console.WriteLine("Общее произведение:");
            //Console.WriteLine(pro);

            //Console.WriteLine("Сумма четных А:");
            //Console.WriteLine(even);
            //Console.WriteLine("Сумма нечетных В:");
            //Console.WriteLine(odd);

            //int[,] B = new int[5, 5];
            //int min = 0,max=0,sum=0;
            //Random r = new Random();
            //for (int i = 0; i < B.GetLength(0); i++)
            //{
            //    for (int j = 0; j < B.GetLength(1); j++)
            //    {
            //        B[i, j] = r.Next(-100, 100);
            //        min = B[0, 0];
            //        if (B[i, j] > max)
            //        {
            //            max = B[i, j];
            //        }
            //        if (B[i, j] < min)
            //        {
            //            min = B[i, j];
            //        }
            //        if(B[i,j]>=min&&B[i,j]<max)
            //        {
            //            sum += B[i, j];
            //        }
            //        Console.Write(String.Format("{0,3}", B[i, j]));

            //    }
            //    Console.WriteLine("\n");
            //}
            //Console.WriteLine("Сумма:");
            //Console.WriteLine(sum);

            //int[,] mat = new int[5, 5];
            //int[,] mat2 = new int[5, 5];
            //int[,] Mat = new int[5, 5];
            //Random r = new Random();
            //Console.WriteLine("Нa какое число умножить:");
            //int num = int.Parse(Console.ReadLine());
            //for (int i = 0; i < mat.GetLength(0); i++)
            //{
            //    for (int j = 0; j < mat.GetLength(1); j++)
            //    {
            //        mat[i, j] = r.Next(1, 100);
            //        Mat[i, j] = mat[i, j] * num;

            //        Console.Write(String.Format("{0,3}", mat[i, j]));
            //    }
            //    Console.Write("\n");
            //}
            //for (int i = 0; i < mat2.GetLength(0); i++)
            //{
            //    for (int j = 0; j < mat2.GetLength(1); j++)
            //    {
            //        mat2[i, j] = r.Next(1, 100);


            //        Console.Write(String.Format("{0,3}", mat2[i, j]));
            //    }
            //    Console.Write("\n");
            //}

            //Console.Write("Умноженная:");
            //for (int i = 0; i < mat.GetLength(0); i++)
            //{
            //    for (int j = 0; j < mat.GetLength(1); j++)
            //    {
            //        Console.Write(String.Format("{0,3}", Mat[i, j]));
            //    }
            //    Console.Write("\n");
            //}

            //Console.WriteLine("Произведение матриц:");
            //for (int i = 0; i < mat.GetLength(0); i++)
            //{
            //    for (int j = 0; j < mat2.GetLength(0); j++)
            //    {
            //        for (int k = 0; k < mat2.GetLength(1); k++)
            //        {
            //            Mat[i, j] += mat[i, k] * mat2[k, j];
            //            Console.Write(String.Format("{0,3}", Mat[i, j]));
            //        }
            //        Console.Write("\n");
            //    }
            //}
            //Console.WriteLine("Сумма матриц:");
            //for (int i = 0; i < mat.GetLength(0); i++)
            //{
            //    for (int j = 0; j < mat.GetLength(1); j++)
            //    {
            //        for (int k = 0; k < mat2.GetLength(0); k++)
            //        {
            //            for (int b = 0; b < mat2.GetLength(1); b++)
            //            {
            //                Mat[i, j] += mat[i, j] + mat2[k, b];
            //                Console.Write(String.Format("{0,3}", Mat[i, j]));
            //            }
            //        }
            //        Console.Write("\n");
            //    }
            //}

        }
        
    }
    //public static class StringExtensions
    //{
    //    public static string Capitalize(this string s)
    //    {
    //        if (String.IsNullOrEmpty(s))
    //        {
    //            throw new ArgumentException("String is mull or empty");
    //        }

    //        return s[0].ToString().ToUpper() + s.Substring(1);
    //    }
    //}

    //public class Example
    //{
    //    public static void Main()
    //    {
    //        string s = "hello";

    //        s = s.Capitalize();

    //        Console.WriteLine(s);       
    //    }
    //}
}
