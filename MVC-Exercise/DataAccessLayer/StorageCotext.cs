using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Data.Entity;

namespace MVC_Exercise.DataAccessLayer
{
    public class StorageCotext : DbContext
    {
        public StorageCotext() : base("DefaultConnection")
        {


        }

        public DbSet <Models.Product> products { get; set; }


    }

}