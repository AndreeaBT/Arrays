using System;
using System.Collections.Generic;
using System.Linq;

namespace Arrays
{
    class Program
    {
        static void Main(string[] args)
        {

            //CreateAndDisplayArray();
            //ReverseArray();
            //NumberOfAppearences();
            //InsertElement();
            //RemoveSpecificElement();
            //Sum();
            //PrintUniqueElement();
            //AscendingTwoArrays();
            //GetMinAndMax();
            //OddAndEven();
            //SortAsc();
            //Sortdesc();
            //MultidimensionalArray();
            //SecondLargest();
            //SecondSmallest();
            AdditionOfTwoMatrices();
        }
        public static string[] GetStringArrayFromUser()
        {
            Console.Write("Enter the length of the array: ");
            int length = int.Parse(Console.ReadLine());
            string[] array = new string[length];
            for (int i = 0; i < length; i++)
            {
                Console.Write($"Add element {i}: ");
                array[i] = Console.ReadLine();
            }
            return array;
        }
        public static int[] GetArrayFromUser()
        {
            Console.WriteLine("Enter length of the array:");
            int length = int.Parse(Console.ReadLine());
            int[] array = new int[length];
            for (int i = 0; i < length; i++)
            {
                Console.WriteLine($"Add element {i}");
                array[i] = int.Parse(Console.ReadLine());

            }
            return array;
        }
        public static int GetIndexOf(int element, int[] array)
        {
            for (int i = 0; i < array.Length; i++)
            {
                if (element == array[i])
                {
                    return i;
                }
            }
            return -1;

        }
        public static void CreateAndDisplayArray()
        {
            Console.WriteLine("This method will display the content of an array");
            int [] array =  GetArrayFromUser();
            foreach (var element in array)
            {
                Console.WriteLine($"{element} ");
            }
        }
        public static void ReverseArray()
        {
            Console.WriteLine("This method will reverse the content of an array");
            var array = GetArrayFromUser();

            for (int i = array.Length - 1; i >= 0; i--)
            {
                Console.Write($"{array[i]}, ");
            }


        }
        public static void NumberOfAppearences()
        {
            Console.WriteLine("This method will count the number of occurrences of an element");
            var myArray = GetArrayFromUser();
            var count = 0;
            Console.WriteLine("Which number are you looking for ....");
            int number = int.Parse(Console.ReadLine());
            foreach (var element in myArray)
            {
                if (element == number)
                {
                    count++;
                }
            }
            Console.WriteLine($"{number} found {count} times");
        }
        public static void InsertElement()
        {
            Console.WriteLine("This method will insert a new element");
            var array = GetStringArrayFromUser();
            int length = array.Length + 1;
            string[] Final = new string[length];
            Console.WriteLine("Please type the element that you want to be inserted into the array");
            string insert =Console.ReadLine();
            Final[0] = array[0];
            Final[1] = insert;
            for (int i = 2; i < array.Length; i++)
            {
               Final[i] = array[i - 1];
               
            }
            foreach (var element in Final)
            {
                Console.Write($"{element}, ");
            }

        }
        public static void RemoveSpecificElement()
        {
            Console.WriteLine("This method will remove the element using the index.");
            var array = GetArrayFromUser();
            Console.WriteLine("Please type the index.The Index must be in the length of the array");
            int index = GetIndexOf(int.Parse(Console.ReadLine()), array);
            array = array.Where(val => val != index+2).ToArray();
            foreach(var element in array)
            {
                Console.Write($"{element} ");
            }
        }
        public static void Sum()
        {
            var array = GetArrayFromUser();
            Console.WriteLine(array.Sum());
        }
        public static void PrintUniqueElement()
        {
            var index = -1;
            var myArray = GetArrayFromUser();
            int[] arrayToPrint = new int[myArray.Length];
            var stringToPrint = string.Empty;
            for (int i = 0; i < myArray.Length; i++)
            {
                if (GetIndexOf(myArray[i], arrayToPrint) == -1)
                {
                    index++;
                    arrayToPrint[index] = myArray[i];
                }
            }

            for (int i = 0; i < index; i++)
            {
                Console.WriteLine($"{arrayToPrint[i]}, ");
            }
        }
        public static void AscendingTwoArrays()
        {
            Console.WriteLine("This method will merge and ascend two arrays of the same length.");
            var myArray = GetArrayFromUser();
            var Min = myArray[0];
            var array = GetArrayFromUser();
            var min = array[0];
            if (myArray.Length != array.Length)
            {
                Console.WriteLine("The arrays are not equal in length");
            }
            for (int i = 0; i < array.Length; i++)
            {
                if (array[i] < min)
                {
                    min = array[i];
                }

            }
            for (int j = 0; j < myArray.Length; j++)
            {
                if (myArray[j] < Min)
                {
                    Min = myArray[j];
                }
            }
            var myList = new List<int>();
            myList.AddRange(myArray);
            myList.AddRange(array);
            int[] arr3 = myList.ToArray();
            foreach (int res in arr3)
            {
                Console.WriteLine(res);
            }
            
            
        }
        public static void GetMinAndMax()
        {
            var myArray1 = GetArrayFromUser();
            Console.WriteLine($"The minimum value of the array is : {myArray1.Min()}");
            Console.WriteLine($"The maximum value of the array is : {myArray1.Max()}");
           
        }
        public static void OddAndEven()
        {
            Console.WriteLine("This method will separate the odd numbers from the even numbers.");
            var myArray = GetArrayFromUser();
            Console.WriteLine("The odd numbers are ");
            for (int i = 0; i < myArray.Length; i++)
            {
                if (myArray[i] % 2 == 0)
                {
                    i++;
                    Console.WriteLine($"{i} ");
                }
            }
            Console.WriteLine("The even numbers are");
            for (int i = 0; i < myArray.Length; i++)
            {
                if (myArray[i] % 2 != 0)
                {
                    i++;
                    Console.WriteLine($"{i} ");
                }
            }

        }
        public static void SortAsc()
        {
            Console.WriteLine("This method will sort the values from the array in ascending order");
            var array = GetArrayFromUser();
          
            for (int i = 0; i < array.Length - 1; i++)
            {
                for (int j = i + 1; j < array.Length; j++)
                {
                    if (array[i] > array[j])
                    {
                        int temp = array[i];
                        array[i] = array[j];
                        array[j] = temp;
                    }
                }
            }
            foreach (var element in array)
            {
                Console.WriteLine($"{element}, ");
            }
        }
        public static void Sortdesc()
        {
            Console.WriteLine("This method will sort the values from the array in descending order");
            var array = GetArrayFromUser();
            for (int i = 0; i < array.Length - 1; i++)
            {
                for (int j = i + 1; j < array.Length; j++)
                {
                    if (array[i] < array[j])
                    {
                        int temp = array[i];
                        array[i] = array[j];
                        array[j] = temp;
                    }
                }
            }
            foreach (var element in array)
            {
                Console.WriteLine($"{element}, ");
            }
        }
        public static void MultidimensionalArray()
        {
           int[,] myArray =
           {
                {1,2,3 },
                {4,5,6 },
                {7,8,9 }
           };
            for (int row = 0; row < myArray.GetLength(0); row++)
            {
                for (int col = 0; col < myArray.GetLength(1); col++)
                {
                    
                    Console.WriteLine($"myArray[{row}, {col}] = {myArray[row, col]}");
                }
            }
        }
        public static void SecondLargest()
        {
            Console.WriteLine("This methos will display the second largest value from the array");
            var array = GetArrayFromUser();
            Console.WriteLine($"The value is : {array.Max()-1}");
        }
        public static void SecondSmallest()
        {
            Console.WriteLine("This method will display the second smallest value from the array");
            var array = GetArrayFromUser();
            Console.WriteLine($"The value is : {array.Min() + 1}");
        }
        public static void AdditionOfTwoMatrices()
        {
            Console.WriteLine("This method will add two matrices\n");
            int[,] myArray1 =
           {
                {1,2,3 },
                {4,5,6 },
                {7,8,9 }
           };
            Console.WriteLine("The fisrt matrix");
            for (int row = 0; row < myArray1.GetLength(0); row++)
            {
                for (int col = 0; col < myArray1.GetLength(1); col++)
                {
                    Console.WriteLine($"[{row}, {col}] = {myArray1[row, col]}");
                }
            }
            int[,] myArray2 =
          {
                {1,2,3 },
                {4,5,6 },
                {7,8,9 }
           };

            Console.WriteLine("\nThe second matrix");
            for (int row = 0; row < myArray2.GetLength(0); row++)
            {
                for (int col = 0; col < myArray2.GetLength(1); col++)
                {
                    Console.WriteLine($"[{row}, {col}] = {myArray2[row, col]}");
                }
            }

            int[,] Sum = new int[myArray1.GetLength(0), myArray1.GetLength(1)];
            for (int i = 0; i < myArray1.GetLength(0); i++)
            {
                for (int j = 0; j < myArray2.GetLength(1); j++)
                {
                    Sum[i, j] = myArray1[i, j] + myArray2[i, j];
                }

            }
            Console.WriteLine("The sum of the matrices");
            for (int i = 0; i < Sum.GetLength(0); i++)
            {
                Console.WriteLine();
                for (int j = 0; j < Sum.GetLength(1); j++)
                {
                    Console.Write($"[{i}, {j}] =  {Sum[i, j]} \n");
                }
            }
        }
    }
}
