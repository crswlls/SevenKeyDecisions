using System.Linq;
using SevenKeyDecisions.Core;
using SevenKeyDecisions.Pages;
using Xamarin.Forms;

namespace SevenKeyDecisions
{
    public partial class SevenKeyDecisionsPage : ContentPage
    {
        public SevenKeyDecisionsPage ()
        {
            InitializeComponent ();
            Title = "7 Key Decisions";
        }
        
        protected override async void OnAppearing ()
        {
            base.OnAppearing ();
            photos.ItemSelected += OnItemSelected;
            
            var photoJson = await new PhotosRequester().GetPhotoInfos().ConfigureAwait(false);
            var photoInfos = new PhotosParser().ParsePhotos(photoJson);
            Device.BeginInvokeOnMainThread(() => photos.ItemsSource = photoInfos);
        }
        
        protected override void OnDisappearing ()
        {
            base.OnDisappearing();
            photos.ItemSelected -= OnItemSelected;
        }

        private async void OnItemSelected (object sender, SelectedItemChangedEventArgs e)
        {
            var photoItem = (PhotoInfo)e.SelectedItem;
            var detailPage = new DetailPage(photoItem);
            await Navigation.PushAsync(detailPage);
        }
    }
}