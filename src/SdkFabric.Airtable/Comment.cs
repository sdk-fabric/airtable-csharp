/**
 * Comment automatically generated by SDKgen please do not edit this file manually
 * @see https://sdkgen.app
 */

using System.Text.Json.Serialization;
namespace SdkFabric.Airtable;
public class Comment
{
    [JsonPropertyName("id")]
    public string? Id { get; set; }
    [JsonPropertyName("createdTime")]
    public string? CreatedTime { get; set; }
    [JsonPropertyName("lastUpdatedTime")]
    public string? LastUpdatedTime { get; set; }
    [JsonPropertyName("text")]
    public string? Text { get; set; }
    [JsonPropertyName("parentCommentId")]
    public string? ParentCommentId { get; set; }
    [JsonPropertyName("reactions")]
    public string? Reactions { get; set; }
    [JsonPropertyName("author")]
    public CommentAuthor? Author { get; set; }
}