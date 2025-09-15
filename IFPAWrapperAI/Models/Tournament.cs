using System.Collections.Generic;
using Newtonsoft.Json;

namespace IFPAWrapper.Models
{
	/// <summary>
	/// TODO: Add class summary.
	/// </summary>
	public class Tournament
	{
		/// <summary>
		/// Gets TODO: Add property summary.
		/// </summary>
		[JsonProperty("tournament_id")]
		public string TournamentId { get; internal set; }

		/// <summary>
		/// Gets TODO: Add property summary.
		/// </summary>
		[JsonProperty("tournament_name")]
		public string TournamentName { get; internal set; }

		/// <summary>
		/// Gets TODO: Add property summary.
		/// </summary>
		[JsonProperty("tournament_type")]
		public string TournamentType { get; internal set; }

		/// <summary>
		/// Gets TODO: Add property summary.
		/// </summary>
		[JsonProperty("prestige_flag")]
		public string PrestigeFlag { get; internal set; }

		/// <summary>
		/// Gets TODO: Add property summary.
		/// </summary>
		[JsonProperty("periodic_flag")]
		public string PeriodicFlag { get; internal set; }

		/// <summary>
		/// Gets TODO: Add property summary.
		/// </summary>
		[JsonProperty("city")]
		public string City { get; internal set; }

		/// <summary>
		/// Gets TODO: Add property summary.
		/// </summary>
		[JsonProperty("state")]
		public string State { get; internal set; }

		/// <summary>
		/// Gets TODO: Add property summary.
		/// </summary>
		[JsonProperty("country_name")]
		public string CountryName { get; internal set; }

		/// <summary>
		/// Gets TODO: Add property summary.
		/// </summary>
		[JsonProperty("contact_name")]
		public string ContactName { get; internal set; }

		/// <summary>
		/// Gets TODO: Add property summary.
		/// </summary>
		[JsonProperty("website")]
		public string Website { get; internal set; }

		/// <summary>
		/// Gets TODO: Add property summary.
		/// </summary>
		[JsonProperty("events")]
		public List<Event> Events { get; internal set; }

		/// <summary>
		/// Gets TODO: Add property summary.
		/// </summary>
		[JsonProperty("event_name")]
		public string EventName { get; internal set; }

		/// <summary>
		/// Gets TODO: Add property summary.
		/// </summary>
		[JsonProperty("event_date")]
		public string EventDate { get; internal set; }

		/// <summary>
		/// Gets TODO: Add property summary.
		/// </summary>
		[JsonProperty("periodic_count")]
		public int? PeriodicCount { get; internal set; }

		/// <summary>
		/// Gets TODO: Add property summary.
		/// </summary>
		[JsonProperty("rating_strength")]
		public string RatingStrength { get; internal set; }

		/// <summary>
		/// Gets TODO: Add property summary.
		/// </summary>
		[JsonProperty("ranking_strength")]
		public string RankingStrength { get; internal set; }

		/// <summary>
		/// Gets TODO: Add property summary.
		/// </summary>
		[JsonProperty("base_value")]
		public string BaseValue { get; internal set; }

		/// <summary>
		/// Gets TODO: Add property summary.
		/// </summary>
		[JsonProperty("event_value")]
		public string EventValue { get; internal set; }

		/// <summary>
		/// Gets TODO: Add property summary.
		/// </summary>
		[JsonProperty("results")]
		public List<TournamentResult> Results { get; internal set; }

		/// <summary>
		/// Gets TODO: Add property summary.
		/// </summary>
		[JsonProperty("winner_name")]
		public string WinnerName { get; internal set; }

		/// <summary>
		/// Gets TODO: Add property summary.
		/// </summary>
		[JsonProperty("winner_player_id")]
		public string WinnerPlayerId { get; internal set; }

		/// <summary>
		/// Gets TODO: Add property summary.
		/// </summary>
		[JsonProperty("country_code")]
		public string CountryCode { get; internal set; }

		/// <summary>
		/// Gets TODO: Add property summary.
		/// </summary>
		[JsonProperty("player_count")]
		public string PlayerCount { get; internal set; }

		/// <summary>
		/// Gets TODO: Add property summary.
		/// </summary>
		[JsonProperty("event_count")]
		public string EventCount { get; internal set; }

		/// <summary>
		/// Gets TODO: Add property summary.
		/// </summary>
		[JsonProperty("event_type")]
		public string EventType { get; internal set; }

		/// <summary>
		/// Gets TODO: Add property summary.
		/// </summary>
		[JsonProperty("last_event_date")]
		public string LastEventDate { get; internal set; }
	}
}
