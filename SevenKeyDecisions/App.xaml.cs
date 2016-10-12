using GalaSoft.MvvmLight.Ioc;
using GalaSoft.MvvmLight.Views;
using SevenKeyDecisions.Navigation;
using SevenKeyDecisions.Pages;
using Xamarin.Forms;

namespace SevenKeyDecisions
{
    public abstract partial class App : Application
    {
        public App ()
		{
			InitializeComponent();
			SetupPages();
		}

		protected override void OnStart ()
        {
            // Handle when your app starts
        }

		protected override void OnSleep ()
        {
            // Handle when your app sleeps
        }

        protected override void OnResume ()
        {
            // Handle when your app resumes
		}

		protected abstract void RegisterPlatformDependencies();

		private void SetupPages()
		{
			var nav = new NavigationService();
			RegisterPlatformDependencies();

			SimpleIoc.Default.Register<INavigationService>(() => nav);
			nav.Configure(nameof(PhotoDetailsViewModel), typeof(DetailPage));
			nav.Configure(nameof(PhotosViewModel), typeof(SevenKeyDecisionsPage));
			var page = new NavigationPage(new SevenKeyDecisionsPage());
			nav.Initialize(page);
			MainPage = page;
		}
    }
}

