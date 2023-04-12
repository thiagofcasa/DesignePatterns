//O padrão de projeto Factory Method é usado quando você precisa criar objetos de uma classe,
//    mas não sabe exatamente qual objeto você precisa criar ou como criar esse objeto. 
//    Em vez de criar cada objeto individualmente, você cria uma fábrica de objetos que
//    produzirá diferentes tipos de objetos com diferentes características.

//imagine que você esteja criando um jogo de computador e precise criar diferentes tipos de
//    personagens. Cada personagem terá habilidades e atributos diferentes, como força, 
//    velocidade e inteligência. Em vez de criar cada personagem individualmente, você pode 
//    criar uma fábrica de personagens que produzirá diferentes tipos de personagens com 
//    diferentes habilidades e atributos.

using FactoryMethod;

Run();

static void Run()
{
    // Cria uma instância da fábrica de ProdutoA e usa-a para criar um ProdutoA.
    IFabrica fabricaProdutoA = new FabricaProdutoA();
    Cliente clienteProdutoA = new Cliente(fabricaProdutoA);
    clienteProdutoA.ExecutarOperacao();

    // Cria uma instância da fábrica de ProdutoB e usa-a para criar um ProdutoB.
    IFabrica fabricaProdutoB = new FabricaProdutoB();
    Cliente clienteProdutoB = new Cliente(fabricaProdutoB);
    clienteProdutoB.ExecutarOperacao();

    Console.ReadKey();
}