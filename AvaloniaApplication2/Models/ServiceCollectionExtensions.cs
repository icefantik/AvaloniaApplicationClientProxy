using Acme.BookStore.Books;
using AvaloniaApplication2.ViewModels;
using Microsoft.Extensions.DependencyInjection;

namespace AvaloniaApplication2.Models;

public static class ServiceCollectionExtensions
{
    public static void AddCommonServices(this ServiceCollection collection)
    {
        collection.AddApplication<ClientAppModule>();

        collection.AddStaticHttpClientProxies(
            typeof(ClientAppModule).Assembly
            );

        //collection.Configure<AbpVirtualFileSystemOptions>(options =>
        //{
        //    options.FileSets.AddEmbedded<ClientAppModule>("AvaloniaApplication2");
        //});

        //collection.AddStaticHttpClientProxies(
        //        typeof(FileClientProxy).Assembly
        //    );

        collection.AddSingleton<IBookAppService, BookClientProxy>();

        collection.AddTransient<IBusinessService, BusinessService>();
        collection.AddTransient<MainViewModel>();
    }
}
