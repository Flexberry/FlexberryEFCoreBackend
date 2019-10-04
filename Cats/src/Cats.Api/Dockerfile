FROM mcr.microsoft.com/dotnet/core/sdk:3.0 AS base
WORKDIR /app
EXPOSE 80
EXPOSE 443

FROM mcr.microsoft.com/dotnet/core/sdk:3.0-buster AS build
WORKDIR /src
COPY ["src/Cats.Api/Cats.Api.csproj", "src/Cats.Api/"]
RUN dotnet restore "src/Cats.Api/Cats.Api.csproj"
COPY . .
WORKDIR "/src/src/Cats.Api"
RUN dotnet build "Cats.Api.csproj" -c Release -o /app/build

FROM build AS publish
RUN dotnet publish "Cats.Api.csproj" -c Release -o /app/publish

FROM base AS final
WORKDIR /app
COPY --from=publish /app/publish .
ENTRYPOINT ["dotnet", "Cats.Api.dll"]