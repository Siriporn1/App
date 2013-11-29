// ------------------------------------------------------------------------
// ========================================================================
// THIS CODE AND INFORMATION ARE GENERATED BY AUTOMATIC CODE GENERATOR
// ========================================================================
// Template:   ViewModel.tt
using System;
using System.CodeDom.Compiler;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using System.Windows;
using System.Windows.Input;
using Controls=WPAppStudio.Controls;
using Entities=WPAppStudio.Entities;
using EntitiesBase=WPAppStudio.Entities.Base;
using IServices=WPAppStudio.Services.Interfaces;
using IViewModels=WPAppStudio.ViewModel.Interfaces;
using Localization=WPAppStudio.Localization;
using Repositories=WPAppStudio.Repositories;
using Services=WPAppStudio.Services;
using ViewModelsBase=WPAppStudio.ViewModel.Base;
using WPAppStudio;
using WPAppStudio.Shared;

namespace WPAppStudio.ViewModel
{
    /// <summary>
    /// Implementation of start_List ViewModel.
    /// </summary>
    [CompilerGenerated]
    [GeneratedCode("Radarc", "4.0")]
    public partial class start_ListViewModel : ViewModelsBase.VMBase, IViewModels.Istart_ListViewModel
    {       

		private readonly IServices.IDialogService _dialogService;
		private readonly IServices.INavigationService _navigationService;
		private readonly IServices.ILockScreenService _lockScreenService;
		private readonly Repositories.IMovie_Movie _movie_Movie;
		private readonly IServices.IInternetService _internetService;
		
        /// <summary>
        /// Initializes a new instance of the <see cref="start_ListViewModel" /> class.
        /// </summary>
        /// <param name="dialogService">The Dialog Service.</param>
        /// <param name="navigationService">The Navigation Service.</param>
        /// <param name="lockScreenService">The Lock Screen Service.</param>
        /// <param name="movie_Movie">The Movie_ Movie.</param>
        /// <param name="internetService">The Internet Service.</param>
        public start_ListViewModel(IServices.IDialogService dialogService, IServices.INavigationService navigationService, IServices.ILockScreenService lockScreenService, Repositories.IMovie_Movie movie_Movie, IServices.IInternetService internetService)
        {
			_dialogService = dialogService;
			_navigationService = navigationService;
			_lockScreenService = lockScreenService;
			_movie_Movie = movie_Movie;
			_internetService = internetService;
        }
		
	    /// <summary>
        /// IsInternetAvalaible property.
        /// </summary>		
        public Visibility IsInternetAvalaible
        {
	      get
          {
				return _internetService.IsNetworkAvailable() ? Visibility.Collapsed : Visibility.Visible; 
           }
		}
	
		private Controls.MenuItemData _selectedListMenuControl;

        /// <summary>
        /// SelectedListMenuControl property.
        /// </summary>		
        public Controls.MenuItemData SelectedListMenuControl
        {
            get
            {
				return _selectedListMenuControl;
            }
            set
            {
                _selectedListMenuControl = value;
                if (value != null)
                    _navigationService.NavigateTo(value);
            }
        }
	
		private ObservableCollection<EntitiesBase.YouTubeVideo> _movie_VideosListControlCollection;

        /// <summary>
        /// Movie_VideosListControlCollection property.
        /// </summary>		
        public ObservableCollection<EntitiesBase.YouTubeVideo> Movie_VideosListControlCollection
        {
            get
            {
				
                if(_movie_VideosListControlCollection == null)
					GetMovie_VideosListControlCollectionData();
				return _movie_VideosListControlCollection;     
            }
            set
            {
                SetProperty(ref _movie_VideosListControlCollection, value);
            }
        }
	
		private int _movie_VideosListControlCollectionPageNumber;

        /// <summary>
        /// Movie_VideosListControlCollectionPageNumber property.
        /// </summary>		
        public int Movie_VideosListControlCollectionPageNumber
        {
            get
            {
				return _movie_VideosListControlCollectionPageNumber;
            }
            set
            {
                SetProperty(ref _movie_VideosListControlCollectionPageNumber, value);
            }
        }
	
		private EntitiesBase.YouTubeVideo _selectedMovie_VideosListControlCollection;

        /// <summary>
        /// SelectedMovie_VideosListControlCollection property.
        /// </summary>		
        public EntitiesBase.YouTubeVideo SelectedMovie_VideosListControlCollection
        {
            get
            {
				return _selectedMovie_VideosListControlCollection;
            }
            set
            {
                _selectedMovie_VideosListControlCollection = value;
                if (value != null)
                    _navigationService.NavigateTo<IViewModels.IMovie_DetailVideosViewModel>(_selectedMovie_VideosListControlCollection);
            }
        }

