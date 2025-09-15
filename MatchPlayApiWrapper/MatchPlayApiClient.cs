using System;
using System.Collections.Generic;
using System.Net.Http;
using System.Net.Http.Headers;
using System.Threading.Tasks;
using Newtonsoft.Json;

namespace MatchPlayApiWrapper
{
    /// <summary>
    /// Provides methods for interacting with the MatchPlay API.
    /// </summary>
    /// <seealso href="https://api.matchplay.com/docs">MatchPlay API Documentation</seealso>
    public class MatchPlayApiClient
    {
        private readonly HttpClient _httpClient;

        /// <summary>
        /// Initializes a new instance of the MatchPlayApiClient class.
        /// </summary>
        /// <param name="baseUrl">The base URL of the MatchPlay API.</param>
        /// <param name="bearerToken">The bearer token for authentication.</param>
        public MatchPlayApiClient(string baseUrl, string bearerToken)
        {
            _httpClient = new HttpClient { BaseAddress = new Uri(baseUrl) };
            _httpClient.DefaultRequestHeaders.Authorization = new AuthenticationHeaderValue("Bearer", bearerToken);
        }

        /// <summary>
        /// Retrieves a list of all tournaments.
        /// </summary>
        /// <returns>A list of Tournament POCOs.</returns>
        public async Task<List<Models.Tournament>> GetTournamentsAsync()
        {
            var response = await _httpClient.GetAsync("/api/tournaments");
            response.EnsureSuccessStatusCode();
            var json = await response.Content.ReadAsStringAsync();
            return JsonConvert.DeserializeObject<List<Models.Tournament>>(json) ?? new List<Models.Tournament>();
        }

        /// <summary>
        /// Retrieves a specific tournament by its ID.
        /// </summary>
        /// <param name="tournamentId">The tournament ID.</param>
        /// <returns>A Tournament POCO.</returns>
        public async Task<Models.Tournament> GetTournamentByIdAsync(int tournamentId)
        {
            var response = await _httpClient.GetAsync($"/api/tournaments/{tournamentId}");
            response.EnsureSuccessStatusCode();
            var json = await response.Content.ReadAsStringAsync();
            return JsonConvert.DeserializeObject<Models.Tournament>(json);
        }

        /// <summary>
        /// Retrieves Amazing Race details for a tournament.
        /// </summary>
        /// <param name="tournamentId">The tournament ID.</param>
        /// <returns>An AmazingRace POCO.</returns>
        public async Task<Models.AmazingRace> GetAmazingRaceAsync(int tournamentId)
        {
            var response = await _httpClient.GetAsync($"/api/tournaments/{tournamentId}/amazing-race");
            response.EnsureSuccessStatusCode();
            var json = await response.Content.ReadAsStringAsync();
            return JsonConvert.DeserializeObject<Models.AmazingRace>(json);
        }

        /// <summary>
        /// Retrieves Frenzy details for a tournament.
        /// </summary>
        /// <param name="tournamentId">The tournament ID.</param>
        /// <returns>A Frenzy POCO.</returns>
        public async Task<Models.Frenzy> GetFrenzyAsync(int tournamentId)
        {
            var response = await _httpClient.GetAsync($"/api/tournaments/{tournamentId}/frenzy");
            response.EnsureSuccessStatusCode();
            var json = await response.Content.ReadAsStringAsync();
            return JsonConvert.DeserializeObject<Models.Frenzy>(json);
        }

        /// <summary>
        /// Retrieves Max Matchplay details for a tournament.
        /// </summary>
        /// <param name="tournamentId">The tournament ID.</param>
        /// <returns>A MaxMatchplay POCO.</returns>
        public async Task<Models.MaxMatchplay> GetMaxMatchplayAsync(int tournamentId)
        {
            var response = await _httpClient.GetAsync($"/api/tournaments/{tournamentId}/max-matchplay");
            response.EnsureSuccessStatusCode();
            var json = await response.Content.ReadAsStringAsync();
            return JsonConvert.DeserializeObject<Models.MaxMatchplay>(json);
        }

