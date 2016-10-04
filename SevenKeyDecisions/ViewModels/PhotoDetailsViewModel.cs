using System;
using System.ComponentModel;
using System.Threading.Tasks;
using SevenKeyDecisions.Core;

namespace SevenKeyDecisions
{
	public class PhotoDetailsViewModel : INotifyPropertyChanged
	{
		private PhotoInfo _thePhoto;
		private Uri _imageUri;

		public Uri ImageUri
		{
			get
			{
				return _imageUri;
			}

			private set
			{
				if (_imageUri != value)
				{
					_imageUri = value;
					PropertyChanged(this, new PropertyChangedEventArgs(nameof(ImageUri)));
				}
			}
		}

		public event PropertyChangedEventHandler PropertyChanged;

		public void Initialise(PhotoInfo photo)
		{
			_thePhoto = photo;
			ImageUri = photo.Url;
		}
	}
}