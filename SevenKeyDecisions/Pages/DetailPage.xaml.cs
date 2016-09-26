using System;
using System.Collections.Generic;
using SevenKeyDecisions.Core;
using Xamarin.Forms;

namespace SevenKeyDecisions.Pages
{
    public partial class DetailPage : ContentPage
    {
        private PhotoInfo _photoInfo;
    
        public DetailPage (PhotoInfo item)
        {
            _photoInfo = item;
            InitializeComponent ();
            Title = item.Title;
        }
        
        protected override void OnAppearing ()
        {
            base.OnAppearing ();
            mainImage.Source = _photoInfo.Url;
        }
    }
}
