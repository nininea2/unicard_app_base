﻿using System;
using Kunicardus.Core.UnicardApiProvider;
using Newtonsoft.Json;

namespace Kunicardus.Core.Models.DataTransferObjects
{
	public class AuthRequest : UnicardApiBaseRequest
	{
		[JsonProperty ("user_name")]
		public string UserName {
			get;
			set;
		}

		[JsonProperty ("pass")]
		public string Password {
			get;
			set;
		}

		[JsonProperty ("fb_token")]
		public string FacebookId {
			get;
			set;
		}

		public AuthRequest () : base ()
		{
		}
	}
}

