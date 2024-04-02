# NinjaOne-Api

This is a Work-In-Progress API Wrapper for the [NinjaOne](https://app.ninjarmm.com/apidocs-beta/core-resources) platform. It aims to provide a seamless way to interact with the API in a statically typed fashion.

Currently the library is written to support .Net 8 and C# 12.

## Features

### Current

* Client Credentials Flow Authentication
* All "System" endpoints implemented
* All "Organization" endpoints implemented
* All "Devices" endpoints implemented
* All "Groups" endpoints implemented
* Some "Management" endpoints implemented
* All "Location" endpoints implemented

### Planned

* Implement other Authentication Flows
* Implement remaining "Management" endpoints
* Implement "Queries" endpoints
* Implement "Ticketing" endpoints
* Implement "Webhooks" endpoints
* Implement "Related Items" endpoints
* Implement "Backup" endpoints
* Implement "Knowledge Base Articles" endpoints
* Implement "Organization Documents" endpoints
* Implement "Document Template" endpoints

## Getting Started

After importing as a dependency in your project, you can create a client using the following:

```csharp
using NinjaOne_Api.Library;
using NinjaOne_Api.Library.Enums;

var client = new Client(
    clientId: "id",
    clientSecret: "secret",
    scopes: ApplicationScopes.Monitoring | ApplicationScopes.Management,
    instance: Instance.US,
    logLevel: LogLevel.Debug
    );
```

Afterwards, you can call any defined methods - please note that all Client methods are async.

All Client methods return a named `Tuple` that contain two objects - one is a nullable response object of the expecting type (e.g. `List<Organization>`), and the other is a nullable `NinjaApiError` object. 

Generally, only one of these should be `null` at a time.

```csharp
var result = await client.GetOrganizations(); // Returns Tuple(List<OrganizationBase>? Organizations, NinjaApiError? Error) 
foreach (var org in result.Organizations!)
{
    Console.WriteLine($"Organization {org.Name} has the Node Approval Mode: {org.NodeApprovalMode}");
}
```

Enums should be defined across the code base that can be passed to methods as well as deserialized from API calls. In the example above, NodeApprovalMode is an Enum that was deserialized from the response body.

## Logging

The Client class has optional method arguments to pass an `LoggingFactory` and `LogLevel`. If you do not pass a `LoggingFactory`, then one will be created by the Client, and you can instead pass just a `LogLevel` in order to get basic console logging. There are two logging levels implemented:
* Debug: This will show you requests that are made, parameters or bodies passed alongside the request, and the returned HTTP code.

Example: 

`2024-03-31T07:35:23.1418553+00:00dbug: NinjaOne_Api.Library.Client[0] Method: Get Resource: notification-channels Parameters:  Response: 200 OK`

* Trace: This will additionally log the response body of a request.

Example:

`2024-04-02T04:36:05.7289524+00:00dbug: NinjaOne_Api.Library.Client[0] Method: Get Resource: jobs Parameters:  Response: 200 OK`

`2024-04-02T04:36:05.7293124+00:00trce: NinjaOne_Api.Library.Client[0] Response Body: [{"jobStatus":"IN_PROCESS","jobType":"NINJA_REMOTE"...}]`

## License

The library is available as open source under the terms of the [MIT License](http://opensource.org/licenses/MIT).