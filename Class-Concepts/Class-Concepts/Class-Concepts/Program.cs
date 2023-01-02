using Class_Concepts;

internal class Program
{
    private static void Main(string[] args)
    {
        var person = new Person(10);
        Console.WriteLine(person.age);

        //initializing the object
        var person1 = new Person { age = 10, Firstname = "bhuvanesh", lastName = "Raja", orders = new List<Order>() };
        Console.WriteLine(person1.Firstname);
        var order = new Order();
        order.name = "test-1";
        person1.orders.Add(order);
        foreach (var orders in person1.orders)
        {
            Console.WriteLine(orders.name);
        }


        var calc = new Calculator();
        Console.WriteLine(calc.Add(1,2,3,4,5));

    }
}