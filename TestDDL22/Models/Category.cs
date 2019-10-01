using NetCoreAutoLinkDropdown.AutoLinkDropdownBehavior;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace TestDDL22.Models
{
	public class Category : DropdownItem, SubDropdownItemProviderFactory
	{
		public int Id { get; set; }
		public string Name { get; set; }

		public List<SubCategory> SubCategories { get; set; }

		public bool DropdownItemEnabled() => true;

		public string DropdownText() => Name;

		public string DropdownValue() => Id.ToString();

		public const string DROPDOWN_KEY_SUBCATEGORIES = "DROPDOWN_KEY_SUBCATEGORIES";

		public List<DropdownItem> GetSubDropdownItems(string Key)
		{
			switch (Key)
			{
				case DROPDOWN_KEY_SUBCATEGORIES:
					return SubCategories.ToList<DropdownItem>();
				default:
					return null;
			}
		}
	}
}
