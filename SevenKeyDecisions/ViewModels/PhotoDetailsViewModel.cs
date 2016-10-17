using System;
using System.ComponentModel;
using System.Threading.Tasks;
using System.Windows.Input;
using SevenKeyDecisions.Core;
using SevenKeyDecisions.Infrastructure;
using Xamarin.Forms;

namespace SevenKeyDecisions
{
	public class PhotoDetailsViewModel : INotifyPropertyChanged
	{
		private IEmailSender _emailSender;

		public PhotoDetailsViewModel(IEmailSender emailSender)
		{
			_emailSender = emailSender;
		}

		private PhotoInfo _thePhoto;
		private Uri _imageUri;
		private ICommand _emailCommand;

		public string Creator => "@crswlls";

		public ICommand EmailCommand => _emailCommand ?? (_emailCommand = new Command(OnSendEmail));

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
					PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(nameof(ImageUri)));
				}
			}
		}

		public event PropertyChangedEventHandler PropertyChanged;

		public void Initialise(PhotoInfo photo)
		{
			_thePhoto = photo;
			ImageUri = photo.Url;
		}

		private void OnSendEmail(object obj)
		{
			_emailSender.SendMessage(Creator, $"About Your Photo ({_thePhoto.Id})", "Sent from Photos App");
		}
	}
}