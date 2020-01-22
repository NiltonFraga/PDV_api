#See https://aka.ms/containerfastmode to understand how Visual Studio uses this Dockerfile to build your images for faster debugging.

FROM mcr.microsoft.com/dotnet/core/aspnet:3.1-buster-slim AS base
WORKDIR /app
EXPOSE 80
EXPOSE 443

FROM mcr.microsoft.com/dotnet/core/sdk:3.1-buster AS build
WORKDIR /src
COPY ["PDV_api/PDV_api.csproj", "PDV_api/"]
COPY ["Infrastructure/Infrastructure.csproj", "Infrastructure/"]
COPY ["Domain/Domain.csproj", "Domain/"]
COPY ["Application/Application.csproj", "Application/"]
RUN dotnet restore "PDV_api/PDV_api.csproj"
COPY . .
WORKDIR "/src/PDV_api"
RUN dotnet build "PDV_api.csproj" -c Release -o /app/build

FROM build AS publish
RUN dotnet publish "PDV_api.csproj" -c Release -o /app/publish

FROM base AS final
WORKDIR /app
COPY --from=publish /app/publish .
ENTRYPOINT ["dotnet", "PDV_api.dll"]