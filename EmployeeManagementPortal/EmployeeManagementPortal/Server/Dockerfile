#See https://aka.ms/containerfastmode to understand how Visual Studio uses this Dockerfile to build your images for faster debugging.

FROM mcr.microsoft.com/dotnet/aspnet:6.0 AS base
WORKDIR /app
EXPOSE 80
EXPOSE 443

FROM mcr.microsoft.com/dotnet/sdk:6.0 AS build
WORKDIR /src
COPY ["EmployeeManagementPortal/Server/EmployeeManagementPortal.Server.csproj", "EmployeeManagementPortal/Server/"]
COPY ["EmployeeManagementPortal/Shared/EmployeeManagementPortal.Shared.csproj", "EmployeeManagementPortal/Shared/"]
COPY ["EmployeeManagementPortal/Client/EmployeeManagementPortal.Client.csproj", "EmployeeManagementPortal/Client/"]
RUN dotnet restore "EmployeeManagementPortal/Server/EmployeeManagementPortal.Server.csproj"
COPY . .
WORKDIR "/src/EmployeeManagementPortal/Server"
RUN dotnet build "EmployeeManagementPortal.Server.csproj" -c Release -o /app/build

FROM build AS publish
RUN dotnet publish "EmployeeManagementPortal.Server.csproj" -c Release -o /app/publish

FROM base AS final
WORKDIR /app
COPY --from=publish /app/publish .
ENTRYPOINT ["dotnet", "EmployeeManagementPortal.Server.dll"]