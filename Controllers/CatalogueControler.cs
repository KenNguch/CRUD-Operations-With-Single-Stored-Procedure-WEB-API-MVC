using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Threading.Tasks;
using CRUD_WEB_API_SP_MVC.Models;

namespace CRUD_WEB_API_SP_MVC.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class CatalogueController : ControllerBase
    {
        private readonly Context _context;


        public CatalogueController(Context context)
        {
            _context = context;
            _context.Database.EnsureCreated();
        }

        [HttpGet]
        [Route("authors")]
        public IActionResult GetAllAuthors()
        {
            return Ok(_context.Authors.ToArray());
        }

        [HttpGet]
        [Route("authors/{id:int}")]
        public IActionResult GetAuthor(int id)
        {
            var author = _context.Authors.Find(id);

            if (author == null)
            {
                return NotFound();
            }

            return Ok(author);
        }
    }
}