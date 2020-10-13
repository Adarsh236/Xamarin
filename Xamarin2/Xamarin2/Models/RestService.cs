using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Diagnostics;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;

namespace Xamarin2.Models
{
	public class RestService
	{
		HttpClient _client;

		public RestService()
		{
			_client = new HttpClient();
		}

		public async Task<ApiData> RequestPeople(string uri)
		{
			ApiData apiData = null;
			try
			{
				HttpResponseMessage response = await _client.GetAsync(uri);

				if (response.IsSuccessStatusCode)
				{
					string content = await response.Content.ReadAsStringAsync();
					apiData = JsonConvert.DeserializeObject<ApiData>(content);
				}


			}
			catch (Exception ex)
			{
				Debug.WriteLine("\tERROR {0}", ex.Message);
			}

			return apiData;
		}
	}
}
