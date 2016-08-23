using Xamarin.Forms;

namespace myCutz
{
	public partial class App : Application
	{
		public App()
		{
			InitializeComponent();

			MainPage = new myCutzPage();
		}

		protected override void OnStart()
		{
			//Debug.WriteLine("Start");
			// Handle when your app starts
		}

		protected override void OnSleep()
		{
			// Handle when your app sleeps
		}

		protected override void OnResume()
		{
			// Handle when your app resumes
		}
	}
}

