using System.Text;

namespace Builder_Pattern.Example;


/// <summary>
/// This is the object (product) we are going to build with the Builder 
/// Pattern. 
/// 
/// It makes sense to use the Builder pattern only when your  
/// products are quite complex and require extensive configuration.
/// </summary>

public class ProductStockReport
{
    public string Header { get; set; }
    public string Body { get; set; }
    public string Footer { get; set; }

    public override string ToString()
    {
        return new StringBuilder()
            .AppendLine(Header)
            .AppendLine(Body)
            .AppendLine(Footer)
            .ToString();
    }
}
