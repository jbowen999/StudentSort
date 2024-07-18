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
                    // Selection Sort
                    break;
                case "3":
                    // Insertion Sort
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
                Console.Write($"{item.name}: {item.gpa} | ");
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
    }
}
