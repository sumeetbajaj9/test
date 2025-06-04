# Add API (.NET)

This project contains a minimal .NET 8 Web API that exposes a single endpoint `/add` for adding two numbers.

## Building and Running

1. Install the .NET 8 SDK if it's not already installed.
2. Navigate to this `add-api` directory.
3. Run `dotnet run` to start the server.

The API listens on port `5000` by default. You can send a request like:

```
GET http://localhost:5000/add?a=1&b=2
```

The response will be JSON:

```
{"result":3}
```
