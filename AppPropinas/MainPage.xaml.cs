using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;

namespace AppPropinas
{
    public partial class MainPage : ContentPage
    {
        public MainPage()
        {
            InitializeComponent();
            btncalcu.Clicked += btnClicked;
        }

      private void btnClicked(Object sender, EventArgs e)
        {
            /* Convertir  a numero el total, propina, numero de personas*/
            double total = double.Parse(toti.Text);
            double propina = double.Parse(propi.Text);
            double numeropersona = double.Parse(numper.Text);
            /* Se genera las operaciones previas */

            double respropina = (total* propina) /100;
            double restotal = respropina + total;
            double rtapropinapersona = respropina/numeropersona;
            double restotpersona = restotal / numeropersona;

            txtpropina.Detail = propina.ToString("C");
            txttotal.Detail = restotal.ToString("C");
            txtpropersona.Detail = rtapropinapersona.ToString("C");
            txttotalpersona.Detail = restotpersona.ToString("C");




        }
    }
}
