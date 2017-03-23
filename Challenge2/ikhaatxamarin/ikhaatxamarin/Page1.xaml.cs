using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace ikhaatxamarin
{
	[XamlCompilation(XamlCompilationOptions.Compile)]
	public partial class Page1 : ContentPage
	{
		public Page1 ()
		{
			InitializeComponent ();

            Button btnVorigePagina = new Button
            {
                Text = "ga terug"
            };

            Button btnVolgendePagina = new Button
            {
                Text = "volgende pagina"
            };

            Label p2 = new Label
            {
                Text = "pagina 2"
            };

            btnVolgendePagina.Clicked += BtnVolgendePagina_Clicked;

            btnVorigePagina.Clicked += BtnVorigePagina_Clicked;

            this.Content = new StackLayout
            {
                Children =
                {
                    btnVorigePagina,
                    btnVolgendePagina,
                    p2
                }
            };
		}

        async void BtnVolgendePagina_Clicked(object sender, EventArgs e)
        {
            await Navigation.PushAsync(new Page2());
        }

        async void BtnVorigePagina_Clicked(object sender, EventArgs e)
        {
            await Navigation.PopAsync();
        }
    }
}
