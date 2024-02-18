using brgy_mgmt_dotnet.application;
using brgy_mgmt_dotnet.infrastructure;
using brgy_mgmt_dotnet.identity;

var builder = WebApplication.CreateBuilder(args);
{
    // Add services to the container.
    builder.Services
        .AddApplicationService()
        .AddInfrastructureService(builder.Configuration)
        .AddIdentityService(builder.Configuration);
    //builder.Services.AddMediatR(cfg => cfg.RegisterServicesFromAssembly(typeof(Program).Assembly));

    builder.Services.AddControllers();
    // Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
    builder.Services.AddEndpointsApiExplorer();
    builder.Services.AddSwaggerGen();

    builder.Services.AddCors(options => 
    {
        options.AddPolicy("brgy-mgmt-reactjs", policyBuilder => 
        {
            policyBuilder.WithOrigins("http://localhost:3000");
            policyBuilder.AllowAnyHeader();
            policyBuilder.AllowAnyMethod();
            policyBuilder.AllowCredentials();
        });    
    });
}


var app = builder.Build();
{
    // Configure the HTTP request pipeline.
    if (app.Environment.IsDevelopment())
    {
        app.UseSwagger();
        app.UseSwaggerUI();
    }

    app.UseHttpsRedirection();

    app.UseAuthentication();
    app.UseAuthorization();
    app.MapControllers();

    app.UseCors("brgy-mgmt-reactjs");
    app.Run();
}
