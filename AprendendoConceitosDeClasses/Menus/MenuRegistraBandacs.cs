using AprendendoConceitosDeClasses.Modelos;

namespace AprendendoConceitosDeClasses.Menus;

internal class MenuRegistraBandacs : Menu
{
    public override void Executar(Dictionary<string, Banda> bandasregistradas)
    {
        base.Executar(bandasregistradas);
        ExibirTitulo("Registro de bandas");
        Console.Write("Digite o nome da banda que deseja registrar: ");
        string nomeDaBanda = Console.ReadLine()!;
        Banda banda = new Banda(nomeDaBanda);
        bandasregistradas.Add(nomeDaBanda, banda);
        Console.WriteLine($"A banda {nomeDaBanda} foi registrada com sucesso!");
        Thread.Sleep(2000);
        Console.Clear();

    }
}
