using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;

namespace Data.Models
{
    [Keyless]
    public class MainInfo
    {
        public IEnumerable<User> users { get; set; }

        public Guid QuoteId { get; set; }

        public string Quote { get; set; }

        public string Author { get; set; }
    }
}
