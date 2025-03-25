using RedSocialFace.views;

namespace RedSocialFace
{
    public partial class AppShell : Shell
    {
        public AppShell()
        {
            InitializeComponent();

            // Registrar la ruta para la navegación
            // Usa "Principio" como ruta y typeof(Principio) como la clase que herede de ContentPage
            Routing.RegisterRoute("Principio", typeof(Principio));
        }
    }
}

