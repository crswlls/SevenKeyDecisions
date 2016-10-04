using System;
using System.Collections.ObjectModel;
using System.Threading.Tasks;
using SevenKeyDecisions.Core;

namespace SevenKeyDecisions
{
	public class PhotosViewModel
	{
		public ObservableCollection<PhotoInfo> Photos { get; } = new ObservableCollection<PhotoInfo>();

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
	}
}