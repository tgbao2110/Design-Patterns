public class CreditCardPayment : IPaymentStrategy
{
    private string cardNumber;

    public CreditCardPayment(string cardNumber)
    {
        this.cardNumber = cardNumber;
    }

    public void Pay(int amount)
    {
        Console.WriteLine($"Paid {amount} using Credit Card.");
    }
}
