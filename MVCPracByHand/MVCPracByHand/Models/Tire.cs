using System;
using System.Collections.Generic;
using static System.Console;
using System.Linq;
using System.Web;
using System.Data.Entity;
using System.ComponentModel.DataAnnotations;

namespace MVCPracByHand.Models
{
    public class Tire
    {
       
        //tire demo setup
        public int ID { get; set; }

        [Display (Name ="Tire Size")  ]
        public int TireWidth { get; set; }

        [Display(Name = "Sidewall Height")]
        public int Sidewall { get; set; }

        [Display(Name = "Rim Size")]
        public int RimDiameter { get; set; }

        public string Manufacturer { get; set; }
        public int Price { get; set; }
        public int NumberInStock { get; set; }
        


    }

    public class TireDBContext : DbContext
    {

        public DbSet<Tire> Wheels { get; set; }


    }


}