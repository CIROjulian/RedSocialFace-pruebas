using Microsoft.Maui.Controls;

namespace RedSocialFace.views
{
    public partial class chat1 : ContentPage
    {
        public chat1()
        {
            InitializeComponent();

            // mensaje puesto predefinido
            AgregarMensajeAmigo("¡Hola! Soy tu amigo.");
        }

        // metodo que se ajecuta al pulsar enviar
        private void AlEnviarClicado(object sender, EventArgs e)
        {
            string texto = EntradaMensaje.Text;
            if (!string.IsNullOrWhiteSpace(texto))
            {
                // se agrega nuestro mensaje a la derecha
                AgregarMiMensaje(texto);
                EntradaMensaje.Text = string.Empty;

            //Opcional: respuesta del mi amigo simulada
                 AgregarMensajeAmigo("¡Genial! ¿Qué tal tu día?");
            }
        }
        private void AgregarMiMensaje(string texto)
        {
            // Grid son dos columnas mensajes y fotos
            var contenedor = new Grid
            {
                ColumnDefinitions =
                {
                    new ColumnDefinition { Width = GridLength.Star }, // Mensaje
                    new ColumnDefinition { Width = GridLength.Auto }   // Foto
                },
                Margin = new Thickness(0, 0, 0, 10)
            };

            // burbuja de mensaje fondo azul
            var burbujaMensaje = new Frame
            {
                BackgroundColor = Color.FromArgb("#1877F2"),
                Padding = 10,
                CornerRadius = 10,
                HasShadow = false,
                HorizontalOptions = LayoutOptions.End,
                Content = new Label
                {
                    Text = texto,
                    TextColor = Colors.White,
                    FontSize = 16
                }
            };
            var fotoMia = new Frame
            {
                WidthRequest = 40,
                HeightRequest = 40,
                CornerRadius = 20,
                Padding = 0,
                IsClippedToBounds = true,
                HorizontalOptions = LayoutOptions.End,
                Content = new Image
                {
                    Source = "messi1.png",
                    Aspect = Aspect.AspectFill
                }
            };

            // agrego al Grid: Mensaje en la columna 0, Foto en la columna 1
            contenedor.Add(burbujaMensaje, 0, 0);
            contenedor.Add(fotoMia, 1, 0);

            // Se agrega el contenedor al VerticalStackLayout
            ContenedorMensajes.Children.Add(contenedor);
        }

        private void AgregarMensajeAmigo(string texto)
        {
            var contenedor = new Grid
            {
                ColumnDefinitions =
                {
                    new ColumnDefinition { Width = GridLength.Auto }, // Foto
                    new ColumnDefinition { Width = GridLength.Star }   // Mensaje
                },
                Margin = new Thickness(0, 0, 0, 10)
            };
            var fotoAmigo = new Frame
            {
                WidthRequest = 40,
                HeightRequest = 40,
                CornerRadius = 20,
                Padding = 0,
                IsClippedToBounds = true,
                HorizontalOptions = LayoutOptions.Start,
                Content = new Image
                {
                    Source = "auron3.png",
                    Aspect = Aspect.AspectFill
                }
            };

            var burbujaMensaje = new Frame
            {
                BackgroundColor = Colors.LightGray,
                Padding = 10,
                CornerRadius = 10,
                HasShadow = false,
                HorizontalOptions = LayoutOptions.Start,
                Content = new Label
                {
                    Text = texto,
                    TextColor = Colors.Black,
                    FontSize = 16
                }
            };
            contenedor.Add(fotoAmigo, 0, 0);
            contenedor.Add(burbujaMensaje, 1, 0);
            ContenedorMensajes.Children.Add(contenedor);
        }
    }
}