        /// <summary>
        /// Retrieves all single player games for a tournament.
        /// </summary>
        /// <param name="tournamentId">The tournament ID.</param>
        /// <returns>A list of SinglePlayerGame POCOs.</returns>
        public async Task<List<Models.SinglePlayerGame>> GetSinglePlayerGamesAsync(int tournamentId)
        {
            var response = await _httpClient.GetAsync($"/api/tournaments/{tournamentId}/single-player-games");
            response.EnsureSuccessStatusCode();
            var json = await response.Content.ReadAsStringAsync();
            return JsonConvert.DeserializeObject<List<Models.SinglePlayerGame>>(json) ?? new List<Models.SinglePlayerGame>();
        }

        /// <summary>
        /// Retrieves single player games as CSV for a tournament.
        /// </summary>
        /// <param name="tournamentId">The tournament ID.</param>
        /// <returns>CSV string of single player games.</returns>
        public async Task<string> GetSinglePlayerGamesCsvAsync(int tournamentId)
        {
            var response = await _httpClient.GetAsync($"/api/tournaments/{tournamentId}/single-player-games/csv");
            response.EnsureSuccessStatusCode();
            return await response.Content.ReadAsStringAsync();
        }

        /// <summary>
        /// Retrieves top scores for single player games in a tournament.
        /// </summary>
        /// <param name="tournamentId">The tournament ID.</param>
        /// <returns>A list of TopScore POCOs.</returns>
        public async Task<List<Models.TopScore>> GetSinglePlayerGamesTopScoresAsync(int tournamentId)
        {
            var response = await _httpClient.GetAsync($"/api/tournaments/{tournamentId}/single-player-games/top-scores");
            response.EnsureSuccessStatusCode();
            var json = await response.Content.ReadAsStringAsync();
            return JsonConvert.DeserializeObject<List<Models.TopScore>>(json) ?? new List<Models.TopScore>();
        }

        /// <summary>
        /// Retrieves a single player game by its ID for a tournament.
        /// </summary>
        /// <param name="tournamentId">The tournament ID.</param>
        /// <param name="gameId">The game ID.</param>
        /// <returns>A SinglePlayerGame POCO.</returns>
        public async Task<Models.SinglePlayerGame> GetSinglePlayerGameByIdAsync(int tournamentId, int gameId)
        {
            var response = await _httpClient.GetAsync($"/api/tournaments/{tournamentId}/single-player-games/{gameId}");
            response.EnsureSuccessStatusCode();
            var json = await response.Content.ReadAsStringAsync();
            return JsonConvert.DeserializeObject<Models.SinglePlayerGame>(json);
        }

        /// <summary>
        /// Retrieves all cards for a tournament.
        /// </summary>
        /// <param name="tournamentId">The tournament ID.</param>
        /// <returns>A list of Card POCOs.</returns>
        public async Task<List<Models.Card>> GetCardsAsync(int tournamentId)
        {
            var response = await _httpClient.GetAsync($"/api/tournaments/{tournamentId}/cards");
            response.EnsureSuccessStatusCode();
            var json = await response.Content.ReadAsStringAsync();
            return JsonConvert.DeserializeObject<List<Models.Card>>(json) ?? new List<Models.Card>();
        }

        /// <summary>
        /// Retrieves a card by its ID for a tournament.
        /// </summary>
        /// <param name="tournamentId">The tournament ID.</param>
        /// <param name="cardId">The card ID.</param>
        /// <returns>A Card POCO.</returns>
        public async Task<Models.Card> GetCardByIdAsync(int tournamentId, int cardId)
        {
            var response = await _httpClient.GetAsync($"/api/tournaments/{tournamentId}/cards/{cardId}");
            response.EnsureSuccessStatusCode();
            var json = await response.Content.ReadAsStringAsync();
            return JsonConvert.DeserializeObject<Models.Card>(json);
        }

        /// <summary>
        /// Retrieves all queues for a tournament.
        /// </summary>
        /// <param name="tournamentId">The tournament ID.</param>
        /// <returns>A list of Queue POCOs.</returns>
        public async Task<List<Models.Queue>> GetQueuesAsync(int tournamentId)
        {
            var response = await _httpClient.GetAsync($"/api/tournaments/{tournamentId}/queues");
            response.EnsureSuccessStatusCode();
            var json = await response.Content.ReadAsStringAsync();
            return JsonConvert.DeserializeObject<List<Models.Queue>>(json) ?? new List<Models.Queue>();
        }

