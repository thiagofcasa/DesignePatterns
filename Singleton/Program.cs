//O padrão de projeto Singleton funciona de maneira semelhante. Ele garante que apenas uma 
//    instância (ou cópia) de uma determinada classe exista em um programa de computador. 
//Isso significa que, não importa quantas vezes você tente criar uma nova instância dessa 
//    classe, sempre haverá apenas uma instância dela.

//imagine que você esteja criando um jogo e deseje garantir que apenas um jogador possa 
//    existir em um determinado momento. Você pode usar o padrão de projeto Singleton para 
//    garantir que apenas uma instância da classe Jogador exista em seu jogo.

Run();

static void Run()
{
    // Obtemos a única instância da classe Singleton usando o método GetInstance().
    Singleton singleton1 = Singleton.GetInstance();
    Singleton singleton2 = Singleton.GetInstance();

    // Verificamos se ambas as variáveis apontam para a mesma instância da classe Singleton.
    if (singleton1 == singleton2)
    {
        Console.WriteLine("singleton1 e singleton2 são a mesma instância de Singleton.");
    }
    else
    {
        Console.WriteLine("singleton1 e singleton2 são instâncias diferentes de Singleton.");
    }

    Console.ReadKey();
}

public class Singleton
{
    // Criamos uma variável estática privada que armazenará a única instância da classe Singleton.
    private static Singleton _instance;

    // Criamos um construtor privado para que a classe não possa ser instanciada diretamente.
    private Singleton() { }

    // Criamos um método estático público que retornará a única instância da classe Singleton.
    public static Singleton GetInstance()
    {
        // Verificamos se a instância já foi criada.
        if (_instance == null)
        {
            // Se a instância ainda não foi criada, criamos uma nova instância.
            _instance = new Singleton();
        }

        // Retornamos a única instância da classe Singleton.
        return _instance;
    }
}
