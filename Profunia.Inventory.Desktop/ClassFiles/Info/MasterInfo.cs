namespace Profunia.Inventory.Desktop.ClassFiles.Info
{
	internal class MasterInfo
	{
		private int _masterId;

		private int _pageSize1;

		private int _pageSizeOther;

		private int _blankLneForFooter;

		private int _lineCountBetweenTwo;

		private int _formName;

		private int _lineCountAfterPrint;

		private string _footerLocation;

		private string _condensed;

		private string _pitch;

		private bool _isTwoLineForHedder;

		private bool _isTwoLineForDetails;

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

		public int LineCountAfterPrint
		{
			get
			{
				return _lineCountAfterPrint;
			}
			set
			{
				_lineCountAfterPrint = value;
			}
		}

		public int PageSize1
		{
			get
			{
				return _pageSize1;
			}
			set
			{
				_pageSize1 = value;
			}
		}

		public int PageSizeOther
		{
			get
			{
				return _pageSizeOther;
			}
			set
			{
				_pageSizeOther = value;
			}
		}

		public int BlankLneForFooter
		{
			get
			{
				return _blankLneForFooter;
			}
			set
			{
				_blankLneForFooter = value;
			}
		}

		public int LineCountBetweenTwo
		{
			get
			{
				return _lineCountBetweenTwo;
			}
			set
			{
				_lineCountBetweenTwo = value;
			}
		}

		public string FooterLocation
		{
			get
			{
				return _footerLocation;
			}
			set
			{
				_footerLocation = value;
			}
		}

		public string Condensed
		{
			get
			{
				return _condensed;
			}
			set
			{
				_condensed = value;
			}
		}

		public string Pitch
		{
			get
			{
				return _pitch;
			}
			set
			{
				_pitch = value;
			}
		}

		public int FormName
		{
			get
			{
				return _formName;
			}
			set
			{
				_formName = value;
			}
		}

		public bool IsTwoLineForHedder
		{
			get
			{
				return _isTwoLineForHedder;
			}
			set
			{
				_isTwoLineForHedder = value;
			}
		}

		public bool IsTwoLineForDetails
		{
			get
			{
				return _isTwoLineForDetails;
			}
			set
			{
				_isTwoLineForDetails = value;
			}
		}
	}
}
