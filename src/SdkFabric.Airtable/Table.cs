/**
 * Table automatically generated by SDKgen please do not edit this file manually
 * @see https://sdkgen.app
 */

using System.Text.Json.Serialization;
namespace SdkFabric.Airtable;
public class Table
{
    [JsonPropertyName("id")]
    public string? Id { get; set; }
    [JsonPropertyName("primaryFieldId")]
    public string? PrimaryFieldId { get; set; }
    [JsonPropertyName("name")]
    public string? Name { get; set; }
    [JsonPropertyName("description")]
    public string? Description { get; set; }
    [JsonPropertyName("fields")]
    public List<Field>? Fields { get; set; }
}
