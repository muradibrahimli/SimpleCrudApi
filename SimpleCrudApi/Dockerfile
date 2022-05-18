FROM mcr.microsoft.com/dotnet/aspnet:5.0 AS base
WORKDIR /app
EXPOSE 80
EXPOSE 443

FROM mcr.microsoft.com/dotnet/sdk:5.0 AS build
WORKDIR /src
COPY ["MuradSimpleCrudApi/MuradSimpleCrudApi.csproj", "MuradSimpleCrudApi/"]
RUN dotnet restore "MuradSimpleCrudApi/MuradSimpleCrudApi.csproj"
COPY . .
WORKDIR "/src/MuradSimpleCrudApi"
RUN dotnet build "MuradSimpleCrudApi.csproj" -c Release -o /app/build

FROM build AS publish
RUN dotnet publish "MuradSimpleCrudApi.csproj" -c Release -o /app/publish

FROM base AS final
WORKDIR /app
COPY --from=publish /app/publish .
ENTRYPOINT ["dotnet", "MuradSimpleCrudApi.dll"]
