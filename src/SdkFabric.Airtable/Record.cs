/**
 * Record automatically generated by SDKgen please do not edit this file manually
 * @see https://sdkgen.app
 */

using System.Text.Json.Serialization;

namespace SdkFabric.Airtable;

public class Record
{
    [JsonPropertyName("id")]
    public string? Id { get; set; }

    [JsonPropertyName("createdTime")]
    public string? CreatedTime { get; set; }

    [JsonPropertyName("fields")]
    public System.Collections.Generic.Dictionary<string, object>? Fields { get; set; }

}

