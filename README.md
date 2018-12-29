[![Build Status](https://travis-ci.com/NachoColl/dotnet-cf4dotnet-library.svg?branch=master)](https://travis-ci.com/NachoColl/dotnet-cf4dotnet-library)

Custom attributes you can use to define cf4dotnet resources.

## Available Properties

### Cloudformation4dotNET.APIGateway.APIGatewayResourceProperties

To define AWS API Gateway properties. For Example:

```csharp
namespace MyAPI
{
    public class APIGateway
    {

        /* A function that will get APIGateway + Lambda resources created. */
        [Cloudformation4dotNET.APIGateway.APIGatewayResourceProperties("utils/status", APIKeyRequired=true,  EnableCORS=true, TimeoutInSeconds=2)]
        public APIGatewayProxyResponse CheckStatus(APIGatewayProxyRequest Request, ILambdaContext context) => new APIGatewayProxyResponse
        {
            StatusCode = 200,
            Headers =  new Dictionary<string,string>(){{"Content-Type","text/plain"}},
            Body = String.Format("Running lambda version {0} {1}.", context.FunctionVersion, JsonConvert.SerializeObject(Request?.StageVariables))
        };

    }
}
```

### Cloudformation4dotNET.Lambda.LambdaResourceProperties

To define AWS Lambda properties: 

```csharp
namespace MyAPI {

    public class Lambdas
    {
        
        /* A function that will get Lambda resources created (only) */
        [Cloudformation4dotNET.Lambda.LambdaResourceProperties(TimeoutInSeconds=20)]
        public void Echo(Object Input, ILambdaContext Context) => Context?.Logger?.Log(JsonConvert.SerializeObject(Input));
        
    }
}
```

## Version Notes 

Check [cf4dotnet](https://github.com/NachoColl/dotnet-cf4dotnet) tool for instructions.
