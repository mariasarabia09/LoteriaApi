using Newtonsoft.Json;

namespace LoteriaApi.Models
{
    public class Card
    {
        [JsonProperty("cardId")]
        public int Id { get; set; }
        [JsonProperty("cardNameSpanish")]
        public string SpanishName { get; set; }
        [JsonProperty("cardNameEnglish")]
        public string EnglishName { get; set; }
        [JsonProperty("imageUrl")]
        public string ImageUrl { get; set; }
    }
}