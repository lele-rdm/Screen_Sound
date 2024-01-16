
class Musica
{
    public string nome;
    public string artista;
    public int duracao;
    public bool disponivel;

    public void ExibirFichaTecnica()
    {
        Console.WriteLine($"Nome da Música: {nome}");
        Console.WriteLine($"Nome do Artista: {artista}");
        Console.WriteLine($"Tempo de Duração: {duracao}");
        if (disponivel) 
        {
            Console.WriteLine("Disponibilidade: Disponível");
        }
        else
        {
            Console.WriteLine("Disponibilidade: Indisponível\nPara ter acesso adquira o Plano Plus.");
        }
    }
}