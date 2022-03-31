using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Net.Http;
using System.Net.Http.Json;
using System.Threading.Tasks;
using WebApplication1.Helper;
using WebApplication1.Models;

namespace WebApplication1.Controllers
{
    public class HomeController : Controller
    {
        private readonly ILogger<HomeController> _logger;
        studentApi _api = new studentApi();
        private object httpclient;

        public HomeController(ILogger<HomeController> logger) 
        {
            _logger = logger;
        }

        public async Task<IActionResult> Index()
        {
            List<StudentData> students = new List<StudentData>();
            HttpClient client = _api.initial();
            HttpResponseMessage res = await client.GetAsync("api/Students");
            if(res.IsSuccessStatusCode)
            {
                var result = res.Content.ReadAsStringAsync().Result;
                students = JsonConvert.DeserializeObject<List<StudentData>>(result);
            }
            return View(students);
        }

        public async Task<IActionResult> Details(int id)
        {
            var student = new StudentData();
            HttpClient client = _api.initial();
            HttpResponseMessage res = await client.GetAsync($"api/Students/{id}");
            if (res.IsSuccessStatusCode)
            {
                var result = res.Content.ReadAsStringAsync().Result;
                student = JsonConvert.DeserializeObject<StudentData>(result);
            }
            return View(student);
        }

        public ActionResult Create()
        {            
            return View();
        }

        [HttpPost]
        public IActionResult Create(StudentData student)
        {
            HttpClient client = _api.initial();
            var posttask = client.PostAsJsonAsync("api/Students", student);
            posttask.Wait();
            var result = posttask.Result;
            if(result.IsSuccessStatusCode)
            {
                return RedirectToAction(nameof(Index));
            }

            return View();
        }

        public async Task<ActionResult> Edit(int id)
        {
            var student = new StudentData();
            HttpClient client = _api.initial();
            HttpResponseMessage res = await client.GetAsync($"api/Students/{id}");
            if (res.IsSuccessStatusCode)
            {
                var result = res.Content.ReadAsStringAsync().Result;
                student = JsonConvert.DeserializeObject<StudentData>(result);
            }
            return View(student);
        }
        [HttpPost]
        public IActionResult Edit(int id,StudentData student)
        {
            HttpClient client = _api.initial();
            var posttask = client.PutAsJsonAsync<StudentData>($"api/Students/{id}", student);
            posttask.Wait();
            var result = posttask.Result;
            if (result.IsSuccessStatusCode)
            {
                return RedirectToAction(nameof(Index));
            }
            return View(student);
        }

        public async Task<IActionResult> Delete(int id)
        {
            var student = new StudentData();
            HttpClient client = _api.initial();
            HttpResponseMessage res = await client.DeleteAsync($"api/Students/{id}");
            return RedirectToAction(nameof(Index));
        }

        public IActionResult Privacy()
        {
            return View();
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}
