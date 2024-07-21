using Dex_Filter.Models;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System.Reflection.Metadata.Ecma335;
using System.Collections.Generic;
using Dex_Filter.DataLayer;
using Microsoft.EntityFrameworkCore;
namespace Dex_Filter.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class TokenCOnntroller : ControllerBase
    {

        private readonly ApiDbContext _db;

        public TokenCOnntroller(ApiDbContext db)
        {
            _db = db;
        }

        [HttpGet]
        public async Task<IActionResult> GetTickers()
        {
            var tokens = await _db.Tokens.ToListAsync();
            
            return Ok(tokens);
        }

        [HttpGet("{id}")]
        
        public async Task<ActionResult<List<Token>>> GetTicker(int id)
        {
            var token = await _db.Tokens.FindAsync(id);
            if (token is null)
                return NotFound("Not found");

            return Ok(token);
        }


        [HttpPost]
       
        public async Task<ActionResult<List<Token>>> AddTicker(Token token)
        {
       _db.Tokens.Add(token);
            await _db.SaveChangesAsync();


            return Ok(await _db.Tokens.ToListAsync());
        }

        [HttpPut]
      
        public async Task<ActionResult<List<Token>>> UpdateTicker(Token updatedToken)
        {
            var dbtoken = await _db.Tokens.FindAsync(updatedToken.Id);
            if (dbtoken is null)
                return NotFound("Not found");
           
            dbtoken.Ticker= updatedToken.Ticker;
            dbtoken.pairAddress= updatedToken.pairAddress;
            await _db.SaveChangesAsync();

            return Ok(await _db.Tokens.ToListAsync());
        }

        [HttpDelete]


      
        public async Task<ActionResult<List<Token>>> DeleteTicker(int Id)
        {

            var dbtoken = await _db.Tokens.FindAsync(Id);
            if (dbtoken is null)
                return NotFound("Not found");





            _db.Tokens.Remove(dbtoken);
            await _db.SaveChangesAsync();


            return Ok(await _db.Tokens.ToListAsync());
        }




    }
}
