# Get the base SDK Image from microsoft
FROM mcr.microsoft.com/dotnet/core/sdk:2.2 AS build-env
WORKDIR /app

#Copy the CSPROJ file and restore dependencies via NUGET
COPY *.csporj ./
RUN dotnet restore

#Copy the project files and build the release
COPY . ./
RUN dotnet publish -c Release -o out

# Generate runtime image
FROM mcr.microsoft.com/dotnet/core/aspnet:2.2
WORKDIR /app
EXPOSE 80
COPY --from=build-env /app/out .
ENTRYPOINT [ "dotnet", "DockerAPI.dll" ]