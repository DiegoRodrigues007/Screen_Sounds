

// SREEN SOUND

Dictionary<string, List<int>> bandasRegistradas = new Dictionary<string, List<int>>();
bandasRegistradas.Add("AC/DC", new List<int> { 10,5,6});
bandasRegistradas.Add("Nirvana", new List<int> ());
 void ExibirLogo()
{
    string mensagemDeBoasVindas = "Boas vindas ao Screen Sound";

    //Mensagem da logo Screen Sound com uma estilização.
    Console.WriteLine(@"
░██████╗░█████╗░██████╗░███████╗███████╗███╗░░██╗  ░██████╗░█████╗░██╗░░░██╗███╗░░██╗██████╗░
██╔════╝██╔══██╗██╔══██╗██╔════╝██╔════╝████╗░██║  ██╔════╝██╔══██╗██║░░░██║████╗░██║██╔══██╗
╚█████╗░██║░░╚═╝██████╔╝█████╗░░█████╗░░██╔██╗██║  ╚█████╗░██║░░██║██║░░░██║██╔██╗██║██║░░██║
░╚═══██╗██║░░██╗██╔══██╗██╔══╝░░██╔══╝░░██║╚████║  ░╚═══██╗██║░░██║██║░░░██║██║╚████║██║░░██║
██████╔╝╚█████╔╝██║░░██║███████╗███████╗██║░╚███║  ██████╔╝╚█████╔╝╚██████╔╝██║░╚███║██████╔╝
╚═════╝░░╚════╝░╚═╝░░╚═╝╚══════╝╚══════╝╚═╝░░╚══╝  ╚═════╝░░╚════╝░░╚═════╝░╚═╝░░╚══╝╚═════╝░");
    Console.WriteLine("\n*****************************");
    Console.WriteLine(mensagemDeBoasVindas);
    Console.WriteLine("*****************************");
} 

void ExibirOpcoesDoMenu()
{
    ExibirLogo();
    Console.WriteLine("\nDigite 1 para registrar uma banda");
    Console.WriteLine("Digite 2 para listar todas as bandas");
    Console.WriteLine("Digite 3 para avaliar uma banda");
    Console.WriteLine("Digite 4 para exibir a média de uma banda");
    Console.WriteLine("Digite 0 para sair");

    Console.Write("\nDigite a sua opção: ");

    string opcaoEscolhida= Console.ReadLine()!;
    int opcaoEscolhidaNumerica = int.Parse(opcaoEscolhida);

    switch (opcaoEscolhidaNumerica)
    {
        case 1: RegistrarBanda();
            break;
        case 2: MostrarBandasRegistradas();
            break;
        case 3: AvaliarUmaBanda();
            break;
        case 4: CalcularMediaDeBandas();
            break;

        case 0 : Console.WriteLine("Tchau tchau :) ");
            break;

            default: Console.WriteLine("Opção inválida.");
            break;
    }
}

void RegistrarBanda()
{
    Console.Clear();
    ExibirTituloDaOpcao("Registro das bandas");
    Console.Write("\n Digite o nome da banda que deseja registrar: ");
    string nomeDaBanda = Console.ReadLine()!;
    bandasRegistradas.Add(nomeDaBanda, new List<int>());
    Console.Write($"\nO nome da banda {nomeDaBanda} foi registrada com sucesso.");
    Thread.Sleep(4000);
    Console.Clear();
    ExibirOpcoesDoMenu();
}

void MostrarBandasRegistradas()
{
    Console.Clear();
    ExibirTituloDaOpcao("Exibindo todas as bandas registradas");
    foreach(string banda in bandasRegistradas.Keys)
    {
        Console.WriteLine($"Banda: {banda}");
    }
    Console.WriteLine("\nDigite uma tecla para voltar ao menu principal.");
    Console.ReadKey();
    Console.Clear();
    ExibirOpcoesDoMenu();
};


void ExibirTituloDaOpcao( string titulo)
{
    int quantidadeDeLetas = titulo.Length;
    string asteriscos = string.Empty.PadLeft(quantidadeDeLetas, '*');
    Console.WriteLine(asteriscos);
    Console.WriteLine(titulo);
    Console.WriteLine(asteriscos + "\n");
}

void AvaliarUmaBanda()
{
    Console.Clear();
    ExibirTituloDaOpcao("Avaliar banda");
    Console.Write("Digite o nome da banda que deseja avaliar: ");
    string nomeDaBandaEscolhida = Console.ReadLine()!;
    if (bandasRegistradas.ContainsKey(nomeDaBandaEscolhida))
    {
        Console.WriteLine($"Qual a nota que a banda {nomeDaBandaEscolhida} merece: ");
        int notaDeAvaliacaoDaBanda = int.Parse(Console.ReadLine()!);
        bandasRegistradas[nomeDaBandaEscolhida].Add(notaDeAvaliacaoDaBanda);
        Console.WriteLine($"\nA nota {notaDeAvaliacaoDaBanda} foi registrada com sucesso para a banda {nomeDaBandaEscolhida}.");
        Thread.Sleep(4000);
        Console.Clear();
        ExibirOpcoesDoMenu();
    }
    else
    {
        Console.WriteLine($"A banda { nomeDaBandaEscolhida } não foi encontrada!");
        Console.WriteLine("Digite uma tecla para voltar ao menu principal. ");
        Console.ReadKey();
        Console.Clear();
        ExibirOpcoesDoMenu();
    }

}

void CalcularMediaDeBandas()
{
    Console.Clear();
    ExibirTituloDaOpcao("Exibir média das bandas");
    Console.Write("Digite qual a banda que você deseja exibir a média de avaliaçào: ");
    string nomeDaBandaEscolhida = Console.ReadLine()!;
    if (bandasRegistradas.ContainsKey(nomeDaBandaEscolhida))
    {
        List<int> notasDaBanda = bandasRegistradas[nomeDaBandaEscolhida];
        Console.WriteLine($"\nA média da banda {nomeDaBandaEscolhida} é  {notasDaBanda.Average()}. ");
        Console.WriteLine("Digite uma tecla para voltar ao menu principal. ");
        Console.ReadKey();
        Console.Clear();
        ExibirOpcoesDoMenu();
    }
    else
    {
        Console.WriteLine($"A banda {nomeDaBandaEscolhida} que você escolheu não foi encontrada!");
        
        Console.ReadKey();
        Console.Clear();
        ExibirOpcoesDoMenu();
    }
}

ExibirOpcoesDoMenu();

