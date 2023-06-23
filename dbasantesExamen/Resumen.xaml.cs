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
    public partial class Resumen : ContentPage
    {
        public Resumen(string usuario, string nombre, string apellido, string edad, string fecha, string pais, string ciudad, string montoInicial, string  pagoMensual, string total)
        {
            InitializeComponent();
            lblUsuario.Text = usuario;
            txtNombre.Text = nombre;
            txtApellido.Text = apellido;
            txtEdad.Text = edad;
            txtFecha.Text = fecha;
            txtPais.Text = pais;
            txtCiudad.Text = ciudad;
            txtMontoInicial.Text = montoInicial;
            txtPagoMensual.Text = pagoMensual;
            txtPagoTotal.Text = total;
        }

        private void btnSalir_Clicked(object sender, EventArgs e)
        {
            
        }
    }
}