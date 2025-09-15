using System;
using System.Net.Http;
using System.Net.Http.Headers;
using System.Threading.Tasks;

namespace IFPAWrapper
{
    public class IfpaApiClient : IIfpaApiClient
    {
        private readonly HttpClient _httpClient;
        private readonly string _apiKey;
        private const string BaseUrl = "https://api.ifpapinball.com/";

        public IfpaApiClient(string apiKey, HttpClient httpClient = null)
        {
            _apiKey = apiKey ?? throw new ArgumentNullException(nameof(apiKey));
            _httpClient = httpClient ?? new HttpClient();
            _httpClient.BaseAddress = new Uri(BaseUrl);
            _httpClient.DefaultRequestHeaders.Add("X-API-Key", _apiKey);
        }

        public async Task<Models.Director> GetDirectorAsync(int directorId)
        {
            var response = await _httpClient.GetAsync($"director/{directorId}");
            response.EnsureSuccessStatusCode();
            var json = await response.Content.ReadAsStringAsync();
            return System.Text.Json.JsonSerializer.Deserialize<Models.Director>(json);
        }

        public async Task<Models.Tournament> GetTournamentAsync(int tournamentId)
        {
            var response = await _httpClient.GetAsync($"tournament/{tournamentId}");
            response.EnsureSuccessStatusCode();
            var json = await response.Content.ReadAsStringAsync();
            return System.Text.Json.JsonSerializer.Deserialize<Models.Tournament>(json);
        }

        public async Task<Models.Player> GetPlayerAsync(int playerId)
        {
            var response = await _httpClient.GetAsync($"player/{playerId}");
            response.EnsureSuccessStatusCode();
            var json = await response.Content.ReadAsStringAsync();
            return System.Text.Json.JsonSerializer.Deserialize<Models.Player>(json);
        }

        public async Task<Models.PlayerMultiResponse> GetPlayersAsync(string playerIds)
        {
            var response = await _httpClient.GetAsync($"player?players={playerIds}");
            response.EnsureSuccessStatusCode();
            var json = await response.Content.ReadAsStringAsync();
            return System.Text.Json.JsonSerializer.Deserialize<Models.PlayerMultiResponse>(json);
        }

        public async Task<Models.PlayerPvpResponse> GetPlayerPvpAsync(int playerId)
        {
            var response = await _httpClient.GetAsync($"player/{playerId}/pvp");
            response.EnsureSuccessStatusCode();
            var json = await response.Content.ReadAsStringAsync();
            return System.Text.Json.JsonSerializer.Deserialize<Models.PlayerPvpResponse>(json);
        }

        public async Task<Models.PlayerPvpToPlayerResponse> GetPlayerPvpToPlayerAsync(int playerId, int otherPlayerId)
        {
            var response = await _httpClient.GetAsync($"player/{playerId}/pvp/{otherPlayerId}");
            response.EnsureSuccessStatusCode();
            var json = await response.Content.ReadAsStringAsync();
            return System.Text.Json.JsonSerializer.Deserialize<Models.PlayerPvpToPlayerResponse>(json);
        }

        public async Task<Models.PlayerRankHistoryResponse> GetPlayerRankHistoryAsync(int playerId)
        {
            var response = await _httpClient.GetAsync($"player/{playerId}/rank_history");
            response.EnsureSuccessStatusCode();
            var json = await response.Content.ReadAsStringAsync();
            return System.Text.Json.JsonSerializer.Deserialize<Models.PlayerRankHistoryResponse>(json);
        }

        public async Task<Models.PlayerResultsResponse> GetPlayerResultsAsync(int playerId, string rankingSystem, string type)
        {
            var response = await _httpClient.GetAsync($"player/{playerId}/results/{rankingSystem}/{type}");
            response.EnsureSuccessStatusCode();
            var json = await response.Content.ReadAsStringAsync();
            return System.Text.Json.JsonSerializer.Deserialize<Models.PlayerResultsResponse>(json);
        }

        public async Task<Models.PlayerSearchResponse> SearchPlayersAsync(string name = null, string country = null, string stateprov = null, string tournament = null, int? tourpos = null)
        {
            var url = "player/search?";
            if (!string.IsNullOrEmpty(name)) url += $"name={Uri.EscapeDataString(name)}&";
            if (!string.IsNullOrEmpty(country)) url += $"country={Uri.EscapeDataString(country)}&";
            if (!string.IsNullOrEmpty(stateprov)) url += $"stateprov={Uri.EscapeDataString(stateprov)}&";
            if (!string.IsNullOrEmpty(tournament)) url += $"tournament={Uri.EscapeDataString(tournament)}&";
            if (tourpos.HasValue) url += $"tourpos={tourpos.Value}&";
            var response = await _httpClient.GetAsync(url.TrimEnd('&'));
            response.EnsureSuccessStatusCode();
            var json = await response.Content.ReadAsStringAsync();
            return System.Text.Json.JsonSerializer.Deserialize<Models.PlayerSearchResponse>(json);
        }

