# Étape 1 : Build
FROM mcr.microsoft.com/dotnet/sdk:6.0 AS build

WORKDIR /src
COPY . .

RUN dotnet publish dotnet-sqli-lab.csproj -c Release -o /app/publish

# Étape 2 : Runtime
FROM mcr.microsoft.com/dotnet/aspnet:6.0

WORKDIR ./
COPY --from=build /app/publish .

EXPOSE 80

ENTRYPOINT ["dotnet", "dotnet-sqli-lab.dll"]
