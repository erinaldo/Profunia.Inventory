namespace Profunia.Inventory.Desktop.ClassFiles.Info
{
	internal class DetailsInfo
	{
		private int _detailsId;

		private int _masterId;

		private int _row;

		private int _columns;

		private int _width;

		private int _wrapLineCount;

		private string _name;

		private string _text;

		private string _dbf;

		private string _DorH;

		private string _repeat;

		private string _align;

		private string _repeatAll;

		private string _FooterRepeatAll;

		private string _textWrap;

		private string _fieldsForExtra;

		private string _extraFieldName;

		public string FieldsForExtra
		{
			get
			{
				return _fieldsForExtra;
			}
			set
			{
				_fieldsForExtra = value;
			}
		}

		public string ExtraFieldName
		{
			get
			{
				return _extraFieldName;
			}
			set
			{
				_extraFieldName = value;
			}
		}

		public int MasterId
		{
			get
			{
				return _masterId;
			}
			set
			{
				_masterId = value;
			}
		}

		public int DetailsId
		{
			get
			{
				return _detailsId;
			}
			set
			{
				_detailsId = value;
			}
		}

		public int Row
		{
			get
			{
				return _row;
			}
			set
			{
				_row = value;
			}
		}

		public int Columns
		{
			get
			{
				return _columns;
			}
			set
			{
				_columns = value;
			}
		}

		public int Width
		{
			get
			{
				return _width;
			}
			set
			{
				_width = value;
			}
		}

		public int WrapLineCount
		{
			get
			{
				return _wrapLineCount;
			}
			set
			{
				_wrapLineCount = value;
			}
		}

		public string Name
		{
			get
			{
				return _name;
			}
			set
			{
				_name = value;
			}
		}

		public string TextWrap
		{
			get
			{
				return _textWrap;
			}
			set
			{
				_textWrap = value;
			}
		}

		public string Text
		{
			get
			{
				return _text;
			}
			set
			{
				_text = value;
			}
		}

		public string DBF
		{
			get
			{
				return _dbf;
			}
			set
			{
				_dbf = value;
			}
		}

		public string DorH
		{
			get
			{
				return _DorH;
			}
			set
			{
				_DorH = value;
			}
		}

		public string Repeat
		{
			get
			{
				return _repeat;
			}
			set
			{
				_repeat = value;
			}
		}

		public string Align
		{
			get
			{
				return _align;
			}
			set
			{
				_align = value;
			}
		}

		public string RepeatAll
		{
			get
			{
				return _repeatAll;
			}
			set
			{
				_repeatAll = value;
			}
		}

		public string FooterRepeatAll
		{
			get
			{
				return _FooterRepeatAll;
			}
			set
			{
				_FooterRepeatAll = value;
			}
		}
	}
}
