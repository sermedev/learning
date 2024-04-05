
using Microsoft.Extensions.Logging;
using StringUtils;
using System.Diagnostics.CodeAnalysis;

[ExcludeFromCodeCoverage]
internal class Program
{
    private static void Main(string[] args)
    {
        var loggerFactory = LoggerFactory.Create(builder =>
        {
            builder.AddConsole();
        });

        var logger = loggerFactory.CreateLogger<StringOperations>();

        while (true)
        {
            ShowMainMenu();
            int optionSelected = AskForAnOperation();

            RunSelectedOption(logger, optionSelected);
        }
    }

    private static void ShowMainMenu()
    {
        Console.WriteLine("------------------------------------------");
        Console.WriteLine("           STRING OPERATIONS");
        Console.WriteLine("------------------------------------------");
        Console.WriteLine("  1.  Contact 2 strings");
        Console.WriteLine("  2.  Reverse string");
        Console.WriteLine("  3.  String length");
        Console.WriteLine("  4.  Remove white spaces");
        Console.WriteLine("  5.  Truncate string");
        Console.WriteLine("  6.  Check if the word is palindrome");
        Console.WriteLine("  7.  Count character concurrency");
        Console.WriteLine("  8.  Plularize a word");
        Console.WriteLine("  9.  Express a quantity in words");
        Console.WriteLine("  10. Convert from roman to number");
        Console.WriteLine("  11. Read text file");
        Console.WriteLine("------------------------------------------");
    }

    private static int AskForAnOperation()
    {
        Console.Write("Select an option: ");
        int optionSelected = int.Parse(Console.ReadLine());
        return optionSelected;
    }

    private static void RunSelectedOption(ILogger<StringOperations> logger, int optionSelected)
    {
        StringOperations stringOperations = new StringOperations(logger);
        switch (optionSelected)
        {
            case 1:
                Console.WriteLine("Write a string 1");
                string input = Console.ReadLine();

                Console.WriteLine("Write a string 2");
                string input2 = Console.ReadLine();

                Console.WriteLine( "Result");
                Console.WriteLine(stringOperations.ConcatenateStrings(input, input2));
                break;
            case 2:
                Console.WriteLine("Write a string");
                string inputToReverse = Console.ReadLine();

                Console.WriteLine("Result");
                Console.WriteLine(stringOperations.ReverseString(inputToReverse));
                break;
            case 3:
                Console.WriteLine("Write a string");
                string inputLength = Console.ReadLine();

                 Console.WriteLine( "Result");
                Console.WriteLine(stringOperations.GetStringLength(inputLength));
                break;
            case 4:
                Console.WriteLine("Write a string");
                string inputWhiteSpaces = Console.ReadLine();

                 Console.WriteLine( "Result");
                Console.WriteLine(stringOperations.RemoveWhitespace(inputWhiteSpaces));
                break;
            case 5:
                Console.WriteLine("Write a string");
                string inputTruncate = Console.ReadLine();

                Console.WriteLine("set max lenght");
                int maxLenght = int.Parse(Console.ReadLine());

                 Console.WriteLine( "Result");
                Console.WriteLine(stringOperations.TruncateString(inputTruncate, maxLenght));
                break;
            case 6:
                Console.WriteLine("Write a string");
                string inputPalandrime = Console.ReadLine();

                 Console.WriteLine( "Result");
                Console.WriteLine(stringOperations.IsPalindrome(inputPalandrime));
                break;
            case 7:
                Console.WriteLine("Write a string");
                string inputConcurrency = Console.ReadLine();

                Console.WriteLine("Write a character");
                char charToFind = char.Parse(Console.ReadLine());

                 Console.WriteLine( "Result");
                Console.WriteLine(stringOperations.CountOccurrences(inputConcurrency, charToFind));
                break;
            case 8:
                Console.WriteLine("Write a string");
                string inputToPluralize = Console.ReadLine();

                 Console.WriteLine( "Result");
                Console.WriteLine(stringOperations.Pluralize(inputToPluralize));
                break;
            case 9:
                Console.WriteLine("Write a word");
                string word = Console.ReadLine();

                Console.WriteLine("Write quantity");
                int quantity = int.Parse(Console.ReadLine());

                 Console.WriteLine( "Result");
                Console.WriteLine(stringOperations.QuantintyInWords(word, quantity));
                break;
            case 10:
                Console.WriteLine("Write a roman number");
                string romanNumber = Console.ReadLine();
                 Console.WriteLine( "Result");
                Console.WriteLine(stringOperations.FromRomanToNumber(romanNumber));
                break;
            case 11:
                 Console.WriteLine( "Result");
                IFileReaderConector fileReader = new FileReaderConector();
                Console.WriteLine(stringOperations.ReadFile(fileReader, "information.txt"));
                break;
            default:
                break;
        }

         Console.WriteLine();
    }
}