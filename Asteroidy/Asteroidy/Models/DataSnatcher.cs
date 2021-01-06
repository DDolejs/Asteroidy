using System;
using System.Collections.Generic;
using System.Text;
using System.Net.Http;
using System.Net.Http.Json;
using Newtonsoft.Json.Serialization;
using System.IO;
using System.Threading.Tasks;

namespace Asteroidy.Models
{
    public class DataSnatcher
    {
        
        HttpClient client = new HttpClient();
        
        
        public async Task<ConvertedObject> SnatchData(string link) 
        {
             
            ConvertedObject ob =  await client.GetFromJsonAsync<ConvertedObject>(link);
            return ob;
        }
        
    }
}
