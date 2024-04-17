using AprendendoConceitosDeClasses.Modelos;

namespace AprendendoConceitosDeClasses.Menus
{
    internal class MenuMostraBandasRegistrada : Menu
    {
        public override void Executar(Dictionary<string, Banda> bandasregistradas)
        {
            base.Executar(bandasregistradas);
            ExibirTitulo("Exibirndo Bandas \n");
            /*for (int i= 0; i < listaDeBandas.Count; i++)
            {
                Console.WriteLine($"Banda: {listaDeBandas[i]}");
            }*/
            foreach (string banda in bandasregistradas.Keys)
            {
                Console.WriteLine($"Banda: {banda}");
            }
            Console.WriteLine("\n Digite uma tecla para voltar ao menu inicial!");
            Console.ReadKey();
            Console.Clear();
        }
    }
}
