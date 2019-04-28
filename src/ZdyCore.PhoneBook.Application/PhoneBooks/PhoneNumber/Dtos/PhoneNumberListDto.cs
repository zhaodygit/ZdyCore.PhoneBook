using System;
using System.Collections.Generic;
using System.Text;
using ZdyCore.PhoneBook.PhoneBooks.PhoneNumbers;

namespace ZdyCore.PhoneBook.PhoneBooks.PhoneNumber.Dtos
{
    public class PhoneNumberListDto
    {

        /// <summary>
        /// 电话号码
        /// </summary>
        public string Number { get; set; }
        /// <summary>
        /// 类型
        /// </summary>
        public PhoneNumberType Type { get; set; }
    }
}
