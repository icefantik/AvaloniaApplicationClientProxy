// This file is automatically generated by ABP framework to use MVC Controllers from CSharp
using Kompozit.Mdb.Letters;
using System;
using System.Collections.Generic;
using Volo.Abp;
using Volo.Abp.Application.Dtos;
using Volo.Abp.ObjectExtending;

// ReSharper disable once CheckNamespace
namespace Kompozit.Mdb.Letters;

public class LetterDto : EntityDto<Guid>
{
    public string IncomingNumber { get; set; }

    public DateTime AdmissionDate { get; set; }

    public bool IsRegistered { get; set; }
}
