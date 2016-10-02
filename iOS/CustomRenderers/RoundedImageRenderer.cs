using SevenKeyDecisions;
using SevenKeyDecisions.iOS;
using Xamarin.Forms;
using Xamarin.Forms.Platform.iOS;

[assembly: ExportRenderer(typeof(RoundedImage), typeof(RoundedImageRenderer))]
namespace SevenKeyDecisions.iOS
{
	public class RoundedImageRenderer : ImageRenderer
	{
		protected override void OnElementChanged(ElementChangedEventArgs<Image> e)
		{
			base.OnElementChanged(e);

			if (e.OldElement != null || Element == null)
				return;
			
			MakeRound();
		}

		protected override void OnElementPropertyChanged(object sender, System.ComponentModel.PropertyChangedEventArgs e)
		{
			base.OnElementPropertyChanged(sender, e);
			if (e.PropertyName == VisualElement.HeightProperty.PropertyName ||
				e.PropertyName == VisualElement.WidthProperty.PropertyName)
			{
				MakeRound();
			}
		}

		private void MakeRound()
		{
			Control.Layer.CornerRadius = (float)(Element.Height / 2);
			Control.ClipsToBounds = true;
		}
	}
}