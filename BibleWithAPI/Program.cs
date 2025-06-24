namespace BibleWithAPI;

//иоанн 3:16
//john 3:16-19

public class Program
{
    public static void Main(string[] args)
    {
        while (true)
        {
            Console.WriteLine("Enter \"exit\" to exit");

            string? input = Menu.GetVerseNumber(Menu.SetLanguage());
            if (input == "exit")
            {
                break;
            }
            else
            {
                Console.WriteLine("Press any key to continue");
                Console.ReadKey();
                Console.Clear();
            }
        }
    }
}