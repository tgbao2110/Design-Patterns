public class PayPalPayment : IPaymentStrategy
{
    private string email;

    public PayPalPayment(string email)
    {
        this.email = email;
    }

    public void Pay(int amount)
    {
        Console.WriteLine($"Paid {amount} using PayPal.");
    }
}
