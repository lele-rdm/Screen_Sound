using ScreenSound.Modelos;
using System.Threading.Channels;

Banda ira = new("Ira!");
ira.AdicionarNota(10);
ira.AdicionarNota(8);
ira.AdicionarNota(6);
Banda beatles = new("The Beatles");

Dictionary<string, Banda> bandasRegistradas = new();
bandasRegistradas.Add(ira.Nome, ira);
bandasRegistradas.Add(beatles.Nome, beatles);

void ExibirLogo()
{
    Console.WriteLine(@"
    ░██████╗░█████╗░██████╗░███████╗███████╗███╗░░██╗  ░██████╗░█████╗░██╗░░░██╗███╗░░██╗██████╗░
    ██╔════╝██╔══██╗██╔══██╗██╔════╝██╔════╝████╗░██║  ██╔════╝██╔══██╗██║░░░██║████╗░██║██╔══██╗
    ╚█████╗░██║░░╚═╝██████╔╝█████╗░░█████╗░░██╔██╗██║  ╚█████╗░██║░░██║██║░░░██║██╔██╗██║██║░░██║
    ░╚═══██╗██║░░██╗██╔══██╗██╔══╝░░██╔══╝░░██║╚████║  ░╚═══██╗██║░░██║██║░░░██║██║╚████║██║░░██║
    ██████╔╝╚█████╔╝██║░░██║███████╗███████╗██║░╚███║  ██████╔╝╚█████╔╝╚██████╔╝██║░╚███║██████╔╝
    ╚═════╝░░╚════╝░╚═╝░░╚═╝╚══════╝╚══════╝╚═╝░░╚══╝  ╚═════╝░░╚════╝░░╚═════╝░╚═╝░░╚══╝╚═════╝░
    ");
    Console.WriteLine("Boas Vindas ao Screen Sound!");
}
void ExibirOpcoesDoMenu()
{
    ExibirLogo();
    Console.WriteLine("\nDigite 1 para registrar uma banda");
    Console.WriteLine("Digite 2 para registrar o álbum de uma banda");
    Console.WriteLine("Digite 3 para mostrar todas as bandas");
    Console.WriteLine("Digite 4 para avaliar uma banda");
    Console.WriteLine("Digite 5 para exibir os detalhes de uma banda");
    Console.WriteLine("Digite -1 para sair");

    Console.Write("\nDigite a sua opção: ");
    int opcaoEscolhida = int.Parse(Console.ReadLine()!);

    switch (opcaoEscolhida)
    {
        case 1:
            RegistrarBanda();
            break;
        case 2:
            RegistrarAlbum();
            break;
        case 3:
            MostrarBandasRegistradas();
            break;
        case 4:
            AvaliarUmaBanda();
            break;
        case 5:
            ExibirDetalhes();
            break;
        case -1:
            Console.WriteLine($"Até mais! Obrigado");
            break;
        default:
            Console.WriteLine("Opção Inválida.");
            break;
    }
}
void RegistrarAlbum()
{
    Console.Clear();
    ExibirTituloDaOpcao("Registro de Álbuns");
    Console.Write("Digite a banda do álbum que deseja registrar: ");
    string nomeDaBanda = Console.ReadLine()!;
    if (bandasRegistradas.ContainsKey(nomeDaBanda))
    {
        Console.Write("Agora digite o título do Álbum: ");
        string tituloAlbum = Console.ReadLine();
        Banda banda = bandasRegistradas[nomeDaBanda];
        banda.AdicionarAlbum(new Album(tituloAlbum));
        Console.WriteLine($"O álbum {tituloAlbum} da banda {nomeDaBanda} foi registrado com sucesso!");
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
    ExibirOpcoesDoMenu();
}
void RegistrarBanda()
{
    Console.Clear();
    ExibirTituloDaOpcao("  Registro de Bandas  ");
    Console.Write("\nDigite a banda a ser registrada: ");
    string nomeDaBanda = Console.ReadLine()!;
    Banda banda = new(nomeDaBanda);
    bandasRegistradas.Add(nomeDaBanda, banda);
    Console.WriteLine($"A banda {nomeDaBanda} foi registrada com sucesso!");
    Thread.Sleep(2000);
    Console.Clear();
    ExibirOpcoesDoMenu();
}
void MostrarBandasRegistradas()
{
    Console.Clear();
    ExibirTituloDaOpcao("  Exibindo Bandas Registradas  ");

    foreach (string banda in bandasRegistradas.Keys)
    {
        Console.WriteLine($"Banda: {banda}");
    }
    Console.WriteLine("\nDigite uma tecla para voltar ao menu principal");
    Console.ReadKey();
    Console.Clear();
    ExibirOpcoesDoMenu();

}
void ExibirTituloDaOpcao(string titulo)
{
    int quantidadeDeLetras = titulo.Length;
    string simbolos = string.Empty.PadLeft(quantidadeDeLetras, '=');
    Console.WriteLine(simbolos);
    Console.WriteLine(titulo);
    Console.WriteLine($"{simbolos}\n");
}
void AvaliarUmaBanda()
{
    Console.Clear();
    ExibirTituloDaOpcao("  Avaliar Banda  ");
    Console.Write("Digite o nome da banda que deseja avaliar: ");
    string nomeDaBanda = Console.ReadLine()!;
    if (bandasRegistradas.ContainsKey(nomeDaBanda))
    {
        Banda banda = bandasRegistradas[nomeDaBanda];
        Console.Write($"Digite a nota da banda {nomeDaBanda}: ");
        int nota = int.Parse(Console.ReadLine()!);
        banda.AdicionarNota(nota);
        Console.WriteLine($"\nA nota {nota} para a banda {nomeDaBanda} foi registrada com sucesso!");
        Thread.Sleep(3000);
        Console.Clear();
        ExibirOpcoesDoMenu();
    }
    else
    {
        Console.WriteLine($"\nA banda {nomeDaBanda} não foi encontrada. ");
        Console.WriteLine("Digite uma tecla para voltar ao menu principal. ");
        Console.ReadKey();
        Console.Clear();
        ExibirOpcoesDoMenu();
    }

}
void ExibirDetalhes()
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
        ExibirOpcoesDoMenu();
    }
    else
    {
        Console.WriteLine($"\nA banda {nomeDaBanda} não foi encontrada. ");
        Console.WriteLine("Digite uma tecla para voltar ao menu principal. ");
        Console.ReadKey();
        Console.Clear();
        ExibirOpcoesDoMenu();
    }

}

// Programa Principal

ExibirOpcoesDoMenu();