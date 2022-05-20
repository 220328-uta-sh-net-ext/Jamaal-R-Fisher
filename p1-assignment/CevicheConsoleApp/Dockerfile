# choose base image
# copy files from outside the image into the image
# run terminal commands inside the image
# add configuration/environment variables

FROM mcr.microsoft.com/dotnet/sdk:6.0 AS build-env

WORKDIR /app

COPY . ./

RUN dotnet restore

RUN dotnet publish -c Release -o publish

FROM mcr.microsoft.com/dotnet/sdk:6.0

WORKDIR /app

COPY --from=build-env /app/publish .

CMD dotnet /app/CevicheConsoleApp.dll