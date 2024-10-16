namespace fsharp_app
#nowarn "20"
#nowarn "25" // ignora match incompleto

open Microsoft.AspNetCore.Builder
open Microsoft.Extensions.DependencyInjection
open Microsoft.Extensions.Hosting

module Program =
    let exitCode = 0

    [<EntryPoint>]
    let main args =

        let builder = WebApplication.CreateBuilder(args)

        builder.Services.AddControllers()

        builder.Services.AddSwaggerGen()

        let app = builder.Build()
        
        match app.Environment.IsDevelopment() with
        | true ->
            app.UseSwagger()
            app.UseSwaggerUI()

        app.UseHttpsRedirection()

        app.UseAuthorization()
        app.MapControllers()

        app.Run()

        exitCode
