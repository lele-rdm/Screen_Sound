﻿using Screen_Sound.Modelos;

namespace Screen_Sound.Menus;

internal class MenuSair : Menu
{
    public void Executar(Dictionary<string, Banda> bandasRegistradas)
    {
        Console.WriteLine($"Até mais! Obrigado");
    }
}