using System.Collections.Generic;
using RestSharp;

namespace LouthRoad.Core
{
    public class TemperatureService
    {        
        public IList<SensorValue> GetTemperatureList()
        {
            var client = new RestClient("https://louthroadtemperature.azure-mobile.net");
            var request = new RestRequest("/tables/SensorValue?$orderby=TimeStamp%20desc", Method.GET);

            return client.Execute<List<SensorValue>>(request).Data;            
        }
    }
}