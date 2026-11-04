using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Text.Json;
using System.Security.Cryptography.X509Certificates;

namespace JSONSerializingDeserializing
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Settings settings = new Settings();

            settings.lives = 3;
            settings.score = 100;

            string jsonString = JsonSerializer.Serialize(settings);

            Console.WriteLine(jsonString);

            System.IO.File.WriteAllText("settings.json", jsonString);
        }

    }
}