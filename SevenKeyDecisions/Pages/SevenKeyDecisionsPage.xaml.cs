using System.Linq;
using SevenKeyDecisions.Core;
using SevenKeyDecisions.Pages;
using Xamarin.Forms;

namespace SevenKeyDecisions
{
    public partial class SevenKeyDecisionsPage : ContentPage
    {
		private PhotosViewModel _photosViewModel;

        public SevenKeyDecisionsPage ()
        {
            InitializeComponent ();
            Title = "7 Key Decisions";
			_photosViewModel = new PhotosViewModel();
			BindingContext = _photosViewModel;
        }
        
        protected override async void OnAppearing ()
        {
            base.OnAppearing ();
			await _photosViewModel.Initialise();
        }

        private async void OnItemSelected(object sender, SelectedItemChangedEventArgs e)
        {
            var photoItem = (PhotoInfo)e.SelectedItem;
            var detailPage = new DetailPage(photoItem);
            await Navigation.PushAsync(detailPage);
        }
    }
}