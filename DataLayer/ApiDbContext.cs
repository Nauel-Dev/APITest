using Dex_Filter.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Options;

namespace Dex_Filter.DataLayer
{
    public class ApiDbContext:DbContext
    {
        public ApiDbContext(DbContextOptions<ApiDbContext> options) :base(options)
        {
            

        }
        public  DbSet<Token> Tokens { get; set; }
    }
}
