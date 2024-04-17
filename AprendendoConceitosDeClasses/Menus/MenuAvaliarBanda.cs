using AprendendoConceitosDeClasses.Modelos;

namespace AprendendoConceitosDeClasses.Menus;

internal class MenuAvaliarBanda : Menu
{
    public override void Executar(Dictionary<string, Banda> bandasregistradas)
    {
        base.Executar(bandasregistradas);
        ExibirTitulo("Avaliar Bandas");
        Console.Write("Digite o nome da banda que desejar avaliar: ");
        string nomeDaBanda = Console.ReadLine()!;

        if (bandasregistradas.ContainsKey(nomeDaBanda))
        {
            Banda banda = bandasregistradas[nomeDaBanda];
            Console.Write($"Qual a nota que a banda {nomeDaBanda} merece: ");
            Avaliacao nota = Avaliacao.Parse(Console.ReadLine()!);
            banda.AdicionarNota(nota);
            Console.WriteLine($" \n A nota {nota.Nota} foi registrada com sucesso, para a banda {nomeDaBanda}");
            Thread.Sleep(3000);
            Console.Clear();
        }
        else
        {
            Console.WriteLine($"\n A banda {nomeDaBanda} não foi encontrada!");
            Console.WriteLine("Digite uma tecla para volta ao menu principal! \n");
            Console.ReadKey();
            Console.Clear();

        }
    }

}
