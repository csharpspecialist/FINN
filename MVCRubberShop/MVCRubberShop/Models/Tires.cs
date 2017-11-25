using System;
using System.Collections.Generic;
using static System.Console;
using System.Linq;
using System.Web;
using System.Data.Entity;

namespace MVCRubberShop.Models
{
    public class Tires
    {

        public int TiresID { get; set; }
        public int TireWidth { get; set; }
        public int Sidewall { get; set; }

        public int RimDiameter { get; set; }
        public int MSRP { get; set; }
        public string Manufacturer { get; set; }


    }


    public class TiresDBContext : DbContext
    {

        public DbSet<Tires> Round { get; set; }

    }




}