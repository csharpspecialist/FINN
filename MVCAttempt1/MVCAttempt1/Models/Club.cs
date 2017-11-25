using System;
using System.Collections.Generic;
using static System.Console;
using System.Linq;
using System.Web;
using System.Data.Entity;

namespace MVCAttempt1.Models
{
    public class Club
    {

        public int ClubID { get; set; }

        public string ClubName { get; set; }
        public string Address { get; set; }
        public int NumberOfBars { get; set; }
        public int NumberOfEntrances { get; set; }
        public int NumberOfEmployees { get; set; }
        public int Capacity { get; set; }



    }


    public class ClubDBContext : DbContext
    {

        public DbSet<Club> Party { get; set; }
    }

}