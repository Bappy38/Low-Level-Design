using Decorator_Pattern.Example;

RunExample();

static void RunExample()
{
    var regularOrder = new RegularOrder();
    Console.WriteLine(regularOrder.CalculateTotalPrice());
    Console.WriteLine();

    var preOrder = new PreOrder();
    Console.WriteLine(preOrder.CalculateTotalPrice());
    Console.WriteLine();

    var premiumPreorder = new PremiumPreOrder(preOrder);
    Console.WriteLine(premiumPreorder.CalculateTotalPrice());
}