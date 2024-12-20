public class Product : Component
{
    private decimal _price;

    public Product(string name, decimal price)
    {
        base.name = name;
        _price = price;
    }

    public override decimal GetPrice()
    {
        return _price;
    }
}

