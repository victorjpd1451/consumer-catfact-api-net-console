using System;
using System.Collections.Generic;
using System.Linq;
using System.Text.Json;
using System.Text.Json.Serialization;
using System.Threading.Tasks;

namespace ConsumerFactCat.Models
{
    public class CatFact
    {
        public string? fact { get; set; }

        
        public int? length { get; set; }
    }
}