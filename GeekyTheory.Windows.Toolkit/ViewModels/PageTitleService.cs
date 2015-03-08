using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GeekyTheory.Windows.Toolkit.ViewModels
{
	public abstract class PageTitleService
	{
		public string PageTitle
		{
			get { return this.ToString(); }
		}
	}
}
