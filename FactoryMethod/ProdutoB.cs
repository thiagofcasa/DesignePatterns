namespace FactoryMethod
{
    public class ProdutoB : ProdutoAbstract
    {
        public override void Operacao()
        {
            Console.WriteLine("ProdutoB: Operação específica do ProdutoB.");
        }
    }
}
