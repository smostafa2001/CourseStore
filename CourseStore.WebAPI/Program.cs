using CourseStore.BLL.Tags.Commands;
using CourseStore.DAL.DbContexts;
using CourseStore.DAL.Framework;
using MediatR;
using Microsoft.EntityFrameworkCore;

var builder = WebApplication.CreateBuilder(args);

builder.Services.AddControllers();
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();
builder.Services.AddDbContext<CourseStoreDbContext>(option =>
        option.UseSqlServer("SERVER=.; INITIAL CATALOG=CleanCourseStoreDb; USER ID=sa; PASSWORD=1;")
        .AddInterceptors(new AddAuditFieldInterceptor()));

builder.Services.AddMediatR(typeof(CreateTagHandler).Assembly);

var app = builder.Build();

if (app.Environment.IsDevelopment())
{
    app.UseSwagger();
    app.UseSwaggerUI();
}

app.UseHttpsRedirection();

app.UseAuthorization();

app.MapControllers();

app.Run();