using Abp.Application.Services.Dto;
using Abp.AutoMapper;
using System;
using System.Collections.Generic;
using System.Text;
using ZdyCore.PhoneBook.PhoneBooks.Persons;
using ZdyCore.PhoneBook.PhoneBooks.PhoneNumber.Dtos;

namespace ZdyCore.PhoneBook.PhoneBooks.Person.Dots
{
    [AutoMapFrom(typeof(Persons.Person))]     //老方法
    public class PersonListDto : FullAuditedEntityDto
    {
        /// <summary>
        /// 姓名
        /// </summary>
        public string Name { get; set; }
        /// <summary>
        /// 邮箱
        /// </summary>
        public string EmailAddress { get; set; }
        /// <summary>
        /// 地址信息
        /// </summary>
        public string Address { get; set; }

        public List<PhoneNumberListDto> PhoneNumbers { get; set; }
    }
}
