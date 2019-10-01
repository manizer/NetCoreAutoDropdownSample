using NetCoreAutoLinkDropdown.AutoLinkDropdownBehavior;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace TestDDL22.Models
{
	public class SubCategory : DropdownItem
	{
		public int Id { get; set; }
		public string Name { get; set; }

		public bool DropdownItemEnabled() => true;

		public string DropdownText() => Name;

		public string DropdownValue() => Id.ToString();
	}
}
