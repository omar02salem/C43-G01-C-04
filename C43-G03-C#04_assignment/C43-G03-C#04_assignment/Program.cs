namespace C43_G03_C_04_assignment
{
    internal class Program
    {
        static void Main(string[] args)
        {
            #region Points on a Single Line
            Console.WriteLine("Enter coordinates for three points:");
            Console.Write("x1: ");
            double x1 = double.Parse(Console.ReadLine());
            Console.Write("y1: ");
            double y1 = double.Parse(Console.ReadLine());

            Console.Write("x2: ");
            double x2 = double.Parse(Console.ReadLine());
            Console.Write("y2: ");
            double y2 = double.Parse(Console.ReadLine());

            Console.Write("x3: ");
            double x3 = double.Parse(Console.ReadLine());
            Console.Write("y3: ");
            double y3 = double.Parse(Console.ReadLine());

            double slope1 = (y2 - y1) / (x2 - x1);
            double slope2 = (y3 - y2) / (x3 - x2);

            if (slope1 == slope2)
            {
                Console.WriteLine("The points lie on a single straight line.");
            }
            else
            {
                Console.WriteLine("The points do not lie on a single straight line.");
            }
            #endregion

            #region Worker Efficiency Evaluation
            Console.Write("Enter time taken to complete the task (in hours): ");
            double time = double.Parse(Console.ReadLine());

            if (time >= 2 && time < 3)
            {
                Console.WriteLine("Highly efficient.");
            }
            else if (time >= 3 && time < 4)
            {
                Console.WriteLine("Increase speed.");
            }
            else if (time >= 4 && time < 5)
            {
                Console.WriteLine("Training to enhance speed.");
            }
            else if (time >= 5)
            {
                Console.WriteLine("Leave the company.");
            }
            #endregion

            #region Identity Matrix
            Console.Write("Enter the size of the identity matrix (n): ");
            int n = int.Parse(Console.ReadLine());

            for (int i = 0; i < n; i++)
            {
                for (int j = 0; j < n; j++)
                {
                    if (i == j)
                    {
                        Console.Write("1 ");
                    }
                    else
                    {
                        Console.Write("0 ");
                    }
                }
                Console.WriteLine();
            }
            #endregion

            #region Sum of All Elements of the Array
            Console.WriteLine("Enter the elements of the array (space-separated):");
            int[] array = Array.ConvertAll(Console.ReadLine().Split(' '), int.Parse);
            int sum = 0;

            for (int i = 0; i < array.Length; i++)
            {
                sum += array[i];
            }

            Console.WriteLine($"Sum of all elements: {sum}");
            #endregion

            #region Merge Two Sorted Arrays
            Console.WriteLine("Enter the elements of the first sorted array (space-separated):");
            int[] array1 = Array.ConvertAll(Console.ReadLine().Split(' '), int.Parse);
            Console.WriteLine("Enter the elements of the second sorted array (space-separated):");
            int[] array2 = Array.ConvertAll(Console.ReadLine().Split(' '), int.Parse);
            int[] mergedArray = new int[array1.Length + array2.Length];

            int index1 = 0, index2 = 0, indexMerged = 0;

            while (index1 < array1.Length && index2 < array2.Length)
            {
                if (array1[index1] <= array2[index2])
                {
                    mergedArray[indexMerged++] = array1[index1++];
                }
                else
                {
                    mergedArray[indexMerged++] = array2[index2++];
                }
            }

            while (index1 < array1.Length)
            {
                mergedArray[indexMerged++] = array1[index1++];
            }

            while (index2 < array2.Length)
            {
                mergedArray[indexMerged++] = array2[index2++];
            }

            Console.WriteLine("Merged array in ascending order:");
            foreach (int item in mergedArray)
            {
                Console.Write(item + " ");
            }
            Console.WriteLine();
            #endregion

            #region Frequency of Each Element in Array
            Console.WriteLine("Enter the elements of the array (space-separated):");
            int[] freqArray = Array.ConvertAll(Console.ReadLine().Split(' '), int.Parse);
            Dictionary<int, int> frequency = new Dictionary<int, int>();

            foreach (int item in freqArray)
            {
                if (frequency.ContainsKey(item))
                {
                    frequency[item]++;
                }
                else
                {
                    frequency[item] = 1;
                }
            }

            Console.WriteLine("Frequency of each element:");
            foreach (var kvp in frequency)
            {
                Console.WriteLine($"{kvp.Key}: {kvp.Value}");
            }
            #endregion

            #region Maximum and Minimum Element in Array
            Console.WriteLine("Enter the elements of the array (space-separated):");
            int[] maxMinArray = Array.ConvertAll(Console.ReadLine().Split(' '), int.Parse);
            int maxElement = maxMinArray[0];
            int minElement = maxMinArray[0];

            for (int i = 1; i < maxMinArray.Length; i++)
            {
                if (maxMinArray[i] > maxElement)
                {
                    maxElement = maxMinArray[i];
                }
                if (maxMinArray[i] < minElement)
                {
                    minElement = maxMinArray[i];
                }
            }

            Console.WriteLine($"Maximum element: {maxElement}");
            Console.WriteLine($"Minimum element: {minElement}");
            #endregion

            #region Second Largest Element in Array
            Console.WriteLine("Enter the elements of the array (space-separated):");
            int[] secLargestArray = Array.ConvertAll(Console.ReadLine().Split(' '), int.Parse);
            int first = int.MinValue, second = int.MinValue;

            foreach (int item in secLargestArray)
            {
                if (item > first)
                {
                    second = first;
                    first = item;
                }
                else if (item > second && item != first)
                {
                    second = item;
                }
            }

            if (second == int.MinValue)
            {
                Console.WriteLine("No second largest element.");
            }
            else
            {
                Console.WriteLine($"Second largest element: {second}");
            }
            #endregion

            #region Longest Distance Between Two Equal Cells
            Console.WriteLine("Enter the elements of the array (space-separated):");
            int[] inputArray = Array.ConvertAll(Console.ReadLine().Split(' '), int.Parse);
            Dictionary<int, int> firstIndex = new Dictionary<int, int>();
            int longestDistance = 0;

            for (int i = 0; i < inputArray.Length; i++)
            {
                if (firstIndex.ContainsKey(inputArray[i]))
                {
                    int distance = i - firstIndex[inputArray[i]];
                    if (distance > longestDistance)
                    {
                        longestDistance = distance;
                    }
                }
                else
                {
                    firstIndex[inputArray[i]] = i;
                }
            }

            Console.WriteLine($"The longest distance between two equal cells is: {longestDistance}");
            #endregion

            #region Reverse the Order of Words
            Console.WriteLine("Enter a list of space-separated words:");
            string inputString = Console.ReadLine();
            string[] words = inputString.Split(' ');
            Array.Reverse(words);
            Console.WriteLine(string.Join(" ", words));
            #endregion

            #region Copy Multidimensional Array
            Console.Write("Enter the number of rows: ");
            int rows = int.Parse(Console.ReadLine());
            Console.Write("Enter the number of columns: ");
            int cols = int.Parse(Console.ReadLine());

            int[,] firstArray = new int[rows, cols];
            Console.WriteLine("Enter the elements of the first array:");
            for (int i = 0; i < rows; i++)
            {
                for (int j = 0; j < cols; j++)
                {
                    Console.Write($"Element [{i},{j}]: ");
                    firstArray[i, j] = int.Parse(Console.ReadLine());
                }
            }

            int[,] secondArray = new int[rows, cols];
            for (int i = 0; i < rows; i++)
            {
                for (int j = 0; j < cols; j++)
                {
                    secondArray[i, j] = firstArray[i, j];
                }
            }

            Console.WriteLine("Elements of the second array:");
            for (int i = 0; i < rows; i++)
            {
                for (int j = 0; j < cols; j++)
                {
                    Console.Write(secondArray[i, j] + " ");
                }
                Console.WriteLine();
            }
            #endregion

            #region Reverse One Dimensional Array
            Console.WriteLine("Enter the elements of the array (space-separated):");
            int[] array = Array.ConvertAll(Console.ReadLine().Split(' '), int.Parse);

            Array.Reverse(array);

            Console.WriteLine("Array in reverse order:");
            foreach (int item in array)
            {
                Console.Write(item + " ");
            }
            Console.WriteLine();
            #endregion


        }
    }
}
