using AprendendoConceitosDeClasses.Modelos;

namespace AprendendoConceitosDeClasses.Menus;

internal class Menu
{
    public void ExibirTitulo(string titulo)
    {
        int quantidadeLetras = titulo.Length;
        string asterisco = string.Empty.PadLeft(quantidadeLetras, '*');
        Console.WriteLine(asterisco);
        Console.WriteLine(titulo);
        Console.WriteLine(asterisco + "\n");
    }
    public virtual void Executar(Dictionary<string, Banda> bandasregistradas)
    {
        Console.Clear();
    }
}
