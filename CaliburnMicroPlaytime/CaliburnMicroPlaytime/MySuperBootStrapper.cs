using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Caliburn.Micro;
using System.ComponentModel.Composition;
using System.ComponentModel.Composition.Hosting;
using System.ComponentModel.Composition.Primitives;

namespace CaliburnMicroPlaytime
{
	public class MySuperBootStrapper : Bootstrapper<AppViewModel>
	{
		private CompositionContainer container;

		protected override void Configure()
		{
			container = new CompositionContainer(new AggregateCatalog(AssemblySource.Instance.Select(x => new AssemblyCatalog(x)).OfType<ComposablePartCatalog>()));

			CompositionBatch batch = new CompositionBatch();

			batch.AddExportedValue<IWindowManager>(new WindowManager());
			batch.AddExportedValue<IEventAggregator>(new EventAggregator());
			batch.AddExportedValue(container);

			container.Compose(batch);
		}

		protected override object GetInstance(Type service, string key)
		{
			string contract = string.IsNullOrEmpty(key) ? AttributedModelServices.GetContractName(service) : key;
			var exports = container.GetExportedValues<object>(contract);

			if (exports.Count() > 0)
				return exports.First();

			throw new Exception(String.Format("Could not locate instance of contract {0}.", contract));
		}
	}
}
