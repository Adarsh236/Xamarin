using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;
using Xamarin2.Models;

namespace Xamarin2.ApiServiceView
{
	[XamlCompilation(XamlCompilationOptions.Compile)]
	public partial class PeopleList : ContentPage
	{
		RestService _restService;
		private int pageNo = 0;
		public PeopleList()
		{
			InitializeComponent();
			_restService = new RestService();
		}

		void OnListViewItemSelected(object sender, SelectedItemChangedEventArgs e)
		{
			ApiData selectedItem = e.SelectedItem as ApiData;
		}

		void OnListViewItemTapped(object sender, ItemTappedEventArgs e)
		{
			ApiData tappedItem = e.Item as ApiData;
		}

		private async void GetData()
		{
			HttpClient client = new HttpClient();

			var response = await client.GetStringAsync("https://swapi.dev/api/people/");
			var data = JsonConvert.DeserializeObject<ApiData>(response);

			Debug.WriteLine("--------response\n");
			Debug.WriteLine(response);
			Debug.WriteLine("--------data\n");
			Debug.WriteLine(data);
			//Debug.WriteLine(apiData.ApiDataList[0]);
			listView.ItemsSource = data.Results;
		}

		void OnNextClicked(object sender, EventArgs e)
		{
			if (pageNo > 0) pageNo += 1;
			else pageNo = 1;

			RequestList();
		}

		void OnPreviosClicked(object sender, EventArgs e)
		{
			if (pageNo > 1) pageNo -= 1;
			else pageNo = 1;

			RequestList();
		}

		private async void RequestList()
		{
			ApiData apiData = await _restService.RequestPeople(GenerateRequestUri(Constants.OpenWeatherMapEndpoint));
			listView.ItemsSource = apiData.Results;
			listView.ItemsSource = apiData.Results
				.OrderBy(d => d.Name)
				.ToList();
		}


		string GenerateRequestUri(string endpoint)
		{
			string requestUri = endpoint;
			requestUri += $"?page={pageNo}";
			Debug.WriteLine("--------\n");
			Debug.WriteLine(requestUri);
			return requestUri;
		}
	}
}