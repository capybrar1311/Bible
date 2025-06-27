namespace BibleWithAPI;
using Newtonsoft.Json;
using System.IO;
using System.Collections.Generic;

public class JSONManager
{
   public static Dictionary<string, int> AllBooksDict(string path)
   {
      string jsonData = File.ReadAllText(path);
      return JsonConvert.DeserializeObject<Dictionary<string, int>>(jsonData);
   }
   
   public static RuBible? ParseRequest(string url)
   {
      Task<string> response = APIManager.GetData(url);
      
      return JsonConvert.DeserializeObject<RuBible>(response.Result);
   }
   
   
}