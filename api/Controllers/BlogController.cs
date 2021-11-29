using System;
using System.IO;
using System.Linq;
using System.Threading.Tasks;
using api.Data;
using api.Entities;
using api.Models;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace api.Controllers
{
    [ApiController]
    [Route("api/[Controller]")]
    public class BlogController : ControllerBase
    {
        private readonly BlogContext _ctx;

        public BlogController(BlogContext ctx)
        {
            _ctx = ctx;
        }

    }
}