FROM mcr.microsoft.com/dotnet/core/aspnet:2.2-stretch-slim AS base
WORKDIR /app
EXPOSE 80
EXPOSE 62450
EXPOSE 1433

FROM mcr.microsoft.com/dotnet/core/sdk:2.2-stretch AS build
WORKDIR /src
COPY ["Auth.Api/Auth.Api.csproj", "Auth.Api/"]
COPY ["Auth.Contracts/Auth.Contracts.csproj", "Auth.Contracts/"]
COPY ["Auth.DataAccess/Auth.DataAccess.csproj", "Auth.DataAccess/"]
COPY ["Auth.Migration/Auth.Migration.csproj", "Auth.Migration/"]
RUN dotnet restore "Auth.Api/Auth.Api.csproj"
COPY . .
WORKDIR "/src/Auth.Api"
RUN dotnet build "Auth.Api.csproj" -c Release -o /app

FROM build AS publish
RUN dotnet publish "Auth.Api.csproj" -c Release -o /app

FROM base AS final
WORKDIR /app
COPY --from=publish /app .
ENTRYPOINT ["dotnet", "Auth.Api.dll"]