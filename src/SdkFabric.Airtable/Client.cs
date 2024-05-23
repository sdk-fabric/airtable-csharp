/**
 * Client automatically generated by SDKgen please do not edit this file manually
 * @see https://sdkgen.app
 */


using System.Collections.Generic;
using System.Text.Json;
using System.Threading.Tasks;
using RestSharp;
using Sdkgen.Client;
using Sdkgen.Client.Credentials;
using Sdkgen.Client.Exception;

namespace SdkFabric.Airtable;

public class Client : ClientAbstract
{
    public Client(string baseUrl, ICredentials credentials) : base(baseUrl, credentials)
    {
    }

    public MetaTag Meta()
    {
        return new MetaTag(
            this.HttpClient,
            this.Parser
        );
    }

    public RecordsTag Records()
    {
        return new RecordsTag(
            this.HttpClient,
            this.Parser
        );
    }

    public FieldsTag Fields()
    {
        return new FieldsTag(
            this.HttpClient,
            this.Parser
        );
    }

    public TableTag Table()
    {
        return new TableTag(
            this.HttpClient,
            this.Parser
        );
    }



    public static Client Build(string token)
    {
        return new Client("https://api.airtable.com/", new HttpBearer(token));
    }
}
