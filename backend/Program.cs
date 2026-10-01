var builder = WebApplication.CreateBuilder(args);

// Add controller support to the application.
builder.Services.AddControllers();
builder.Services.AddSwaggerGen(); 

var app = builder.Build();

// Only expose OpenAPI information while developing.
if (app.Environment.IsDevelopment())
{
    app.UseDeveloperExceptionPage();

    // Enable middleware to serve generated Swagger as a JSON endpoint.
    app.UseSwagger();
    app.UseSwaggerUI();
}

// Redirect HTTP requests to HTTPS.
app.UseHttpsRedirection();

// Map routes that are defined inside controller classes.
app.MapControllers();

// Start the application.
app.Run();