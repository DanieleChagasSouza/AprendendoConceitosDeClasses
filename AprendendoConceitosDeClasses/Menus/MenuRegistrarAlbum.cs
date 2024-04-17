

using AprendendoConceitosDeClasses.Modelos;

namespace AprendendoConceitosDeClasses.Menus;

internal class MenuRegistrarAlbum : Menu
{
    public override void Executar(Dictionary<string, Banda> bandasregistradas)
    {
        base.Executar(bandasregistradas);
        ExibirTitulo("Registro de álbuns");
        Console.Write("Digite a banda cujo album deseja registrar: ");
        string nomeDaBanda = Console.ReadLine()!;
        if (bandasregistradas.ContainsKey(nomeDaBanda))
        {
            Console.Write("Agora digite o titulo do album: ");
            string tituloDoAlbum = Console.ReadLine()!;
            Banda banda = bandasregistradas[nomeDaBanda];
            banda.AdicionarAlbum(new Album(nomeDaBanda));

            Console.WriteLine($"O Álbum {tituloDoAlbum} de {nomeDaBanda} foi registrado com sucesso!");
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
