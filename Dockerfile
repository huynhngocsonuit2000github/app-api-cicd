FROM mcr.microsoft.com/dotnet/sdk:7.0 AS build-env
WORKDIR /src

COPY *.sln .
COPY src/*.csproj .
RUN dotnet restore

COPY src .
RUN dotnet publish -c Release -o /publish
 
FROM mcr.microsoft.com/dotnet/aspnet:7.0 as runtime

WORKDIR /publish

COPY --from=build-env /publish .
 

ENTRYPOINT ["dotnet", "app3.dll"]