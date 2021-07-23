FROM mcr.microsoft.com/dotnet/aspnet:5.0 AS base
WORKDIR /app

FROM mcr.microsoft.com/dotnet/sdk:5.0 AS build
WORKDIR /src
COPY ["netcore.csproj", ""]
RUN dotnet restore "netcore.csproj"
COPY . .
WORKDIR "/src/"

RUN dotnet build "netcore.csproj" -c Release -o /app

FROM build AS publish
RUN dotnet publish "netcore.csproj" -c Release -o /app

FROM base AS final
WORKDIR /app
COPY --from=publish /app .
ENTRYPOINT ["dotnet", "netcore.dll"]


