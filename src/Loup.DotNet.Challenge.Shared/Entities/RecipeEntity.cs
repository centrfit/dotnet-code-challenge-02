using Newtonsoft.Json;

namespace Loup.DotNet.Challenge.Shared.Entities
{
    public class RecipeEntity
    {
        [JsonProperty("contentId")]
        public int ContentId { get; set; }

        [JsonProperty("name")]
        public string Name { get; set; }

        [JsonProperty("summary")]
        public string Summary { get; set; }

        [JsonProperty("servingSize")]
        public int ServingSize { get; set; }

        [JsonProperty("calories")]
        public double Calories { get; set; }
    }
}
