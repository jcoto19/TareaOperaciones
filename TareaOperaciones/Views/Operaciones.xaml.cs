using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace TareaOperaciones.Views
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class Operaciones : ContentPage
    {
        private double resultado;
        public Operaciones()
        {
            InitializeComponent();
        }

        private async void btnMostrar_Clicked(object sender, EventArgs e)
        {
            await DisplayAlert("Bienvendios","Operaciones", "Ok");
        }

        private void Button_Clicked(object sender, EventArgs e)
        {

        }

        private async void Suma(object sender, EventArgs e)
        {

            await DisplayAlert("","Datos Guardados", "Continuar");

            resultado = double.Parse(numero1.Text) + double.Parse(numero2.Text);
            var Op = new Models.OperacionesClass
            {
                numero1 = resultado,
            };

            var page = new Views.Resultado();
            page.BindingContext = Op;
            await Navigation.PushAsync(page);

        }

        private async void resta(object sender, EventArgs e)
        {
            await DisplayAlert("", "Datos Guardados", "Continuar");

            resultado = double.Parse(numero1.Text) - double.Parse(numero2.Text);

            var Op = new Models.OperacionesClass
            {
                numero1 = resultado,
            };

            var page = new Views.Resultado();
            page.BindingContext = Op;
            await Navigation.PushAsync(page);
        }

        private async void multiplicacion(object sender, EventArgs e)
        {
            await DisplayAlert("", "Datos Guardados", "Continuar");

            resultado = double.Parse(numero1.Text) * double.Parse(numero2.Text);

            var Op = new Models.OperacionesClass
            {
                numero1 = resultado,
            };

            var page = new Views.Resultado();
            page.BindingContext = Op;
            await Navigation.PushAsync(page);
        }

        private async void division(object sender, EventArgs e)
        {
            await DisplayAlert("", "Datos Guardados", "Continuar");

            resultado = double.Parse(numero1.Text) / double.Parse(numero2.Text);

            var Op = new Models.OperacionesClass
            {
                numero1 = resultado,
            };

            var page = new Views.Resultado();
            page.BindingContext = Op;
            await Navigation.PushAsync(page);
        }

        
    }
}