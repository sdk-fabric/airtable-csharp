/**
 * Error automatically generated by SDKgen please do not edit this file manually
 * @see https://sdkgen.app
 */

using System.Text.Json.Serialization;
namespace SdkFabric.Airtable;
public class Error
{
    [JsonPropertyName("error")]
    public ErrorDetails? Error { get; set; }
}