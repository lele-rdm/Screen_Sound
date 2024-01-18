
class Musica
{
    public string Nome { get; set; }
    public string Artista { get; set; }
    public int Duracao { get; set; }
    public bool Disponivel { get; set; }
    public string DescricaoResumida => $"A música {Nome} pertence á banda {Artista}";
    public void ExibirFichaTecnica()
    {
        Console.WriteLine($"Nome da Música: {Nome}");
        Console.WriteLine($"Nome do Artista: {Artista}");
        Console.WriteLine($"Tempo de Duração: {Duracao}");
        if (Disponivel) 
        {
            Console.WriteLine("Disponibilidade: Disponível");
        }
        else
        {
            Console.WriteLine("Disponibilidade: Indisponível\nPara ter acesso adquira o Plano Plus.");
        }
    }
}