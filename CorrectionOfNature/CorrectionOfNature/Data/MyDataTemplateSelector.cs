using CorrectionOfNature.CustomCells;
using CorrectionOfNature.Tables;
using System;
using System.Collections.Generic;
using System.Text;
using Xamarin.Forms;

namespace CorrectionOfNature.Data
{
	class MyDataTemplateSelector : Xamarin.Forms.DataTemplateSelector
	{
		public MyDataTemplateSelector()
		{
			this.incomingDataTemplate = new DataTemplate(typeof(IncomingViewCell));
			this.outgoingDataTemplate = new DataTemplate(typeof(OutgoingViewCell));
		}

		protected override DataTemplate OnSelectTemplate(object item, BindableObject container)
		{
			var messageVm = item as Message;
			if (messageVm == null)
				return null;
			return messageVm.IsIncoming ? this.incomingDataTemplate : this.outgoingDataTemplate;
		}

		private readonly DataTemplate incomingDataTemplate;
		private readonly DataTemplate outgoingDataTemplate;
	}
}
