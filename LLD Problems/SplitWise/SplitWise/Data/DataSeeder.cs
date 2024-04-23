using System.Text.Json;

namespace SplitWise.Data;

public class DataSeeder
{
    public static async Task SeedData<T>(RepositoryContext repositoryContext) where T : class
    {
        var modelName = typeof(T).Name;
        var templatePath = Path.Combine("Data", "SeedData", $"{modelName}s.json");

        if (!File.Exists(templatePath))
        {
            Console.WriteLine($"Seed template not found at path: {templatePath}");
            return;
        }

        Console.WriteLine($"Seeding Data for Model {modelName} from Template {templatePath}");

        var data = File.ReadAllText(templatePath);
        var entries = JsonSerializer.Deserialize<List<T>>(data);

        if (entries is null || !entries.Any())
        {
            Console.WriteLine($"No entries found to seed from template {templatePath}");
            return;
        }

        repositoryContext.Set<T>().AddRange(entries);
        await repositoryContext.SaveChangesAsync();
        Console.WriteLine($"{entries.Count} entries seeded successfully");
    }
}