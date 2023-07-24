using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Array_Assignment
{//1.	WAP to search for a given number in an array and accordingly print the index if exists

    public class Assignment
    {
        static void Main(string[] args)
        {
            int[] array = new int[5] { 5, 7, 56, 87, 98 };
            int max = array[0];
            for (int i = 0; i < array.Length; i++)
            {
                foreach (var item in array)
                {
                    if (array[0] > max)
                    {
                        array[i] = max;
                    }

                }

            }
            Console.WriteLine(max);
            {

            }
            int[] array = new int[5] { 1, 2, 3, 4, 5 };
            Console.WriteLine("Enter any number");
            int searchNumber = Convert.ToInt32(Console.ReadLine());
            int index = -1;

            {

                index = -1;
                for (int i = 0; i < array.Length; i++)
                {
                    if (array[i] == searchNumber)
                    {
                        index = i;
                        break;
                    }
                }

                if (index > -1)
                {
                    Console.WriteLine("The number {0} is found at index {1}", searchNumber, index);
                }
                else
                {
                    Console.WriteLine("The number {0} is not found in the array", searchNumber);
                }
                Console.WriteLine("  ");
            }
            Console.WriteLine("------ 2. WAP to create an array of 5 integers. Initialize 5 values. Display using foreach loop------.");

            int[] num = new int[5] { 1, 2, 3, 4, 5 };

            foreach (int i in num)
            {
                Console.WriteLine(i);
            }
            Console.WriteLine(" ");

            Console.WriteLine("______ 3. \tWAP to create an array of 5 strings to store students name, sort names in ascending order & display using foreach loop.\n");

            string[] name = new string[5] { "sagar", "pratik", "snehal", "pankaj", "nilesh" };


            Console.WriteLine("_______after sort_______");

            Array.Sort(name);
            foreach (string i in name)
            {
                Console.WriteLine(i);
                Console.WriteLine(" ");
            }

            Console.WriteLine("______ 4.Create matrix of 3* 3 & calculate addition & display the details\n______");
            {
                int[,] mat = new int[3, 3];
                {
                    Console.WriteLine("_____first matrix_____________");

                    for (int i = 0; i < mat.GetLength(0); i++)//row

                    {
                        for (int j = 0; j < mat.GetLength(1); j++)//col
                        {
                            Console.WriteLine($"Enter value for array[{i},{j}]");
                            mat[i, j] = Convert.ToInt32(Console.ReadLine());
                        }

                    }

                    for (int i = 0; i < mat.GetLength(0); i++)
                    {
                        for (int j = 0; j < mat.GetLength(1); j++)
                        {
                            Console.Write(mat[i, j] + " ");
                        }
                        Console.WriteLine();

                    }

                    Console.WriteLine("_____secound matrix_____________");

                    for (int i = 0; i < mat.GetLength(0); i++)
                    {
                        for (int j = 0; j < mat.GetLength(1); j++)
                        {
                            Console.WriteLine($"Enter value for array[{i},{j}]");
                            mat[i, j] = Convert.ToInt32(Console.ReadLine());
                        }

                    }

                    for (int i = 0; i < mat.GetLength(0); i++)
                    {
                        for (int j = 0; j < mat.GetLength(1); j++)
                        {
                            Console.Write(mat[i, j] + " ");
                        }
                        Console.WriteLine();
                    }
                    Console.WriteLine("_____Addition_____________");
                    for (int i = 0; i < mat.GetLength(0); i++)
                    {
                        for (int j = 0; j < mat.GetLength(1); j++)
                        {
                            Console.Write(mat[i, j] + mat[i, j] + " ");
                        }
                        Console.WriteLine();
                    }
                }
                Console.WriteLine("______WAP to create jagged array, initialized data & display the details\r\n_______");


            }
            Console.Write("Enter the number of rows in the jagged array: ");
            int rows = Convert.ToInt32(Console.ReadLine());

            int[][] jaggedArray = new int[rows][];

            for (int i = 0; i < rows; i++)
            {
                Console.Write($"Enter the size of row {i + 1}: ");
                int rowSize = Convert.ToInt32(Console.ReadLine());

                jaggedArray[i] = new int[rowSize];

                for (int j = 0; j < rowSize; j++)
                {
                    Console.Write($"Enter the value for row {i + 1} and column {j + 1}: ");
                    jaggedArray[i][j] = Convert.ToInt32(Console.ReadLine());
                }
            }

            Console.WriteLine("\nJagged Array Details:");
            for (int i = 0; i < rows; i++)
            {
                Console.Write($"Row {i + 1}: ");
                for (int j = 0; j < jaggedArray[i].Length; j++)
                {
                    Console.Write($"{jaggedArray[i][j]} ");
                }
                Console.WriteLine();
            }


            int[] number = new int[5] { 3, 4, 5, 6, 7 };
            Console.WriteLine("selecy any number");
            int search = Convert.ToInt32(Console.ReadLine());

            for (int i = 0; i < number.Length; i++)
            {
                if (number[i] == search)
                {
                    Console.WriteLine("number is found " + i);
                    break;

                }

            }
        }
    }












