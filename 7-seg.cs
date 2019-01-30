// A Hello World! program in C#.
using System;
namespace HelloWorld
{
    class Hello
    {
        public static void Main()
        {
            Console.WriteLine("Hello World!");

            for (int counter = 1; counter <= 10; counter++)
            {

             Num_Write(counter-1);
             Console.WriteLine();
            }

            // Keep the console window open in debug mode.
            Console.WriteLine("Press any key to exit.");
            Console.ReadKey();
        }

        public static class Globals
        {
            public const Int32 BUFFER_SIZE = 512; // Unmodifiable
            public static String FILE_NAME = "Output.txt"; // Modifiable
            public static readonly String CODE_PREFIX = "US-"; // Unmodifiable
            public static int [,] num_array = new int [10,7] {  { 1,1,1,1,1,1,0 },    // 0
                                      { 0,1,1,0,0,0,0 },    // 1
                                      { 1,1,0,1,1,0,1 },    // 2
                                      { 1,1,1,1,0,0,1 },    // 3
                                      { 0,1,1,0,0,1,1 },    // 4
                                      { 1,0,1,1,0,1,1 },    // 5
                                      { 1,0,1,1,1,1,1 },    // 6
                                      { 1,1,1,0,0,0,0 },    // 7
                                      { 1,1,1,1,1,1,1 },    // 8
                                      { 1,1,1,0,0,1,1 }};   // 9
        }


        static void Num_Write(int number)
        {
          int pin= 2;
          for (int j=0; j < 7; j++) {
            Console.Write("PIN:"+ pin +" ""Value: " +Globals.num_array[number,j]+" ");

           pin++;
          }
        }
    }
}
