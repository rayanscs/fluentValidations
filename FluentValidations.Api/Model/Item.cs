using Newtonsoft.Json;

namespace FluentValidations.Api.Model
{
    public class Item
    {
        [JsonProperty("numero")]
        public int Numero { get; set; }
    }
}
