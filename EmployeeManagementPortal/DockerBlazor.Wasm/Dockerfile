FROM mcr.microsoft.com/dotnet/sdk:6.0 AS build
WORKDIR /src
COPY ["DockerBlazor.Wasm/DockerBlazor.Wasm.csproj", "DockerBlazor.Wasm/"]
RUN dotnet restore "DockerBlazor.Wasm/DockerBlazor.Wasm.csproj"
COPY . .
WORKDIR "/src/DockerBlazor.Wasm"
RUN dotnet build "DockerBlazor.Wasm.csproj" -c Release -o /app/build

FROM build AS publish
RUN dotnet publish "DockerBlazor.Wasm.csproj" -c Release -o /app/publish

FROM nginx:alpine AS final
WORKDIR /var/www/web
COPY --from=publish /app/publish/wwwroot .
COPY DockerBlazor.Wasm/nginx.conf /etc/nginx/nginx.conf
EXPOSE 80