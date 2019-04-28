using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Dynamic.Core;
using System.Text;
using System.Threading.Tasks;
using Abp.Application.Services.Dto;
using Abp.Authorization;
using Abp.AutoMapper;
using Abp.Domain.Repositories;
using Abp.Linq.Extensions;
using Abp.UI;
using Microsoft.EntityFrameworkCore;
using ZdyCore.PhoneBook.Authorization;
using ZdyCore.PhoneBook.PhoneBooks.Person.Dots;
using ZdyCore.PhoneBook.PhoneBooks.Person.Dtos;
using ZdyCore.PhoneBook.PhoneBooks.Persons;
using ZdyCore.PhoneBook.PhoneBooks.PhoneNumbers;

namespace ZdyCore.PhoneBook.PhoneBooks.Person
{
    //[AbpAuthorize(PermissionNames.Pages_Roles)]
    public class PersonAppService : PhoneBookAppServiceBase, IPersonAppService
    {
        private readonly IRepository<Persons.Person> _personRepository;
        public PersonAppService(IRepository<Persons.Person> personRepository)
        {
            _personRepository = personRepository;
        }

        public async Task CreateUpdatePersonAsync(CreateOrUpdatePersonInput input)
        {
            if (input.PersonEditDto.Id.HasValue)
            {
                await UpdatePersonAsync(input.PersonEditDto);
            }
            else
            {
                await CreatePersonAsync(input.PersonEditDto);
            }

        }

        public async Task CreateOrUpdatePersonAsync(CreateOrUpdatePersonInput input)
        {
            if (input.PersonEditDto.Id.HasValue)
            {
                await UpdatePersonAsync(input.PersonEditDto);
            }
            else
            {
                await CreatePersonAsync(input.PersonEditDto);
            }
        }

        public async Task DeletePersonAsync(EntityDto input)
        {
            var entity = await _personRepository.GetAsync(input.Id);
            if (entity != null)
                await _personRepository.DeleteAsync(input.Id);
            else
            {
                throw new UserFriendlyException("已经删除，无法二次删除");
            }
        }

        public async Task<PagedResultDto<PersonListDto>> GetPagedPersonAsync(GetPersonInput input)
        {
            var query = _personRepository.GetAllIncluding(a=>a.PhoneNumbers);
            var personCount = await query.CountAsync();

            var persons = await query.OrderBy(input.Sorting).PageBy(input).ToListAsync();

            var dtos = persons.MapTo<List<PersonListDto>>();

            return new PagedResultDto<PersonListDto>(personCount, dtos);
        }

       

        public async Task<PersonListDto> GetPersonByIdAsync(NullableIdDto input)
        {
            var person =  await _personRepository.GetAllIncluding(a=>a.PhoneNumbers).FirstOrDefaultAsync(p=>p.Id == input.Id.Value);
            return person.MapTo<PersonListDto>();   
        }

        protected async Task UpdatePersonAsync(PersonEditDto input)
        {
            var entity = await _personRepository.GetAsync(input.Id.Value);
            await _personRepository.UpdateAsync(input.MapTo(entity));
        }
        protected async Task CreatePersonAsync(PersonEditDto input)
        {
            var entity = input.MapTo<Persons.Person>();
            await  _personRepository.InsertAsync(entity);
        }

        public async Task PrintHelloAsync(CreateOrUpdatePersonInput input)
        {
            if (input.PersonEditDto.Id.HasValue)
            {
                await UpdatePersonAsync(input.PersonEditDto);
            }
            else
            {
                await CreatePersonAsync(input.PersonEditDto);
            }

        }

        public async Task<GetPersonForEditOutput> GetPersonForEditAsync(NullableIdDto input)
        {
            var output = new GetPersonForEditOutput();
            PersonEditDto personEditDto;
            if (input.Id.HasValue)
            {
                var entity = await _personRepository.GetAllIncluding(a => a.PhoneNumbers).FirstOrDefaultAsync(p => p.Id == input.Id.Value);
                personEditDto = entity.MapTo<PersonEditDto>();
            }
            else {
                personEditDto = new PersonEditDto();
            }

            output.Person = personEditDto;
            return output;
        }
    }
}
