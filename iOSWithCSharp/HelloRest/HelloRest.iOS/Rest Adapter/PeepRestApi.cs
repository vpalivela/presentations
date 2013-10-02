using System;
using System.Collections.Generic;
using RestSharp;
using HelloRest.Models;

namespace HelloRest.iOS
{
	public class PeepRestApi
	{
		const string BaseUrl      = "http://localhost:3000/";
		const string PeepResource = "peeps";

		public PeepRestApi ()
		{
		}

		public T Execute<T>(RestRequest request) where T : new()
		{
			var client = new RestClient();
			client.BaseUrl = BaseUrl;
			var response = client.Execute<T>(request);

			if (response.ErrorException != null)
			{
				const string message = "Error retrieving response.  Check inner details for more info.";
				throw new Exception(message, response.ErrorException);
			}
			return response.Data;
		}

		public IList<Person> GetPeeps()
		{
			return Execute<List<Person>>(new RestRequest(PeepResource, Method.GET));
		}

		public void CreatePeep(Person person)
		{
			var request = new RestRequest(PeepResource, Method.POST);
			request.RequestFormat = DataFormat.Json;
			request.AddBody (person);
			Execute<RestResponse> (request);
		}
	}
}