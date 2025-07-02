using Newtonsoft.Json;

namespace CS2GamblingSim.DTO
{
	public class CasesDto
	{
		[JsonProperty("id")]
		public string Id { get; set; }
		[JsonProperty("name")]
		public string Name { get; set; }
		[JsonProperty("image")]
		public string Image { get; set; }
		[JsonProperty("contains")]
		public List<SkinDto> Skins { get; set; } = new List<SkinDto>();
	}
}
