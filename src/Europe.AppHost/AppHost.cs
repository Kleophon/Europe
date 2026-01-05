var builder = DistributedApplication.CreateBuilder(args);

var sql = builder.AddSqlServer("sql").WithDataVolume();
var europeDb = sql.AddDatabase("europeDB");
builder.AddProject<Projects.Europe_Server>("europe-server").WithReference(europeDb);

builder.Build().Run();
