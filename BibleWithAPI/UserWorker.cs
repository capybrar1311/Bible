namespace BibleWithAPI;

public class UserWorker
{
    public string? GetVerseRequest(string? language)
    {
        string? res = "john 3:16";
        switch (language)
        {
            case "en":
                Console.Write("Enter book and verse number ");
                res = Console.ReadLine();
                if (res == "") return "john 3:16";
                
                break;
            case "ru":
                Console.Write("Введите книгу и номер стиха ");
                string? input = Console.ReadLine();
                if (input == "") input = "Иоанн 3:16";
                return input;
                
        }

        return "иоанн 3:16";
    }

    public string? SetLanguage()
    {
        Console.Write("Enter language (\"ru\", \"en\")");

        string lang = Console.ReadLine();

        switch (lang)
        {
            case "ru":
                return "ru";
            case "en":
                return "en";
            case "exit":
                return "exit";
            default:
                return "ru";
        }
    }

    public string[] SplitUserRequestToBookNameAndChapterVerse(string userInput)
    {
        string[] splitedInput = userInput.Split(' ');


        if (splitedInput.Length == 3)
        {
            splitedInput[0] = splitedInput[0] + " " + splitedInput[1];
            splitedInput[1] = splitedInput[2];
        }


        return splitedInput;
    }

    public string[] SplitChapterAndVerse(string[] inputArray)
    {
        string[] chapterAndVerse = inputArray;
        if (inputArray[1].Contains(':'))
        {
            chapterAndVerse = inputArray[1].Split(':');
            chapterAndVerse.Append(inputArray[0]);
        }

        return chapterAndVerse;
    }
}