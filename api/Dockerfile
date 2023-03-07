# Use the .NET Core SDK as the base image
FROM mcr.microsoft.com/dotnet/aspnet:6.0 AS base

# Set the working directory
WORKDIR /app

EXPOSE 80
EXPOSE 443
# Copy the solution file and restore dependencies

FROM mcr.microsoft.com/dotnet/sdk:6.0 AS build
WORKDIR /src
COPY *.sln .
COPY ./Infrastructure/*.csproj ./Infrastructure/
COPY ./Common/*.csproj ./Common/
COPY ./Domain/*.csproj ./Domain/
COPY ./Application/*.csproj ./Application/
RUN dotnet restore

# Copy the rest of the source code and build the application
COPY . .
WORKDIR /src/Application
RUN dotnet publish -c Release -o /app/out

# Build the runtime image
FROM base AS final

WORKDIR /app
COPY --from=build /app/out ./
