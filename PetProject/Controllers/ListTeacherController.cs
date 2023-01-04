using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Http;
using PetProject.Model.Model;
using PetProject.Interfaces.Interfaces;
using PetProject.Interfaces.Service;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
namespace PetProject.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class ListTeacherController : Controller
    {
        private readonly ListTeacherService _listTeacherService;
        public ListTeacherController(ListTeacherService listTeacherService)
        {
            _listTeacherService = listTeacherService;
        }

        [HttpPost("AddPerson")]
        public async Task<Object> AddPerson([FromBody] ListTeacher listTeacher)
        {
            try
            {
                 await _listTeacherService.AddPerson(listTeacher);
                return true;
            }
            catch (Exception)
            {

                return false;
            }
        }
        [HttpGet("GetAllTeacher")]
        public Object GetAllTeacher()
        {
            var data = _listTeacherService.GetAllTeacher();
            var json = JsonConvert.SerializeObject(data, Formatting.Indented,
                new JsonSerializerSettings()
                {
                    ReferenceLoopHandling = Newtonsoft.Json.ReferenceLoopHandling.Ignore
                }
            );
            return json;

        }
    }
}
