namespace FactoryMethod
{
    // Definimos várias classes que herdam da classe Produto e implementam suas próprias operações.
    public class ProdutoA : ProdutoAbstract
    {
        public override void Operacao()
        {
            Console.WriteLine("ProdutoA: Operação específica do ProdutoA.");
        }
    }
}
