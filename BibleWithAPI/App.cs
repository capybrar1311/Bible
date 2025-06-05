using System.Text.Json;


namespace Bible;

public class App
{
    static HttpClient client = new HttpClient();

    public static async Task GetData(string userInput)
    {
        try
        {
            string requestUrl = $"https://bible-api.com/{userInput}?translation=web";
            var response = await client.GetStringAsync(requestUrl);

            var verse = JsonSerializer.Deserialize<BibleVerse>(response, MyJsonContext.Default.BibleVerse);
            PrintTheVerses(verse.Verses);
        }
        catch (Exception e)
        {
            Console.WriteLine(e);
            Console.ReadLine();
            throw;
        }
    }

    public static async Task GetDataRu(string userInput)
    {
        Dictionary<string, int> _bibleBooks = new Dictionary<string, int>()
            
            {
                { "Бытие", 1 },
                { "Исход", 2 },
                { "Левит", 3 },
                { "Числа", 4 },
                { "Второзаконие", 5 },
                { "Иисус Навин", 6 },
                { "Книга Судей", 7 },
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
                { "Псалтырь", 19 },
                { "Притчи", 20 },
                { "Песня песней", 22 },
                { "Исаия", 23 },
                { "Иеремия", 24 },
                { "Плач Иеремии", 25 },
                { "Иезекииль", 26 },
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
                { "От Матфея", 40 },
                { "От Ммарпка", 41 },
                { "От Луки", 42 },
                { "От Иоанна", 43 },
                { "Деяния", 44 },
                { "Иакова", 45 },
                { "1 Петра", 46 },
                { "2 Петра", 47 },
                { "1 Иоанна", 48 },
                { "2 Иоанна", 49 },
                { "Иуды", 50 },
                { "Римлянам", 51 },
                { "1 Коринфянам", 52 },
                { "2 Коринфянам", 53 },
                { "Галатам", 54 },
                { "Ефесянам", 55 },
                { "Филиппийцам", 56 },
                { "Колоссянам", 57 },
                { "1 Фесалоникийцам", 58 },
                { "2 Фесалоникийцам", 59 },
                { "1 Тимофею", 60 },
                { "2 Тимофею", 61 },
                { "Титу", 62 },
                { "Филимону", 63 },
                { "Евреям", 64 },
                { "Откровение", 65 }
            };
        try
        {
            string requestUrl = $"https://bible-api.com/{userInput}?translation=web";
            var response = await client.GetStringAsync(requestUrl);

            var verse = JsonSerializer.Deserialize<BibleVerse>(response, MyJsonContext.Default.BibleVerse);
            PrintTheVerses(verse.Verses);
        }
        catch (Exception e)
        {
            Console.WriteLine(e);
            Console.ReadLine();
            throw;
        }
    }

    private static void PrintTheVerses(List<BibleVerse.Verse> vvv)
    {
        foreach (var ver in vvv)
        {
            Console.WriteLine($"{ver.BookName} {ver.Chapter}:{ver.VerseNumber} - {ver.Text?.Trim()}\n");
        }
    }
}