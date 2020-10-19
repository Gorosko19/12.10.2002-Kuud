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
    public partial class Suvi : TabbedPage
    {
        public Suvi()
        {
            InitializeComponent();
        }
        private async void Button_Clicked6(object sender, EventArgs e)
        {
            await DisplayAlert("Pea pidu", "Juuni peamine püha on 23. juuni - võidupüha", "välja");
        }
        private async void Button_Clicked7(object sender, EventArgs e)
        {
            await DisplayAlert("Pea pidu", "Juuli peamine püha on 4. Juuli - USA iseseisvuspäev", "välja");
        }
        private async void Button_Clicked8(object sender, EventArgs e)
        {
            await DisplayAlert("Pea pidu", "August peamine püha on 23. august - kommunismi ja natsismi ohvrite mälestuspäev", "välja");
        }
    }
}