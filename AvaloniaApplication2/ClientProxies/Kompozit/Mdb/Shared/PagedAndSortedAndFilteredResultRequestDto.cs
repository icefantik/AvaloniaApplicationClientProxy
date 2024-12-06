using System;
using Volo.Abp.Application.Dtos;

namespace Kompozit.Mdb.Shared;

[Serializable]
public class PagedAndSortedAndFilteredResultRequestDto : PagedAndSortedResultRequestDto, IFilteredResultRequest
{
    public virtual string? Filter { get; set; }
}
