using System;
using System.Collections.Generic;
using System.Text;
using Newtonsoft.Json;
using System.Net.Http;


namespace Asteroidy.Models
{
    public class DataSnatcher
    {
        
        HttpClient htc = new HttpClient();
        
        public async void GrabData(string link) { HttpResponseMessage resp = await htc.GetAsync(link); }
        
    }
}
