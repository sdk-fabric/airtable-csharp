/**
 * CommentCollection automatically generated by SDKgen please do not edit this file manually
 * @see https://sdkgen.app
 */

using System.Text.Json.Serialization;
namespace SdkFabric.Airtable;
public class CommentCollection
{
    [JsonPropertyName("offset")]
    public string? Offset { get; set; }
    [JsonPropertyName("records")]
    public System.Collections.Generic.List<Comment>? Records { get; set; }
}
