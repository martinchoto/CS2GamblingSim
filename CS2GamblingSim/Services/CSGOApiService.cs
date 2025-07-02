using CS2GamblingSim.Data;
using CS2GamblingSim.DTO;
using Newtonsoft.Json;
using System.Text.Json.Serialization;

namespace CS2GamblingSim.Services
{
	public class CSGOApiService
	{
		private readonly HttpClient _httpClient;

		public CSGOApiService(HttpClient httpClient)
		{
			_httpClient = httpClient;
		}

		public async Task<List<CasesDto>> GetCasesAsync()
		{
			var data = await _httpClient.GetStringAsync(Constants.CS2CASESAPI);

			var json = JsonConvert.DeserializeObject<List<CasesDto>>(data);

			List<CasesDto> allCases = json.Where(c => c.Name.Contains("Case")).ToList();

			return allCases;
		}
		public async Task<CasesDto> GetSkinsAsync(string caseId)
		{
			var data = await _httpClient.GetStringAsync(Constants.CS2CASESAPI);

			var json = JsonConvert.DeserializeObject<List<CasesDto>>(data);
			var crate = json.FirstOrDefault(c => c.Id.Contains(caseId));

			return crate;
		}
	}
}
