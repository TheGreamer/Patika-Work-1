using FluentValidation.AspNetCore;
using Microsoft.EntityFrameworkCore;
using PatikaClassWork1.Business.Abstract;
using PatikaClassWork1.Business.Concrete;
using PatikaClassWork1.DataAccess.Abstract;
using PatikaClassWork1.DataAccess.Concrete.Contexts;
using PatikaClassWork1.DataAccess.Concrete.Layers;
using PatikaClassWork1.Utilities;
using PatikaClassWork1.Validators;
using System.Reflection;

var builder = WebApplication.CreateBuilder(args);

builder.Services.AddDbContext<EfContext>(options => options.UseSqlServer(builder.Configuration.GetConnectionString("MsSqlConnectionString")))
                .AddAutoMapper(Assembly.GetExecutingAssembly())
                .AddSingleton<IAuthorDal, AuthorDal>()
                .AddSingleton<IBookDal, BookDal>()
                .AddSingleton<IAuthorService, AuthorService>()
                .AddSingleton<IBookService, BookService>();

builder.Services.AddControllers()
                .AddJsonOptions(j => j.JsonSerializerOptions.Converters.Add(new DateTimeConverter()))
                .AddFluentValidation(f => f.RegisterValidatorsFromAssemblyContaining<CreateAuthorValidator>())
                .AddFluentValidation(f => f.RegisterValidatorsFromAssemblyContaining<CreateBookValidator>())
                .AddFluentValidation(f => f.RegisterValidatorsFromAssemblyContaining<UpdateAuthorValidator>())
                .AddFluentValidation(f => f.RegisterValidatorsFromAssemblyContaining<UpdateBookValidator>());

builder.Services.AddEndpointsApiExplorer()
                .AddSwaggerGen();

var app = builder.Build();

if (app.Environment.IsDevelopment())
    app.UseSwagger().UseSwaggerUI();

app.UseHttpsRedirection().UseAuthorization();
app.MapControllers();
app.Run();