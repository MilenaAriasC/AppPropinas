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
            double total = double.Parse(toti.Text);
            double propina = double.Parse(propi.Text);
            double numeropersona = double.Parse(numper.Text);

        }
    }
}
