using Screen_Sound.Modelos;

namespace Screen_Sound.Menus;

internal class MenuRegistrarAlbum : Menu
{
    public override void Executar(Dictionary<string, Banda> bandasRegistradas)
    {
        base.Executar(bandasRegistradas);
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
    }
}
