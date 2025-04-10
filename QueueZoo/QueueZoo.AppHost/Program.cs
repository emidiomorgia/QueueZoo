var builder = DistributedApplication.CreateBuilder(args);

builder.AddProject<Projects.ServiceM1>("servicem1");

builder.Build().Run();