        /// <summary>
        /// Retrieves matchplay statistics for a tournament.
        /// </summary>
        /// <param name="tournamentId">The tournament ID.</param>
        /// <returns>A MatchplayStats POCO.</returns>
        public async Task<Models.MatchplayStats> GetMatchplayStatsAsync(int tournamentId)
        {
            var response = await _httpClient.GetAsync($"/api/tournaments/{tournamentId}/stats/matchplay");
            response.EnsureSuccessStatusCode();
            var json = await response.Content.ReadAsStringAsync();
            return JsonConvert.DeserializeObject<Models.MatchplayStats>(json);
        }

        /// <summary>
        /// Retrieves round statistics for a tournament.
        /// </summary>
        /// <param name="tournamentId">The tournament ID.</param>
        /// <returns>A list of RoundStats POCOs.</returns>
        public async Task<List<Models.RoundStats>> GetRoundStatsAsync(int tournamentId)
        {
            var response = await _httpClient.GetAsync($"/api/tournaments/{tournamentId}/stats/rounds");
            response.EnsureSuccessStatusCode();
            var json = await response.Content.ReadAsStringAsync();
            return JsonConvert.DeserializeObject<List<Models.RoundStats>>(json) ?? new List<Models.RoundStats>();
        }

        /// <summary>
        /// Retrieves arena statistics for a tournament.
        /// </summary>
        /// <param name="tournamentId">The tournament ID.</param>
        /// <returns>A list of ArenaStats POCOs.</returns>
        public async Task<List<Models.ArenaStats>> GetArenaStatsAsync(int tournamentId)
        {
            var response = await _httpClient.GetAsync($"/api/tournaments/{tournamentId}/stats/arenas");
            response.EnsureSuccessStatusCode();
            var json = await response.Content.ReadAsStringAsync();
            return JsonConvert.DeserializeObject<List<Models.ArenaStats>>(json) ?? new List<Models.ArenaStats>();
        }

        /// <summary>
        /// Retrieves player statistics for a tournament.
        /// </summary>
        /// <param name="tournamentId">The tournament ID.</param>
        /// <returns>A list of PlayerStats POCOs.</returns>
        public async Task<List<Models.PlayerStats>> GetPlayerStatsAsync(int tournamentId)
        {
            var response = await _httpClient.GetAsync($"/api/tournaments/{tournamentId}/stats/players");
            response.EnsureSuccessStatusCode();
            var json = await response.Content.ReadAsStringAsync();
            return JsonConvert.DeserializeObject<List<Models.PlayerStats>>(json) ?? new List<Models.PlayerStats>();
        }

        /// <summary>
        /// Retrieves match statistics for a tournament.
        /// </summary>
        /// <param name="tournamentId">The tournament ID.</param>
        /// <returns>A list of MatchStats POCOs.</returns>
        public async Task<List<Models.MatchStats>> GetMatchStatsAsync(int tournamentId)
        {
            var response = await _httpClient.GetAsync($"/api/tournaments/{tournamentId}/stats/matches");
            response.EnsureSuccessStatusCode();
            var json = await response.Content.ReadAsStringAsync();
            return JsonConvert.DeserializeObject<List<Models.MatchStats>>(json) ?? new List<Models.MatchStats>();
        }

        /// <summary>
        /// Retrieves best game statistics for a tournament.
        /// </summary>
        /// <param name="tournamentId">The tournament ID.</param>
        /// <returns>A BestGameStats POCO.</returns>
        public async Task<Models.BestGameStats> GetBestGameStatsAsync(int tournamentId)
        {
            var response = await _httpClient.GetAsync($"/api/tournaments/{tournamentId}/stats/bestgame");
            response.EnsureSuccessStatusCode();
            var json = await response.Content.ReadAsStringAsync();
            return JsonConvert.DeserializeObject<Models.BestGameStats>(json);
        }

        /// <summary>
        /// Retrieves players as CSV for a tournament.
        /// </summary>
        /// <param name="tournamentId">The tournament ID.</param>
        /// <returns>CSV string of players.</returns>
        public async Task<string> GetPlayersCsvAsync(int tournamentId)
        {
            var response = await _httpClient.GetAsync($"/api/tournaments/{tournamentId}/players/csv");
            response.EnsureSuccessStatusCode();
            return await response.Content.ReadAsStringAsync();
        }

