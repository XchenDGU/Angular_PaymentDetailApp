using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Payment_Web_ServerApi.Models
{
    public class PaymentDetailContext:DbContext
    {
        /*options = pass in db provider such as SQL and connection string...*/
        public PaymentDetailContext(DbContextOptions<PaymentDetailContext> options):base(options)
        {
             
        }
        public DbSet<PaymentDetail> PaymentDetails { get; set; }
    }
}