        /// <summary>
        /// Delegate method for the RefreshMovie_VideosListControlCollectionCommand command.
        /// </summary>
        public async void RefreshMovie_VideosListControlCollectionCommandDelegate() 
        {
			try
			{
				LoadingMovie_VideosListControlCollection = true;
				var items = await  _movie_Movie.Refresh();
				Movie_VideosListControlCollection = items;
				Movie_VideosListControlCollectionPageNumber = 0;
			}
            catch (Exception ex)
            {
				Movie_VideosListControlCollection = null;
		
                Debug.WriteLine(ex.ToString());
                _dialogService.Show(Localization.AppResources.youtubeError + Environment.NewLine + Localization.AppResources.TryAgain);
            }
            finally
            {
				LoadingMovie_VideosListControlCollection = false;
			}
        }
		
		
        private bool _loadingMovie_VideosListControlCollection;
		
        public bool LoadingMovie_VideosListControlCollection
        {
            get { return _loadingMovie_VideosListControlCollection; }
            set { SetProperty(ref _loadingMovie_VideosListControlCollection, value); }
        }

        private ICommand _refreshMovie_VideosListControlCollectionCommand;

        /// <summary>
        /// Gets the RefreshMovie_VideosListControlCollectionCommand command.
        /// </summary>
        public ICommand RefreshMovie_VideosListControlCollectionCommand
        {
            get { return _refreshMovie_VideosListControlCollectionCommand = _refreshMovie_VideosListControlCollectionCommand ?? new ViewModelsBase.DelegateCommand(RefreshMovie_VideosListControlCollectionCommandDelegate); }
        }

        /// <summary>
        /// Delegate method for the GetMovie_VideosListControlCollectionCommand command.
        /// </summary>
        public  void GetMovie_VideosListControlCollectionCommandDelegate(int pageNumber= 0) 
        {
				GetMovie_VideosListControlCollectionData(pageNumber);
        }
		

        private ICommand _getMovie_VideosListControlCollectionCommand;

        /// <summary>
        /// Gets the GetMovie_VideosListControlCollectionCommand command.
        /// </summary>
        public ICommand GetMovie_VideosListControlCollectionCommand
        {
            get { return _getMovie_VideosListControlCollectionCommand = _getMovie_VideosListControlCollectionCommand ?? new ViewModelsBase.DelegateCommand<int>(GetMovie_VideosListControlCollectionCommandDelegate); }
        }

        /// <summary>
        /// Delegate method for the SetLockScreenCommand command.
        /// </summary>
        public  void SetLockScreenCommandDelegate() 
        {
				_lockScreenService.SetLockScreen("LockScreen-2b67af4e-cdc3-476d-8a08-ad77a79cdd50.jpg");
        }
		

        private ICommand _setLockScreenCommand;

        /// <summary>
        /// Gets the SetLockScreenCommand command.
        /// </summary>
        public ICommand SetLockScreenCommand
        {
            get { return _setLockScreenCommand = _setLockScreenCommand ?? new ViewModelsBase.DelegateCommand(SetLockScreenCommandDelegate); }
        }

        /// <summary>
        /// Delegate method for the AboutCommand command.
        /// </summary>
        public  void AboutCommandDelegate() 
        {
				_navigationService.NavigateTo<IViewModels.IAboutViewModel>();
        }
		

        private ICommand _aboutCommand;

        /// <summary>
        /// Gets the AboutCommand command.
        /// </summary>
        public ICommand AboutCommand
        {
            get { return _aboutCommand = _aboutCommand ?? new ViewModelsBase.DelegateCommand(AboutCommandDelegate); }
        }

        private async void GetMovie_VideosListControlCollectionData(int pageNumber = 0)
        {
	
			try
			{
				LoadingMovie_VideosListControlCollection = true;
				Movie_VideosListControlCollectionPageNumber = pageNumber;

                if (pageNumber == 0)
				{
					var items = await _movie_Movie.GetData(pageNumber);
                    Movie_VideosListControlCollection = items;
				}
                else   
				{
					var items = await _movie_Movie.GetData(pageNumber);
                    foreach (var item in items)                    
                        Movie_VideosListControlCollection.Add(item);
				}
			}
            catch (Exception ex)
            {
				Movie_VideosListControlCollection = null;
		
                Debug.WriteLine(ex.ToString());
                _dialogService.Show(Localization.AppResources.youtubeError + Environment.NewLine + Localization.AppResources.TryAgain);
            }
            finally
            {
				LoadingMovie_VideosListControlCollection = false;
			}
		}
    }
}