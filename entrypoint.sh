#!/bin/bash

# Wait for the database to be ready
until PGPASSWORD=mypassword psql -h postgres -U myuser -d mydatabase -c '\q'; do
  >&2 echo "PostgreSQL is starting up"
  sleep 5
done

# Apply database migrations
dotnet ef database update

# Start the application
exec dotnet api.dll
