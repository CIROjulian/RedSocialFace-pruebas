using Microsoft.Maui.Controls;
using System.Collections.ObjectModel;
using System.Linq;

namespace RedSocialFace.views
{
    public partial class AñadirAmigos : ContentPage
    {
        // lista de perfiles
        public ObservableCollection<AmigoModel> ListaAmigos { get; set; }
        private ObservableCollection<AmigoModel> _amigosOriginal;

        public AñadirAmigos()
        {
            InitializeComponent();

            // perfiles
            ListaAmigos = new ObservableCollection<AmigoModel>
            {
                new AmigoModel { FotoPerfil="auron2.png", Nombre="AuronPlay", Ubicacion="Barcelona, España" },
                new AmigoModel { FotoPerfil="ibai1.png", Nombre="Ibai Llanos", Ubicacion="Bilbao, España" },
                new AmigoModel { FotoPerfil="pique1.png", Nombre="Pique", Ubicacion="Barcelona, España" },
                new AmigoModel { FotoPerfil="perxita2.png", Nombre="Perxitaa", Ubicacion="Sevilla, España" },
                new AmigoModel { FotoPerfil="kun1.png", Nombre="Kun Agüero", Ubicacion="Buenos Aires, Argentina" },
            };

            // se guarda
            _amigosOriginal = new ObservableCollection<AmigoModel>(ListaAmigos);

            BindingContext = this;
        }

        // se cambia y se modifica el estado del boton
        private void OnSearchTextChanged(object sender, TextChangedEventArgs e)
        {
            var textoBusqueda = e.NewTextValue?.ToLower() ?? string.Empty;

            // Filtramos la lista
            var filtrados = _amigosOriginal
                .Where(a => a.Nombre.ToLower().Contains(textoBusqueda)
                         || a.Ubicacion.ToLower().Contains(textoBusqueda))
                .ToList();

            // se actualiza la lista de amigos
            ListaAmigos.Clear();
            foreach (var amigo in filtrados)
                ListaAmigos.Add(amigo);
        }


        private async void OnAgregarClicked(object sender, EventArgs e)
        {
            var boton = (Button)sender;

            await boton.ScaleTo(1.2, 100, Easing.CubicIn);
            await boton.ScaleTo(0.8, 100, Easing.CubicOut);
            await boton.ScaleTo(1.0, 100, Easing.Linear);

            var amigo = (AmigoModel)boton.BindingContext;
            boton.Text = "Enviado";
            boton.IsEnabled = false;

            await DisplayAlert("Solicitud de amistad", $"Has enviado una solicitud a {amigo.Nombre}.", "OK");
        }

    }
    public class AmigoModel
    {
        public string FotoPerfil { get; set; }
        public string Nombre { get; set; }
        public string Ubicacion { get; set; }
    }
}