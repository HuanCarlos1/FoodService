#!/bin/bash
version=$(find ./Migrations -type f ! -name '*Designer*' | wc -l)

migrationName=MigrationV"$version"

echo adding migration...
dotnet ef migrations add "$migrationName"  --context DatabaseContext
dotnet ef database update
echo migration done...
