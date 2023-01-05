using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace StudentManagement.Pages {
    public class IndexModel : PageModel {
        public HttpClient client;
        public IndexModel(HttpClient _client)
        {
            client = _client;
        }
        public void OnGet() {

        }
    }
}
