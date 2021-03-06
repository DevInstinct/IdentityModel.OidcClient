﻿// Copyright (c) Brock Allen & Dominick Baier. All rights reserved.
// Licensed under the Apache License, Version 2.0. See LICENSE in the project root for license information.


namespace IdentityModel.OidcClient
{
    public class Result
    {
        public bool Success => string.IsNullOrWhiteSpace(Error);
        public string Error { get; set; }
    }
}