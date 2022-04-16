using System;
using System.IO;
using System.Net;
using System.Threading.Tasks;
using System.Runtime;

namespace DzTg
{
    public class ApiLogic
    {
      public static async Task<string> ApiResult ()
        {
            
            Console.WriteLine("\n\nStart creating of request to DateApi");
            var webRequest = WebRequest.Create($"http://numbersapi.com/"+ TimeM() +"/"+ TimeD() + "/date");
            Console.WriteLine("\nCreating request to dateApi success\nGetting of response... ");
            var response = await webRequest.GetResponseAsync();
            Console.WriteLine("\nResponse is received \n");
            using var stream = response.GetResponseStream();
            using var data = new StreamReader(stream);
            var result = (await  data.ReadToEndAsync());
            Console.WriteLine("\nResponse is received and converted\n");
            return result;


        }
      public static string TimeM()
      {
          DateTime now = DateTime.Now;
          var timeMonth = (now.ToString("MM"));
          return timeMonth;
      }
      
      public static string TimeD()
      {
          DateTime now = DateTime.Now;
          var timeDay = (now.ToString("dd"));
          return timeDay;
        
      }
    }
} 
// 