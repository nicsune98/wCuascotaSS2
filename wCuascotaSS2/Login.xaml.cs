using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace wCuascotaSS2
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class Login : ContentPage
    {
        public Login()
        {
            InitializeComponent();
        }

        private void btIngreso_Clicked(object sender, EventArgs e)
        {
            if (txtUsuario.Text=="wcuascota" && txtContraseña.Text=="12345")
            {
                Navigation.PushAsync(new Calificaciones());
                txtUsuario.Text = "";
                txtContraseña.Text = "";
            }
            else 
            {
                DisplayAlert("Error","Usuario o Contraseña incorrectos","Aceptar");
                txtUsuario.Text = "";
                txtContraseña.Text = "";
            }
        }
    }
}