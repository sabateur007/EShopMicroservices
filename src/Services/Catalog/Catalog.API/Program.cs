var builder = WebApplication.CreateBuilder(args);
//add services to the container

var app = builder.Build();

//configure http request pipeline
app.Run();
