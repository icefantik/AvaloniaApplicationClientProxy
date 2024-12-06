using Microsoft.Extensions.DependencyInjection;
using Volo.Abp.Http.Client;
using Volo.Abp.Modularity;
using Volo.Abp.VirtualFileSystem;

namespace AvaloniaApplication2.Models;

[DependsOn(
    typeof(AbpHttpClientModule),
    typeof(AbpVirtualFileSystemModule)
)]
public class ClientAppModule : AbpModule
{
    public const string RemoteServiceName = "Default";

    public override void ConfigureServices(ServiceConfigurationContext context)
    {
        //context.Services.Configure<AbpRemoteServiceOptions>(options =>
        //{
        //    options.RemoteServices.Default =
        //        new RemoteServiceConfiguration("https://localhost:44358/");
        //});

        context.Services.AddStaticHttpClientProxies(
                typeof(ClientAppModule).Assembly,
                RemoteServiceName
            );

        Configure<AbpVirtualFileSystemOptions>(options =>
        {
            options.FileSets.AddEmbedded<ClientAppModule>("AvaloniaApplication2");
        });
    }
}
