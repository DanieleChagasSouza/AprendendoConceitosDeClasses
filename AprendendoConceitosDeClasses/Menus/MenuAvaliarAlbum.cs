using AprendendoConceitosDeClasses.Modelos;

namespace AprendendoConceitosDeClasses.Menus;

internal class MenuAvaliarAlbum : Menu
{
    public override void Executar(Dictionary<string, Banda> bandasregistradas)
    {
        base.Executar(bandasregistradas);
        ExibirTitulo("Avaliar Album");
        Console.Write("Digite o nome da banda que desejar avaliar: ");
        string nomeDaBanda = Console.ReadLine()!;

        if (bandasregistradas.ContainsKey(nomeDaBanda))
        {
            Banda banda = bandasregistradas[nomeDaBanda];
            Console.Write("Agora digite o titulo do album: ");
            string tituloDoAlbum = Console.ReadLine()!;
            if(banda.Albums.Any(a => a.Nome.Equals(tituloDoAlbum)))
            {
                Album album = banda.Albums.First(a => a.Equals(tituloDoAlbum));
                Console.Write($"Qual a nota que o Album {tituloDoAlbum} merece: ");
                Avaliacao nota = Avaliacao.Parse(Console.ReadLine()!);
                album.AdicionarNota(nota);
                Console.WriteLine($" \n A nota {nota.Nota} foi registrada com sucesso, para o album {tituloDoAlbum}");
                Thread.Sleep(3000);
                Console.Clear();

            }
            else
            {
                Console.WriteLine($"\n O album {tituloDoAlbum} não foi encontrada!");
                Console.WriteLine("Digite uma tecla para volta ao menu principal! \n");
                Console.ReadKey();
                Console.Clear();
            }
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
