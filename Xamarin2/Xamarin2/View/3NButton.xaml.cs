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
	public partial class _3NButton : ContentPage
	{
		public _3NButton()
		{
			InitializeComponent();
		}
		async void OnButtonClicked(object sender, EventArgs e)
		{
			(sender as Button).Text = "Click me again!";
		}
		async void OnButtonClicked2(object sender, EventArgs e)
		{
			(sender as Button).Text = "Click me again 2!";
		}
	}
}