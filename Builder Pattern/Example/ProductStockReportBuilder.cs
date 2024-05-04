namespace Builder_Pattern.Example;


/// <summary>
/// This is the concrete Builder class. The Concrete Builder classes
/// follow the Builder interface and provide specific implementations of
/// the building steps.
/// </summary>

public class ProductStockReportBuilder : IProductStockReportBuilder
{
    private ProductStockReport _productStockReport;
    private IEnumerable<Product> _products;

    public ProductStockReportBuilder(IEnumerable<Product> products)
    {
        _products = products;

        // A fresh builder instance should contain a blank product object.
        _productStockReport = new ProductStockReport();
    }

    public IProductStockReportBuilder BuildHeader()
    {
        _productStockReport.Header = $"Stock Report for All the Products on Date: {DateTime.UtcNow}\n";

        return this;
    }

    public IProductStockReportBuilder BuildBody()
    {
        _productStockReport.Body = string.Join("\n", _products.Select(p => $"Product Name: {p.Name}, Product Price: {p.Price}"));

        return this;
    }

    public IProductStockReportBuilder BuildFooter()
    {
        _productStockReport.Footer = $"\nReport provided by the IT_Department of XYZ company.";

        return this;
    }


    /// <summary>
    /// Usually, after returning the end result to the client, a
    /// builder instance is expected to be ready to start producing 
    /// another product. That's why it's a usual practice to call the 
    /// reset method at the end of the `GetProduct` method body.
    /// </summary>
    
    public ProductStockReport GetReport()
    {
        var productStockReport = _productStockReport;
        Clear();
        return productStockReport;
    }

    private void Clear()
    {
        _productStockReport = new ProductStockReport();
    }
}
