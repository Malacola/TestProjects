using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Caliburn.Micro;
using System.ComponentModel.Composition;
using System.Windows.Media;

namespace CaliburnMicroPlaytime
{
	[Export(typeof(ColorViewModel))]
	public class ColorViewModel : PropertyChangedBase
	{
		private readonly IEventAggregator events;
		[ImportingConstructor]
		public ColorViewModel(IEventAggregator events)
		{
			this.events = events;
		}

		public void Red()
		{
			events.Publish(new ColorEvent(new SolidColorBrush(Colors.Red)));
		}

		public void Green()
		{
			events.Publish(new ColorEvent(new SolidColorBrush(Colors.Green)));
		}

		public void Blue()
		{
			events.Publish(new ColorEvent(new SolidColorBrush(Colors.Blue)));
		}
	}

	public class ColorEvent
	{
		public ColorEvent(SolidColorBrush color)
		{
			this.Color = color;
		}

		public SolidColorBrush Color { get; private set; }
	}
}
