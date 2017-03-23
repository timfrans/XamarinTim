using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;

namespace ikhaatxamarin
{
	public partial class MainPage : ContentPage
	{
		public MainPage()
		{
			InitializeComponent();

            Button btnVolgendeActivity = new Button
            {
                Text="volgende pagina"

            };

            Label p1 = new Label
            {
                Text = "rootpage"
            };

            btnVolgendeActivity.Clicked += BtnVolgendeActivity_Clicked;

            this.Content = new StackLayout
            {
                Children =
                {
                    btnVolgendeActivity,
                    p1
                }
            };
		}

        async void BtnVolgendeActivity_Clicked(object sender, EventArgs e)
        {
            await Navigation.PushAsync(new Page1());
        }
    }
}
