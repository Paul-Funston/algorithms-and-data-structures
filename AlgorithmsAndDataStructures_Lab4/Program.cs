/*
 * Write, test, and then refactor the following methods as you see fit. They should validate their inputs and provide a reasonable response for incorrect input.
Note that several of these methods have Nested Lists (ie. Lists within Lists) as their parameters. It is best to write helper methods to simplify the required ones. 
For example, int GetHighestValueInList(List<int>) would be a helpful method to write and use throughout these problems. 
Ideally, each function should be as simple as possible, performing a small amount of work before passing it to another function inside or after that method.
 
 */


/*
 * Problem 1
  List<int> MaxNumbersInLists(List<List<int>>) accepts as a parameter a List of Lists of Integers. It returns a new list with each element representing the maximum number found in the corresponding original list. 
        For example, { {1, 5, 3}, {9, 7, 3, -2}, {2, 1, 2} } returns {5, 9, 2}. Output the results with a message like: “List 1 has a maximum of 5. List 2 has a maximum of 9. List 3 has a maximum of 2.”

// complexity - O(2MN)  THe outer lists are iterated over twice. once while accessing the inner list and then a second time when returning results. I remove the second iteration   
*/

using System.Text;

Console.WriteLine("Max Numbers in Lists");
List<List<int>> listNumbers = new List<List<int>>();
listNumbers.Add(new List<int> { 9, 7, 3, -2 });
listNumbers.Add(new List<int> { 2, 1, 2 });
listNumbers.Add(new List<int> { 1, 5, 3 });

int[] max = new int[listNumbers.Count()];
int maxIndex = 0;
foreach(List<int> list in listNumbers)
{
    int highest = int.MinValue;
    
    foreach(int n in list)
    {
        if (n > highest) { highest = n; }
    }

    max[maxIndex++] = highest;
}

for ( int i = 0; i < max.Length; i++)
{
    Console.Write($"List {i + 1} has a maximum of {max[i]}. ");
}

Console.WriteLine();
Console.WriteLine();


/*
 * Problem 2
     String HighestGrade(List<List<int>>) accepts a list of number grades among students in different courses (where each list represents a single course), between 0 and 100. It returns the highest grade among all students in all courses.
        For example: { {85,92, 67, 94, 94}, {50, 60, 57, 95}, {95} } returns "The highest grade is 95. This grade was found in class(es) {index}".

// Complexity: O2MN Again the outer list is iterated over twice. Not possible to remove the second iteration with this method, but it can be reduced.
*/
Console.WriteLine("Highest Grade");
List<List<int>> listGrades = new List<List<int>>();
listGrades.Add(new List<int> { 85, 92, 67, 94, 94 });
listGrades.Add(new List<int> { 50, 60, 57, 95 });
listGrades.Add(new List<int> { 95 });



int[] highestGrades = new int[listGrades.Count()];
int highestGradeIndex = 0;
int overalHighestGrade = int.MinValue;

foreach (List<int> list in listGrades)
{
    int currentClassMaxGrade = int.MinValue;

    foreach (int n in list)
    {
        if (n > currentClassMaxGrade) { currentClassMaxGrade = n; }
        if (currentClassMaxGrade > overalHighestGrade) { overalHighestGrade = currentClassMaxGrade; }
    }
    highestGrades[highestGradeIndex++] = currentClassMaxGrade;
}

Console.Write($"The highest grade is {overalHighestGrade}. This grade was found in class(es) ");


// Return to find a better way of getting the classes with highest grade
for (int i = 0; i < highestGrades.Length; i++)
{
    if (highestGrades[i] == overalHighestGrade)
    {
        Console.Write($"{i + 1}, ");
    }
}

Console.WriteLine();
Console.WriteLine();


/*
 *  Problem 3
     List<int> OrderByLooping (List<int>) orders a list of integers, from least to greatest, using only basic control statements (ie. if/else, for/while).
        For example, argument {6, -2, 5, 3} returns {-2, 3, 5, 6}.

Complexity first Attempt is ON^2 and handles duplicates poorly 

*/

Console.WriteLine("Sorting Lists");
List<int> numbers = new List<int>() { 6, -2, 5, 3, 3, 8, 6 };
foreach (int n in numbers)
{
    Console.WriteLine(n);
}

List<int> sortedNumbers = new List<int>();
int lastLowest = int.MinValue;
while (sortedNumbers.Count() < numbers.Count())
{
    int currentLowest = int.MaxValue;
    bool hasFoundDuplicate = false;
    foreach (int n in numbers)
    {   
        // Set flag once the previously found lowest number has been found, if its found again after flag is set its a duplicate.
        if (n == lastLowest)
        {
            if (hasFoundDuplicate)
            {
                sortedNumbers.Add(n);
                break;
            } else { hasFoundDuplicate = true; }
        } 

        if (n < currentLowest && n > lastLowest)
        {
            currentLowest = n;
        }
    }
    sortedNumbers.Add(currentLowest);
    lastLowest = currentLowest;
}

Console.WriteLine("sorted list");
foreach(int n in sortedNumbers)
{
   Console.WriteLine(n);
}

Console.WriteLine("Bubble Sort");

// Bubble Sort

int[] bubbleSort = numbers.ToArray();
for (int j = 0; j < bubbleSort.Length; j++)
{
    for (int i = 0; i < bubbleSort.Length - 1 - j; i++)
    {
        if (bubbleSort[i] > bubbleSort[i + 1])
        {
            (bubbleSort[i + 1], bubbleSort[i]) = (bubbleSort[i], bubbleSort[i + 1]);
        }
    }
}


foreach(int i in bubbleSort)
{
    Console.Write($"{i} ");
}