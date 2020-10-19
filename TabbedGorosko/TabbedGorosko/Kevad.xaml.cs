using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace TabbedGorosko
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class Kevad : TabbedPage
    {
        public Kevad()
        {
            InitializeComponent();
        }
        private async void Button_Clicked9(object sender, EventArgs e)
        {
            await DisplayAlert("Pea pidu", "Märts peamine püha on 14. märts - emakeelepäev", "välja");
        }
        private async void Button_Clicked10(object sender, EventArgs e)
        {
            await DisplayAlert("Pea pidu", "Aprill peamine püha on 10. aprill - suur reede", "välja");
        }
        private async void Button_Clicked11(object sender, EventArgs e)
        {
            await DisplayAlert("Pea pidu", "Mai peamine püha on 1. mai - kevadpäev", "välja");
        }
    }
}