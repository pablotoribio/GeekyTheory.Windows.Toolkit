﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Windows.Storage;

namespace GeekyTheory.Windows.Toolkit.Services
{
	/// <summary>
	/// Service implementation to work with app settings.
	/// </summary>
	public class SettingsService : ISettingsService
	{
		/// <summary>
		/// Save a value in the settings using the provided key.
		/// </summary>
		/// <param name="key">key to identify the object saved</param>
		/// <param name="value">value to save</param>
		public void SaveSetting(string key, string value)
		{
			ApplicationData.Current.LocalSettings.Values[key] = value;
		}

		/// <summary>
		/// Load a value from the settings using the provided key.
		/// </summary>
		/// <param name="key">key to search for in the settings.</param>
		public string LoadSetting(string key)
		{
			var value = ApplicationData.Current.LocalSettings.Values[key];
			return value == null ? string.Empty : value.ToString();
		}

		/// <summary>
		/// Remove the given key from the application settings.
		/// </summary>
		/// <param name="key"></param>
		public void RemoveSetting(string key)
		{
			ApplicationData.Current.LocalSettings.Values.Remove(key);
		}
	}
}
