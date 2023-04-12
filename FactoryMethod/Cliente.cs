namespace FactoryMethod
{
    // Classe que usa a fábrica para criar produtos.
    public class Cliente
    {
        private IFabrica _fabrica;

        public Cliente(IFabrica fabrica)
        {
            _fabrica = fabrica;
        }

        public void ExecutarOperacao()
        {
            // Usa a fábrica para criar um produto e chama sua operação.
            ProdutoAbstract produto = _fabrica.CriarProduto();
            produto.Operacao();
        }
    }
}
