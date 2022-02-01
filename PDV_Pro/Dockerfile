#See https://aka.ms/containerfastmode to understand how Visual Studio uses this Dockerfile to build your images for faster debugging.

FROM mcr.microsoft.com/dotnet/aspnet:3.1 AS base
WORKDIR /app
EXPOSE 80
EXPOSE 443

FROM mcr.microsoft.com/dotnet/sdk:3.1 AS build
WORKDIR /src
COPY ["PDV_Pro/PDV_Pro.csproj", "PDV_Pro/"]
RUN dotnet restore "PDV_Pro/PDV_Pro.csproj"
COPY . .
WORKDIR "/src/PDV_Pro"
RUN dotnet build "PDV_Pro.csproj" -c Release -o /app/build

FROM build AS publish
RUN dotnet publish "PDV_Pro.csproj" -c Release -o /app/publish

FROM base AS final
WORKDIR /app
COPY --from=publish /app/publish .
ENTRYPOINT ["dotnet", "PDV_Pro.dll"]