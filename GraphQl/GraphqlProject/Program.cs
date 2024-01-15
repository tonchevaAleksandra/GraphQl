using GraphiQl;
using GraphQL;
using GraphQL.Types;
using GraphqlProject.Interfaces;
using GraphqlProject.Query;
using GraphqlProject.Schema;
using GraphqlProject.Services;
using GraphqlProject.Type;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.
builder.Services.AddTransient<IMenuRepository, MenuRepository>();
builder.Services.AddTransient<MenuType>();
builder.Services.AddTransient<MenuQuery>();
builder.Services.AddTransient<ISchema,MenuSchema>();

builder.Services.AddGraphQL(x => x.AddAutoSchema<ISchema>().AddSystemTextJson());


var app = builder.Build();

// Configure the HTTP request pipeline.

app.UseHttpsRedirection();
app.UseGraphiQl("/graphql");
app.UseGraphQL<ISchema>();

app.Run();

