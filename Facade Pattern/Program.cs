

using Facade_Pattern.Example;

RunExample();

///
/// The client code works with complex subsystems through a simple 
/// interface provided by the Facade. When a facade manages the lifecycle
/// of the subsystems, the client might not even know about the existence
/// of the subsystems. This approach lets you keep the complexity under control.
///
static void RunExample()
{
    var restaurant = new OnlineRestaurant();
    var shippingService = new ShippingService();

    var facade = new Facade(restaurant, shippingService);

    var chickenOrder = new Order
    {
        DishName = "Grilled Chicken",
        DishPrice = 20,
        User = "Bappy",
        ShippingAddress = "RAOWA"
    };

    var beefOrder = new Order
    {
        DishName = "Beef Sheek",
        DishPrice = 52,
        User = "Jabed",
        ShippingAddress = "Maniknagar"
    };

    facade.OrderFood(new List<Order> { beefOrder, chickenOrder });
}