// ------------------------------------------------------------------------
// ========================================================================
// THIS CODE AND INFORMATION ARE GENERATED BY AUTOMATIC CODE GENERATOR
// ========================================================================
// Template:   IViewModel.tt
using System.CodeDom.Compiler;
using System.Collections.ObjectModel;
using System.Runtime.CompilerServices;
using System.Windows;
using System.Windows.Input;
using Entities=WPAppStudio.Entities;
using EntitiesBase=WPAppStudio.Entities.Base;

namespace WPAppStudio.ViewModel.Interfaces
{
    /// <summary>
    /// Episode_Episode ViewModel interface.
    /// </summary>
    [CompilerGenerated]
    [GeneratedCode("Radarc", "4.0")]
    public interface IEpisode_EpisodeViewModel
    {		
        /// <summary>
        /// Gets/Sets the Episode_EpisodeListControlCollection property.
        /// </summary>
		ObservableCollection<EntitiesBase.RssSearchResult> Episode_EpisodeListControlCollection { get; set; }
        /// <summary>
        /// Gets/Sets the SelectedEpisode_EpisodeListControlCollection property.
        /// </summary>
		EntitiesBase.RssSearchResult SelectedEpisode_EpisodeListControlCollection { get; set; }
        
        /// <summary>
        /// Gets the RefreshEpisode_EpisodeListControlCollectionCommand command.
        /// </summary>
		ICommand RefreshEpisode_EpisodeListControlCollectionCommand { get; }

        
        /// <summary>
        /// Gets the GetEpisode_EpisodeListControlCollectionCommand command.
        /// </summary>
		ICommand GetEpisode_EpisodeListControlCollectionCommand { get; }

	}
}
