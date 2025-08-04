#!/bin/bash

read -p "Project Name: " RAWNAME

# Convert to PascalCase
PROJECTNAME=$(echo "$RAWNAME" | sed -E 's/[^a-zA-Z0-9 ]//g' | awk '{ for(i=1;i<=NF;i++) { $i=toupper(substr($i,1,1)) tolower(substr($i,2)) } print }' | tr -d ' ')

dotnet new console -o "$PROJECTNAME" && cd "$PROJECTNAME" && code .