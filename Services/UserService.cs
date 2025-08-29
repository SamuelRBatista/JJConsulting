using System.Net.Http.Json;
using JJConsulting.Models;


namespace JJConsulting.Services;


public class UserService : IUserService
{
    private readonly HttpClient _http;
    public UserService(HttpClient http)
    {
        _http = http;
    }


    public async Task<IEnumerable<User>> GetAllAsync(CancellationToken cancellationToken = default)
    {
        var resp = await _http.GetFromJsonAsync<List<User>>("users", cancellationToken);
        return resp ?? new List<User>();
    }


    public async Task<User?> GetByIdAsync(int id, CancellationToken cancellationToken = default)
    {
        return await _http.GetFromJsonAsync<User>($"users/{id}", cancellationToken);
    }
}