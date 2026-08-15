
# airtable-csharp

This [SDK](https://github.com/sdk-fabric/airtable-csharp) is managed by the [SDK Fabric](https://sdk-fabric.org/) project, a global infrastructure to
automatically generate SDKs for every API.

You can find more information about this SDK at [TypeHub](https://typehub.cloud/):
https://app.typehub.cloud/d/sdkfabric/airtable

## Usage

```csharp
using SdkFabric.Airtable.Client;

Client client = Client.Build("[access_token]")

// Retrieve the user's ID.
User response = client.Meta().Getwhoami();

// List records in a table.
RecordCollection response = client.Records().Getall("baseId", "tableIdOrName", "timeZone", "userLocale", 1, 1, "offset", "view", "sort", "filterByFormula", "cellFormat", "fields", true, "recordMetadata");

// Retrieve a single record.
Record response = client.Records().Get("baseId", "tableIdOrName", "recordId");

// Creates multiple records.
RecordCollection response = client.Records().Create("baseId", "tableIdOrName", new RecordCollection());

// Updates a single record.
Record response = client.Records().Replace("baseId", "tableIdOrName", "recordId", new Record());

// Updates up to 10 records, or upserts them when performUpsert is set.
BulkUpdateResponse response = client.Records().Replaceall("baseId", "tableIdOrName", new BulkUpdateRequest());

// Updates a single record.
Record response = client.Records().Update("baseId", "tableIdOrName", "recordId", new Record());

// Updates up to 10 records, or upserts them when performUpsert is set.
BulkUpdateResponse response = client.Records().Updateall("baseId", "tableIdOrName", new BulkUpdateRequest());

// Deletes a single record.
DeleteResponse response = client.Records().Delete("baseId", "tableIdOrName", "recordId");

// Creates a new column and returns the schema for the newly created column.
Field response = client.Fields().Create("baseId", "tableId", new Field());

// Updates the name and/or description of a field.
Field response = client.Fields().Update("baseId", "tableId", "columnId", new Field());

// Creates a new table and returns the schema for the newly created table.
Table response = client.Tables().Create("baseId", new Table());

// Updates the name and/or description of a table.
Table response = client.Tables().Update("baseId", "tableIdOrName", new Table());

// Returns a list of comments for the record from newest to oldest.
CommentCollection response = client.Comments().Getall("baseId", "tableIdOrName", "recordId");

// Creates a comment on a record.
Comment response = client.Comments().Create("baseId", "tableIdOrName", "recordId", new Comment());

// Updates a comment on a record.
Comment response = client.Comments().Update("baseId", "tableIdOrName", "recordId", "rowCommentId", new Comment());

// Deletes a comment from a record.
DeleteResponse response = client.Comments().Delete("baseId", "tableIdOrName", "recordId", "rowCommentId");
```
