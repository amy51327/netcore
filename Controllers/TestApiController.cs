using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using netcore.Models;

namespace netcore.Controllers
{
    [Route("api/test")]
    public class TestApiController : Controller
    {
        private readonly ILogger<HomeController> _logger;

        public TestApiController(ILogger<HomeController> logger)
        {
            _logger = logger;
        }

        [HttpGet]
        public List<Student> Get()
        {
            return new List<Student>
            {
                new Student
                {
                    Id = 100,
                    Name = "小明"
                },
                new Student
                {
                    Id = 101,
                    Name = "小華"
                },
            };
        }


    }
    public class Student
    {
        public int Id { get; set; }
        public string Name { get; set; }
    }
}
