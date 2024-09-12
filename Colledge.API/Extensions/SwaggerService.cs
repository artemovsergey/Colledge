namespace Colledge.API.Extensions;

public static class SwaggerServices
{
    public static void UseSwaggerServices(this IApplicationBuilder app)
    {

        //var descriptions = app.DescribeApiVersions();
        app.UseSwagger();

        app.UseSwaggerUI(
            options =>
            {

                foreach (var description in new List<string>() { "v1", "v2" })
                {
                    options.SwaggerEndpoint($"/swagger/{description}/swagger.json", description.ToUpperInvariant());
                }
            });
    }
}
