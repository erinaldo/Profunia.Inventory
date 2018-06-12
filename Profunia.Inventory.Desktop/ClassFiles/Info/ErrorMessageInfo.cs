using System.ComponentModel;

namespace Profunia.Inventory.Desktop.ClassFiles.Info
{
	public class ErrorMessageInfo : INotifyPropertyChanged
	{
		public string ErrorData = "Error Message !";

		public string ErrorString
		{
			get
			{
				return ErrorData;
			}
			set
			{
				if (ErrorData != value)
				{
					ErrorData = value;
					NotifyPropertyChanged(ErrorData);
				}
			}
		}

		public event PropertyChangedEventHandler PropertyChanged;

		private void NotifyPropertyChanged(string info)
		{
			if (this.PropertyChanged != null)
			{
				this.PropertyChanged(this, new PropertyChangedEventArgs(info));
			}
		}
	}
}
