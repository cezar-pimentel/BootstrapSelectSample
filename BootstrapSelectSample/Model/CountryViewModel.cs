using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Web.Mvc;

namespace BootstrapSelectSample.Model
{
	public class CountryViewModel
	{
		public IEnumerable<SelectListItem> Countries { get; set; }

		[Display(Name = "Country")]
		public int SelectedCountry { get; set; }
	}
}