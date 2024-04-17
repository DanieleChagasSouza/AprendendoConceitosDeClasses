namespace AprendendoConceitosDeClasses.Modelos;
internal class Podcast
{
    private List<Episodio> episodios = new List<Episodio>();
    public Podcast(string nome, string host)
    {
        Nome = nome;
        Host = host;
    }

    public string Nome { get; }
    public string Host { get; }

    public int TotalEpisodios { get; set; }

    public void AdicionarEpisodios(Episodio episodio)
    {
        episodios.Add(episodio);
    }
    public void ExibirDetalhes()
    {
        Console.WriteLine($"Podcast {Nome} apresentando por {Host} \n");
        foreach(var episode in episodios.OrderBy(e => e.Ordem))
        {
            Console.WriteLine(episode.Resumo);
        }
        Console.WriteLine($"Esse podcast possui {TotalEpisodios} episodios.");
    }

}