using System.Collections.Generic;

using Newtonsoft.Json;

namespace PteroSharp.ApiModels.Server.Console
{
    public partial class ReceiveBaseResponse
    {
        [JsonProperty("event")]
        public string Event { get; set; }

        [JsonProperty("args")]
        public List<string> Args { get; set; }
    }
}
