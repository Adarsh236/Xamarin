using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;
using Xamarin2.Models;

namespace Xamarin2.ApiServiceView
{
	[XamlCompilation(XamlCompilationOptions.Compile)]
	public partial class WeatherView : ContentPage
	{
		RestService _restService;
		public WeatherView()
		{
			InitializeComponent();
			_restService = new RestService();
		}
		async void OnButtonClicked(object sender, EventArgs e)
		{
			if (!string.IsNullOrWhiteSpace(cityEntry.Text))
			{
				// ApiData apiData = await _restService.RequestPeople(GenerateRequestUri(Constants.OpenWeatherMapEndpoint));
				//BindingContext = apiData;
			}
		}

		string GenerateRequestUri(string endpoint)
		{
			string requestUri = endpoint;
			requestUri += $"{cityEntry.Text}";
			/* requestUri += "&units=imperial"; // or units=metric
			requestUri += $"&APPID={Constants.OpenWeatherMapAPIKey}";*/
			Debug.WriteLine("--------\n");
			Debug.WriteLine(requestUri);
			return requestUri;
		}
	}
}