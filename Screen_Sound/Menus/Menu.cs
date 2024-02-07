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
}
