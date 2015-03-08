using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GeekyTheory.Windows.Toolkit.Services
{
	/// <summary>
	/// Service contract to work with app settings.
	/// </summary>
	public interface ISettingsService
	{
		/// <summary>
		/// Save a value in the settings using the provided key.
		/// </summary>
		/// <param name="key">key to identify the object saved</param>
		/// <param name="value">value to save</param>
		void SaveSetting(string key, string value);

		/// <summary>
		/// Load a value from the settings using the provided key.
		/// </summary>
		/// <param name="key">key to search for in the settings.</param>
		string LoadSetting(string key);

		/// <summary>
		/// Remove the given key from the application settings.
		/// </summary>
		/// <param name="key"></param>
		void RemoveSetting(string key);
	}
}
