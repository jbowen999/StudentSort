namespace StudentSort
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string algo = ""; // Used during final print

            Student julian = new Student("Jack", 4.0);
            Student robert = new Student("Jill", 3.3);
            Student yuselmi = new Student("Mac", 3.9);
            Student shay = new Student("Adam", 1.5);
            Student matt = new Student("Kait", 3.7);
            Student lee = new Student("Diana", 0.8);

            Student[] students = { julian, robert, yuselmi, shay, matt, lee };

            Console.WriteLine("Please select a sorting algorithm");
            Console.WriteLine("1: Bubble Sort");
            Console.WriteLine("2: Selection Sort");
            Console.WriteLine("3: Insertion Sort");
            Console.WriteLine("4: Merge Sort");


            string? userSelection = Console.ReadLine(); // Allows for user input 

            switch (userSelection) // Conditional logic changes "algo" and calls the appropriate method
            {
                case "1":
                    algo = "Bubble Sort";
                    BubbleSort(students);
                    break;
                case "2":
                    algo = "Selection Sort";
                    SelectionSort(students);
                    break;
                case "3":
                    algo = "Insertion Sort";
                    InsertionSort(students);
                    break;
                case "4":
                    algo = "Merge Sort";
                    MergeSort(students);
                    break;
                default:
                    // none of these cases match
                    break;

            }
            PrintArray(students, algo);

        }

        public static void PrintArray(Student[] arr, string algo)
        {
            Console.WriteLine($"Students sorted by GPA ({algo})");

            foreach (var item in arr)
            {
                Console.WriteLine($"{item.name}: {item.gpa} ");
            }
            Console.WriteLine();
        }

        public static void BubbleSort(Student[] arrToSort)
        {
            Student temp;
            for (int i = 0; i < arrToSort.Length - 1; i++) // how many times we need to go though the unsorted array  
            {
                for (int j = 0; j < arrToSort.Length - 1 - i; j++)
                {
                    // we need to swap  
                    if (arrToSort[j].gpa < arrToSort[j + 1].gpa)
                    {
                        temp = arrToSort[j];
                        arrToSort[j] = arrToSort[j + 1];
                        arrToSort[j + 1] = temp;
                    }
                }
            }

        }

        public static void SelectionSort(Student[] arrToSort)
        {
            // minIndex keeps track of the smallest index in each iteration  
            // temp is used as temporary storage  
            int minIndex;
            Student temp;

            // O(n) how many times we need to go though the unsorted array  
            for (int i = 0; i < arrToSort.Length; i++)
            {
                minIndex = i; // set the minIdex equal to current smallest index  
                for (int j = i; j < arrToSort.Length; j++) // loop through each element starting at i  
                {
                    // if the element is smaller than the current minIndex  
                    if (arrToSort[j].gpa > arrToSort[minIndex].gpa)
                    {
                        // swap  
                        minIndex = j;
                    }
                }

                // swap elements  
                // swap current i (which is smallest position with the smallest/min element)  
                temp = arrToSort[i];
                arrToSort[i] = arrToSort[minIndex];
                arrToSort[minIndex] = temp;
            }

        }

        public static void InsertionSort(Student[] arr)
        {
            // Overall worst case: O(n^2) == array is reverse sorted
            // Best case: O(n) == while loop never runs
            for (int i = 1; i < arr.Length; i++) // O (n)
            {
                Student temp = arr[i];// store the current element as it might be overwritten
                int priorIndex = i - 1; // start comparing with element before the current element

                while (priorIndex >= 0 && arr[priorIndex].gpa < temp.gpa) // O (n)
                {
                    arr[priorIndex + 1] = arr[priorIndex];
                    priorIndex--;
                }

                // need an assignment
                arr[priorIndex + 1] = temp;
            }
        }


        public static void MergeSort(Student[] arr)
        {
            // Base case: if the array has 1 or fewer elements, it is already sorted
            if (arr.Length <= 1) return;

            // Find the midpoint of the array
            int mid = arr.Length / 2;

            // Create subarrays for the left and right halves
            Student[] leftSubArr = new Student[mid];
            Student[] rightSubArr = new Student[arr.Length - mid];

            // Copy elements to the left subarray
            for (int i = 0; i < mid; i++)
            {
                leftSubArr[i] = arr[i];
            }

            // Copy elements to the right subarray
            for (int i = mid; i < arr.Length; i++)
            {
                rightSubArr[i - mid] = arr[i];
            }

            // Recursively sort the subarrays
            MergeSort(leftSubArr);
            MergeSort(rightSubArr);

            Merge(arr, leftSubArr, rightSubArr); // Merge the sorted subarrays


        }

        // Merges two subarrays of arr[].
        static void Merge(Student[] arr, Student[] left, Student[] right)
        {
            int i = 0, j = 0, k = 0;

            // Merge elements from left and right subarrays in descending order

            while (i < left.Length && j < right.Length)
            {
                if (left[i].gpa >= right[j].gpa)
                {
                    arr[k] = left[i];
                    i++;
                }
                else
                {
                    arr[k] = right[j];
                    j++;
                }
                k++;
            }


            // Copy any remaining elements from the left subarray
            while (i < left.Length)
            {
                arr[k] = left[i];
                i++;
                k++;
            }


            // Copy any remaining elements from the right subarray
            while (j < right.Length)
            {
                arr[k] = right[j];
                j++;
                k++;
            }
        }

    }
}
