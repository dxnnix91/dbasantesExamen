using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace dbasantesExamen
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class Registro : ContentPage
    {
        public Registro( string usuario)
        {
            InitializeComponent();
            lblUsuario.Text = usuario;
        }

        double pagoTotal = 0;
        private void pPaises_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void pCiudades_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void txtMontoIncial_TextChanged(object sender, TextChangedEventArgs e)
        {
            try
            {
                double montoInicial = Convert.ToDouble(txtMontoIncial.Text);
                if (montoInicial > 1500 || montoInicial < 0 )
                {
                    DisplayAlert("Alerta", "Dato fuera de rango", "Cerrar");
                    txtMontoIncial.Text = "";
                }
            }
            catch (Exception)
            {


            }
        }

        private void btnCalcular_Clicked(object sender, EventArgs e)
        {
            double valorSemestre = 1500;
            double montoInicial = Convert.ToDouble(txtMontoIncial.Text);

            double cuotaMensual = ((valorSemestre - montoInicial) + montoInicial * 0.04)/4;
            txtPagoMensual.Text = cuotaMensual.ToString();
            pagoTotal = montoInicial + cuotaMensual * 4;
        }

        private void btnResumen_Clicked(object sender, EventArgs e)
        {
            string usuario = lblUsuario.Text;
            string nombre = txtNombre.Text;
            string apellido = txtApellido.Text;
            string edad = txtEdad.Text;
            string fecha = pFecha.Date.ToString();
            string pais = pPaises.Items[pPaises.SelectedIndex].ToString();
            string ciudad = pCiudades.Items[pCiudades.SelectedIndex].ToString();
            string montoInicial = txtMontoIncial.Text;
            string pagoMensual = txtPagoMensual.Text;
            string total = pagoTotal.ToString();
            Navigation.PushAsync(new Resumen(usuario, nombre, apellido, edad, fecha, pais, ciudad, montoInicial, pagoMensual, total));
        }
    }
}