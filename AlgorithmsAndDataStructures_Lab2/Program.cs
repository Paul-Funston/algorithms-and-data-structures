/*
Write and test the following methods in a Console Application. 

    A program that produces an array of all of the characters that appear more than once in a string.
        For example, the string “Programmatic Python” would result in the array ['p','r','o','a','m','t'].
    A program returns an array of strings that are unique words found in the argument.
        For example, the string “To be or not to be” returns ["to","be","or","not"].
    A program that reverses a provided string 
    A program that finds the longest unbroken word in a string and prints it
        For example, the string "Tiptoe through the tulips" would print "through"
        If there are multiple words tied for greatest length, print the last one
 
*/
using System.Text;

string phraseOne = "Programmatic Python";
string phraseTwo = "To be or not to be";
string phraseThree = "Tiptoe through the tulips";
string phrase = "";

//Console.WriteLine("Enter a phrase:");
//string? userString = Console.ReadLine();


// Repeated Characters
Console.WriteLine("Repeated Characters");

// check first character
// compare other characters if it repeats store it (make a counter)
// check second character is stored then compare to characters after



// Unique Words
Console.WriteLine();
Console.WriteLine("Unique Words");

// split sentence into words
// compare first word to later words if match do nothing, else add store


// Reverse String
Console.WriteLine();
Console.WriteLine("Reverse String");
StringBuilder reverse = new StringBuilder();

if (string.IsNullOrEmpty(phrase))
{
    phrase = phraseThree;
}

for (int i = 0; i < phrase.Length; i++)
{
    int mirrorIndex = phrase.Length - 1 - i;
    reverse.Append(phrase[mirrorIndex]);
}

Console.WriteLine(phrase);
Console.WriteLine(reverse.ToString());

// Longest Word
Console.WriteLine();
Console.WriteLine("Longest Word");

string[] words = phrase.Split(' ');
int longestLength = 0;
int longestIndex = 0;

for (int i = 0; i < words.Length; i++)
{
    int length = words[i].Trim().Length;

    if (length >= longestLength)
    {
        longestLength = length; 
        longestIndex = i;
    }
}

Console.WriteLine($"The longest word is \"{words[longestIndex]}\" at {longestLength} characters");

