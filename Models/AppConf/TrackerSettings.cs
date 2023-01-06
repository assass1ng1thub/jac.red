﻿namespace JacRed.Models.AppConf
{
    public class TrackerSettings
    {
        public TrackerSettings(string host, bool enable = true, bool useproxy = false, LoginSettings login = null, string priority = null)
        {
            this.host = host;
            this.enable = enable;
            this.useproxy = useproxy;

            if (login != null)
                this.login = login;

            this.priority = priority;
        }


        public string host { get; set; }

        public bool enable { get; set; }

        public string priority { get; set; }

        public bool useproxy { get; set; }

        public LoginSettings login { get; set; } = new LoginSettings();
    }
}
