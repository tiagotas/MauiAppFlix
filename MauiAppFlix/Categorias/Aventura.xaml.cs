namespace MauiAppFlix.Categorias;

public partial class Aventura : ContentPage
{
	public Aventura()
	{
		InitializeComponent();
	}

    private void btnDuna_Clicked(object sender, EventArgs e)
    {
        try
        {
            Navigation.PushAsync(new Filmes.Duna());

        }
        catch (Exception ex)
        {
            DisplayAlert("Ops", ex.Message, "OK");
        }
    }
}