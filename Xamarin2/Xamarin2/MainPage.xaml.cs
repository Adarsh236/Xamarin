using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;
using Xamarin2.View;

namespace Xamarin2
{
	public partial class MainPage : ContentPage
	{
		public MainPage()
		{
			InitializeComponent();
			
		}

		async void StackLayoutClicked(object sender, EventArgs e)
		{
			await Navigation.PushAsync(new _1NStackLayout { });
		}

		async void LabelClicked(object sender, EventArgs e)
		{
			await Navigation.PushAsync(new _2NLabel { });
		}
		async void ButtonClicked(object sender, EventArgs e)
		{
			await Navigation.PushAsync(new _3NButton { });
		}
		async void EntryClicked(object sender, EventArgs e)
		{
			await Navigation.PushAsync(new _4NEntry { });
		}
		async void ImageClicked(object sender, EventArgs e)
		{
			await Navigation.PushAsync(new _5NImage { });
		}
		async void GridClicked(object sender, EventArgs e)
		{
			await Navigation.PushAsync(new _6NGrid { });
		}
		async void ListClicked(object sender, EventArgs e)
		{
			await Navigation.PushAsync(new _7NList { });
		}
		async void PopUpClicked(object sender, EventArgs e)
		{
			await Navigation.PushAsync(new _8NPopUp { });
		}
		async void AppLifeCycleClicked(object sender, EventArgs e)
		{
			await Navigation.PushAsync(new _9NAppLifeCycle { });
		}
	}
}
