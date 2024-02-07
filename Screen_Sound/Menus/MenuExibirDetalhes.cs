using Screen_Sound.Modelos;

namespace Screen_Sound.Menus;

internal class MenuExibirDetalhes
{
    void ExibirTituloDaOpcao(string titulo)
    {
        int quantidadeDeLetras = titulo.Length;
        string simbolos = string.Empty.PadLeft(quantidadeDeLetras, '=');
        Console.WriteLine(simbolos);
        Console.WriteLine(titulo);
        Console.WriteLine($"{simbolos}\n");
    }
    public void Executar(Dictionary<string, Banda> bandasRegistradas)
    {
        Console.Clear();
        ExibirTituloDaOpcao("  Exibir Média da Banda  ");
        Console.Write("Digite o nome da banda que deseja exibir a média: ");
        string nomeDaBanda = Console.ReadLine()!;
        if (bandasRegistradas.ContainsKey(nomeDaBanda))
        {
            Banda banda = bandasRegistradas[nomeDaBanda];
            Console.WriteLine($"\nA média da banda {nomeDaBanda} é {banda.Media}");
            Console.WriteLine("Digite uma tecla para voltar ao menu principal");
            Console.ReadKey();
            Console.Clear();
        }
        else
        {
            Console.WriteLine($"\nA banda {nomeDaBanda} não foi encontrada. ");
            Console.WriteLine("Digite uma tecla para voltar ao menu principal. ");
            Console.ReadKey();
            Console.Clear();
        }
    }
}
