using System.Text;
using System.Text.RegularExpressions;
using Newtonsoft.Json;

namespace BibleWithAPI;

public class RuBibleManager
{
    public static async Task GetData(string userInput)
    {
        try
        {
            string requestUrl = CreateRequestUrl(userInput);

            var response = await Menu.client.GetStringAsync(requestUrl);

            var verse = ParseFullJson(response);
            PrintTheVerses(verse);
        }
        catch (Exception e)
        {
            Console.WriteLine("НЕТ ТАКОЙ КНИГИ!!! ВВОДИ НОВУЮ!!!");
            string newInp = Console.ReadLine();
            switch (newInp)
            {
                case "":
                    newInp = "Иоанн 3:16";
                    break;
            }

            await GetData(newInp);
        }
    }

    private static void PrintTheVerses(RuBible vvv)
    {
        foreach (var verse in vvv.Verses)
        {
            Console.WriteLine($"{vvv.Info.Book} {vvv.Info.Chapter}:{verse.Key} {verse.Value}");
        }
    }

    private static RuBible ParseFullJson(string json)
    {
        return JsonConvert.DeserializeObject<RuBible>(json);
    }

    private static string CreateRequestUrl(string userInput)
    {
        Dictionary<string, int> SynodalBooks = new Dictionary<string, int>
        {
            { "бытие", 1 },
            { "исход", 2 },
            { "левит", 3 },
            { "числа", 4 },
            { "второзаконие", 5 },
            { "иисус навин", 6 },
            { "судьи", 7 },
            { "руфь", 8 },
            { "1 царств", 9 },
            { "2 царств", 10 },
            { "3 царств", 11 },
            { "4 царств", 12 },
            { "1 паралипоменон", 13 },
            { "2 паралипоменон", 14 },
            { "ездра", 15 },
            { "неемия", 16 },
            { "есфирь", 17 },
            { "иов", 18 },
            { "псалтырь", 19 },
            { "притчи", 20 },
            { "екклезиаст", 21 },
            { "песнь песней", 22 },
            { "исаия", 23 },
            { "иеремия", 24 },
            { "плач иеремии", 25 },
            { "иезекииль", 26 },
            { "даниил", 27 },
            { "осия", 28 },
            { "иоиль", 29 },
            { "амос", 30 },
            { "авдий", 31 },
            { "иона", 32 },
            { "михей", 33 },
            { "наум", 34 },
            { "аввакум", 35 },
            { "софония", 36 },
            { "аггей", 37 },
            { "захария", 38 },
            { "малахия", 39 },
            { "матфей", 40 },
            { "марк", 41 },
            { "лука", 42 },
            { "иоанн", 43 },
            { "деяния", 44 },
            { "иаков", 45 },
            { "1 петра", 46 },
            { "2 петра", 47 },
            { "1 иоанна", 48 },
            { "2 иоанна", 49 },
            { "3 иоанна", 50 },
            { "иуда", 51 },
            { "римлянам", 52 },
            { "1 коринфянам", 53 },
            { "2 коринфянам", 54 },
            { "галатам", 55 },
            { "ефесянам", 56 },
            { "филиппийцам", 57 },
            { "колоссянам", 58 },
            { "1 фессалоникийцам", 59 },
            { "2 фессалоникийцам", 60 },
            { "1 тимофею", 61 },
            { "2 тимофею", 62 },
            { "титу", 63 },
            { "филимону", 64 },
            { "евреям", 65 },
            { "откровение", 66 }
        };
// Остальная часть метода остается без изменений


        List<string> books = SynodalBooks.Keys.ToList();
        string defaultUrl =
            "https://justbible.ru/api/bible?translation=rst&book={splitedBook}&chapter={splitedChapter}";
        string actualUrl = defaultUrl;
        string[] splitedInput = userInput.Split(' ');

        if (splitedInput.Length == 3)
        {
            splitedInput[0] = $"{splitedInput[0]} {splitedInput[1]}".ToLower();
            splitedInput[1] = splitedInput[2];
        }


        int splitedBook = SynodalBooks[splitedInput[0]];
        try
        {
            if (splitedInput[1].Contains(":"))
            {
                string[] chapterAndVerse = splitedInput[1].Split(':');
                string splitedChapter = chapterAndVerse[0];
                string splitedVerse = chapterAndVerse[1];
                if (splitedVerse.Contains("-") | splitedVerse.Contains(","))
                {
                    actualUrl =
                        $"https://justbible.ru/api/bible?translation=rst&book={splitedBook}&chapter={splitedChapter}&verses={splitedVerse}";
                }
                else
                {
                    actualUrl =
                        $"https://justbible.ru/api/bible?translation=rst&book={splitedBook}&chapter={splitedChapter}&verse={splitedVerse}";
                }
            }
            else
            {
                actualUrl =
                    $"https://justbible.ru/api/bible?translation=rst&book={splitedBook}&chapter={splitedInput[1]}";
            }
        }
        catch (Exception e)
        {
            Console.WriteLine(e);
            return CreateRequestUrl(Console.ReadLine());
        }


        return actualUrl;
    }
}
//https://justbible.ru/api/bible?translation=rst&book={splitedBook}&chapter={splitedChapter}&verse={splitedVerse}