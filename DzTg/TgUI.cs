using System.Net;

namespace DzTg
{
    public class TgUI
    {
        public static void SendMsg() 
            { 
               string container = ApiLogic.ApiResult().Result;
                string uri = "https://api.telegram.org/bot" + ConnectionLogic.ApiTg + "/sendMessage" + "?chat_id=" + ConnectionLogic.UserId + "&text=" + container;
                var request = WebRequest.Create(uri); 
                request.Method = "GET"; 
                var response = request.GetResponse(); 
                
            } 
 
        
        }
    
    
    
    }
