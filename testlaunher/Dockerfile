FROM mcr.microsoft.com/dotnet/runtime:6.0 AS base
WORKDIR /app

FROM mcr.microsoft.com/dotnet/sdk:6.0 AS build
WORKDIR /src
COPY ["testlaunher/testlaunher.csproj", "testlaunher/"]
RUN dotnet restore "testlaunher/testlaunher.csproj"
COPY . .
WORKDIR "/src/testlaunher"
RUN dotnet build "testlaunher.csproj" -c Release -o /app/build

FROM build AS publish
RUN dotnet publish "testlaunher.csproj" -c Release -o /app/publish

FROM base AS final
WORKDIR /app
COPY --from=publish /app/publish .
ENTRYPOINT ["dotnet", "testlaunher.dll"]
