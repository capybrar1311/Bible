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
            Console.WriteLine(e);
            Console.ReadLine();
            throw;
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
            { "Бытие", 1 },
            { "Исход", 2 },
            { "Левит", 3 },
            { "Числа", 4 },
            { "Второзаконие", 5 },
            { "Иисус Навин", 6 },
            { "Судьи", 7 },
            { "Руфь", 8 },
            { "1 Царств", 9 },
            { "2 Царств", 10 },
            { "3 Царств", 11 },
            { "4 Царств", 12 },
            { "1 Паралипоменон", 13 },
            { "2 Паралипоменон", 14 },
            { "Ездра", 15 },
            { "Неемия", 16 },
            { "Есфирь", 17 },
            { "Иов", 18 },
            { "Псалмы", 19 },
            { "Притчи", 20 },
            { "Екклезиаст", 21 },
            { "Песнь Песней", 22 },
            { "Исаия", 23 },
            { "Иеремия", 24 },
            { "Плач Иеремии", 25 },
            { "Иезекиил", 26 },
            { "Даниил", 27 },
            { "Осия", 28 },
            { "Иоиль", 29 },
            { "Амос", 30 },
            { "Авдий", 31 },
            { "Иона", 32 },
            { "Михей", 33 },
            { "Наум", 34 },
            { "Аввакум", 35 },
            { "Софония", 36 },
            { "Аггей", 37 },
            { "Захария", 38 },
            { "Малахия", 39 },
            { "Матфей", 40 },
            { "Марк", 41 },
            { "Лука", 42 },
            { "Иоанн", 43 },
            { "Деяния", 44 },
            { "Иаков", 45 },
            { "1 Петра", 46 },
            { "2 Петра", 47 },
            { "1 Иоанна", 48 },
            { "2 Иоанна", 49 },
            { "3 Иоанна", 50 },
            { "Иуда", 51 },
            { "Римлянам", 52 },
            { "1 Коринфянам", 53 },
            { "2 Коринфянам", 54 },
            { "Галатам", 55 },
            { "Ефесянам", 56 },
            { "Филиппийцам", 57 },
            { "Колоссянам", 58 },
            { "1 Фессалоникийцам", 59 },
            { "2 Фессалоникийцам", 60 },
            { "1 Тимофею", 61 },
            { "2 Тимофею", 62 },
            { "Титу", 63 },
            { "Филимону", 64 },
            { "Евреям", 65 },
            { "Откровение", 66 }
        };

        List<string> books = SynodalBooks.Keys.ToList();
        string defaultUrl =
            "https://justbible.ru/api/bible?translation=rst&book={splitedBook}&chapter={splitedChapter}";
        string actualUrl = defaultUrl;
        string[] splitedInput = userInput.Split(' ');

        if (splitedInput.Length == 3)
        {
            splitedInput[0] = $"{splitedInput[0]} {splitedInput[1]}";
            splitedInput[1] = splitedInput[2];
        }


        if (!books.Contains(splitedInput[0]))
        {
            throw new Exception("Book not found");
        }

        int splitedBook = SynodalBooks[splitedInput[0]];
        

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

        return actualUrl;
    }
}
//https://justbible.ru/api/bible?translation=rst&book={splitedBook}&chapter={splitedChapter}&verse={splitedVerse}