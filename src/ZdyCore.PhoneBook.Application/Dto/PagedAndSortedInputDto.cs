﻿using Abp.Application.Services.Dto;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace ZdyCore.PhoneBook.Dto
{
    public class PagedAndSortedInputDto : IPagedResultRequest, ISortedResultRequest
    {
        public string Sorting { get; set; }

        [Range(0,int.MaxValue)]
        public int SkipCount { get; set; }

        [Range(1,500)]
        public int MaxResultCount { get; set; }
    }
}
