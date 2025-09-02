public class Televisao
{
    public Televisao(float tamanho)
    {
        Tamanho = tamanho;
    }

    public float Tamanho { get; }
    public int Resolucao { get; set; } 
    public int Volume { get; set; }
    public int Canal { get; set; }
    public int Estado { get;set; }

    public void AumentarVolume()
    {
        if (Volume < 100)
            Volume++;
        else
            Console.WriteLine("TV já está no max.");
    }
}