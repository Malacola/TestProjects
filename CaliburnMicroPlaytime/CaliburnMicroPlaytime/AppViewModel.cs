using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Caliburn.Micro;
using System.ComponentModel.Composition;
using System.Windows.Media;

namespace CaliburnMicroPlaytime
{
	[Export(typeof(AppViewModel))]
	public class AppViewModel : PropertyChangedBase, IHandle<ColorEvent>
	{
		[ImportingConstructor]
		public AppViewModel(ColorViewModel colorModel, IEventAggregator events)
		{
			ColorModel = colorModel;
			events.Subscribe(this);
		}

		public ColorViewModel ColorModel { get; private set; }

		private SolidColorBrush color;
		public SolidColorBrush Color 
		{ 
			get { return color; }
			set 
			{
				color = value;
				NotifyOfPropertyChange(() => Color);
			}
		}

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


		public void Handle(ColorEvent message)
		{
			Color = message.Color;
		}
	}
}
