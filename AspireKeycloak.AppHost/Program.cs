var builder = DistributedApplication.CreateBuilder(args);

builder.AddProject<Projects.AspireKeycloak_ApiService>("aspirekeycloak-apiservice");

builder.Build().Run();
