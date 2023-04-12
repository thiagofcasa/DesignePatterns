namespace FactoryMethod
{
    public class FabricaProdutoB : IFabrica
    {
        public ProdutoAbstract CriarProduto()
        {
            return new ProdutoB();
        }
    }
}
