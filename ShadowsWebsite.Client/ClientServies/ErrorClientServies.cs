using System;
using System.Collections.Generic;
using System.Net.Http;
using System.Text.Json;
using System.Threading.Tasks;
using ShadowsWebsite.Common.Domain;

namespace ShadowsWebsite.Client.ClientServies
{
    public class ErrorClientServies
    {
        private readonly HttpClient _httpClient;

        public ErrorClientServies(HttpClient httpClient)
        {
            _httpClient = httpClient;
        }
        public async Task<IEnumerable<ErrorLogModle>> GetAllErrorLogs()
        {
            IEnumerable<ErrorLogModle> errorLogs = new List<ErrorLogModle>();
            var httpResponse = await _httpClient.GetAsync($"api/errorlog/get-all");
            if (httpResponse.IsSuccessStatusCode)
            {
                try
                {
                    var responseString = await httpResponse.Content.ReadAsStringAsync();
                    if (!string.IsNullOrEmpty(responseString))
                    {
                        errorLogs = JsonSerializer.Deserialize<List<ErrorLogModle>>(responseString,
                            new JsonSerializerOptions() { PropertyNameCaseInsensitive = true });
                    }
                }
                catch (Exception e)
                {
                    Console.WriteLine(e);
                    throw;
                }
            }

            return errorLogs;
        }
    }
}