using Xamarin.Forms;
using System;

namespace myCutz
{
	public partial class myCutzPage : ContentPage
	{
		public myCutzPage()
		{
			InitializeComponent();
		}

		public void signUp(object sender, EventArgs args)
		{
			Navigation.PushModalAsync(new myCutz.signUpPage());
		}
	}
}

