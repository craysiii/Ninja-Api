# NinjaOne-Api

This is a Work-In-Progress API Wrapper for the [NinjaOne](https://app.ninjarmm.com/apidocs-beta/core-resources) platform. It aims to provide a seamless way to interact with the API in a statically typed fashion.

Currently the library is written to support .Net 6 and C# 10.

## Features

### Current

* Client Credentials Flow Authentication
* All of the "System" endpoints implemented
* All of the "Organization" endpoints implemented
* All of the "Devices" endpoints implemented
* All of the "Groups" endpoints implemented
* A few of the "Management" endpoints implemented
* All of the "Location" endpoints implemented

### Planned

* Implement other Authentication Flows
* Implement remaining "Management" endpoints
* Implement "Queries" endpoints
* Implement "Ticketing" endpoints
* Implement "Webhooks" endpoints
* Implement "Related Items" endpoints
* Implement "Backup" endpoints
* Implement logging and verbosity configuration
* Implement proper documentation on classes and methods

## Getting Started

After importing as a dependency in your project, you can create a client using the following:

```csharp
using NinjaOne_Api.Library;
using NinjaOne_Api.Library.Enums;

var client = new Client(
    clientId: "id",
    clientSecret: "secret",
    scopes: ApplicationScopes.Monitoring | ApplicationScopes.Management,
    instance: Instance.US
    );
```

Afterwards, you can call any defined methods - please note that all Client methods are async - they must be awaited.

```csharp
var organizations = await client.GetOrganizations(); // Returns List<OrganizationBase>
foreach (var org in organizations)
{
    Console.WriteLine($"Organization {org.Name} has the Node Approval Mode: {org.NodeApprovalMode}");
}
```

Enums should be defined across the code base that can be passed to methods as well as deserialized from API calls. In the example above, NodeApprovalMode is an Enum that was deserialized from the response body.



## License

The library is available as open source under the terms of the [MIT License](http://opensource.org/licenses/MIT).