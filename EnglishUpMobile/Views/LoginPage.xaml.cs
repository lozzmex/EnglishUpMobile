
namespace EnglishUpMobile.Views;

public partial class LoginPage : ContentPage
{
    public LoginPage()
    {
        InitializeComponent();
    }

    private async void IniciarSesion_Clicked(
        object sender, EventArgs e)
    {
        await DisplayAlert(
            "EnglishUp",
            "Bienvenido a EnglishUp Mobile",
            "Aceptar");
    }
}
