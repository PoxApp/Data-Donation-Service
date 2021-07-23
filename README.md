# DataDonation

The Data Donation Service for the CovApp

# Production

[Install .NET Core SDK or Runtime](https://dotnet.microsoft.com/download/dotnet/5.0)

Change the [appsettings.json](./appsettings.json) accordingly. (e.g. The Database Connection String)

```
dotnet restore
dotnet publish -c Release -o ./app
# Edit the appsettings.json file in ./app/appsettings.json and change the connection string
dotnet ./app/DataDonation.dll
```

# Development

[Install .NET Core SDK or Runtime](https://dotnet.microsoft.com/download/dotnet/5.0)

Run `docker-compose up -d` before to start the local database.

```
dotnet restore
dotnet watch run
```
