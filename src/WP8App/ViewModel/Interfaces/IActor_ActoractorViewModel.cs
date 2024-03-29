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
    /// Actor_Actoractor ViewModel interface.
    /// </summary>
    [CompilerGenerated]
    [GeneratedCode("Radarc", "4.0")]
    public interface IActor_ActoractorViewModel
    {		
        /// <summary>
        /// Gets/Sets the Actor_ActoractorListControlCollection property.
        /// </summary>
		ObservableCollection<Entities.charactersSchema> Actor_ActoractorListControlCollection { get; set; }
        /// <summary>
        /// Gets/Sets the Actor_ActoractorListControlCollectionPageNumber property.
        /// </summary>
		int Actor_ActoractorListControlCollectionPageNumber { get; set; }
        /// <summary>
        /// Gets/Sets the SelectedActor_ActoractorListControlCollection property.
        /// </summary>
		Entities.charactersSchema SelectedActor_ActoractorListControlCollection { get; set; }
        
        /// <summary>
        /// Gets the GetActor_ActoractorListControlCollectionCommand command.
        /// </summary>
		ICommand GetActor_ActoractorListControlCollectionCommand { get; }

	}
}
