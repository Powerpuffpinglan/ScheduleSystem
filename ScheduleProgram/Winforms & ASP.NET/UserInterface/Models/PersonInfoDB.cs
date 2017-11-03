using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;

namespace UserInterface.Models
{
    public class PersonInfoDB: DbContext
    {
        public PersonInfoDB()
            : base("name=PersonInfoDB")
        {
        }

        public virtual DbSet<PersonModel> PersInfo { get; set; }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
        }
    }
}