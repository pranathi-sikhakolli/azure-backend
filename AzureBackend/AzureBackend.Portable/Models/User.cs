﻿using AppServiceHelpers.Models;

namespace AzureBackend.Shared
{
    public class User : EntityData
    {
        public string Username { get; set; }
        public string Password { get; set; }
        public string Fullname { get; set; }
        public string Occupation { get; set; }
    }
}
