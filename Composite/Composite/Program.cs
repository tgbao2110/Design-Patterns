
class Program
{
    static void Main(string[] args)
    {
        //Leaf
        Component book = new Product("Book", 20);

        //Node
        Box box1 = new  Box("Package");
        box1.AddComponent(new Product("Controllẻ", 30));
        box1.AddComponent(new Product("Pants", 50));

        //Root
        Box package = new Box("Main Package");
        package.AddComponent(book);
        package.AddComponent(box1);

        decimal totalPrice = package.GetPrice();
        Console.WriteLine("Total price of all products: " + totalPrice); // Output: 100
    }
}


