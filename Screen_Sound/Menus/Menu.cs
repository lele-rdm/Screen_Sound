using Screen_Sound.Modelos;

namespace Screen_Sound.Menus;

internal class Menu
{
    public void ExibirTituloDaOpcao(string titulo)
    {
        int quantidadeDeLetras = titulo.Length;
        string simbolos = string.Empty.PadLeft(quantidadeDeLetras, '=');
        Console.WriteLine(simbolos);
        Console.WriteLine(titulo);
        Console.WriteLine($"{simbolos}\n");
    }

    public virtual void Executar(Dictionary<string, Banda> bandasRegistradas)
    {
        Console.Clear();
    }
}
