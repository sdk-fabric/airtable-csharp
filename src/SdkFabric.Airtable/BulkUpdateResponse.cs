/**
 * BulkUpdateResponse automatically generated by SDKgen please do not edit this file manually
 * @see https://sdkgen.app
 */

using System.Text.Json.Serialization;
namespace SdkFabric.;
public class BulkUpdateResponse
{
    [JsonPropertyName("createdRecords")]
    public List<string>? CreatedRecords { get; set; }
    [JsonPropertyName("updatedRecords")]
    public List<string>? UpdatedRecords { get; set; }
    [JsonPropertyName("records")]
    public List<Record>? Records { get; set; }
}