        /// <summary>
        /// Retrieves arena background summary for a tournament.
        /// </summary>
        /// <param name="tournamentId">The tournament ID.</param>
        /// <returns>A list of ArenaBgSummary POCOs.</returns>
        public async Task<List<Models.ArenaBgSummary>> GetArenaBgSummaryAsync(int tournamentId)
        {
            var response = await _httpClient.GetAsync($"/api/tournaments/{tournamentId}/arenas/bgsummary");
            response.EnsureSuccessStatusCode();
            var json = await response.Content.ReadAsStringAsync();
            return JsonConvert.DeserializeObject<List<Models.ArenaBgSummary>>(json) ?? new List<Models.ArenaBgSummary>();
        }

        /// <summary>
        /// Retrieves arena background details for a specific arena in a tournament.
        /// </summary>
        /// <param name="tournamentId">The tournament ID.</param>
        /// <param name="arenaId">The arena ID.</param>
        /// <returns>An ArenaBgDetails POCO.</returns>
        public async Task<Models.ArenaBgDetails> GetArenaBgDetailsAsync(int tournamentId, int arenaId)
        {
            var response = await _httpClient.GetAsync($"/api/tournaments/{tournamentId}/arenas/{arenaId}/bgdetails");
            response.EnsureSuccessStatusCode();
            var json = await response.Content.ReadAsStringAsync();
            return JsonConvert.DeserializeObject<Models.ArenaBgDetails>(json);
        }

        /// <summary>
        /// Retrieves all games for a tournament.
        /// </summary>
        /// <param name="tournamentId">The tournament ID.</param>
        /// <returns>A list of Game POCOs.</returns>
        public async Task<List<Models.Game>> GetGamesAsync(int tournamentId)
        {
            var response = await _httpClient.GetAsync($"/api/tournaments/{tournamentId}/games");
            response.EnsureSuccessStatusCode();
            var json = await response.Content.ReadAsStringAsync();
            return JsonConvert.DeserializeObject<List<Models.Game>>(json) ?? new List<Models.Game>();
        }

        /// <summary>
        /// Retrieves games as CSV for a tournament.
        /// </summary>
        /// <param name="tournamentId">The tournament ID.</param>
        /// <returns>CSV string of games.</returns>
        public async Task<string> GetGamesCsvAsync(int tournamentId)
        {
            var response = await _httpClient.GetAsync($"/api/tournaments/{tournamentId}/games/csv");
            response.EnsureSuccessStatusCode();
            return await response.Content.ReadAsStringAsync();
        }

        /// <summary>
        /// Retrieves a game by its ID for a tournament.
        /// </summary>
        /// <param name="tournamentId">The tournament ID.</param>
        /// <param name="gameId">The game ID.</param>
        /// <returns>A Game POCO.</returns>
        public async Task<Models.Game> GetGameByIdAsync(int tournamentId, int gameId)
        {
            var response = await _httpClient.GetAsync($"/api/tournaments/{tournamentId}/games/{gameId}");
            response.EnsureSuccessStatusCode();
            var json = await response.Content.ReadAsStringAsync();
            return JsonConvert.DeserializeObject<Models.Game>(json);
        }

        /// <summary>
        /// Retrieves all rounds for a tournament.
        /// </summary>
        /// <param name="tournamentId">The tournament ID.</param>
        /// <returns>A list of Round POCOs.</returns>
        public async Task<List<Models.Round>> GetRoundsAsync(int tournamentId)
        {
            var response = await _httpClient.GetAsync($"/api/tournaments/{tournamentId}/rounds");
            response.EnsureSuccessStatusCode();
            var json = await response.Content.ReadAsStringAsync();
            return JsonConvert.DeserializeObject<List<Models.Round>>(json) ?? new List<Models.Round>();
        }

        /// <summary>
        /// Retrieves all standings for a tournament.
        /// </summary>
        /// <param name="tournamentId">The tournament ID.</param>
        /// <returns>A list of Standing POCOs.</returns>
        public async Task<List<Models.Standing>> GetStandingsAsync(int tournamentId)
        {
            var response = await _httpClient.GetAsync($"/api/tournaments/{tournamentId}/standings");
            response.EnsureSuccessStatusCode();
            var json = await response.Content.ReadAsStringAsync();
            return JsonConvert.DeserializeObject<List<Models.Standing>>(json) ?? new List<Models.Standing>();
        }
    }
}
