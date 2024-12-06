// This file is automatically generated by ABP framework to use MVC Controllers from CSharp
using Kompozit.Mdb.Materials.Documents;
using Kompozit.Mdb.Shared;
using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using Volo.Abp;
using Volo.Abp.Application.Dtos;
using Volo.Abp.Application.Services;

// ReSharper disable once CheckNamespace
namespace Kompozit.Mdb.Materials.Documents;

public interface IFileAppService : IApplicationService
{
    Task<GetСontentFileDto> GetFileAsync(Guid id);

    Task<IEnumerable<GetListFilesDto>> GetListUnrecognizedFilesAsync();

    Task<FileDto> GetAsync(Guid id);

    Task<PagedResultDto<FileDto>> GetListAsync(PagedAndSortedAndFilteredResultRequestDto input);
}