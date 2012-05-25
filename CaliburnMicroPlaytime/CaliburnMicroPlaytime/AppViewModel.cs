using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Caliburn.Micro;

namespace CaliburnMicroPlaytime
{
	public class AppViewModel : PropertyChangedBase
	{
		private int count = 50;

		public int Count
		{
			get { return count; }
			set
			{
				count = value;
				NotifyOfPropertyChange(() => Count);
				NotifyOfPropertyChange(() => CanIncrementCount);
			}
		}

		public bool CanIncrementCount
		{
			get { return Count < 60; }
		}

		public void IncrementCount(int delta)
		{
			Count += delta;
		}
	}
}
