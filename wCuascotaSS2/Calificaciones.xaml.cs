using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.PlatformConfiguration.AndroidSpecific;
using Xamarin.Forms.Xaml;

namespace wCuascotaSS2
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class Calificaciones : ContentPage
    {
        public Calificaciones(string estudiante)
        {
            InitializeComponent();
            lblUsuario.Text = "Usuario: "+estudiante;
        }

        private void btnCalcular_Clicked(object sender, EventArgs e)
        {
            double n1,n2,e1,e2,p1,p2,nf;
            if (!string.IsNullOrEmpty(txtSeguimiento1.Text) && !string.IsNullOrEmpty(txtSeguimiento2.Text) && !string.IsNullOrEmpty(txtExamen1.Text) && !string.IsNullOrEmpty(txtExamen2.Text))
            {
                n1 = Convert.ToDouble(txtSeguimiento1.Text) * 0.3;
                e1 = Convert.ToDouble(txtExamen1.Text) * 0.2;
                p1 = Math.Truncate((n1 + e1)*100)/100;
                lblParcial1.Text = Convert.ToString(p1);
                n2 = Convert.ToDouble(txtSeguimiento2.Text) * 0.3;
                e2 = Convert.ToDouble(txtExamen2.Text) * 0.2;
                p2 = Math.Truncate((n2 + e2)*100)/100;
                lblParcial2.Text = Convert.ToString(p2);
                nf = Math.Truncate((p1 + p2)*100)/100;
                lblNotaFinal.Text = Convert.ToString(nf);
                if (nf >= 7)
                {
                    lblEstado.Text = "Aprobado";
                    lblEstado.TextColor= Color.Green;
                    lblNotaFinal.TextColor= Color.Green;
                }
                if (nf >= 5 && nf <= 6.99)
                {
                    lblEstado.Text = "Complementario";
                    lblEstado.TextColor= Color.Orange;
                    lblNotaFinal.TextColor = Color.Orange;
                }
                if (nf <= 4.99)
                {
                    lblEstado.Text = "Reprobado";
                    lblEstado.TextColor= Color.Red;
                    lblNotaFinal.TextColor=Color.Red;
                }
            }
            else 
            {
                DisplayAlert("Mensaje", "Ingrese todas las notas", "Aceptar");
            }
        }
        private void btnLimpiar_Clicked(object sender, EventArgs e)
        {
            Limpiador.LimpiarTodo(this);
            lblParcial1.Text = "";
            lblParcial2.Text = "";
            lblNotaFinal.Text = "";
            lblEstado.Text = "";
        }
        private void txtSeguimiento1_Unfocused(object sender, FocusEventArgs e)
        {
            if (!string.IsNullOrWhiteSpace(txtSeguimiento1.Text))
            {
                if (!Validacion.ValidacionNumerica(txtSeguimiento1.Text))
                {
                    txtSeguimiento1.Text = "";
                    DisplayAlert("Error", "El valor debe estar entre 0.1 y 10", "Aceptar");
                }
            }
        }
        private void txtExamen1_Unfocused(object sender, FocusEventArgs e)
        {
            if (!string.IsNullOrWhiteSpace(txtExamen1.Text))
            {
                if (!Validacion.ValidacionNumerica(txtExamen1.Text))
                {
                    txtExamen1.Text = "";
                    DisplayAlert("Error", "El valor debe estar entre 0.1 y 10", "Aceptar");
                }
            }
        }
        private void txtSeguimiento2_Unfocused(object sender, FocusEventArgs e)
        {
            if (!string.IsNullOrWhiteSpace(txtSeguimiento2.Text))
            {
                if (!Validacion.ValidacionNumerica(txtSeguimiento2.Text))
                {
                    txtSeguimiento2.Text = "";
                    DisplayAlert("Error", "El valor debe estar entre 0.1 y 10", "Aceptar");
                }
            }
        }
        private void txtExamen2_Unfocused(object sender, FocusEventArgs e)
        {
            if (!string.IsNullOrWhiteSpace(txtExamen2.Text))
            {
                if (!Validacion.ValidacionNumerica(txtExamen2.Text))
                {
                    txtExamen2.Text = "";
                    DisplayAlert("Error", "El valor debe estar entre 0.1 y 10", "Aceptar");
                }
            }
        }
    }
}