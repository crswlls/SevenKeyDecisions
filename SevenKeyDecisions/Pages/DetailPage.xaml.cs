using SevenKeyDecisions.Core;
using SevenKeyDecisions.Navigation;
using Xamarin.Forms;

namespace SevenKeyDecisions.Pages
{
	public partial class DetailPage : ContentPage
    {
        private PhotoInfo _photoInfo;
		private PhotoDetailsViewModel _photoDetailsViewModel = ViewModelLocator.GetViewModel<PhotoDetailsViewModel>();
    
        public DetailPage (PhotoInfo item)
        {
            _photoInfo = item;
            InitializeComponent ();
            Title = item.Title;
			BindingContext = _photoDetailsViewModel;
        }
        
        protected override void OnAppearing ()
        {
            base.OnAppearing ();
			_photoDetailsViewModel.Initialise(_photoInfo);
        }
    }
}
