using Azure.Storage.Blobs;
using MediatR;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Azure;
using System.Text.Json.Serialization;
using TeaShop.Core.Abstract;
using TeaShop.Core.Abstract.Repository;
using TeaShop.Core.Commands.Users.CreateUserCommand;
using TeaShop.Core.Domain;
using TeaShop.Core.Queries.Users.GetUsersQuery;
using TeaShop.Infrastructure.Data;
using TeaShop.Infrastructure.Data.Repository;

var builder = WebApplication.CreateBuilder(args);

builder.Services.AddControllers().AddJsonOptions(x => x.JsonSerializerOptions.ReferenceHandler = ReferenceHandler.IgnoreCycles);

builder.Services.AddSingleton(x => new BlobServiceClient("DefaultEndpointsProtocol=https;AccountName=storageaccountinternship;AccountKey=RZ+vz/KG1fOfe+zEi8n9TtNU9UY9ZpkZbjEgbNA/2xD1TN9+W3/lnFoZipJUn8atienNkjMDbKI1haB1vrLeCQ==;EndpointSuffix=core.windows.net"));

builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();

builder.Services.AddScoped<IUnitOfWork, UnitOfWork>();
builder.Services.AddDbContext<AppDbContext>(options => options.UseSqlServer(@"Server=DESKTOP-7K11RRC\SQLEXPRESS;Database=TeaShop;Trusted_Connection=True;MultipleActiveResultSets = True;TrustServerCertificate=True"));
builder.Services.AddMediatR(typeof(GetUsersQuery));
builder.Services.AddAutoMapper(typeof(User));

builder.Services.AddCors(o =>
    o.AddDefaultPolicy(b =>
        b.AllowAnyOrigin().AllowAnyMethod().AllowAnyHeader()));

var app = builder.Build();

// Configure the HTTP request pipeline.
if (app.Environment.IsDevelopment())
{
    app.UseSwagger();
    app.UseSwaggerUI();
}

app.UseHttpsRedirection();

app.UseAuthorization();

app.MapControllers();

app.UseCors();

app.Run();
