var builder = DistributedApplication.CreateBuilder(args);

var rabbitMq = builder.AddRabbitMQ("eventbus")
    .WithManagementPlugin() // Abilita e configura la Web UI
       .WithEnvironment("RABBITMQ_DEFAULT_USER", "guest")
       .WithEnvironment("RABBITMQ_DEFAULT_PASS", "guest")
        .WithLifetime(ContainerLifetime.Persistent);

builder.AddProject<Projects.ServiceM1>("servicem1");
builder.AddProject<Projects.ServiceM2>("servicem2");

builder.Build().Run();
