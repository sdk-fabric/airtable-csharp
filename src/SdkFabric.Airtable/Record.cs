/**
 * Record automatically generated by SDKgen please do not edit this file manually
 * @see https://sdkgen.app
 */

using System.Text.Json.Serialization;
using System.Collections.Generic;
namespace SdkFabric.;
public class Record
{
    [JsonPropertyName("id")]
    public string? Id { get; set; }
    [JsonPropertyName("createdTime")]
    public string? CreatedTime { get; set; }
    [JsonPropertyName("fields")]
    public Dictionary<string, object>? Fields { get; set; }
}
