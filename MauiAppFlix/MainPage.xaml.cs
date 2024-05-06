using MauiAppFlix.Categorias;

namespace MauiAppFlix
{
    public partial class MainPage : ContentPage
    {
        public MainPage()
        {
            InitializeComponent();
        }        

        private void Button_Clicked(object sender, EventArgs e)
        {
            try
            {
                Navigation.PushAsync(new Aventura());

            }
            catch (Exception ex)
            {
                DisplayAlert("Ops", ex.Message, "OK");
            }
        }
    }

}