        public async Task<Models.DirectorSearchResponse> SearchDirectorsAsync(string name = null, string country = null, string stateprov = null, string city = null)
        {
            var url = "director/search?";
            if (!string.IsNullOrEmpty(name)) url += $"name={Uri.EscapeDataString(name)}&";
            if (!string.IsNullOrEmpty(country)) url += $"country={Uri.EscapeDataString(country)}&";
            if (!string.IsNullOrEmpty(stateprov)) url += $"stateprov={Uri.EscapeDataString(stateprov)}&";
            if (!string.IsNullOrEmpty(city)) url += $"city={Uri.EscapeDataString(city)}&";
            var response = await _httpClient.GetAsync(url.TrimEnd('&'));
            response.EnsureSuccessStatusCode();
            var json = await response.Content.ReadAsStringAsync();
            return System.Text.Json.JsonSerializer.Deserialize<Models.DirectorSearchResponse>(json);
        }

        public async Task<Models.DirectorTournamentsResponse> GetDirectorTournamentsAsync(int directorId)
        {
            var response = await _httpClient.GetAsync($"director/{directorId}/tournaments");
            response.EnsureSuccessStatusCode();
            var json = await response.Content.ReadAsStringAsync();
            return System.Text.Json.JsonSerializer.Deserialize<Models.DirectorTournamentsResponse>(json);
        }

        public async Task<Models.RankingResponse> GetGlobalRankingsAsync(string system = "MAIN", int? page = null)
        {
            var url = $"rankings/{system}";
            if (page.HasValue) url += $"?page={page.Value}";
            var response = await _httpClient.GetAsync(url);
            response.EnsureSuccessStatusCode();
            var json = await response.Content.ReadAsStringAsync();
            return System.Text.Json.JsonSerializer.Deserialize<Models.RankingResponse>(json);
        }

        public async Task<Models.CountryRankingResponse> GetCountryRankingsAsync(string countryCode, string system = "MAIN", int? page = null)
        {
            var url = $"rankings/{system}/country/{countryCode}";
            if (page.HasValue) url += $"?page={page.Value}";
            var response = await _httpClient.GetAsync(url);
            response.EnsureSuccessStatusCode();
            var json = await response.Content.ReadAsStringAsync();
            return System.Text.Json.JsonSerializer.Deserialize<Models.CountryRankingResponse>(json);
        }

        public async Task<Models.StateRankingResponse> GetStateRankingsAsync(string countryCode, string stateProv, string system = "MAIN", int? page = null)
        {
            var url = $"rankings/{system}/country/{countryCode}/stateprov/{stateProv}";
            if (page.HasValue) url += $"?page={page.Value}";
            var response = await _httpClient.GetAsync(url);
            response.EnsureSuccessStatusCode();
            var json = await response.Content.ReadAsStringAsync();
            return System.Text.Json.JsonSerializer.Deserialize<Models.StateRankingResponse>(json);
        }

        public async Task<Models.RegionRankingResponse> GetRegionRankingsAsync(string regionCode, string system = "MAIN", int? page = null)
        {
            var url = $"rankings/{system}/region/{regionCode}";
            if (page.HasValue) url += $"?page={page.Value}";
            var response = await _httpClient.GetAsync(url);
            response.EnsureSuccessStatusCode();
            var json = await response.Content.ReadAsStringAsync();
            return System.Text.Json.JsonSerializer.Deserialize<Models.RegionRankingResponse>(json);
        }

        public async Task<Models.SeriesRankingResponse> GetSeriesRankingsAsync(string seriesCode, int year, string system = "MAIN", int? page = null)
        {
            var url = $"rankings/{system}/series/{seriesCode}/{year}";
            if (page.HasValue) url += $"?page={page.Value}";
            var response = await _httpClient.GetAsync(url);
            response.EnsureSuccessStatusCode();
            var json = await response.Content.ReadAsStringAsync();
            return System.Text.Json.JsonSerializer.Deserialize<Models.SeriesRankingResponse>(json);
        }

