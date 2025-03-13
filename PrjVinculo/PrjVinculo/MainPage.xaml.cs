namespace PrjVinculo
{
    public partial class MainPage : ContentPage
    {
        int count = 0;

        public MainPage()
        {
            InitializeComponent();
        }

        private void OnCounterClicked(object sender, EventArgs e)
        {
            count++;

            if (count == 1)
                CounterBtn.Text = $"Clicked {count} time";
            else
                CounterBtn.Text = $"Clicked {count} times";

            SemanticScreenReader.Announce(CounterBtn.Text);
        }

        private void btnProduto_Clicked(object sender, EventArgs e)
        {
            Produto Produto = new Produto();

            Produto.Descricao = "Garrafa";
            Produto.Preco = "R$ 50,00";
            Produto.Categoria = "Garrafas";

            Navigation.PushAsync(new ProdutoPage() { BindingContext = Produto});
        }
    }

}
