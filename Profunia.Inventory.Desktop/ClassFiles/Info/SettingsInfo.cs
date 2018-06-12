using System;

namespace Profunia.Inventory.Desktop.ClassFiles.Info
{
	internal class SettingsInfo
	{
		private decimal _settingsId;

		private string _settingsName;

		private string _status;

		private DateTime _extraDate;

		private string _extra1;

		private string _extra2;

		public static string _negativeCashTransaction;

		public decimal SettingsId
		{
			get
			{
				return _settingsId;
			}
			set
			{
				_settingsId = value;
			}
		}

		public string SettingsName
		{
			get
			{
				return _settingsName;
			}
			set
			{
				_settingsName = value;
			}
		}

		public string Status
		{
			get
			{
				return _status;
			}
			set
			{
				_status = value;
			}
		}

		public DateTime ExtraDate
		{
			get
			{
				return _extraDate;
			}
			set
			{
				_extraDate = value;
			}
		}

		public string Extra1
		{
			get
			{
				return _extra1;
			}
			set
			{
				_extra1 = value;
			}
		}

		public string Extra2
		{
			get
			{
				return _extra2;
			}
			set
			{
				_extra2 = value;
			}
		}

		public string NegativeCashTransaction
		{
			get
			{
				return _negativeCashTransaction;
			}
			set
			{
				_negativeCashTransaction = value;
			}
		}
	}
}
