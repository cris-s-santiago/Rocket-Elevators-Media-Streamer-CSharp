using System;
using System.Net;
using System.IO;

namespace MediaStreamer
{
    public class Bored
    {
        public string activity { get; set; }
        public string type { get; set; }

    }
    public class MedStreamer
    {
        public string getContent()
        {
            WebRequest request = HttpWebRequest.Create("https://www.boredapi.com/api/activity");
            WebResponse response = request.GetResponse();
            StreamReader reader = new StreamReader(response.GetResponseStream());

            string Activity_Json = reader.ReadToEnd();

            Bored Activity = Newtonsoft.Json.JsonConvert.DeserializeObject<Bored>(Activity_Json);


            return "<html><body>" + Activity.type + ": " + Activity.activity + "<html><body>";
        }
        static void Main(string[] args)
        {
            MedStreamer stremRocket = new MedStreamer();
            Console.WriteLine(stremRocket.getContent());
        }
    }
}
