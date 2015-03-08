using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;
using Windows.Graphics.Display;
using Windows.UI.Xaml;
using Windows.UI.Xaml.Navigation;
using GeekyTheory.Windows.Toolkit.Annotations;

namespace GeekyTheory.Windows.Toolkit.ViewModels
{
	public class ViewModelBase : INotifyPropertyChanged
	{

		public virtual void OnNavigatedFrom(NavigationEventArgs e)
		{
		}

		public virtual void OnNavigatingFrom(NavigatingCancelEventArgs e)
		{
		}

		public virtual void OnNavigatedTo(NavigationEventArgs e)
		{
		}

		public event PropertyChangedEventHandler PropertyChanged;

		[NotifyPropertyChangedInvocator]
		protected virtual void OnPropertyChanged([CallerMemberName] string propertyName = null)
		{
			PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyName));
		}
	}
}
