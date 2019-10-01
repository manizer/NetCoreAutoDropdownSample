using NetCoreAutoLinkDropdown.AutoLinkDropdownBehavior;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace TestDDL22.Models
{
	public class IndexViewModel
	{
		public List<DropdownItem> Categories { get; set; }
		public int CategoryId { get; set; }
		public int SubCategoryId { get; set; }
	}
}
