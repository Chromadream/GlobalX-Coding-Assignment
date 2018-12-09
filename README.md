# Name Sorter

[![Build Status](https://travis-ci.org/Chromadream/GlobalX-Coding-Assignment.svg?branch=master)](https://travis-ci.org/Chromadream/GlobalX-Coding-Assignment)

A name sorter for GlobalX coding assignment, written in C# (.NET Core 2.1).

## Building and Running

Assumption:

* .NET Core SDK is installed, and on $PATH.

* The current working directory is the cloned folder from git.

```bash$
dotnet build src/GlobalX_Assignment/GlobalX_Assignment.csproj
dotnet run --project src/GlobalX_Assignment/ <FILE_NAME>
```

## Unit Tests

Unit tests are written in XUnit.net, and can be executed with the following command. Same assumption still applies.

```bash$
dotnet restore test/GlobalX_AssignmentTest/GlobalX_AssignmentTest.csproj
dotnet test test/GlobalX_AssignmentTest/GlobalX_AssignmentTest.csproj
```
