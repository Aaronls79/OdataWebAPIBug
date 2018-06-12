using System.Runtime.Serialization;
using Newtonsoft.Json;

namespace OdataWebAPI.Models
{
    [DataContract(Name = "keyValue")]
    public class KeyValue
    {
        
        [JsonProperty("key")]
        [DataMember(Name = "key")]
        public string Key { get; set; }

        [JsonProperty("value")]
        [DataMember(Name = "value")]
        public string Value { get; set; }

        public KeyValue(string key, string value)
        {
            this.Key = key;
            this.Value = value;
        }

        public KeyValue()
        { }
    }
}