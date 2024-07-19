namespace StudentSort
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Student julian = new Student("Julian", 4.0);
            Student robert = new Student("Robert", 3.3);
            Student yuselmi = new Student("Yuselmi", 3.9);
            Student shay = new Student("Shay", 1.5);
            Student matt = new Student("Matt", 3.7);
            Student lee = new Student("Lee", 0.8);

            Student[] students = { julian, robert, yuselmi, shay, matt, lee };

            Console.WriteLine("Please select a sorting algorithm");
            Console.WriteLine("1: Bubble Sort");
            Console.WriteLine("2: Selection Sort");
            Console.WriteLine("3: Insertion Sort");

            string? userSelection = Console.ReadLine();

            switch (userSelection)
            {
                case "1":
                    BubbleSort(students);
                    break;
                case "2":
                    SelectionSort(students);
                    break;
                case "3":
                    InsertionSort(students);
                    break;
                default:
                    // none of these cases match
                    break;

            }
            PrintArray(students);

        }

        public static void PrintArray(Student[] arr)
        {
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
            Console.WriteLine("Students sorted by GPA (Bubble Sort)");

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
            Console.WriteLine("Students sorted by GPA (Selection Sort)");

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
            Console.WriteLine("Students sorted by GPA (Insertion Sort)");
        }
    }
}
