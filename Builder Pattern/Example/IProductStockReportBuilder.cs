namespace Builder_Pattern.Example;

/// <summary>
/// This is the Builder interface. The Builder interface specifies methods
/// for creating different parts of the Product objects. Returning the
/// same builder object from those methods is an extension known as Fluent
/// Builder.
/// </summary>

public interface IProductStockReportBuilder
{
    IProductStockReportBuilder BuildHeader();
    IProductStockReportBuilder BuildBody();
    IProductStockReportBuilder BuildFooter();

    ProductStockReport GetReport();
}
