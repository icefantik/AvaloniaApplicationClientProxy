// This file is automatically generated by ABP framework to use MVC Controllers from CSharp
using Kompozit.Mdb.Materials;
using System;
using System.Collections.Generic;
using Volo.Abp;
using Volo.Abp.Application.Dtos;
using Volo.Abp.ObjectExtending;

// ReSharper disable once CheckNamespace
namespace Kompozit.Mdb.Materials;

public class AnnotationDto
{
    public string DocumentType { get; set; }

    public string OriginCountry { get; set; }

    public string ShortDescription { get; set; }

    public string Articles { get; set; }

    public string Chapters { get; set; }

    public string[] Tags { get; set; }

    public string[] DocumentLanguages { get; set; }
}
