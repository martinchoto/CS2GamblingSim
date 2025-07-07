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
		public async Task<CasesDto> GetCaseAsync(string caseId)
		{
			Console.WriteLine($"Fetching case with ID: {caseId}");
			var data = await _httpClient.GetStringAsync(Constants.CS2CASESAPI);
			var json = JsonConvert.DeserializeObject<List<CasesDto>>(data);
			return json.FirstOrDefault(c => c.Id == caseId) ?? null;
		}
	}
}
