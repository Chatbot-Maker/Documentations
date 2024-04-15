using HTTPRequest.Models;

namespace HTTPRequest.Services
{
    public class SuriService
    {
        protected HttpClient _httpClient;

        public SuriService (IConfiguration configuration)
        {
            _httpClient = new HttpClient();
            _httpClient.BaseAddress = new Uri(configuration["ChatbotUrl"]);
            _httpClient.DefaultRequestHeaders.Authorization = new System.Net.Http.Headers.AuthenticationHeaderValue("Bearer", configuration["ChatbotToken"]);
        }

        public async Task<SuriAPIResponse<bool>> AddVariable (string userId, string variableName, string variableValue)
        {
            var response = new SuriAPIResponse<bool>
            {
                Success = false,
                Data = false
            };

            try
            {

                var res = await _httpClient.PostAsync($"api/contacts/{userId}/addvariable?name={variableName}&value={variableValue}", null);
                if (res.IsSuccessStatusCode)
                {
                    response.Success = true;
                    response.Data = true;
                }
            }
            catch (Exception ex)
            {
                // TODO: log error
            }

            return response;
        }
    }
}
