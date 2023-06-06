namespace Builder_Pattern.Example;


/// <summary>
/// The Director is only responsible for executing the building steps in a
/// particular sequence. It is helpful when producing products according
/// to a specific order or configuration. Strictly speaking, the Director 
/// class is optional, since the client can control builders directly.
/// 
/// The Director can construct several product variations using the
/// same building steps.
/// </summary>

public class ProductStockReportDirector
{
    private readonly IProductStockReportBuilder _productStockReportBuilder;

	public ProductStockReportDirector(IProductStockReportBuilder productStockReportBuilder)
	{
		_productStockReportBuilder = productStockReportBuilder;
	}

	public void BuildStockReport()
	{
		_productStockReportBuilder
			.BuildHeader()
			.BuildBody()
			.BuildFooter();
	}
}
