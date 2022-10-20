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
    public partial class Login1 : ContentPage
    {
        public Login1()
        {
            InitializeComponent();
        }

        private async void btnIniciar_Clicked(object sender, EventArgs e)
        {
            await Navigation.PushAsync(new Page1(txtUsuario.Text,txtContrasena.Text));
        }
    }
}