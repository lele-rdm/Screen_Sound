using Screen_Sound.Modelos;

namespace Screen_Sound.Menus;

internal class MenuAvaliarBanda : Menu
{
    public void Executar(Dictionary<string, Banda> bandasRegistradas)
    {

        Console.Clear();
        ExibirTituloDaOpcao("  Avaliar Banda  ");
        Console.Write("Digite o nome da banda que deseja avaliar: ");
        string nomeDaBanda = Console.ReadLine()!;
        if (bandasRegistradas.ContainsKey(nomeDaBanda))
        {
            Banda banda = bandasRegistradas[nomeDaBanda];
            Console.Write($"Digite a nota da banda {nomeDaBanda}: ");
            Avaliacao nota = Avaliacao.Parse(Console.ReadLine()!);
            banda.AdicionarNota(nota);
            Console.WriteLine($"\nA nota {nota} para a banda {nomeDaBanda} foi registrada com sucesso!");
            Thread.Sleep(3000);
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
