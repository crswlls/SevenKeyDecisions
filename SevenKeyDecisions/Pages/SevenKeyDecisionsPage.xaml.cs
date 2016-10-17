using System.Linq;
using SevenKeyDecisions.Core;
using SevenKeyDecisions.Navigation;
using SevenKeyDecisions.Pages;
using Xamarin.Forms;

namespace SevenKeyDecisions
{
    public partial class SevenKeyDecisionsPage : ContentPage
    {
		private PhotosViewModel _photosViewModel = ViewModelLocator.GetViewModel<PhotosViewModel>();

        public SevenKeyDecisionsPage ()
        {
            InitializeComponent ();
            Title = "7 Key Decisions";
			BindingContext = _photosViewModel;
        }
        
        protected override async void OnAppearing ()
        {
            base.OnAppearing ();
			await _photosViewModel.Initialise();
        }

        private async void OnItemSelected(object sender, SelectedItemChangedEventArgs e)
        {
			_photosViewModel.PhotoSelectedCommand.Execute(e.SelectedItem);
        }
    }
}