using Composite_Pattern.Example_1;

RunExample1();

static void RunExample1()
{
    var rootBox = new CompositeGift("RootBox", 0);

    var plainToy = new SingleGift("PlainToy", 255);
    var carToy = new SingleGift("CarToy", 145);

    rootBox.Add(plainToy);
    rootBox.Add(carToy);

    var childBox = new CompositeGift("ChildBox", 0);
    var soldierToy = new SingleGift("SoldierToy", 111);
    childBox.Add(soldierToy);

    rootBox.Add(childBox);

    Console.WriteLine($"Total Price of Gifts: {rootBox.CalculateTotalPrice()}");
}