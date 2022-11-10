using System;
namespace Login.Api.Model
{
	public class User
	{
		public string? FristName { get; set; }

		public string? LastName { get; set; }

		public Contact Contact { get; set; } = new Contact();

		public Address Address { get; set; } = new Address();
	}
}

