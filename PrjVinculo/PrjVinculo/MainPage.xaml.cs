namespace PrjVinculo
{
    public partial class MainPage : ContentPage
    {
        int count = 0;

        public MainPage()
        {
            InitializeComponent();
        }


        private void btnProduto_Clicked(object sender, EventArgs e)
        {
            Produto Produto = new Produto();

            Produto.Descricao = "Garrafa";
            Produto.Preco = "R$ 50,00";
            Produto.Categoria = "Garrafas";

            Navigation.PushAsync(new ProdutoPage() { BindingContext = Produto});
        }

        private void btnOuProdutos_Clicked(object sender, EventArgs e)
        {
            Navigation.PushAsync(new PagListaProfuto());
        }

    }

}
