using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using Practical_16.Constant;
using Practical_16.Contracts;
using Practical_16.Data;

namespace Practical_16.Controllers
{
    [Authorize(Roles =Roles.User)]
    public class UserController : Controller
    {
        private readonly IStudentRepository studentRepository;

        public UserController(IStudentRepository studentRepository)
        {
            this.studentRepository = studentRepository;
        }

        // GET: Students1
        public async Task<IActionResult> Index()
        {
            return View(await studentRepository.GetAllAsync());
        }

        // GET: Students1/Details/5
        public async Task<IActionResult> Details(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var student = await studentRepository.GetAsync(id);
            if (student == null)
            {
                return NotFound();
            }

            return View(student);
        }
            
    }
}
