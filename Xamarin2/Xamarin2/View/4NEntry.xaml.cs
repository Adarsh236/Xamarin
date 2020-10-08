using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace Xamarin2.View
{
	[XamlCompilation(XamlCompilationOptions.Compile)]
	public partial class _4NEntry : ContentPage
	{
		public _4NEntry()
		{
			InitializeComponent();
		}

		void OnEntryTextChanged(object sender, TextChangedEventArgs e)
		{
			string oldText = e.OldTextValue;
			string newText = e.NewTextValue;
		}

		void OnEntryCompleted(object sender, EventArgs e)
		{
			string text = ((Entry)sender).Text;
		}

		void OnEditorTextChanged(object sender, TextChangedEventArgs e)
		{
			string oldText = e.OldTextValue;
			string newText = e.NewTextValue;
		}

		void OnEditorCompleted(object sender, EventArgs e)
		{
			string text = ((Editor)sender).Text;
		}
	}
}