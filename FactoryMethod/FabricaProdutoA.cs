namespace FactoryMethod
{
    // Definimos várias classes que implementam a interface IFabrica e criam diferentes tipos de produtos.
    public class FabricaProdutoA : IFabrica
    {
        public ProdutoAbstract CriarProduto()
        {
            return new ProdutoA();
        }
    }
}
