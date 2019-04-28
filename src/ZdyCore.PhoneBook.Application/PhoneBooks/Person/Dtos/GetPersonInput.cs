using Abp.Runtime.Validation;
using System;
using System.Collections.Generic;
using System.Text;
using ZdyCore.PhoneBook.Dto;

namespace ZdyCore.PhoneBook.PhoneBooks.Person.Dots
{
    //dto 数据传输模型
    public class GetPersonInput : PagedAndSortedInputDto, IShouldNormalize
    {
        /// <summary>
        /// 模糊查询
        /// </summary>
        public string FilterText { get; set; }

        public void Normalize()
        {
            if (string.IsNullOrEmpty(Sorting))
            {
                Sorting = "Id";
            }
        }
    }
}
