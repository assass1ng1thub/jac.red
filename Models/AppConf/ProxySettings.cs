﻿using System.Collections.Generic;

namespace JacRed.Models.AppConf
{
    public class ProxySettings
    {
        public string pattern;

        public bool useAuth;

        public bool BypassOnLocal;

        public string username;

        public string password;

        public List<string> list;
    }
}
