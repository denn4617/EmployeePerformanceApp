# Use the official image as a parent image
FROM mcr.microsoft.com/dotnet/aspnet:7.0 AS base
WORKDIR /app
EXPOSE 80

# Use the SDK image to build the app
FROM mcr.microsoft.com/dotnet/sdk:7.0 AS build
WORKDIR /src
COPY ["EmployeePerformanceApp.Server.csproj", "./"]
RUN dotnet restore "./EmployeePerformanceApp.Server.csproj"
COPY . .
WORKDIR "/src/."
RUN dotnet build "EmployeePerformanceApp.Server.csproj" -c Release -o /app/build

FROM build AS publish
RUN dotnet publish "EmployeePerformanceApp.Server.csproj" -c Release -o /app/publish

# Build runtime image
FROM base AS final
WORKDIR /app
COPY --from=publish /app/publish .
ENTRYPOINT ["dotnet", "EmployeePerformanceApp.Server.dll"]
