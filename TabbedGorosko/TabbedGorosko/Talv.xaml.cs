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
    public partial class Talv : TabbedPage
    {
        public Talv()
        {
            InitializeComponent();
        }
        private async void Button_Clicked3(object sender, EventArgs e)
        {
            await DisplayAlert("Pea pidu", "Detsembri peamine püha on 31. detsember Uus aasta", "välja");
        }
        private async void Button_Clicked4(object sender, EventArgs e)
        {
            await DisplayAlert("Pea pidu", "Oktoobri peamine püha on 17. oktoober (oktoobri kolmas laupäev) - soome-ugri rahvaste päev", "välja");
        }
        private async void Button_Clicked5(object sender, EventArgs e)
        {
            await DisplayAlert("Pea pidu", "Oktoobri peamine püha on 24. veebruar - iseseisvuspäev, Eesti Vabariigi aastapäev", "välja");
        }

    }
}