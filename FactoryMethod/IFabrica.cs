namespace FactoryMethod
{
    // Definimos uma interface para criar objetos do tipo Produto.
    public interface IFabrica
    {
        ProdutoAbstract CriarProduto();
    }

}
