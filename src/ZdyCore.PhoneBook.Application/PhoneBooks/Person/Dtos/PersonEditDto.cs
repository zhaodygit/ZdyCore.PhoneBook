using Abp.Application.Services.Dto;
using Abp.AutoMapper;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;
using ZdyCore.PhoneBook.PhoneBooks.Persons;
using ZdyCore.PhoneBook.PhoneBooks.PhoneNumber.Dtos;

namespace ZdyCore.PhoneBook.PhoneBooks.Person.Dots
{
    [AutoMapTo(typeof(Persons.Person))]
    public class PersonEditDto 
    {
        public int? Id { get; set; }
        /// <summary>
        /// 姓名
        /// </summary>
        [Required]
        [MaxLength(50)]
        public string Name { get; set; }
        /// <summary>
        /// 邮箱
        /// </summary>
        [EmailAddress]
        [MaxLength(200)]
        public string EmailAddress { get; set; }
        /// <summary>
        /// 地址信息
        /// </summary>
        [MaxLength(200)]
        public string Address { get; set; }

        public List<PhoneNumberEditDto> PhoneNumbers { get; set; }
    }
}
