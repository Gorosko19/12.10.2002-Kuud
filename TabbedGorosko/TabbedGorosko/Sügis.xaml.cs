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
    public partial class Sügis : TabbedPage
    {
        public Sügis()
        {
            InitializeComponent();
        }

        private async void Button_Clicked(object sender, EventArgs e)
        {
            await DisplayAlert("Pea pidu", "Septembri peamine püha on 1. september teadmistepäev", "välja");
        }
        private async void Button_Clicked1(object sender, EventArgs e)
        {
            await DisplayAlert("Pea pidu", "Oktoobri peamine püha on 5. oktoober õpetaja päev", "välja");
        }
        private async void Button_Clicked2(object sender, EventArgs e)
        {
            await DisplayAlert("Pea pidu", "Novembri peamine püha on 8. Isadepäev Eestis", "välja");
        }
    }
}