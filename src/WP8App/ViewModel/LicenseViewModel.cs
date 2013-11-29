// ------------------------------------------------------------------------
// ========================================================================
// THIS CODE AND INFORMATION ARE GENERATED BY AUTOMATIC CODE GENERATOR
// ========================================================================
// Template:   LicenseViewModel.tt
using System.CodeDom.Compiler;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using System.Windows.Input;
using ViewModelsBase=WPAppStudio.ViewModel.Base;
using WPAppStudio;
using WPAppStudio.Entities.Base;
using WPAppStudio.Services.Interfaces;
using WPAppStudio.ViewModel.Base;
using WPAppStudio.ViewModel.Interfaces;

namespace WPAppStudio.ViewModel
{
    /// <summary>
    /// Implementation of About ViewModel.
    /// </summary>
    public partial class LicenseViewModel : ViewModelsBase.VMBase, ILicenseViewModel
    {     
		private List<string> _licenseTerms = new List<string>();

		public IEnumerable<string> LicenseTerms 
		{ 
			get 
			{ 
				return _licenseTerms; 
			} 
		}	
		
        /// <summary>
        /// Initializes a new instance of the <see cref="LicenseViewModel" /> class.
        /// </summary>
        public LicenseViewModel()
        {
				_licenseTerms.Add("You are obtaining data from third parties under separate license terms applicable to the data or to the API through which the data is obtained. It is your responsibility to locate, understand, and comply with all applicable license terms for all third party data or APIs that your application uses.");
        }
    }
}

