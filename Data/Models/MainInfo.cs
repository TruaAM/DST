using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace Data.Models
{
    public class MainInfo
    {
        public IEnumerable<User> users { get; set; }
        [Key]
        public uint QuoteId { get; set; }

        public string Quote { get; set; }

        public string Author { get; set; }
    }
}
