﻿using System;
using System.Collections.Generic;

namespace MicroService.ApiGateway.Ocelot.Dto
{
    [Serializable]
    public class AuthenticationOptionsDto
    {
        public string AuthenticationProviderKey { get; set; }
        public List<string> AllowedScopes { get; set; }
        public AuthenticationOptionsDto()
        {
            AllowedScopes = new List<string>();
        }
    }
}