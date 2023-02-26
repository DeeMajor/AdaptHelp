using CaptureDetails.Models;
using Newtonsoft.Json;
using System.Text.Json;
using System.Text.Json.Serialization;

namespace CaptureDetails.Services
{
    public class WriteFile
    {
        const string file = "../clients.json";

        public string WriteToFile(Client client)
        {
            

            if (File.Exists(@$"{file}"))
            {
                string jsonrString = File.ReadAllText(@$"{file}");
                CheckIfExists(client, jsonrString);
                var listOfClients =  JsonConvert.DeserializeObject<List<Client>>(jsonrString);
                listOfClients.Add(client);
                var convertedJSON = JsonConvert.SerializeObject(listOfClients, Formatting.Indented);
                
                File.WriteAllText(@$"{file}", convertedJSON);

            } else
            {
                List<Client> listOfClients = new List<Client>();
                listOfClients.Add(client);
                var json = System.Text.Json.JsonSerializer.Serialize(listOfClients);

                File.WriteAllText($@"{file}", json);
            }
            

            return "Client Successfully Added";
        }

        private void CheckIfExists(Client client, string fileString)
        {
            if (fileString.Contains(client.clientName))
            {
                throw new Exception("Client exists");
            }

        }
    }
}
