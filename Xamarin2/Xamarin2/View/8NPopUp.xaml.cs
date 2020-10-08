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
	public partial class _8NPopUp : ContentPage
	{
		public _8NPopUp()
		{
			InitializeComponent();
		}
		async void OnDisplayAlertButtonClicked(object sender, EventArgs e)
		{
			await DisplayAlert("Alert", "This is an alert.", "OK");
		}

		async void OnDisplayAlertQuestionButtonClicked(object sender, EventArgs e)
		{
			bool response = await DisplayAlert("Save?", "Would you like to save your data?", "Yes", "No");
			Console.WriteLine("Save data: " + response);
		}
		async void OnDisplayActionSheetButtonClicked(object sender, EventArgs e)
		{
			string action = await DisplayActionSheet("Send to?", "Cancel", null, "Email", "Twitter", "Facebook");
			Console.WriteLine("Action: " + action);
		}
	}
}