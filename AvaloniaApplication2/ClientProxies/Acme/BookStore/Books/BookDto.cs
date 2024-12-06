// This file is automatically generated by ABP framework to use MVC Controllers from CSharp
using Acme.BookStore.Books;
using System;
using System.Collections.Generic;
using Volo.Abp;
using Volo.Abp.Application.Dtos;
using Volo.Abp.ObjectExtending;

// ReSharper disable once CheckNamespace
namespace Acme.BookStore.Books;

public class BookDto : AuditedEntityDto<Guid>
{
    public Guid AuthorId { get; set; }

    public string AuthorName { get; set; }

    public string Name { get; set; }

    public BookType Type { get; set; }

    public DateTime PublishDate { get; set; }

    public Single Price { get; set; }
}
