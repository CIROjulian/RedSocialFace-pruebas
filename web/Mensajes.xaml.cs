using Microsoft.Maui.Controls;
using System.Collections.ObjectModel;

namespace RedSocialFace.views
{
    public partial class Mensajes : ContentPage
    {
        // Colección de conversaciones para enlazar a la CollectionView
        public ObservableCollection<Conversacion> ListaConversaciones { get; set; }

        public Mensajes()
        {
            InitializeComponent();

            // Simulación de datos
            ListaConversaciones = new ObservableCollection<Conversacion>
            {
                new Conversacion
                {
                    FotoPerfil="auron3.png",
                    NombreContacto="auron Play",
                    UltimoMensaje="payasoooo",
                    HoraUltimoMensaje="09:30"
                },
                new Conversacion
                {
                    FotoPerfil="perxita3.png",
                    NombreContacto="Perxita",
                    UltimoMensaje="pateas un penalti de la kings",
                    HoraUltimoMensaje="Ayer"
                },
                new Conversacion
                {
                    FotoPerfil="kun3.png",
                    NombreContacto="Kun Aguero",
                    UltimoMensaje="vamo a juga pa",
                    HoraUltimoMensaje="10:15"
                },
                // Agrega más contactos según desees
                new Conversacion
                {
                    FotoPerfil="ibai1.png",
                    NombreContacto="Ibai",
                    UltimoMensaje="bienes a la belada?",
                    HoraUltimoMensaje="10:15"
                },
            };

            BindingContext = this;
        }
    }

    // Modelo simple para representar cada conversación
    public class Conversacion
    {
        public string FotoPerfil { get; set; }
        public string NombreContacto { get; set; }
        public string UltimoMensaje { get; set; }
        public string HoraUltimoMensaje { get; set; }
    }
}
