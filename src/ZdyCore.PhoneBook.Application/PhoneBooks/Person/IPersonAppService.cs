using Abp.Application.Services;
using Abp.Application.Services.Dto;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;
using ZdyCore.PhoneBook.PhoneBooks.Person.Dots;
using ZdyCore.PhoneBook.PhoneBooks.Person.Dtos;

namespace ZdyCore.PhoneBook.PhoneBooks.Person
{
    public interface IPersonAppService: IApplicationService
    {

        /// <summary>
        /// 获取人的相关信息,支持分页
        /// </summary>
        /// <param name="input"></param>
        /// <returns></returns>
        Task<PagedResultDto<PersonListDto>> GetPagedPersonAsync(GetPersonInput input);

        /// <summary>
        /// 根据id获取相关用户信息
        /// </summary>
        /// <returns></returns>
        Task<PersonListDto> GetPersonByIdAsync(NullableIdDto input);
        /// <summary>
        /// 通过id获取联系人进行编辑操作
        /// </summary>
        /// <param name="input"></param>
        /// <returns></returns>
        Task<GetPersonForEditOutput> GetPersonForEditAsync(NullableIdDto input);
        /// <summary>
        /// 新增或者修改联系人信息
        /// </summary>
        /// <returns></returns>
        Task CreateUpdatePersonAsync(CreateOrUpdatePersonInput input);

        Task CreateOrUpdatePersonAsync(CreateOrUpdatePersonInput input);
        /// <summary>
        /// 删除
        /// </summary>
        /// <returns></returns>
        Task DeletePersonAsync(EntityDto input);

        Task PrintHelloAsync(CreateOrUpdatePersonInput input);
    }
}
