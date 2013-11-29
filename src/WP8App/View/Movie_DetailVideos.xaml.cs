// ------------------------------------------------------------------------
// ========================================================================
// THIS CODE AND INFORMATION ARE GENERATED BY AUTOMATIC CODE GENERATOR
// ========================================================================
// Template:   PageCS.tt
using System;
using System.CodeDom.Compiler;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Net;
using System.Runtime.CompilerServices;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Navigation;
using Entities=WPAppStudio.Entities;
using Ioc=WPAppStudio.Ioc;
using IServices=WPAppStudio.Services.Interfaces;
using IViewModels=WPAppStudio.ViewModel.Interfaces;
using Localization=WPAppStudio.Localization;
using Microsoft.Phone.Controls;
using Microsoft.Phone.Shell;
using MyToolkit.Paging;
using Repositories=WPAppStudio.Repositories;
using WPAppStudio;

namespace WPAppStudio.View
{
    /// <summary>
    /// Phone application page for Movie_DetailVideos.
    /// </summary>
    [CompilerGenerated]
    [GeneratedCode("Radarc", "4.0")]
    public partial class Movie_DetailVideos : PhoneApplicationPage
    {       
        /// <summary>
        /// Initializes the phone application page for Movie_DetailVideos and all its components.
        /// </summary>
        public Movie_DetailVideos()
        {
            InitializeComponent();        
			if (Resources.Contains("PanoramaMovie_DetailVideos0AppBar"))
				PhonePage.SetApplicationBar(this, Resources["PanoramaMovie_DetailVideos0AppBar"] as BindableApplicationBar);                            
		}
		
        private void panoramaMovie_DetailVideos_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {		
			InitializeAppBarpanoramaMovie_DetailVideos(PanoramaMovie_DetailVideos.SelectedItem as PanoramaItem);
        }
		
		private void InitializeAppBarpanoramaMovie_DetailVideos(PanoramaItem panoramaItem)        
        {
			if (Resources.Contains(panoramaItem.Name + "AppBar"))
			{
				PhonePage.SetApplicationBar(this, Resources[panoramaItem.Name + "AppBar"] as BindableApplicationBar);            
				ApplicationBar.IsVisible = true;
            }
		    else if(ApplicationBar != null)
		        ApplicationBar.IsVisible = false;
        }

		protected override void OnBackKeyPress(CancelEventArgs e)
		{
			if (MyToolkit.Multimedia.YouTube.CancelPlay())
				e.Cancel = true;

			base.OnBackKeyPress(e);
		}
 
        /// <summary>
        /// Called when the page becomes the active page.
        /// </summary>
        /// <param name="e">Contains information about the navigation done.</param>
        protected override async void OnNavigatedTo(NavigationEventArgs e)
        {
            base.OnNavigatedTo(e);
            string currentId;
			
            if (NavigationContext.QueryString.TryGetValue("currentID", out currentId))
            {
				var dataSource = new Ioc.Container().Resolve<Repositories.IMovie_Movie>();
				AddHomeAppBarButton();
				var pinnedItem  = (await dataSource.GetData()).FirstOrDefault(x => IsPinnedItem(x.VideoId.ToString(), currentId));
				if(pinnedItem==null)
					MessageBox.Show(Localization.AppResources.PinError);
				((IViewModels.IMovie_DetailVideosViewModel)DataContext).CurrentYouTubeVideo = pinnedItem;				
			}
			MyToolkit.Multimedia.YouTube.CancelPlay();
		}

        private static bool IsPinnedItem(string itemId, string currentId)
        {
            itemId = itemId.Trim();
            currentId = HttpUtility.UrlDecode(currentId.Trim());
            return itemId.Equals(currentId, StringComparison.InvariantCultureIgnoreCase);
        }
		
        private void AddHomeAppBarButton()
        {
            if (ApplicationBar.Buttons.Count >= 4 ||
                ApplicationBar.Buttons.Cast<ApplicationBarIconButton>().Any(button => button.Text == "Home")) 
                return;
						
			var homeIcon = new ApplicationBarIconButton() {IconUri = new Uri("/Images/Icons/Light/Home.png", UriKind.Relative), IsEnabled = true, Text = "Home"};
            homeIcon.Click += delegate 
			{ 
				new Ioc.Container().Resolve<IServices.INavigationService>().NavigateTo<IViewModels.Istart_ListViewModel>(); 
				while (NavigationService.RemoveBackEntry() != null);
			};
            ApplicationBar.Buttons.Add(homeIcon);
        }
    }
}