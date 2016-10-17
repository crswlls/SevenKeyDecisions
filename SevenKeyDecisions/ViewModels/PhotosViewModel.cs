using System;
using System.Collections.ObjectModel;
using System.Threading.Tasks;
using GalaSoft.MvvmLight.Views;
using SevenKeyDecisions.Core;
using Xamarin.Forms;

namespace SevenKeyDecisions
{
	public class PhotosViewModel
	{
		private Command<PhotoInfo> _photoSelectedCommand;
		private INavigationService _nav;

		public PhotosViewModel(INavigationService navigation)
		{
			_nav = navigation;
		}

		public ObservableCollection<PhotoInfo> Photos { get; } = new ObservableCollection<PhotoInfo>();

		public Command<PhotoInfo> PhotoSelectedCommand => _photoSelectedCommand ?? (_photoSelectedCommand = new Command<PhotoInfo>(OnPhotoSelected));

		public async Task Initialise()
		{
			if (Photos.Count == 0)
			{
				var photoJson = await new PhotosRequester().GetPhotoInfos().ConfigureAwait(false);
				var photoInfos = new PhotosParser().ParsePhotos(photoJson);

				foreach (var photos in photoInfos)
				{
					Photos.Add(photos);
				}
			}
		}

		private void OnPhotoSelected(PhotoInfo photoInfo)
		{
			_nav.NavigateTo(nameof(PhotoDetailsViewModel), photoInfo);
		}
	}
}