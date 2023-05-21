#See https://aka.ms/customizecontainer to learn how to customize your debug container and how Visual Studio uses this Dockerfile to build your images for faster debugging.

FROM mcr.microsoft.com/dotnet/aspnet:7.0 AS base
WORKDIR /app
EXPOSE 80

ENV ASPNETCORE_URLS=http://+:5285;http://+:80;
ENV ASPNETCORE_ENVIRONMENT=Development;

FROM mcr.microsoft.com/dotnet/sdk:7.0 AS build
WORKDIR /src
COPY ["Cod3rsGrowth.Web/Cod3rsGrowth.Web.csproj", "Cod3rsGrowth.Web/"]
COPY ["Cod3rsGrowth.Dominio/Cod3rsGrowth.Dominio.csproj", "Cod3rsGrowth.Dominio/"]
COPY ["Cod3rsGrowth.Infra/Cod3rsGrowth.Infra.csproj", "Cod3rsGrowth.Infra/"]
RUN dotnet restore "Cod3rsGrowth.Web/Cod3rsGrowth.Web.csproj"
COPY . .
WORKDIR "/src/Cod3rsGrowth.Web"
RUN dotnet build "Cod3rsGrowth.Web.csproj" -c Release -o /app/build

FROM build AS publish
RUN dotnet publish "Cod3rsGrowth.Web.csproj" -c Release -o /app/publish /p:UseAppHost=false

FROM base AS final
WORKDIR /app
COPY --from=publish /app/publish .
ENTRYPOINT ["dotnet", "Cod3rsGrowth.Web.dll"]