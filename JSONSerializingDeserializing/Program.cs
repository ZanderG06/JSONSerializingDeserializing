using System;
using System.Text.Json;

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

            System.IO.File.WriteAllText("settings.json", jsonString);

            Settings newSettings = JsonSerializer.Deserialize<Settings>(jsonString);
            Console.WriteLine($"Lives: {newSettings.lives}, Score: {newSettings.score}");
        }
    }
}