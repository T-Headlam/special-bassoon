using System;
namespace Login.Api.Response
{
	public class BaseResponse
	{
		public int ResponseCode { get; set; }
		public string? ResponseMessage { get; set; }
		public Guid CorrelationId { get; set; }
	}
}

