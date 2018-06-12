using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Runtime.Serialization;
using Newtonsoft.Json;

namespace OdataWebAPI.Models
{
    [DataContract(Name = "KISS")]
    public class KISS
    {

        /// <summary>
        ///     Guid Id, auto populated field.
        /// </summary>
        [Key]
        [DataMember(Name = "id")]
        [JsonProperty("id")]
        public virtual string Id { get; set; }

        [JsonProperty("catalogItems")]
        [DataMember(Name = "catalogItems")]
        public string Name { get; set; }

        /// <summary>
        ///     List of properties that describe the product.
        /// </summary>
        [JsonProperty("properties")]
        [DataMember(Name = "properties")]
        public IEnumerable<KeyValue> Properties { get; set; } = new List<KeyValue>();

    }
}