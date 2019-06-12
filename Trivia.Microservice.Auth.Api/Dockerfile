FROM mcr.microsoft.com/dotnet/core/aspnet:2.2-stretch-slim AS base
WORKDIR /app
EXPOSE 80
EXPOSE 443

FROM mcr.microsoft.com/dotnet/core/sdk:2.2-stretch AS build
WORKDIR /src
COPY ["Trivia.Microservice.Auth.Api/Trivia.Microservice.Auth.Api.csproj", "Trivia.Microservice.Auth.Api/"]
RUN dotnet restore "Trivia.Microservice.Auth.Api/Trivia.Microservice.Auth.Api.csproj"
COPY . .
WORKDIR "/src/Trivia.Microservice.Auth.Api"
RUN dotnet build "Trivia.Microservice.Auth.Api.csproj" -c Release -o /app

FROM build AS publish
RUN dotnet publish "Trivia.Microservice.Auth.Api.csproj" -c Release -o /app

FROM base AS final
WORKDIR /app
COPY --from=publish /app .
ENTRYPOINT ["dotnet", "Trivia.Microservice.Auth.Api.dll"]