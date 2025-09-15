using System.Text.Json.Serialization;

namespace IFPAWrapper.Models
{
    public class TournamentResult
    {
    [JsonPropertyName("player_id")]
    public int PlayerId { get; set; }

    [JsonPropertyName("first_name")]
    public string FirstName { get; set; }

    [JsonPropertyName("last_name")]
    public string LastName { get; set; }

    [JsonPropertyName("position")]
    public int Position { get; set; }

    [JsonPropertyName("points")]
    public double Points { get; set; }

    [JsonPropertyName("profile_photo")]
    public string ProfilePhoto { get; set; }
    }
}
