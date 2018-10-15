//Task 1

//using System;

//namespace HelloWorld
//{
//    class Program
//    {
//        static void Main(string[] args)
//        {
//            Console.WriteLine("Hello World!");
//        }
//    }
//}

//Task 2
//using System;

//namespace Expressions
//{
//    class Program
//    {
//        static void Main(string[] args)
//        {
//            Console.WriteLine((3522 + 52353) * 23 - (2336 * 501 + 23432 - 6743) * 3);
//        }
//    }
//}

//Task 3
//using System;

//namespace Num1to20
//{
//    class Program
//    {
//        static void Main(string[] args)
//        {
//            for (int i = 1; i <= 20; i++)
//            {
//                Console.WriteLine(i);
//            }
//        }
//    }
//}

//Task 4
//using System;

//namespace TriangleOf55Stars
//{
//    class Program
//    {
//        static void Main(string[] args)
//        {
//            for (int i = 0; i <= 10; i++)
//            {
//                for (int j = 0; j < i; j++)
//                {
//                    Console.Write('*');
//                }
//                    Console.WriteLine();

//                }
//            }
//        }
//}

//Task 5
//using System;

//namespace TriangleSquare
//{
//    class Program
//    {
//        static void Main(string[] args)
//        {
//            var a = decimal.Parse(Console.ReadLine());
//            var b = decimal.Parse(Console.ReadLine());
//            Console.WriteLine(a * b);
//        }
//    }
//}

//Task 6
//using System;

//namespace TriangleSquare
//{
//    class Program
//    {
//        static void Main(string[] args)
//        {
//            int n = int.Parse(Console.ReadLine());
//            Console.WriteLine(new string('*', n));

//            for (int i = 0; i < n - 2; i++)
//            {
//                Console.WriteLine('*' + new string (' ', n -2) + "*" );
//            }
//            Console.WriteLine(new string('*', n));
//        }
//    }
//}