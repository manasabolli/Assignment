using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using WebApi.Models;

namespace WebApi
{
    public partial class HydrographicContext : DbContext
    {
        private IConfiguration configuration;

        public HydrographicContext(DbContextOptions<HydrographicContext> options) : base(options)
        {

        }
        public HydrographicContext(IConfiguration configuration)
        {
            this.configuration = configuration;
        }
        public DbSet<RequestModel> RequestModel { get; set; }
        public DbSet<ResponseModel> ResponseModel { get; set; }

    }       
}
