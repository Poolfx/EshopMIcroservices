var builder = WebApplication.CreateBuilder(args);

//add services to the container

var app = builder.Build();

//configure teh http request pipeline

app.Run();
