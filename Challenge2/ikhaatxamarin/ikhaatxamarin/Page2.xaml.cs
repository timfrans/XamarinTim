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
	public partial class Page2 : ContentPage
	{
		public Page2 ()
		{
			InitializeComponent ();

            Button btnVorigePagina = new Button
            {
                Text = "vorige pagina"
            };

            btnVorigePagina.Clicked += BtnVorigePagina_Clicked;

            Button btnRootPage = new Button
            {
                Text = "naar root page"
            };

            Label p3 = new Label
            {
                Text = "page 3"
            };

            btnRootPage.Clicked += BtnRootPage_Clicked;

            this.Content = new StackLayout
            {
                Children =
                {
                    btnVorigePagina,
                    btnRootPage,
                    p3
                }
            };


		}

        async void BtnRootPage_Clicked(object sender, EventArgs e)
        {
            await Navigation.PopToRootAsync();
        }

        async void BtnVorigePagina_Clicked(object sender, EventArgs e)
        {
            await Navigation.PopAsync();
        }
    }
}
