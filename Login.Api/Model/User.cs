using System;
using Login.Api.Model.Enum;

namespace Login.Api.Model
{
	public class User
	{
		public int Id { get; set; }

		public string? FirstName { get; set; }

		public string? LastName { get; set; }

		public string? UserName { get; set; }

		public Role Role { get; set; }

		public string? Password { get; set; }
	}
}