        public async Task<Models.SeriesListResponse> GetSeriesListAsync(string regionCode = null, int? year = null)
        {
            var url = "series?";
            if (!string.IsNullOrEmpty(regionCode)) url += $"region_code={Uri.EscapeDataString(regionCode)}&";
            if (year.HasValue) url += $"year={year.Value}&";
            var response = await _httpClient.GetAsync(url.TrimEnd('&'));
            response.EnsureSuccessStatusCode();
            var json = await response.Content.ReadAsStringAsync();
            return System.Text.Json.JsonSerializer.Deserialize<Models.SeriesListResponse>(json);
        }

        public async Task<Models.SeriesResponse> GetSeriesAsync(string seriesCode, int year)
        {
            var response = await _httpClient.GetAsync($"series/{seriesCode}/{year}");
            response.EnsureSuccessStatusCode();
            var json = await response.Content.ReadAsStringAsync();
            return System.Text.Json.JsonSerializer.Deserialize<Models.SeriesResponse>(json);
        }

        public async Task<Models.StatsResponse> GetGlobalStatsAsync(string system = "MAIN", int? page = null)
        {
            var url = $"stats/{system}";
            if (page.HasValue) url += $"?page={page.Value}";
            var response = await _httpClient.GetAsync(url);
            response.EnsureSuccessStatusCode();
            var json = await response.Content.ReadAsStringAsync();
            return System.Text.Json.JsonSerializer.Deserialize<Models.StatsResponse>(json);
        }

        public async Task<Models.StatsResponse> GetCountryStatsAsync(string countryCode, string system = "MAIN", int? page = null)
        {
            var url = $"stats/{system}/country/{countryCode}";
            if (page.HasValue) url += $"?page={page.Value}";
            var response = await _httpClient.GetAsync(url);
            response.EnsureSuccessStatusCode();
            var json = await response.Content.ReadAsStringAsync();
            return System.Text.Json.JsonSerializer.Deserialize<Models.StatsResponse>(json);
        }

        public async Task<Models.StatsResponse> GetStateStatsAsync(string countryCode, string stateProv, string system = "MAIN", int? page = null)
        {
            var url = $"stats/{system}/country/{countryCode}/stateprov/{stateProv}";
            if (page.HasValue) url += $"?page={page.Value}";
            var response = await _httpClient.GetAsync(url);
            response.EnsureSuccessStatusCode();
            var json = await response.Content.ReadAsStringAsync();
            return System.Text.Json.JsonSerializer.Deserialize<Models.StatsResponse>(json);
        }

        public async Task<Models.StatsResponse> GetRegionStatsAsync(string regionCode, string system = "MAIN", int? page = null)
        {
            var url = $"stats/{system}/region/{regionCode}";
            if (page.HasValue) url += $"?page={page.Value}";
            var response = await _httpClient.GetAsync(url);
            response.EnsureSuccessStatusCode();
            var json = await response.Content.ReadAsStringAsync();
            return System.Text.Json.JsonSerializer.Deserialize<Models.StatsResponse>(json);
        }

        public async Task<Models.TournamentSearchResponse> SearchTournamentsAsync(string name = null, string country = null, string stateprov = null, string city = null, int? directorId = null, int? year = null)
        {
            var url = "tournament/search?";
            if (!string.IsNullOrEmpty(name)) url += $"name={Uri.EscapeDataString(name)}&";
            if (!string.IsNullOrEmpty(country)) url += $"country={Uri.EscapeDataString(country)}&";
            if (!string.IsNullOrEmpty(stateprov)) url += $"stateprov={Uri.EscapeDataString(stateprov)}&";
            if (!string.IsNullOrEmpty(city)) url += $"city={Uri.EscapeDataString(city)}&";
            if (directorId.HasValue) url += $"director_id={directorId.Value}&";
            if (year.HasValue) url += $"year={year.Value}&";
            var response = await _httpClient.GetAsync(url.TrimEnd('&'));
            response.EnsureSuccessStatusCode();
            var json = await response.Content.ReadAsStringAsync();
            return System.Text.Json.JsonSerializer.Deserialize<Models.TournamentSearchResponse>(json);
        }

        public async Task<Models.TournamentResultsResponse> GetTournamentResultsAsync(int tournamentId)
        {
            var response = await _httpClient.GetAsync($"tournament/{tournamentId}/results");
            response.EnsureSuccessStatusCode();
            var json = await response.Content.ReadAsStringAsync();
            return System.Text.Json.JsonSerializer.Deserialize<Models.TournamentResultsResponse>(json);
        }
    }
}
