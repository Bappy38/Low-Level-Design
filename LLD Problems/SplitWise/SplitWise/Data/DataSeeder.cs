using System.Text.Json;

namespace SplitWise.Data;

public class DataSeeder
{
    public static List<T> GetSeedData<T>() where T : class
    {
        var modelName = typeof(T).Name;
        var templatePath = Path.Combine("Data", "SeedData", $"{modelName}s.json");

        if (!File.Exists(templatePath))
        {
            Console.WriteLine($"Seed template not found at path: {templatePath}");
            return new List<T>();
        }

        var data = File.ReadAllText(templatePath);
        var entries = JsonSerializer.Deserialize<List<T>>(data);

        if (entries is null || !entries.Any())
        {
            Console.WriteLine($"No entries found to seed from template {templatePath}");
            return new List<T>();
        }

        return entries;
    }
}