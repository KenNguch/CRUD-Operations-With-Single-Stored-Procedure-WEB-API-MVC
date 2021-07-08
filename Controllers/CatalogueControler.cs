using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Threading.Tasks;
using CRUD_WEB_API_SP_MVC.Models;
using DefaultNamespace;
using Microsoft.EntityFrameworkCore;

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
        public async Task<IActionResult> GetAllAuthors([FromQuery] QueryParameters queryParameters)
        {
            IQueryable<Author> authors = _context.Authors;

            authors = queryParameters.size >0 ? authors.Skip(queryParameters.size * (queryParameters.page - 1)).Take(queryParameters.size) : authors;

            return Ok(await authors.ToArrayAsync());
        }

        [HttpGet]
        [Route("authors/{id:int}")]
        public async Task<IActionResult> GetAuthor(int id)
        {
            var author = await _context.Authors.FindAsync(id);

            if (author == null)
            {
                return NotFound();
            }

            return Ok(author);
        }
    }
}