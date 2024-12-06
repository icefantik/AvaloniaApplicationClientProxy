using Acme.BookStore.Books;
using System.Threading.Tasks;
using Volo.Abp.Application.Dtos;
using Volo.Abp.DependencyInjection;

namespace AvaloniaApplication2.Models;

internal class BusinessService : IBusinessService, ITransientDependency
{
    //private IVirtualFileProvider _virtualFileProvider;

    private IBookAppService _bookAppService;

    public BusinessService(IBookAppService fileAppService) //IVirtualFileProvider virtualFileProvider, 
    {
        _bookAppService = fileAppService;
        //_virtualFileProvider = virtualFileProvider;
    }

    public async Task DoSomething()
    {
        //var exists = CheckFileExists();
        PagedAndSortedResultRequestDto pagedAndSortedResultRequestDto = new();
        await _bookAppService.GetListAsync(pagedAndSortedResultRequestDto);
        var q = await _bookAppService.GetListAsync(pagedAndSortedResultRequestDto);
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
