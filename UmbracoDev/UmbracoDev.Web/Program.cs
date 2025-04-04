using Umbraco.Cms.Core.Notifications;
using UmbracoDev.Web.Handlers.Notifications;

WebApplicationBuilder builder = WebApplication.CreateBuilder(args);

builder.CreateUmbracoBuilder()
    .AddBackOffice()
    .AddWebsite()
    .AddDeliveryApi()
    .AddComposers()
    .AddNotificationAsyncHandler<ContentSavedNotification, GenerateTailwindClasses>()
    .Build();

if (builder.Environment.IsDevelopment())
{
    //builder.Services.AddHostedService<TailwindHostedService>();
}

WebApplication app = builder.Build();

await app.BootUmbracoAsync();

app.UseHttpsRedirection();

app.UseUmbraco()
    .WithMiddleware(u =>
    {
        u.UseBackOffice();
        u.UseWebsite();
    })
    .WithEndpoints(u =>
    {
        u.UseBackOfficeEndpoints();
        u.UseWebsiteEndpoints();
    });

await app.RunAsync();
