using HealthManagement.Infrastructure;
using Microsoft.EntityFrameworkCore;
using Yarp.ReverseProxy.Configuration;
using Yarp.ReverseProxy.LoadBalancing;

var builder = WebApplication.CreateBuilder(args);
builder.Services.AddDbContext<HealthManagmentDBContext> (options =>
{
    options.UseSqlServer(
        builder.Configuration
            .GetConnectionString("HealthManagement"));
});
builder.Services.AddOpenApi();
var app = builder.Build();
if (app.Environment.IsDevelopment())
{
    app.MapOpenApi();
}
app.Run();

// Define Routes
static IReadOnlyList<RouteConfig> GetRoutes()
{
    return new[]
    {
        new RouteConfig
        {
            RouteId = "dynamic-route",
            ClusterId = "dynamic-cluster",
            Match = new RouteMatch
            {
                Path = "{**catch-all}" // Catch-all for any path
            }
        }
    };
}

// Define Clusters (destinations)
static IReadOnlyList<ClusterConfig> GetClusters()
{
    var destinations = new Dictionary<string, DestinationConfig>
    {
        ["worker1"] = new DestinationConfig
        {
            Address = "http://localhost:5002" // worker #1
        },
        ["worker2"] = new DestinationConfig
        {
            Address = "http://localhost:5003" // worker #2
        }
    };

    return new[]
    {
        new ClusterConfig
        {
            ClusterId = "dynamic-cluster",
            LoadBalancingPolicy = "CustomHashPolicy",
            Destinations = destinations
        }
    };
}