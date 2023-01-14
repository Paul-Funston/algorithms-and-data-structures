/*


Create new methods to solve each of the following problems.

    We have a list of integers where elements appear either once or twice. Find the elements that appeared twice in O(n) time.
        example: {1, 2, 3, 4, 7, 9, 2, 4} returns {2, 4}
    We have two sorted int arrays which could be with different sizes. We need to merge them in a third array while keeping this result array sorted. Can you do that in O(n) time? Don't use any extra structures like Sets or Dictionaries
        example: {{1, 2, 3, 4, 5}, {2, 5, 7, 9, 13}}
            returns {1, 2, 2, 3, 4, 5, 5, 7, 9, 13}
    Given an integer, reverse the digits of that integer, e. g. input is 345, output is 543. What is the time complexity of your solution?


*/

/*
 *     We have a list of integers where elements appear either once or twice. Find the elements that appeared twice in O(n) time.
        example: {1, 2, 3, 4, 7, 9, 2, 4} returns {2, 4}
*/

/*
     We have two sorted int arrays which could be with different sizes. We need to merge them in a third array while keeping this result array sorted. Can you do that in O(n) time? Don't use any extra structures like Sets or Dictionaries
        example: {{1, 2, 3, 4, 5}, {2, 5, 7, 9, 13}}
            returns {1, 2, 2, 3, 4, 5, 5, 7, 9, 13} 
*/



/*
 * Problem #3
 Given an integer, reverse the digits of that integer, e. g. input is 345, output is 543. What is the time complexity of your solution?

Time complexity of this solution. Method 1 is O2N where N is the number of digits in the original number.
2nd Attempted 0N;
*/



/*
 //FIRST DRAFT
int startingNum = 345;
int reversedNum = 0;
int remainder = 0;
int newDigit = 0;
int magnitude = 1;


while (remainder < startingNum )
{
    remainder = (int)(startingNum % Math.Pow(10, magnitude));
    //Console.WriteLine(remainder);
 
    // part 1 Just printing the digits not storing the new number
    newDigit = remainder / (int) Math.Pow(10, magnitude - 1);
    Console.Write(newDigit);
    // end of method 1
    
    magnitude++;
     
}

Console.WriteLine();

magnitude--;
// part 2, after determining How many digits in the number. Creating the new reversed number
for (int i = 1; i <= magnitude; i++)
{
    remainder = (int)(startingNum % Math.Pow(10, i));
    newDigit = remainder / (int)Math.Pow(10, i - 1);

    reversedNum += newDigit * (int) Math.Pow(10, magnitude - i);
}

Console.WriteLine(reversedNum);
*/

/// SECOND TRY


int startingNumber = 65532;
int i = startingNumber;
int reversedNumber = 0;

while (i > 0)
{
    reversedNumber = reversedNumber * 10 + i % 10;
    i = i / 10;
}

Console.WriteLine(reversedNumber);




