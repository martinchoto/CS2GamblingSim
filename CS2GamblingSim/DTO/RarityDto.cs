using Newtonsoft.Json;
using System.Text.Json.Serialization;

namespace CS2GamblingSim.DTO
{
	public class RarityDto
	{
		[JsonProperty("id")]
		public string Id { get; set; }
		[JsonProperty("name")]
		public string Name { get; set; }
		[JsonProperty("color")]
		public string Color { get; set; }
	}
}
