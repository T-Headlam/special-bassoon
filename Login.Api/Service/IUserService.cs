using System;
using Login.Api.Model;

namespace Login.Api.Service
{
	public interface IUserService
	{
		public Task Register();
		public Task Login();
	}
}

