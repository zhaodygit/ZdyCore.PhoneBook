using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using ZdyCore.PhoneBook.Controllers;
using ZdyCore.PhoneBook.PhoneBooks.Person;
using ZdyCore.PhoneBook.PhoneBooks.Person.Dots;

namespace ZdyCore.PhoneBook.Web.Mvc.Controllers
{
    public class PersonsController : PhoneBookControllerBase
    {
        private readonly IPersonAppService _persionAppServce;

        public PersonsController(IPersonAppService personAppService)
        {
            _persionAppServce = personAppService;
        }
        public async Task<IActionResult> Index(GetPersonInput input)
        {
            var dtos = await _persionAppServce.GetPagedPersonAsync(input);
            return View(dtos);
        }
    }
}