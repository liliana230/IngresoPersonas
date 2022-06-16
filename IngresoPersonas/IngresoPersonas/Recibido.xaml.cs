using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace IngresoPersonas
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class Recibido : ContentPage
    {
        public Recibido(String nombre, string apellido, string edad, string correo)
        {
            InitializeComponent();

            lbnombre.Text = nombre;
            lbapellido.Text = apellido;
            lbedad.Text = edad;
            lbcorreo.Text = correo;
        }
    }
}