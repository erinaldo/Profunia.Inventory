namespace Profunia.Inventory.Desktop.ClassFiles.Info
{
	internal class FieldInfo
	{
		private string _fieldName;

		private int _formId;

		private int _fieldId;

		public int FormId
		{
			get
			{
				return _formId;
			}
			set
			{
				_formId = value;
			}
		}

		public int FieldId
		{
			get
			{
				return _fieldId;
			}
			set
			{
				_fieldId = value;
			}
		}

		public string FieldName
		{
			get
			{
				return _fieldName;
			}
			set
			{
				_fieldName = value;
			}
		}
	}
}
