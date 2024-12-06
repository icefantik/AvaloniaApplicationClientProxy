// This file is automatically generated by ABP framework to use MVC Controllers from CSharp
using Kompozit.Mdb.Letters;
using Kompozit.Mdb.Shared;
using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using Volo.Abp;
using Volo.Abp.Application.Dtos;
using Volo.Abp.DependencyInjection;
using Volo.Abp.Http.Client;
using Volo.Abp.Http.Client.ClientProxying;
using Volo.Abp.Http.Modeling;

// ReSharper disable once CheckNamespace
namespace Kompozit.Mdb.Letters;

[Dependency(ReplaceServices = true)]
[ExposeServices(typeof(ILetterAppService), typeof(LetterClientProxy))]
public partial class LetterClientProxy : ClientProxyBase<ILetterAppService>, ILetterAppService
{
    public virtual async Task<PagedResultDto<LetterDto>> GetListAsync(PagedAndSortedAndFilteredResultRequestDto input)
    {
        return await RequestAsync<PagedResultDto<LetterDto>>(nameof(GetListAsync), new ClientProxyRequestTypeValue
        {
            { typeof(PagedAndSortedAndFilteredResultRequestDto), input }
        });
    }

    public virtual async Task<LetterDto> RegisterAsync(Guid id)
    {
        return await RequestAsync<LetterDto>(nameof(RegisterAsync), new ClientProxyRequestTypeValue
        {
            { typeof(Guid), id }
        });
    }

    public virtual async Task<LetterDto> CreateAsync(CreateLetterDto input)
    {
        return await RequestAsync<LetterDto>(nameof(CreateAsync), new ClientProxyRequestTypeValue
        {
            { typeof(CreateLetterDto), input }
        });
    }

    public virtual async Task<LetterDto> UpdateAsync(Guid id, UpdateLetterDto input)
    {
        return await RequestAsync<LetterDto>(nameof(UpdateAsync), new ClientProxyRequestTypeValue
        {
            { typeof(Guid), id },
            { typeof(UpdateLetterDto), input }
        });
    }

    public virtual async Task DeleteAsync(Guid id)
    {
        await RequestAsync(nameof(DeleteAsync), new ClientProxyRequestTypeValue
        {
            { typeof(Guid), id }
        });
    }

    public virtual async Task<LetterDto> GetAsync(Guid id)
    {
        return await RequestAsync<LetterDto>(nameof(GetAsync), new ClientProxyRequestTypeValue
        {
            { typeof(Guid), id }
        });
    }
}
