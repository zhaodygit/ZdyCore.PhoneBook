using Abp.AutoMapper;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;
using ZdyCore.PhoneBook.PhoneBooks.PhoneNumbers;

namespace ZdyCore.PhoneBook.PhoneBooks.PhoneNumber.Dtos
{
    [AutoMapTo(typeof(PhoneNumbers.PhoneNumber))]
    public class PhoneNumberEditDto
    {
        /// <summary>
        /// 电话号码
        /// </summary>
        [Required]
        [MaxLength(PhoneBookConsts.MaxPhoneNumberLength)]
        public string Number { get; set; }
        /// <summary>
        /// 类型
        /// </summary>
        public PhoneNumberType Type { get; set; }

    }
}
