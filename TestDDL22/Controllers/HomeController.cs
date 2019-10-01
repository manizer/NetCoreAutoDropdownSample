using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using NetCoreAutoLinkDropdown.AutoLinkDropdownBehavior;
using TestDDL22.Models;

namespace TestDDL22.Controllers
{
	public class HomeController : Controller
	{
		public IActionResult Index()
		{
			List<Category> categories = new List<Category>
			{
				new Category
				{
					Id = 1,
					Name = "Electronic",
					SubCategories = new List<SubCategory>
					{
						new SubCategory{Id = 1, Name = "Laptop"},
						new SubCategory{Id = 2, Name = "Smart Phone"},
						new SubCategory{Id = 3, Name = "Headset"}
					}
				},
				new Category
				{
					Id = 2,
					Name = "Fitness",
					SubCategories = new List<SubCategory>
					{
						new SubCategory{Id = 1, Name = "Badminton"},
						new SubCategory{Id = 2, Name = "Basketball"},
						new SubCategory{Id = 3, Name = "Baseball"}
					}
				},
				new Category
				{
					Id = 3,
					Name = "Food",
					SubCategories = new List<SubCategory>
					{
						new SubCategory{Id = 1, Name = "Fried Rice"},
						new SubCategory{Id = 2, Name = "Steak"},
						new SubCategory{Id = 3, Name = "Soup"}
					}
				}
			};

			IndexViewModel indexViewModel = new IndexViewModel
			{
				Categories = categories.ToList<DropdownItem>()
			};
			return View(indexViewModel);
		}
	}
}
