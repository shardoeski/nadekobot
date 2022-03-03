﻿using Newtonsoft.Json;

namespace NadekoBot
{
    public class SmartTextEmbedFooter
    {
        public string Text { get; set; }
        public string IconUrl { get; set; }
        [JsonProperty("icon_url")]
        private string Icon_Url { set => IconUrl = value; }
    }
}