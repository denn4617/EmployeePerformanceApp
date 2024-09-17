# Use the official image as a parent image for the runtime
FROM mcr.microsoft.com/dotnet/aspnet:8.0 AS base
WORKDIR /app
EXPOSE 80

# Use the SDK image to build the app
FROM mcr.microsoft.com/dotnet/sdk:8.0 AS build
WORKDIR /src

# Copy the project file and restore dependencies
COPY ["EmployeePerformanceApp.Server/EmployeePerformanceApp.Server.csproj", "EmployeePerformanceApp.Server/"]
RUN dotnet restore "EmployeePerformanceApp.Server/EmployeePerformanceApp.Server.csproj"

# Copy the rest of the source code and build the project
COPY . .
WORKDIR "/src/EmployeePerformanceApp.Server"
RUN dotnet build "EmployeePerformanceApp.Server.csproj" -c Release -o /app/build

# Publish the project
FROM build AS publish
RUN dotnet publish "EmployeePerformanceApp.Server.csproj" -c Release -o /app/publish

# Use the base image for runtime and set the entry point
FROM base AS final
WORKDIR /app
COPY --from=publish /app/publish .
ENTRYPOINT ["dotnet", "EmployeePerformanceApp.Server.dll"]
