namespace AprendendoConceitosDeClasses.Modelos;

internal interface IAvaliavel
{
    void AdicionarNota(Avaliacao nota);
    double Media {  get; }
}
