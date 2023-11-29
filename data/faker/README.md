# Fake data utility

This C# console app generates a number of JSON formatted addresses and inserts them in a Redis database.

## Building & Running

You need to have dotnet installed, and access to a Redis endpoint.

Then type `dotnet build` to compile, and `dotnet run` and you will be prompted with the command line options.

Hint: to connect to a Redis Enterprise database with a password for default user, you need to use the -s option, in a format like: `redis-19010.internal.c28466.eu-west-1-1.ec2.cloud.rlrcp.com:19010,password=<default_user_password>`

