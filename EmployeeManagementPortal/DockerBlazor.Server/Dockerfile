FROM mcr.microsoft.com/dotnet/aspnet:6.0 AS base
WORKDIR /app
EXPOSE 80
EXPOSE 443

FROM mcr.microsoft.com/dotnet/sdk:6.0 AS build
WORKDIR /src
COPY ["DockerBlazor.Server/DockerBlazor.Server.csproj", "DockerBlazor.Server/"]
RUN dotnet restore "DockerBlazor.Server/DockerBlazor.Server.csproj"
COPY . .
WORKDIR "/src/DockerBlazor.Server"
RUN dotnet build "DockerBlazor.Server.csproj" -c Release -o /app/build

FROM build AS publish
RUN dotnet publish "DockerBlazor.Server.csproj" -c Release -o /app/publish

FROM base AS final
WORKDIR /app
COPY --from=publish /app/publish .
ENTRYPOINT ["dotnet", "DockerBlazor.Server.dll"]