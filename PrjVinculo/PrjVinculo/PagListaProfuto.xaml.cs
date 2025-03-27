namespace PrjVinculo;

public partial class PagListaProfuto : ContentPage
{
	public PagListaProfuto()
	{
		InitializeComponent();
		List<Produto> lista = new List<Produto>();

		lista.Add(
			new Produto()
			{
				Categoria = "Informática",
				Descricao = "Teclado",
				Preco = "R$ 500"
			});

		lista.Add(
			new Produto()
			{
				Categoria = "Musica",
				Descricao = "Mesa de som",
				Preco = "R$ 1,500"
			});

        lista.Add(
            new Produto()
            {
                Categoria = "Musica",
                Descricao = "Fone de Ouvido",
                Preco = "R$ 200"
            });

		lstProduto.ItemsSource = lista;

    }

    private void ViewCell_Tapped(object sender, EventArgs e)
    {
		var context = (sender as ViewCell).BindingContext;

        Navigation.PushAsync(new ProdutoPage() { BindingContext = context });

    }
}