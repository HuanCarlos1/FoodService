#See https://aka.ms/containerfastmode to understand how Visual Studio uses this Dockerfile to build your images for faster debugging.

FROM mcr.microsoft.com/dotnet/aspnet:6.0 AS base
WORKDIR /app
EXPOSE 80
EXPOSE 443

ENV ASPNETCORE_URLS=http://+:5001

FROM mcr.microsoft.com/dotnet/sdk:6.0 AS build
WORKDIR /src
COPY ["Kamall-foods-server-aspNetCore.csproj", "."]
RUN dotnet restore "./Kamall-foods-server-aspNetCore.csproj"
COPY . .
WORKDIR "/src/."
RUN dotnet build "Kamall-foods-server-aspNetCore.csproj" -c Release -o /app/build

FROM build AS publish
RUN dotnet publish "Kamall-foods-server-aspNetCore.csproj" -c Release -o /app/publish

FROM base AS final
WORKDIR /app
COPY --from=publish /app/publish .
COPY conf.d conf.d
ENTRYPOINT ["dotnet", "Kamall-foods-server-aspNetCore.dll"]
