using DisplayDetyails.Models;
using Newtonsoft.Json;

namespace DisplayDetyails.Services
{
    public class ReadData
    {
        const string file = "../clients.json";

        public List<Client> ReadFile()
        {
            string jsonrString = File.ReadAllText(@$"{file}");

            var listOfClients = JsonConvert.DeserializeObject<List<Client>>(jsonrString);

            return listOfClients;
        }
    }
}
