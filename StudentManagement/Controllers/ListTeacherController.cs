using DevExtreme.AspNet.Data;
using DevExtreme.AspNet.Mvc;
using Microsoft.AspNetCore.Mvc;
using Newtonsoft.Json;
using Newtonsoft.Json.Linq;
using PetProject.Model.Model;
using StudentManagement.Data;
using StudentManagement.Models;
using System.Net.WebSockets;
using System.Text;


namespace StudentManagement.Controllers
{
    
    [Route("ListTeacher")]
    public class ListTeacherController : Controller
    {
        private readonly IHttpClientFactory _httpClientFactory;
        private readonly HttpClient _client;
        public ListTeacherController(IHttpClientFactory httpClientFactory)
        {
            _httpClientFactory = httpClientFactory;
            _client = _httpClientFactory.CreateClient();
        }
        [HttpPost("AddTeacher")]
        public object AddTeacher(FormTeacherViewMD listTeacher)
        {
            StringContent content = new StringContent(System.Text.Json.JsonSerializer.Serialize(listTeacher), Encoding.UTF8, "application/json");
            Task.Run(async () =>
            {
                var response = await _client.PostAsync($"https://localhost:7161/api/ListTeacher/AddPerson", content);
                var body = await response.Content.ReadAsStringAsync();
            }).Wait();
            return "";
        }
        [HttpGet("GetAll")]
        public object GetAll(DataSourceLoadOptions loadOptions) 
        {
      
            var result = new List<ListTeacher>();
            Task.Run(async () =>
            {
                var response = await _client.GetAsync($"https://localhost:7161/api/ListTeacher/GetAllTeacher");
                var body = await response.Content.ReadAsStringAsync();
                result = JsonConvert.DeserializeObject<List<ListTeacher>>(body);
            }).Wait();

            return DataSourceLoader.Load((dynamic)result, loadOptions);
        }
        [HttpDelete("DeleteTeacher")]
        public string DeleteTeacher(int UserId)
        {
             Task.Run(async () =>
            {
                var response = await _client.DeleteAsync($"https://localhost:7161/api/ListTeacher/DeletePerson?UserId={UserId}");
            }).Wait();
            return "done";
        }
        [HttpPut("UpDate")]
        public object UpDate(FormTeacherViewMD listTeacher)
        {
            StringContent content = new StringContent(System.Text.Json.JsonSerializer.Serialize(listTeacher), Encoding.UTF8, "application/json");
            Task.Run(async () =>
            {
                var response = await _client.PutAsync($"https://localhost:7161/api/ListTeacher/AddPerson", content);
                var body = await response.Content.ReadAsStringAsync();
            }).Wait();
            return "";
        }
    }
}
