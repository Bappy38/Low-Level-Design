
using Builder_Pattern.Example;


RunExample();

static void RunExample()
{
    var products = new List<Product>
        {
            new Product { Name = "Monitor", Price = 200.50 },
            new Product { Name = "Mouse", Price = 20.41 },
            new Product { Name = "Keyboard", Price = 30.15}
        };

    var builder = new ProductStockReportBuilder(products);
    var director = new ProductStockReportDirector(builder);
    director.BuildStockReport();
    var report = builder.GetReport();
    Console.WriteLine(report);
}