using Chain_Of_Responsibility_Pattern.Example;


var monkey = new MonkeyHandler();
var cat = new CatHandler();
var dog = new DogHandler();

monkey.SetNext(cat).SetNext(dog);

/*
 * The client code should be able to send a request to any handler, not just the first one in the chain.
 */

EatFood(monkey);
Console.WriteLine();
EatFood(cat);

static void EatFood(AHandler handler)
{
    var foods = new List<string> { "Banana", "Milk", "Meat", "Coffee" };

    foreach (var food in foods)
    {
        Console.WriteLine($"Who wants to eat a {food}? ");

        var result = handler.Handle(food);

        if(result is null)
        {
            Console.WriteLine($"{food} was untouched.\n");
        }
        else
        {
            Console.WriteLine($" {result.ToString()}");
        }
    }
}