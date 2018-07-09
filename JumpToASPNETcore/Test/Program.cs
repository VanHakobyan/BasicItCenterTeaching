using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;

namespace Test
{
    class Program
    {
        static void Main(string[] args)
        {
            WebClient wc = new WebClient();
            wc.Headers.Add(HttpRequestHeader.UserAgent, "Mozilla/5.0 (Windows NT 10.0; Win64; x64) AppleWebKit/537.36 (KHTML, like Gecko) Chrome/67.0.3396.99 Safari/537.36");
            wc.Headers.Add(HttpRequestHeader.ContentType, "application/x-www-form-urlencoded");
            wc.Headers.Add(HttpRequestHeader.AcceptLanguage, "en-US,en;q=0.9");
            var facebookContent = wc.DownloadString("https://www.sas.am/");

            string json = wc.DownloadString(@"http://localhost:52684/Home/getpeoplejson");
            var peoples = JsonConvert.DeserializeObject<List<People>>(json);
        }
    }
}


public class People
{
    public int pid { get; set; }
    public string firstName { get; set; }
    public string lastName { get; set; }
    public int age { get; set; }
}
