namespace RedSocialFace.views;

public partial class Amigos : ContentPage
{
	public Amigos()
	{
		InitializeComponent();
	}
    private async void OnActionButtonClicked(object sender, EventArgs e)
    {
        var button = (Button)sender;

        // Animación de rebote
        await button.ScaleTo(1.2, 100, Easing.CubicIn);
        await button.ScaleTo(0.8, 100, Easing.CubicOut);
        await button.ScaleTo(1.0, 100, Easing.Linear);

        // Si el botón dice "Seguir", al finalizar la animación:
        if (button.Text == "Seguir")
        {
            // Cambiamos el texto a "Siguiendo"
            button.Text = "Siguiendo";

            // Cambiamos el fondo a rojo
            button.BackgroundColor = Colors.Red;

            // Mantenemos el texto en blanco para que se lea bien
            button.TextColor = Colors.White;
        }
        else if (button.Text == "Mensaje")
        {
            await Shell.Current.GoToAsync("//Chat1Page");
        }
    }
}