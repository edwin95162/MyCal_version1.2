using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;

namespace MY_CALC_1_2
{
    public partial class MainPage : ContentPage
    {
        public MainPage()
        {
            InitializeComponent();
            Seleccionar_operacion.Items.Add("suma");
            Seleccionar_operacion.Items.Add("resta");
            Seleccionar_operacion.Items.Add("division");
            Seleccionar_operacion.Items.Add("multiplicacion");

        }

        private void OpcionOperacion(object sender, EventArgs e)
        {
            String OPCION = Seleccionar_operacion.SelectedItem.ToString();
            var numero1 = double.Parse(num1.Text);
            var numero2 = double.Parse(num2.Text);
            double resultado2 = 0;

            if (OPCION == "suma")
            {
                resultado2 = numero1 + numero2;
            }
            else if (OPCION == "resta")
            {
                resultado2 = numero1 - numero2;
            }
            else if (OPCION == "division")
            {
                resultado2 = numero1 / numero2;
            }
            else if (OPCION == "multiplicacion")
            {
                resultado2 = numero1 * numero2;
            }

            resultado.Text = "El resultado es: " + resultado2;

        }
    }
}
