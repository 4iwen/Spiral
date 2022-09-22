FROM mcr.microsoft.com/dotnet/runtime:6.0 AS base
WORKDIR /app

FROM mcr.microsoft.com/dotnet/sdk:6.0 AS build
WORKDIR /src
COPY ["Recursion/Recursion.csproj", "Recursion/"]
RUN dotnet restore "Recursion/Recursion.csproj"
COPY . .
WORKDIR "/src/Recursion"
RUN dotnet build "Recursion.csproj" -c Release -o /app/build

FROM build AS publish
RUN dotnet publish "Recursion.csproj" -c Release -o /app/publish

FROM base AS final
WORKDIR /app
COPY --from=publish /app/publish .
ENTRYPOINT ["dotnet", "Recursion.dll"]
