var builder = DistributedApplication.CreateBuilder(args);

builder.AddProject<Projects.Europe_Server>("europe-server");

builder.Build().Run();
