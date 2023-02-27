using Microsoft.AspNetCore.Rewrite;
var builder = WebApplication.CreateBuilder(args);
var app = builder.Build();
app.UseRewriter(
    new RewriteOptions()
        .AddRedirectToHttpsPermanent()
        .AddRedirectToWwwPermanent()
        );
app.Run();
