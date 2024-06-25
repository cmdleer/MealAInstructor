using System.Net.Http;
using System.Text.Json;

namespace MealAInstructor;

public class GPTRequest
{
    
    private static readonly HttpClient client = new HttpClient();

    static async Task Main(string[] args)
    {
        var apiKey = "****";
        var endpoint = "https://api.example.com/chatgpt";

        var userInput = "Hello, how are you?";
        var response = await ChatGPTRequest(userInput, apiKey, endpoint);

        Console.WriteLine("ChatGPT Response:");
        Console.WriteLine(response);
    }

    static async Task<string> ChatGPTRequest(string userInput, string apiKey, string endpoint)
    {
        try
        {
            client.DefaultRequestHeaders.Add("Authorization", $"Bearer {apiKey}");

            var requestData = new { input = userInput };
            var jsonRequest = JsonSerializer.Serialize(requestData);
            var content = new StringContent(jsonRequest, System.Text.Encoding.UTF8, "application/json");

            var httpResponse = await client.PostAsync(endpoint, content);

            if (httpResponse.IsSuccessStatusCode)
            {
                var jsonResponse = await httpResponse.Content.ReadAsStringAsync();
                var responseData = JsonSerializer.Deserialize<dynamic>(jsonResponse);
                return responseData.output;
            }
            else
            {
                Console.WriteLine($"Request failed: {httpResponse.StatusCode}");
                return null;
            }
        }
        catch (Exception ex)
        {
            Console.WriteLine($"Exception: {ex.Message}");
            return null;
        }
    }
}