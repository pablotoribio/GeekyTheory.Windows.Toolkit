using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Windows.UI.Xaml.Controls;
using Windows.UI.Xaml.Navigation;

namespace GeekyTheory.Windows.Toolkit.ViewModels
{
	public class PageBase : Page
	{
		private ViewModelBase vm;

		public PageBase()
		{
		}

		protected override void OnNavigatedTo(NavigationEventArgs e)
		{
			base.OnNavigatedTo(e);

			vm = (ViewModelBase)this.DataContext;
			if (vm != null)
			{
				vm.OnNavigatedTo(e);
			}
		}

		protected override void OnNavigatedFrom(NavigationEventArgs e)
		{
			base.OnNavigatedFrom(e);
			vm.OnNavigatedFrom(e);
		}

		protected override void OnNavigatingFrom(NavigatingCancelEventArgs e)
		{
			base.OnNavigatingFrom(e);
			vm.OnNavigatingFrom(e);
		}
	}
}
