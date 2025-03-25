using Microsoft.Maui.Controls;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.DependencyInjection; // Necesario para CreateScope()
using RedSocialFace.DaraAcces;

namespace RedSocialFace.views
{
    public partial class MainPage : ContentPage
    {
        public MainPage()
        {
            InitializeComponent();
        }

        protected override void OnAppearing()
        {
            base.OnAppearing();
            Shell.SetNavBarIsVisible(this, false);
            Shell.SetFlyoutBehavior(this, FlyoutBehavior.Disabled);
            Shell.SetTabBarIsVisible(this, false);
        }

        private async void OnLoginButtonClicked(object sender, EventArgs e)
        {
            // Animaciones del botón (opcional)
            var button = (Button)sender;
            Color originalColor = button.BackgroundColor;
            button.BackgroundColor = Colors.LightGray;
            await button.FadeTo(0.3, 100);
            await button.ScaleTo(1.1, 100, Easing.Linear);
            await button.FadeTo(1, 100);
            await button.ScaleTo(1, 100, Easing.Linear);
            button.BackgroundColor = originalColor;
            await button.RotateTo(1080, 300, Easing.Linear);
            button.Rotation = 0;
            for (int i = 0; i < 3; i++)
            {
                await button.RotateTo(360, 300, Easing.Linear);
                button.Rotation = 0;
            }

            // Obtenemos las credenciales que ingresó el usuario
            string username = UsernameEntry.Text;  // Gmail
            string password = PasswordEntry.Text;  // Contraseña

            // Creamos un scope para usar el DbContext
            using (var scope = App.Services.CreateScope())
            {
                var dbContext = scope.ServiceProvider.GetRequiredService<AppDbContext>();

                // Buscamos un usuario que coincida con los datos ingresados
                var user = await dbContext.Usuarios
                    .FirstOrDefaultAsync(u => u.gmail == username && u.contraseña == password);

                if (user != null)
                {
                    // Credenciales correctas
                    await DisplayAlert("Inicio exitoso", "¡Bienvenido!", "OK");

                    // Aquí navegas a la siguiente página (ej. PrincipioPage)
                    await Shell.Current.GoToAsync("//PrincipioPage");

                }
                else
                {
                    // Credenciales inválidas
                    await DisplayAlert("Incorrecto", "Usuario o contraseña incorrectos", "OK");
                }
            }
        }
    }
}
