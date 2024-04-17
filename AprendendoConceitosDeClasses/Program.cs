
using AprendendoConceitosDeClasses.Menus;
using AprendendoConceitosDeClasses.Modelos;
//using OpenAI_API;

//var client = new OpenAIAPI("sk-proj-YcEmjthIylhYPjTtIbcQT3BlbkFJ8rDhDG2iZYPOje195D5q");

//var chat = client.Chat.CreateConversation();
//chat.AppendSystemMessage("Resuma a banda Nickelback em um paragrafo. adota um estilo informal.");

//string resposta = await chat.GetResponseFromChatbotAsync();
//Console.WriteLine(resposta);

Banda calypso = new Banda("Calypso");
calypso.AdicionarNota(new Avaliacao(10));
calypso.AdicionarNota(new Avaliacao(9));
calypso.AdicionarNota(new Avaliacao(4));

Banda internacional = new Banda("internacional");

Dictionary<string, Banda> bandasregistradas = new();
bandasregistradas.Add(calypso.Nome, calypso);
bandasregistradas.Add(internacional.Nome, internacional);

Dictionary<int, Menu> opcoes = new();
opcoes.Add(1, new MenuRegistraBandacs());
opcoes.Add(2, new MenuRegistrarAlbum());
opcoes.Add(3, new MenuMostraBandasRegistrada());
opcoes.Add(4, new MenuAvaliarBanda());
opcoes.Add(5, new MenuAvaliarAlbum());
opcoes.Add(6, new MenuExibirDetalhes());
opcoes.Add(-1, new MenuSaircs());



void ExibirLogo()
{
    Console.WriteLine(@"
░██████╗░█████╗░██████╗░███████╗███████╗███╗░░██╗  ░██████╗░█████╗░██╗░░░██╗███╗░░██╗██████╗░
██╔════╝██╔══██╗██╔══██╗██╔════╝██╔════╝████╗░██║  ██╔════╝██╔══██╗██║░░░██║████╗░██║██╔══██╗
╚█████╗░██║░░╚═╝██████╔╝█████╗░░█████╗░░██╔██╗██║  ╚█████╗░██║░░██║██║░░░██║██╔██╗██║██║░░██║
░╚═══██╗██║░░██╗██╔══██╗██╔══╝░░██╔══╝░░██║╚████║  ░╚═══██╗██║░░██║██║░░░██║██║╚████║██║░░██║
██████╔╝╚█████╔╝██║░░██║███████╗███████╗██║░╚███║  ██████╔╝╚█████╔╝╚██████╔╝██║░╚███║██████╔╝
╚═════╝░░╚════╝░╚═╝░░╚═╝╚══════╝╚══════╝╚═╝░░╚══╝  ╚═════╝░░╚════╝░░╚═════╝░╚═╝░░╚══╝╚═════╝░");

}

void ExibirMenuDeOpsoes()
{
    ExibirLogo();
    Console.WriteLine("\n Digite 1 para registrar uma banda");
    Console.WriteLine("Digite 2 para registrar um album");
    Console.WriteLine("Digite 3 Mostra todas as bandas registradas");
    Console.WriteLine("Digite 4 Avaliar uma banda ");
    Console.WriteLine("Digite 5 Avaliara um album");
    Console.WriteLine("Digite 6 Exibir detalhes");
    Console.WriteLine("digite -1 para sair");

    Console.Write("\n Digite a sua opção/: ");
    string opcoesEscolhida = Console.ReadLine()!;
    int opcaoNumerica = int.Parse(opcoesEscolhida);

    if(opcoes.ContainsKey(opcaoNumerica))
    {
        Menu menuASerExibido = opcoes[opcaoNumerica];
        menuASerExibido.Executar(bandasregistradas);
        if (opcaoNumerica > 0) ExibirMenuDeOpsoes();
    }
    else
    {
        Console.WriteLine("Opção invalida!");
    }

}
ExibirMenuDeOpsoes();