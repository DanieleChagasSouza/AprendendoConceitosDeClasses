using AprendendoConceitosDeClasses.Modelos;

namespace AprendendoConceitosDeClasses.Menus;

internal class MenuExibirDetalhes : Menu
{
    public override void Executar(Dictionary<string, Banda> bandasregistradas)
    {
        base.Executar(bandasregistradas);
        ExibirTitulo("Media da Banda");
        Console.Write("Qual o nome da banda que deseja conhecer melhor: ");
        string nomeDaBanda = Console.ReadLine()!;

        if (bandasregistradas.ContainsKey(nomeDaBanda))
        {
            Banda banda = bandasregistradas[nomeDaBanda];
            Console.WriteLine($"\n A Medía da banda {nomeDaBanda} é {banda.Media}.");
            foreach (Album album in banda.Albums)
            {
                Console.WriteLine($" {album.Nome} => {album.Media} ");
            }
            Console.WriteLine("\n Digite uma tecla para volta ao menu principal! \n");
            Console.ReadKey();
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
