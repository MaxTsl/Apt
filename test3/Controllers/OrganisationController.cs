using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using test3.Data;
using test3.Models;

namespace test3.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class OrganisationController : ControllerBase
    {
        ApplicationDbContext _context;

        public OrganisationController(ApplicationDbContext context)
        {
            _context = context;
        }


        public async Task<List<Organisation>> Index()
        {
            var res = await _context.Organisations.ToListAsync();
            return res;
        }

        /// GET api/users/5
        [HttpGet("{id}")]
        public IActionResult Get(int id)
        {
            Organisation org = _context.Organisations.FirstOrDefault(x => x.OrgId == id);
            if (org == null)
                return NotFound();
            return new ObjectResult(org);
        }

        // POST api/users
        [HttpPost]
        public IActionResult Post([FromBody]Organisation org)
        {
            if (org == null)
            {
                return BadRequest();
            }

            _context.Organisations.Add(org);
            _context.SaveChanges();
            return Ok(org);
        }

        // PUT api/users/
        [HttpPut]
        public IActionResult Put([FromBody]Organisation org)
        {
            if (org == null)
            {
                return BadRequest();
            }
            if (!_context.Organisations.Any(x => x.OrgId == org.OrgId))
            {
                return NotFound();
            }

            _context.Update(org);
            _context.SaveChanges();
            return Ok(org);
        }

        // DELETE api/users/5
        [HttpDelete("{id}")]
        public IActionResult Delete(int id)
        {
            Organisation org = _context.Organisations.FirstOrDefault(x => x.OrgId == id);
            if (org == null)
            {
                return NotFound();
            }
            _context.Organisations.Remove(org);
            _context.SaveChanges();
            return Ok(org);
        }
    }
}