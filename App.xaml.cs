using Microsoft.Maui.Controls;
using Microsoft.Maui;
using Microsoft.Maui.Hosting;

namespace RedSocialFace
{
    public partial class App : Application
    {
        // Esta propiedad devuelve la instancia actual de la App
        public static new App Current => (App)Application.Current;

        // Esta propiedad expone el ServiceProvider de .NET MAUI
        public static IServiceProvider Services =>
            Current.Handler?.MauiContext?.Services;

        public App()
        {
            InitializeComponent();

            // Define tu página inicial (por ejemplo, AppShell)
            MainPage = new AppShell();
        }
    }
}
