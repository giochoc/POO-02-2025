public class CartaoDebito : Cartao
{
    public override void Debitar(decimal valor)
    {
        Console.WriteLine($"Compra {valor:C} realizada no cartão de débito.");
    }
}