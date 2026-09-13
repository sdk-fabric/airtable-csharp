
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
User response = client.Meta().getWhoami();

// List records in a table.
Record_Collection response = client.Records().getAll("baseId", "tableIdOrName", "timeZone", "userLocale", 1, 1, "offset", "view", "sort", "filterByFormula", "cellFormat", "fields", true, "recordMetadata");

// Retrieve a single record.
Record response = client.Records().get("baseId", "tableIdOrName", "recordId");

// Creates multiple records.
Record_Collection response = client.Records().create("baseId", "tableIdOrName", new Record_Collection());

// Updates a single record.
Record response = client.Records().replace("baseId", "tableIdOrName", "recordId", new Record());

// Updates up to 10 records, or upserts them when performUpsert is set.
Bulk_Update_Response response = client.Records().replaceAll("baseId", "tableIdOrName", new Bulk_Update_Request());

// Updates a single record.
Record response = client.Records().update("baseId", "tableIdOrName", "recordId", new Record());

// Updates up to 10 records, or upserts them when performUpsert is set.
Bulk_Update_Response response = client.Records().updateAll("baseId", "tableIdOrName", new Bulk_Update_Request());

// Deletes a single record.
Delete_Response response = client.Records().delete("baseId", "tableIdOrName", "recordId");

// Creates a new column and returns the schema for the newly created column.
Field response = client.Fields().create("baseId", "tableId", new Field());

// Updates the name and/or description of a field.
Field response = client.Fields().update("baseId", "tableId", "columnId", new Field());

// Creates a new table and returns the schema for the newly created table.
Table response = client.Tables().create("baseId", new Table());

// Updates the name and/or description of a table.
Table response = client.Tables().update("baseId", "tableIdOrName", new Table());

// Returns a list of comments for the record from newest to oldest.
Comment_Collection response = client.Comments().getAll("baseId", "tableIdOrName", "recordId");

// Creates a comment on a record.
Comment response = client.Comments().create("baseId", "tableIdOrName", "recordId", new Comment());

// Updates a comment on a record.
Comment response = client.Comments().update("baseId", "tableIdOrName", "recordId", "rowCommentId", new Comment());

// Deletes a comment from a record.
Delete_Response response = client.Comments().delete("baseId", "tableIdOrName", "recordId", "rowCommentId");
```
