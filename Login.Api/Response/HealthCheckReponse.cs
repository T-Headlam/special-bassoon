using System;
namespace Login.Api.Response
{
	public class HealthCheckReponse
	{
		public string? Status { get; set; }
		public string? DB { get; set; }
		public string? Cache { get; set; }
	}
}

