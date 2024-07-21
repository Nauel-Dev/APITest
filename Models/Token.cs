using Microsoft.EntityFrameworkCore;
using System.ComponentModel.DataAnnotations;

namespace Dex_Filter.Models
{
    public class Token
    {
        [Key]
        public int Id { get; set; }

        public string Chain { get; set; }
        public string? Ticker { get; set; }
        public string? pairAddress { get; set; }
 

    }
}
 