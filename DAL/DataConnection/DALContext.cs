using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.AspNet.Identity.EntityFramework;
using System.Data.Entity;
using DAL.Entity;
using DAL.Entity.Customer;

namespace DAL.DataConnection
{
    public class DALContext : IdentityDbContext <Users>
    {
        public DALContext() : base("KSTestDB")
        {

        }

        public DbSet <Customer_PersonalDetails> Customer_PersonalDetail { get; set; }
    }
}
