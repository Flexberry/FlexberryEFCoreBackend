FROM mcr.microsoft.com/dotnet/core/aspnet:3.0-buster-slim AS base
WORKDIR /app
EXPOSE 80
EXPOSE 443

FROM mcr.microsoft.com/dotnet/core/sdk:3.0-buster AS build
WORKDIR /src
COPY ["src/Cats.OData/Cats.OData.csproj", "src/Cats.OData/"]
RUN dotnet restore "src/Cats.OData/Cats.OData.csproj"
COPY . .
WORKDIR "/src/src/Cats.OData"
RUN dotnet build "Cats.OData.csproj" -c Release -o /app/build

FROM build AS publish
RUN dotnet publish "Cats.OData.csproj" -c Release -o /app/publish

FROM base AS final
WORKDIR /app
COPY --from=publish /app/publish .
ENTRYPOINT ["dotnet", "Cats.OData.dll"]