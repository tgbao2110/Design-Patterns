public class ShoppingCart
{
    private IPaymentStrategy paymentStrategy;

    public void SetPaymentStrategy(IPaymentStrategy paymentStrategy)
    {
        this.paymentStrategy = paymentStrategy;
    }

    public void Checkout(int amount)
    {
        if (paymentStrategy == null)
        {
            Console.WriteLine("Please select a payment method.");
        }
        else
        {
            paymentStrategy.Pay(amount);
        }
    }
}
