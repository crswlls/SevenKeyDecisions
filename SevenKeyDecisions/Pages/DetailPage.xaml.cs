using SevenKeyDecisions.Core;
using Xamarin.Forms;

namespace SevenKeyDecisions.Pages
{
	public partial class DetailPage : ContentPage
    {
        private PhotoInfo _photoInfo;
		private PhotoDetailsViewModel _photoDetailsViewModel;
    
        public DetailPage (PhotoInfo item)
        {
            _photoInfo = item;
            InitializeComponent ();
            Title = item.Title;
			_photoDetailsViewModel = new PhotoDetailsViewModel();
			BindingContext = _photoDetailsViewModel;
        }
        
        protected override void OnAppearing ()
        {
            base.OnAppearing ();
			_photoDetailsViewModel.Initialise(_photoInfo);
        }
    }
}
