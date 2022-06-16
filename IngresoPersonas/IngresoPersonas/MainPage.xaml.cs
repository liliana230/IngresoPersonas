using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;

namespace IngresoPersonas
{
    public partial class MainPage : ContentPage
    {
        public MainPage()
        {
            InitializeComponent();
        }

        private async void btnenviar_Clicked(object sender, EventArgs e)
        {
            var person = new Ingreso.Personas
            {
                nombre = txtnombre.Text,
                apellido = txtapellidos.Text,
                edad = txtedad.Text,
                correo = txtcorreo.Text
            };

            await Navigation.PushAsync(new Recibido(txtnombre.Text, txtapellidos.Text, txtedad.Text, txtcorreo.Text));
        }
    }
    
}
