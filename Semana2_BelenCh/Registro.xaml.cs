using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace Semana2_BelenCh
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class Registro : ContentPage
    {
        public Registro()
        {
            InitializeComponent();
        }

        

        private async void btnIniciar_Clicked(object sender, EventArgs e)
        {
            string nombre = "Belen";
            string clave = "1234";

            string TNombre = txtNombre.Text;
            string TClave = txtClave.Text;

            if (nombre ==TNombre & clave == TClave)
            {
                await Navigation.PushAsync(new Page1(nombre, clave));
            }
            else
            {
                await DisplayAlert("Advertencia", "El nombre de usuario o contraseña son incorrectos","Cerrar");
            }
        }

    }
}