using Kompozit.Mdb.Materials.Documents;
using System.Threading.Tasks;
using Volo.Abp.Application.Dtos;
using Volo.Abp.DependencyInjection;
using Volo.Abp.VirtualFileSystem;

namespace AvaloniaApplication2.Models;

internal class BusinessService : IBusinessService, ITransientDependency
{
    //private IVirtualFileProvider _virtualFileProvider;

    private IFileAppService _fileAppService;

    public BusinessService(IFileAppService fileAppService) //IVirtualFileProvider virtualFileProvider, 
    {
        _fileAppService = fileAppService;
        //_virtualFileProvider = virtualFileProvider;
    }

    public async Task DoSomething()
    {
        //var exists = CheckFileExists();
        await _fileAppService.GetListUnrecognizedFilesAsync();
        var q = await _fileAppService.GetListUnrecognizedFilesAsync();
    }

    //private bool CheckFileExists()
    //{
    //    var q = _virtualFileProvider.GetFileInfo("/ClientProxies/app-generate-proxy.json");
    //    if (q.Exists)
    //    {
    //        return true;
    //    }
    //    return false;
    //}
}
