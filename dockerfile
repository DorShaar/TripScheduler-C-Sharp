FROM mcr.microsoft.com/dotnet/core/sdk:2.2

# Setting working directory.
WORKDIR /app

# Copying projects from current application's directory into image.
COPY ./DTOs/DTOs.csproj ./DTOs/
COPY ./QueueAdapter/QueueAdapter.csproj ./QueueAdapter/
COPY ./TripScheduler/TripScheduler.csproj ./TripScheduler/
COPY ./TripScheduler.Interfaces/TripScheduler.Interfaces.csproj ./TripScheduler.Interfaces/

# Copy rest of the files 
copy ./ ./

# Restore Nuget packages.
RUN dotnet restore ./TripScheduler/TripScheduler.csproj 

# Build projects (Also restoring NuGet packages).
RUN dotnet build ./TripScheduler/TripScheduler.csproj -c Release --no-restore

CMD ["dotnet", "/app/TripScheduler/bin/Release/netcoreapp2.2/TripScheduler.dll"]