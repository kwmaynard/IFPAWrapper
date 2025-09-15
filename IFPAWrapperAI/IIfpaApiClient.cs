using System.Threading.Tasks;
using IFPAWrapper.Models;

namespace IFPAWrapper
{
    public interface IIfpaApiClient
    {
        Task<Director> GetDirectorAsync(int directorId);

        Task<Tournament> GetTournamentAsync(int tournamentId);

        Task<Player> GetPlayerAsync(int playerId);

        Task<PlayerMultiResponse> GetPlayersAsync(string playerIds);

        Task<PlayerPvpResponse> GetPlayerPvpAsync(int playerId);

        Task<PlayerPvpToPlayerResponse> GetPlayerPvpToPlayerAsync(int playerId, int otherPlayerId);

        Task<PlayerRankHistoryResponse> GetPlayerRankHistoryAsync(int playerId);

        Task<PlayerResultsResponse> GetPlayerResultsAsync(int playerId, string rankingSystem, string type);

        Task<PlayerSearchResponse> SearchPlayersAsync(string name = null, string country = null, string stateprov = null, string tournament = null, int? tourpos = null);

        Task<DirectorSearchResponse> SearchDirectorsAsync(string name = null, string country = null, string stateprov = null, string city = null);

        Task<DirectorTournamentsResponse> GetDirectorTournamentsAsync(int directorId);

        Task<RankingResponse> GetGlobalRankingsAsync(string system = "MAIN", int? page = null);

        Task<CountryRankingResponse> GetCountryRankingsAsync(string countryCode, string system = "MAIN", int? page = null);

        Task<StateRankingResponse> GetStateRankingsAsync(string countryCode, string stateProv, string system = "MAIN", int? page = null);

        Task<RegionRankingResponse> GetRegionRankingsAsync(string regionCode, string system = "MAIN", int? page = null);

        Task<SeriesRankingResponse> GetSeriesRankingsAsync(string seriesCode, int year, string system = "MAIN", int? page = null);

        Task<SeriesListResponse> GetSeriesListAsync(string regionCode = null, int? year = null);

        Task<SeriesResponse> GetSeriesAsync(string seriesCode, int year);

        Task<StatsResponse> GetGlobalStatsAsync(string system = "MAIN", int? page = null);

        Task<StatsResponse> GetCountryStatsAsync(string countryCode, string system = "MAIN", int? page = null);

        Task<StatsResponse> GetStateStatsAsync(string countryCode, string stateProv, string system = "MAIN", int? page = null);

        Task<StatsResponse> GetRegionStatsAsync(string regionCode, string system = "MAIN", int? page = null);

        Task<TournamentSearchResponse> SearchTournamentsAsync(string name = null, string country = null, string stateprov = null, string city = null, int? directorId = null, int? year = null);

        Task<TournamentResultsResponse> GetTournamentResultsAsync(int tournamentId);
    }
}