public class Televisao
{

    private const int VOL_MAX = 100;
    private const int VOL_MIN = 0;
    private const int CANAL_MINIMO = 1;
    private const int CANAL_MAXIMO = 520;

    private int ultimoCanalAssistido = 1; // começa no 1 por padrão

    public Televisao(float tamanho)
    {
        Tamanho = tamanho;
        Estado = false; // desligada por padrão
        Volume = 10;    // volume inicial
        Canal = 1;      // canal inicial
    }

    public float Tamanho { get; }
    public int Resolucao { get; set; }
    public int Volume { get; private set; }
    public int Canal { get; private set; }
    public bool Estado { get; private set; }
    public bool Mudo { get; private set; }

    public void LigarOuDesligar()
    {
        Estado = !Estado;
        if (Estado)
        {
            Canal = ultimoCanalAssistido; // volta para o último canal assistido
            Console.WriteLine("A TV foi ligada.");
        }
        else
        {
            Console.WriteLine("A TV foi desligada.");
        }
    }

    public void AumentarVolume()
    {
        {
            if (!Estado) { Console.WriteLine("A TV está desligada!"); return; }
            if (Volume < VOL_MAX) { Volume++; Mudo = false; }
            else Console.WriteLine("Volume máximo atingido.");
        }
    }

    // Diminui o volume em 1 unidade
    public void DiminuirVolume()
    {
        if (!Estado)
        {
            if (!Estado) { Console.WriteLine("A TV está desligada!"); return; }
            if (Volume > VOL_MIN) { Volume--; Mudo = false; }
            else Console.WriteLine("Volume mínimo atingido.");
        }
    }

    // Ativa ou desativa o modo mudo
    public void AtivarOuDesativarMudo()
    {
        if (!Estado) { Console.WriteLine("A TV está desligada!"); return; }
        Mudo = !Mudo;
        Console.WriteLine(Mudo ? "Mudo ativado." : "Mudo desativado.");
    }

    // ================== CONTROLE DE CANAIS ==================
    public void IrParaCanal(int numeroCanal)
    {
        if (!Estado) { Console.WriteLine("A TV está desligada!"); return; }

        if (numeroCanal >= CANAL_MINIMO && numeroCanal <= CANAL_MAXIMO)
        {
            Canal = numeroCanal;
            ultimoCanalAssistido = Canal; // guarda como último canal
            Console.WriteLine($"Canal alterado para {Canal}.");
        }
        else
        {
            Console.WriteLine("Número de canal inválido!");
        }
    }

    public void ProximoCanal()
    {
        if (!Estado) { Console.WriteLine("A TV está desligada!"); return; }

        if (Canal < CANAL_MAXIMO)
            Canal++;
        else
            Canal = CANAL_MINIMO; // volta ao primeiro canal

        ultimoCanalAssistido = Canal;
        Console.WriteLine($"Canal alterado para {Canal}.");
    }

    public void CanalAnterior()
    {
        if (!Estado) { Console.WriteLine("A TV está desligada!"); return; }

        if (Canal > CANAL_MINIMO)
            Canal--;
        else
            Canal = CANAL_MAXIMO; // volta ao último canal

        ultimoCanalAssistido = Canal;
        Console.WriteLine($"Canal alterado para {Canal}.");
    }

    // ================== INFORMAÇÕES ==================
    public void ExibirInformacoes()
    {
        Console.WriteLine($"📺 TV {Tamanho}\"");
        Console.WriteLine($"Estado: {(Estado ? "Ligada" : "Desligada")}");
        Console.WriteLine($"Canal atual: {Canal}");
        Console.WriteLine($"Resolução: {Resolucao}p");
        Console.WriteLine(Mudo ? "Volume: MUDO" : $"Volume: {Volume}");
        Console.WriteLine("----------------------------------");
    }
}
