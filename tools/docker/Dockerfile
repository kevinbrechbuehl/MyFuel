FROM mcr.microsoft.com/dotnet/aspnet:8.0-alpine

WORKDIR /app
COPY apps/backend/net8.0/publish/ ./

USER $APP_UID
EXPOSE 8080

ENTRYPOINT ["dotnet", "MyFuel.WebHost.dll"]
