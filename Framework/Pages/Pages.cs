using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using SeleniumExtras.PageObjects;

namespace Framework.Pages
{
	public static class Pages
	{
		private static T GetPage<T>() where T : new()
		{
			var page = new T();
			PageFactory.InitElements(Browser.Driver, page);
			return page;
		}

		public static DriveAwayInsurance DriveAwayInsurance
		{ get { return GetPage<DriveAwayInsurance>(); } }
	}
}
//applying the new constraint to a type parameter when my generic class creates new instances of the type