﻿using System;
using Kuni.Core.UnicardApiProvider;
using Newtonsoft.Json;

namespace Kuni.Core.Models
{
	public class GetUserByPhoneResponse: UnicardApiBaseResponse
	{
		[JsonProperty ("Phone")]
		public string UserPhoneNumber{ get; set; }

		[JsonProperty ("UserId")]
		public string UserId{ get; set; }
	}
}

