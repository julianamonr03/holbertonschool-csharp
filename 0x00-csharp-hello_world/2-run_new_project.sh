#!/usr/bin/env bash
# Bash script initializes, builds, and runs a new C# project from a folder
dotnet new console -o 2-new_project
dotnet build 2-new_project
dotnet run --project 2-new_project
