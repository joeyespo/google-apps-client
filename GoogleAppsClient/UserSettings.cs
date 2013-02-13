using System;
using System.Collections.Generic;
using System.Configuration;
using System.Text;

namespace GoogleAppsClient {
	public sealed class UserSettings : ConfigurationSection {
		static ConfigurationPropertyCollection properties;

		//static bool readOnly;

		static readonly ConfigurationProperty usernameProperty = new ConfigurationProperty("username", typeof(string), "", ConfigurationPropertyOptions.None);
		static readonly ConfigurationProperty encryptedPasswordProperty = new ConfigurationProperty("encryptedPassword", typeof(string), "", ConfigurationPropertyOptions.None);
		static readonly ConfigurationProperty savePasswordProperty = new ConfigurationProperty("savePassword", typeof(bool), true, ConfigurationPropertyOptions.None);

		public UserSettings()
		{
			properties = new ConfigurationPropertyCollection {
				usernameProperty,
				encryptedPasswordProperty,
				savePasswordProperty
			};
		}

		protected override ConfigurationPropertyCollection Properties
		{
			get { return properties; }
		}

		/*
		new bool IsReadOnly
		{
			get { return readOnly; }
		}

		void ThrowIfReadOnly(string propertyName)
		{
			if (IsReadOnly)
				throw new ConfigurationErrorsException("The property " + propertyName + " is read only.");
		}

		protected override object GetRuntimeObject()
		{
			readOnly = true;
			return base.GetRuntimeObject();
		}
		*/

		public string Username
		{
			get { return (string)this["username"]; }
			set { this["username"] = value; }
		}


		public string EncryptedPassword
		{
			get { return (string)this["encryptedPassword"]; }
			set { this["encryptedPassword"] = value; }
		}

		public bool SavePassword
		{
			get { return (bool)this["savePassword"]; }
			set { this["savePassword"] = value; }
		}
	}
}
