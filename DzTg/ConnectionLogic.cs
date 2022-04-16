
using System.IO;
using System.Net;

namespace DzTg
{
    public  class ConnectionLogic
    {
        public static string ApiTg = "5210719847:AAF0nyouNnCuYNPMTazOiyvpScIyvcCxaBY"; 
        public static string UserId = "466821906";
        //TODO добавить подстановку id пользователя 

        
        public static void UserIdChecker()
        {
            string uri = "https://api.telegram.org/bot5210719847:AAF0nyouNnCuYNPMTazOiyvpScIyvcCxaBY/getUpdates";
            
            var request = WebRequest.Create(uri); 
            request.Method = "GET";
           
            var  response = request.GetResponse(); 
            using var stream = response.GetResponseStream();
            
            using var data = new StreamReader(stream);
            var responseData = (data.ReadToEndAsync());
            var responseDataString = responseData.Result;
            //TODO JSON Serialize 
           }
        
          
        }
        
        
    }
