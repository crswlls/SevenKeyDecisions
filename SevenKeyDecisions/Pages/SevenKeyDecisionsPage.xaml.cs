using System.Linq;
using SevenKeyDecisions.Core;
using Xamarin.Forms;

namespace SevenKeyDecisions
{
    public partial class SevenKeyDecisionsPage : ContentPage
    {
        public SevenKeyDecisionsPage ()
        {
            InitializeComponent ();
        }
        
        protected override async void OnAppearing ()
        {
            base.OnAppearing ();
            
            var photoJson = await new PhotosRequester().GetPhotoInfos().ConfigureAwait(false);
            var photoInfos = new PhotosParser().ParsePhotos(photoJson);
            Device.BeginInvokeOnMainThread(() => photos.ItemsSource = photoInfos);
        }
    }
}