namespace BibleWithAPI;

//иоанн 3:16
//john 3:16-19

public class Program
{
    public static UserWorker userClient = new UserWorker();
    public static URLMaker urlMaker = new URLMaker();
    public static Printer printer = new Printer();

    public static void Main(string[] args)
    {
        while (true)
        {
            Console.WriteLine("Enter \"exit\" to exit");

            string? userRequest = userClient.GetVerseRequest(userClient.SetLanguage());
            string[] userRequestArray = userClient.SplitUserRequestToBookNameAndChapterVerse(userRequest);
            string[] chapterAndVerse = userClient.SplitChapterAndVerse(userRequestArray);
            var requestUrl = urlMaker.MakeRequestUrl(chapterAndVerse);
            
            var response = JSONManager.ParseRequest(requestUrl);
            
            printer.PrintTheVerses(response);
            
        }
    }
}