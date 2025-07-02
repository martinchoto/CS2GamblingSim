using Newtonsoft.Json;

namespace CS2GamblingSim.DTO
{
	public class SkinDto
	{
		[JsonProperty("id")]
		public string Id { get; set; }
		[JsonProperty("name")]
		public string Name { get; set; }
		[JsonProperty("image")]
		public string Image { get; set; }
		[JsonProperty("rarity")]
		public RarityDto Rarity { get; set; }
	}
}
