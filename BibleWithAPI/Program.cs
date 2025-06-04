namespace Bible;

//иоанн 3:16
//john 3:16-19


public class Program
{
    public static void Main(string[] args)
    {
        while (true)
        {
            Console.WriteLine("Enter \"exit\" to exit");
            string? input = GetVerseNumber();
            if (input == "exit")
            {
                
                break;
            }
            App.GetData(input).GetAwaiter().GetResult();
            Console.WriteLine("Press any key to continue");
            Console.ReadKey();
            Console.Clear();
        }
        
    }
    
    static string? GetVerseNumber()
    {
        Console.Write("Enter book and verse number ");
        
        return Console.ReadLine();
    }
    
}