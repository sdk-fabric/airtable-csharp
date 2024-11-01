/**
 * CommentsTag automatically generated by SDKgen please do not edit this file manually
 * @see https://sdkgen.app
 */


using System.Collections.Generic;
using System.Text.Json;
using System.Threading.Tasks;
using RestSharp;
using Sdkgen.Client;
using Sdkgen.Client.Exception;

namespace SdkFabric.Airtable;

public class CommentsTag : TagAbstract {
    public CommentsTag(RestClient httpClient, Parser parser): base(httpClient, parser)
    {
    }


    /**
     * Returns a list of comments for the record from newest to oldest.
     */
    public async Task<CommentCollection> GetAll(string baseId, string tableIdOrName, string recordId)
    {
        Dictionary<string, object> pathParams = new();
        pathParams.Add("baseId", baseId);
        pathParams.Add("tableIdOrName", tableIdOrName);
        pathParams.Add("recordId", recordId);

        Dictionary<string, object> queryParams = new();

        List<string> queryStructNames = new();

        RestRequest request = new(this.Parser.Url("/v0/:baseId/:tableIdOrName/:recordId/comments", pathParams), Method.Get);
        this.Parser.Query(request, queryParams, queryStructNames);


        RestResponse response = await this.HttpClient.ExecuteAsync(request);

        if (response.IsSuccessful)
        {
            var data = this.Parser.Parse<CommentCollection>(response.Content);

            return data;
        }

        var statusCode = (int) response.StatusCode;
        if (statusCode == 400)
        {
            var data = this.Parser.Parse<Error>(response.Content);

            throw new ErrorException(data);
        }

        if (statusCode == 403)
        {
            var data = this.Parser.Parse<Error>(response.Content);

            throw new ErrorException(data);
        }

        if (statusCode == 404)
        {
            var data = this.Parser.Parse<Error>(response.Content);

            throw new ErrorException(data);
        }

        if (statusCode == 500)
        {
            var data = this.Parser.Parse<Error>(response.Content);

            throw new ErrorException(data);
        }

        throw new UnknownStatusCodeException("The server returned an unknown status code: " + statusCode);
    }
    /**
     * Creates a comment on a record. User mentioned is supported.
     */
    public async Task<Comment> Create(string baseId, string tableIdOrName, string recordId, Comment payload)
    {
        Dictionary<string, object> pathParams = new();
        pathParams.Add("baseId", baseId);
        pathParams.Add("tableIdOrName", tableIdOrName);
        pathParams.Add("recordId", recordId);

        Dictionary<string, object> queryParams = new();

        List<string> queryStructNames = new();

        RestRequest request = new(this.Parser.Url("/v0/:baseId/:tableIdOrName/:recordId/comments", pathParams), Method.Post);
        this.Parser.Query(request, queryParams, queryStructNames);
        request.AddJsonBody(JsonSerializer.Serialize(payload));

        request.AddOrUpdateHeader("Content-Type", "application/json");

        RestResponse response = await this.HttpClient.ExecuteAsync(request);

        if (response.IsSuccessful)
        {
            var data = this.Parser.Parse<Comment>(response.Content);

            return data;
        }

        var statusCode = (int) response.StatusCode;
        if (statusCode == 400)
        {
            var data = this.Parser.Parse<Error>(response.Content);

            throw new ErrorException(data);
        }

        if (statusCode == 403)
        {
            var data = this.Parser.Parse<Error>(response.Content);

            throw new ErrorException(data);
        }

        if (statusCode == 404)
        {
            var data = this.Parser.Parse<Error>(response.Content);

            throw new ErrorException(data);
        }

        if (statusCode == 500)
        {
            var data = this.Parser.Parse<Error>(response.Content);

            throw new ErrorException(data);
        }

        throw new UnknownStatusCodeException("The server returned an unknown status code: " + statusCode);
    }
    /**
     * Updates a comment on a record. API users can only update comments they have created. User mentioned is supported.
     */
    public async Task<Comment> Update(string baseId, string tableIdOrName, string recordId, string rowCommentId, Comment payload)
    {
        Dictionary<string, object> pathParams = new();
        pathParams.Add("baseId", baseId);
        pathParams.Add("tableIdOrName", tableIdOrName);
        pathParams.Add("recordId", recordId);
        pathParams.Add("rowCommentId", rowCommentId);

        Dictionary<string, object> queryParams = new();

        List<string> queryStructNames = new();

        RestRequest request = new(this.Parser.Url("/v0/:baseId/:tableIdOrName/:recordId/comments/:rowCommentId", pathParams), Method.Patch);
        this.Parser.Query(request, queryParams, queryStructNames);
        request.AddJsonBody(JsonSerializer.Serialize(payload));

        request.AddOrUpdateHeader("Content-Type", "application/json");

        RestResponse response = await this.HttpClient.ExecuteAsync(request);

        if (response.IsSuccessful)
        {
            var data = this.Parser.Parse<Comment>(response.Content);

            return data;
        }

        var statusCode = (int) response.StatusCode;
        if (statusCode == 400)
        {
            var data = this.Parser.Parse<Error>(response.Content);

            throw new ErrorException(data);
        }

        if (statusCode == 403)
        {
            var data = this.Parser.Parse<Error>(response.Content);

            throw new ErrorException(data);
        }

        if (statusCode == 404)
        {
            var data = this.Parser.Parse<Error>(response.Content);

            throw new ErrorException(data);
        }

        if (statusCode == 500)
        {
            var data = this.Parser.Parse<Error>(response.Content);

            throw new ErrorException(data);
        }

        throw new UnknownStatusCodeException("The server returned an unknown status code: " + statusCode);
    }
    /**
     * Deletes a comment from a record. Non-admin API users can only delete comments they have created. Enterprise Admins can delete any comment from a record.
     */
    public async Task<DeleteResponse> Delete(string baseId, string tableIdOrName, string recordId, string rowCommentId)
    {
        Dictionary<string, object> pathParams = new();
        pathParams.Add("baseId", baseId);
        pathParams.Add("tableIdOrName", tableIdOrName);
        pathParams.Add("recordId", recordId);
        pathParams.Add("rowCommentId", rowCommentId);

        Dictionary<string, object> queryParams = new();

        List<string> queryStructNames = new();

        RestRequest request = new(this.Parser.Url("/v0/:baseId/:tableIdOrName/:recordId/comments/:rowCommentId", pathParams), Method.Delete);
        this.Parser.Query(request, queryParams, queryStructNames);


        RestResponse response = await this.HttpClient.ExecuteAsync(request);

        if (response.IsSuccessful)
        {
            var data = this.Parser.Parse<DeleteResponse>(response.Content);

            return data;
        }

        var statusCode = (int) response.StatusCode;
        if (statusCode == 400)
        {
            var data = this.Parser.Parse<Error>(response.Content);

            throw new ErrorException(data);
        }

        if (statusCode == 403)
        {
            var data = this.Parser.Parse<Error>(response.Content);

            throw new ErrorException(data);
        }

        if (statusCode == 404)
        {
            var data = this.Parser.Parse<Error>(response.Content);

            throw new ErrorException(data);
        }

        if (statusCode == 500)
        {
            var data = this.Parser.Parse<Error>(response.Content);

            throw new ErrorException(data);
        }

        throw new UnknownStatusCodeException("The server returned an unknown status code: " + statusCode);
    }


}
