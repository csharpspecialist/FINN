using System;
using System.Collections.Generic;
using static System.Console;
using System.Linq;
using System.Web;
using System.Data.Entity;

namespace MVCPracByHand.Models
{
    public class Starter
    {

        public int ID { get; set; }
        public string Make { get; set; }
        public int Year { get; set; }
        public string Model { get; set; }
        public decimal Price { get; set; }
        public string Color { get; set; }
    }

    public class StarterDBContext : DbContext
    {

        public DbSet<Starter> Cars { get; set; }


    }





}
