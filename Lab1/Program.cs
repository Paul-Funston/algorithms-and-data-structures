
using System.Runtime.CompilerServices;

Console.Write("How many words will you add?");

int numberOfWords = 0;
bool isValid = false;

 while(!(isValid))
 {
     string? numberOfWordsString = Console.ReadLine();
     if(!(Int32.TryParse(numberOfWordsString, out numberOfWords)))
     {
         Console.WriteLine("Enter a number");
     } else
     {
         isValid= true;
     }
 };

 string[] wordsToCheck = new string[numberOfWords];
 Console.WriteLine("Add a word to the list");
 for (int i = 0; i < wordsToCheck.Length; i++)
 {
    isValid= false;
    while (!(isValid))
    {
        Console.Write(i + 1);
        Console.Write(": ");
        string? userWord = Console.ReadLine();
        if (string.IsNullOrEmpty(userWord) || userWord.Any(Char.IsWhiteSpace))
        {
            Console.WriteLine("Enter a single word");
        } else
        {
            wordsToCheck[i] = userWord.ToLower();
            isValid= true;
        }
    }
 }

isValid= false;
char key = ' ';
while (!(isValid)) 
{
    Console.WriteLine();
    Console.Write("Please Enter a Letter: ");
    char userKey = Console.ReadKey().KeyChar;

    if (char.IsLetter(userKey))
    {
        key = char.ToLower(userKey);
        isValid= true; 
    } else
    {
        Console.WriteLine("Try again?");
    }
}

 int totalCharacterCount = 0;
 byte counter = 0;

 foreach (string word in wordsToCheck)
 {
     totalCharacterCount += word.Length;
    // word.ToCharArray();
     foreach (char c in word)
     {
         if (c == key) counter++;
     }
 }


    bool greaterThan25Percent = (double)counter / (double)totalCharacterCount  >= 0.25;

    Console.WriteLine();
    Console.Write("The letter '{0}' appears {1} times in the array. ", key, counter);
    if (greaterThan25Percent)
    {
        Console.WriteLine("This letter makes up at least 25% of the total number of characters.");
    } else
    {
        Console.WriteLine("This letter makes up less than 25% of the total number of characters.");
    }





