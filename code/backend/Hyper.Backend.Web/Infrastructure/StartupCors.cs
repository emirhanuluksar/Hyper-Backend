namespace WebAPI.Infrastructure;

public static class StartupCors {
    private const string MyAllowSpecificOrigins = "_myAllowSpecificOrigins";

    public static void AddStartupCors(this WebApplicationBuilder builder) {
        builder.Services.AddCors(options => {
            options.AddPolicy(name: MyAllowSpecificOrigins, policy => {
                if (builder.Environment.IsProduction()) {
                    policy.WithOrigins("http://localhost:4200")
                        .AllowAnyHeader()
                        .AllowAnyMethod();
                } else {
                    policy.WithOrigins("http://localhost:4200")
                        .AllowAnyHeader()
                        .AllowAnyMethod();
                }
            });
        });
    }

    public static void UseStartupCors(this WebApplication app) {
        app.UseCors(MyAllowSpecificOrigins);
    }
}
