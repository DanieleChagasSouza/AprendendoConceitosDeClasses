namespace AprendendoConceitosDeClasses.Modelos;
internal class Musica
{
    public Musica(Banda artista, string nome)
    {
        Artista = artista;
        Nome = nome;
    }
    public string Nome { get; }
    public Banda Artista { get; }
    public int Duracao { get; set; }
    public bool Disponivel { get; set; }

    public Genero Genero { get; set; }

    public string DescricaoResumida => $"A musica {Nome} pertence ao Artista {Artista}";


    public void ExibirInformaçoes()
    {
        Console.WriteLine($"Nome: {Nome}");
        Console.WriteLine($"Artista: {Artista.Nome}");
        Console.WriteLine($"Duração: {Duracao}");
    }
}
