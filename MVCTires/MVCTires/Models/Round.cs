using System;
using System.Collections.Generic;
using static System.Console;
using System.Linq;
using System.Web;
using System.Data.Entity;

namespace MVCTires.Models
{
    public class Round
    {
        public int TireID { get; set; }
        public string Maker { get; set; }
        public int TireWidth { get; set; }
        public int Sidewall { get; set; }
        public int RimDiameter { get; set; }
        public int MSRP { get; set; }
        public int NumberInStock { get; set; }
        public decimal Price { get; set; }
    }

    public class RoundDBContext : DbContext
    {
        public DbSet<Round> Rounds { get; set; }
    }


}