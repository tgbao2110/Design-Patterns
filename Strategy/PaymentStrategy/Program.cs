class Program
{
    static void Main(string[] args)
    {
        ShoppingCart cart = new ShoppingCart();

        // Pay with Credit Card
        cart.SetPaymentStrategy(new CreditCardPayment("1234-5678-9876-5432"));
        cart.Checkout(100);

        // Pay with PayPal
        cart.SetPaymentStrategy(new PayPalPayment("user@example.com"));
        cart.Checkout(200);
    }
}
