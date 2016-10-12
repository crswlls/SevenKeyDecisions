using System;
using GalaSoft.MvvmLight.Ioc;
using Microsoft.Practices.ServiceLocation;

namespace SevenKeyDecisions.Navigation
{
	internal static class ViewModelLocator
	{
		static ViewModelLocator()
		{
			ServiceLocator.SetLocatorProvider(() => SimpleIoc.Default);
			SimpleIoc.Default.Register<PhotosViewModel>();
			SimpleIoc.Default.Register<PhotoDetailsViewModel>();
		}

		public static T GetViewModel<T>() where T : class
		{
			return ServiceLocator.Current.GetInstance<T>();
		}
	}
}
