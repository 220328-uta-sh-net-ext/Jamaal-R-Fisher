#See https://aka.ms/containerfastmode to understand how Visual Studio uses this Dockerfile to build your images for faster debugging.

FROM mcr.microsoft.com/dotnet/aspnet:6.0 AS base

WORKDIR /app
EXPOSE 80
EXPOSE 443

FROM mcr.microsoft.com/dotnet/sdk:6.0 AS build

WORKDIR /src
COPY ["CevicheAPI/CevicheAPI.csproj", "CevicheAPI/"]
COPY ["CevicheDL/CevicheDL.csproj", "CevicheDL/"]
COPY ["CevicheModels/CevicheModels.csproj", "CevicheModels/"]
COPY ["CevicheBL/CevicheBL.csproj", "CevicheBL/"]
COPY ["CevicheUI/CevicheUI.csproj", "CevicheUI/"]

RUN dotnet restore "CevicheAPI/CevicheAPI.csproj"
COPY . .
WORKDIR "/src/CevicheAPI"
RUN dotnet build "CevicheAPI.csproj" -c Release -o /app/build

FROM build AS publish

RUN dotnet publish "CevicheAPI.csproj" -c Release -o /app/publish

FROM base AS final

WORKDIR /app
COPY --from=publish /app/publish .
ENTRYPOINT ["dotnet", "CevicheAPI.dll"]