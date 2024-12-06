using AvaloniaApplication2.ViewModels;
using Kompozit.Mdb.Materials.Documents;
using Microsoft.Extensions.DependencyInjection;
using Volo.Abp.AspNetCore;
using Volo.Abp.Modularity;
using Volo.Abp.VirtualFileSystem;
using YamlDotNet.Serialization.NodeDeserializers;

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

        collection.AddSingleton<IFileAppService, FileClientProxy>();

        collection.AddTransient<IBusinessService, BusinessService>();
        collection.AddTransient<MainViewModel>();
    }
}
