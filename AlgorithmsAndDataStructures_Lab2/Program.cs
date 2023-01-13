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
using System.Collections.Immutable;
using System.Text;

string phraseOne = "Programmatic Python";
string phraseTwo = "To be or not to be";
string phraseThree = "Tiptoe through the tulips";
string phrase = "";

//Console.WriteLine("Enter a phrase:");
//string? userString = Console.ReadLine();


// Repeated Characters
//A program that produces an array of all of the characters that appear more than once in a string.
//For example, the string “Programmatic Python” would result in the array ['p','r','o','a','m','t'].

// the Time complexity of this solution is  ON^2 Contains Method

char[] repeatedChars = new char[phraseOne.Length];
int repeatedCharsIndex = 0;

if (string.IsNullOrEmpty(phrase))
{
    Console.WriteLine("Using default phrases.");
    phrase = phraseOne;
}

Console.WriteLine("Repeated Characters");
Console.Write("For the phrase: ");
Console.WriteLine(phrase);
for (int i = 0; i < phrase.Length - 1; i++)
{

    char currentChar = phrase[i];
    if (repeatedChars.Contains(currentChar) || !char.IsLetter(currentChar))
    {
        continue;
    }

    if (phrase.Substring(i + 1).Contains(currentChar))
    {
        repeatedChars[repeatedCharsIndex++] = currentChar;
        repeatedCharsIndex++;
    }
}

Console.Write("The repeated characters are:");
foreach(char c in repeatedChars)
{
    if (char.IsLetter(c))
    {
        Console.Write($"{c} ");
    }
}


// Unique Words 
// The complexity of this solution is ON^2 (due to Contains Method)
// A program returns an array of strings that are unique words found in the argument.
// For example, the string “To be or not to be” returns ["to","be","or","not"].
Console.WriteLine();
Console.WriteLine("Unique Words");


if (phrase == phraseOne)
{
    phrase = phraseTwo;
}

Console.Write("For the phrase: ");
Console.WriteLine(phrase);

string[] words = phrase.ToLower().Split(" ");
string[] uniqueWords = new string[words.Length];
int uniqueIndex = 0;
Array.Sort(words);


for(int i = 0; i < words.Length - 1; i++)
{
    if (uniqueWords.Contains(words[i])) { continue; }

    if (i == 0)
    {
        if (words[i] != words[i + 1])
        {
            uniqueWords[uniqueIndex++] = words[i];
        }
        continue;
    }

    if (words[i] != words[i+1] && words[i] != words[i-1])
    {
        uniqueWords[uniqueIndex++] = words[i];
    }
        
}

Console.WriteLine("The unique words are: ");

foreach(string word in uniqueWords)
{
    if (!string.IsNullOrEmpty(word))
    {
        Console.Write($"{word} ");
    }

}
Console.WriteLine();

// split sentence into words
// compare first word to later words if match do nothing, else add store


// Reverse String
// The time complexity of this solution is ON
// A program that reverses a provided string 
Console.WriteLine();
Console.WriteLine("Reverse String");
StringBuilder reverse = new();

if (phrase == phraseTwo)
{
    phrase = phraseThree;
}
Console.Write("For the phrase: ");
Console.WriteLine(phrase);

for (int i = 0; i < phrase.Length; i++)
{
    int mirrorIndex = phrase.Length - 1 - i;
    reverse.Append(phrase[mirrorIndex]);
}


Console.WriteLine(reverse.ToString());

// Longest Word
// TIme complexity is ON (N is the number of words in the phrase)
// A program that finds the longest unbroken word in a string and prints it
// For example, the string "Tiptoe through the tulips" would print "through"
// If there are multiple words tied for greatest length, print the last one
Console.WriteLine();
Console.WriteLine("Longest Word");

words = phrase.Split(' ');
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

