To adapt the sorting algorithms for sorting a list of custom Student objects based on GPA in descending order, we started by creating the Student class. This class includes properties for the student's name and GPA. Once the class was established, we proceeded to modify the sorting algorithms covered in class—Bubble Sort, Selection Sort, and Insertion Sort. Additionally, we included Merge Sort as extra credit.

The primary adaptation involved modifying the comparison logic within each algorithm to compare the GPA properties of Student objects rather than simple primitive types. Specifically, we adjusted the algorithms to sort the students in descending order by GPA, which required reversing the usual comparison operators.

To facilitate user interaction, we implemented a console menu using Console.WriteLine and Console.ReadLine. This menu allows users to select the desired sorting algorithm. Based on the user's choice, the corresponding sorting algorithm is executed to sort the array of Student objects.

Finally, we instantiated an array of Student objects with unique names and GPAs. After sorting, the list of student names, reflecting the descending GPA order, is displayed on the console.

Challenges and Strategies

One challenge encountered was ensuring the sorting algorithms worked correctly with objects rather than primitive types. This required careful attention to the comparison logic within each algorithm. Debugging the modified algorithms was crucial to confirm they were accurately comparing and swapping Student objects based on their GPA.

Another challenge was designing an intuitive and user-friendly console menu for algorithm selection. Ensuring seamless interaction required handling user inputs robustly, including validating choices and managing potential errors.

To overcome these challenges, we conducted extensive testing for each algorithm. We also incorporated unit tests to validate the sorting functionality for various input scenarios, ensuring the algorithms correctly sorted the Student objects in descending order.
