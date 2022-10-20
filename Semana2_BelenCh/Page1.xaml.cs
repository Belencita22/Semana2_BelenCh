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
    public partial class Page1 : ContentPage
    {
        public Page1()
        {
            InitializeComponent();
        }

        public Page1(string nombre, string clave)
        {
            InitializeComponent();
            lblUsuario.Text = nombre;
            lblPass.Text = clave;
        }

        private void BtnCalcular_Clicked(object sender, EventArgs e)
        {
            double notaP1 = Convert.ToDouble(TxtNota1.Text);
            double examenP1 = Convert.ToDouble(TxtExamen1.Text);
            double parcial = (notaP1 * 0.3) + (examenP1 * 0.2);
            txtParcial1.Text = parcial.ToString();
        }

        private void BtnCalcular2_Clicked(object sender, EventArgs e)
        {
            double notaP2 = Convert.ToDouble(txtNota2.Text);
            double examenP2 = Convert.ToDouble(TxtExamen2.Text);
            double parcial2 = (notaP2 * 0.3) + (examenP2 * 0.2);
            txtParcial2.Text = parcial2.ToString();

        }

        private void btnPromedio_Clicked(object sender, EventArgs e)
        {
            double suma1 = Convert.ToDouble(txtParcial1.Text);
            double suma2 = Convert.ToDouble(txtParcial2.Text);
            double total = (suma1 + suma2);
            txtTotal.Text = total.ToString();

            string estadoA = "APROBADO";
            string estadoB = "COMPLEMENTARIO";
            string estadoC = "REPROBADO";

            if (total >= 7)
            {
                txtEstado.Text = estadoA.ToString();
            }
            else
            if (total >= 5 && total <= 6.9)
            {
                txtEstado.Text = estadoB.ToString();
            }
            else
            {
                txtEstado.Text = estadoC.ToString();
            }

        }

        private void TxtNota1_TextChanged(object sender, TextChangedEventArgs e)
        {
            if (Convert.ToDouble(TxtNota1.Text)>10)
            {
                DisplayAlert("Advertencia","Solo puede ingresar notas de 1 a 10","Cerrar");
            }
        }

        private void txtNota2_TextChanged(object sender, TextChangedEventArgs e)
        {
            if (Convert.ToDouble(txtNota2.Text) > 10)
            {
                DisplayAlert("Advertencia", "Solo puede ingresar notas de 1 a 10", "Cerrar");
            }
        }

        private void TxtExamen1_TextChanged(object sender, TextChangedEventArgs e)
        {
            if (Convert.ToDouble(TxtExamen1.Text) > 10)
            {
                DisplayAlert("Advertencia", "Solo puede ingresar notas de 1 a 10", "Cerrar");
            }
        }

        private void TxtExamen2_TextChanged(object sender, TextChangedEventArgs e)
        {
            if (Convert.ToDouble(TxtExamen2.Text) > 10)
            {
                DisplayAlert("Advertencia", "Solo puede ingresar notas de 1 a 10", "Cerrar");
            }
        }
    }
}